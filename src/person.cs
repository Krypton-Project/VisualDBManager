/**
Copyright (C) 2012 KryptonX & Princessjinifer
All rights reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are met:
    * Redistributions of source code must retain the above copyright
      notice, this list of conditions and the following disclaimer.
    * Redistributions in binary form must reproduce the above copyright
      notice, this list of conditions and the following disclaimer in the
      documentation and/or other materials provided with the distribution.
    * Neither the name of the author nor the
      names of its contributors may be used to endorse or promote products
      derived from this software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
DISCLAIMED. IN NO EVENT SHALL <EDWARD CHERNYSH> BE LIABLE FOR ANY
DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
(INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

**/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace VisualDBManager
{    
    public class person
    {
        public string FirstName;
        public string LastName;
        public string MiddleName;

        public bool SingleParentOrGuardian = false;

        public string FatherFirstName;
        public string FatherLastName;
        public decimal age;
        public string MotherFirstName;
        public string MotherLastName;

        private string GuardianOrSingleParentFirstName;
        private string GuardianOrSingleParentLastName;

        public string Birthdate;    // (DD/MM/YY)
        public string BirthCountry;
        public string BirthCity;

        public string[] Allergies;

        public string Address;
        public int[] HomePhone;
        public int[] AltPhone;        
        public string EmergencyContactFullName = string.Empty;
        public int[] EmergencyContactPhone;

        public void EnterProfile(string FirstName, string LastName, string MiddleName, int age, string OfFatherFirstName, string OfFatherLastName, string OfMotherFirstName,
            string OfMotherLastName, string BirthDate, string CountryOfBirth, string CityOfBirth, string[] ListOfAllergies, string Address, int[] _HomePhoneNumber,
            int[] AlternatePhoneNumber, string __EmergencyContactFullName, int[] EmergencyPhoneNumber, bool HasGuardian = false)
        {
            this.FirstName = FirstName.ToString();
            this.LastName = LastName.ToString();
            this.MiddleName = MiddleName.ToString();
            this.age = age;

            this.SingleParentOrGuardian = HasGuardian;
            if (this.SingleParentOrGuardian == false)
            {
                this.FatherFirstName = OfFatherFirstName.ToString();
                this.FatherLastName = OfFatherLastName.ToString();
                this.MotherFirstName = OfMotherFirstName.ToString();
                this.MotherLastName = OfMotherLastName.ToString();
            }
            this.Birthdate = BirthDate.ToString();
            this.BirthCountry = CountryOfBirth.ToString();
            this.BirthCity = CityOfBirth.ToString();
            this.Allergies = ListOfAllergies;

            this.Address = Address.ToString();            
            this.HomePhone = _HomePhoneNumber;
            this.AltPhone = AlternatePhoneNumber;

            this.EmergencyContactFullName = (MotherLastName + " " + MotherLastName);
            this.EmergencyContactPhone = _HomePhoneNumber;           

        }

        

        public string WriteProfile(string directory /* must include termination backslash! */)
        {
            int count = 0;
            string filename = string.Empty;
            foreach (string s in Directory.GetFiles(directory))
            {
                if (s.IndexOf(this.FirstName) != -1 && s.IndexOf(this.LastName) != -1)
                    ++count;
            }

            if (count == 0)
            {
                filename = (directory + (this.FirstName + this.LastName).ToString()).ToString();
                using (System.IO.StreamWriter writer = new System.IO.StreamWriter(filename.ToString()))
                {
                    /* User */
                    writer.WriteLine(this.FirstName);
                    writer.WriteLine(this.LastName);
                    writer.WriteLine(this.MiddleName);
                    writer.WriteLine(this.age);

                    if (this.SingleParentOrGuardian == false)
                    {
                        writer.WriteLine(FatherFirstName);
                        writer.WriteLine(FatherLastName);
                        writer.WriteLine(MotherFirstName);
                        writer.WriteLine(MotherLastName);
                    }

                    else if (this.SingleParentOrGuardian == true)
                    {
                        writer.WriteLine(GuardianOrSingleParentFirstName);
                        writer.WriteLine(GuardianOrSingleParentLastName);
                    }

                    writer.WriteLine(Birthdate);
                    writer.WriteLine(BirthCountry);
                    writer.WriteLine(BirthCity);

                    writer.Write("allergies: [");
                    foreach (string s in this.Allergies)                    
                        writer.Write(s + ",");
                    writer.Write("]\n");
                    writer.WriteLine(Address);                    
                    writer.WriteLine(HomePhone);
                    writer.WriteLine(AltPhone);
                    writer.WriteLine(EmergencyContactFullName);
                    writer.Write(EmergencyContactPhone);
                    writer.Dispose();   // end stream
                }
            }

            else if (count >= 1)
            {
                filename = (directory + (this.FirstName + this.LastName + count.ToString()).ToString()).ToString();
                using (System.IO.StreamWriter writer = new System.IO.StreamWriter(filename.ToString()))
                {
                    /* User */
                    writer.WriteLine(this.FirstName);
                    writer.WriteLine(this.LastName);
                    writer.WriteLine(this.MiddleName);
                    writer.WriteLine(this.age);

                    if (this.SingleParentOrGuardian == false)
                    {
                        writer.WriteLine(FatherFirstName);
                        writer.WriteLine(FatherLastName);
                        writer.WriteLine(MotherFirstName);
                        writer.WriteLine(MotherLastName);
                    }

                    else if (this.SingleParentOrGuardian == true)
                    {
                        writer.WriteLine(GuardianOrSingleParentFirstName);
                        writer.WriteLine(GuardianOrSingleParentLastName);
                    }

                    writer.WriteLine(Birthdate);
                    writer.WriteLine(BirthCountry);
                    writer.WriteLine(BirthCity);

                    writer.Write("allergies: [");
                    foreach (string s in this.Allergies)
                        writer.Write(s + ",");
                    writer.Write("]\n");
                    writer.WriteLine(Address);
                    foreach (int i in HomePhone)
                        writer.Write(i.ToString());
                    foreach (int i in AltPhone)
                        writer.Write(i.ToString());
                    writer.WriteLine(EmergencyContactFullName);
                    foreach (int i in EmergencyContactPhone)
                        writer.Write(i.ToString());
                    writer.Dispose();   // end stream
                }
            }

            return filename.ToString();
        }
    }
}
