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
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VisualDBManager
{
    public partial class addForm : UserControl
    {
        enum Caption { NORMAL, ERROR };
        public addForm()
        {
            InitializeComponent();
        }

        private void layout_Paint(object sender, PaintEventArgs e)
        {

        }

        public void PassToObject(ref person p)
        {
            Caption caption = new Caption();
            caption = Caption.NORMAL;
            foreach (Control ctrl in this.emergencyPanel.Controls)
            {
                if (ctrl is TextBox)
                    if (ctrl.Text.Length < 2)
                    {
                        MessageBox.Show("Please fill in all required fields!", "Caption Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning, 0);
                        caption = Caption.ERROR;
                        break;
                    }
            }

            if (caption != Caption.ERROR)
            {
                foreach (Control ctrl in this.secondPanel.Controls)
                {
                    if (ctrl is TextBox)
                        if (ctrl.Text.Length < 2)
                        {
                            MessageBox.Show("Please fill in all required fields!", "Caption Warning",
                                                        MessageBoxButtons.OK, MessageBoxIcon.Warning, 0);
                            caption = Caption.ERROR;
                            break;
                        }
                }
            }

            if (caption != Caption.ERROR)
            {
                foreach (Control c in this.thirdPanel.Controls)
                {
                    if (c is TextBox)
                        if (c.Text.Length < 2)
                        {
                            MessageBox.Show("Please fill in all required fields!", "Caption Warning",
                                                        MessageBoxButtons.OK, MessageBoxIcon.Warning, 0);
                            caption = Caption.ERROR;
                            break;
                        }
                }
            }

            if (caption != Caption.ERROR)
            {
                foreach (Control c in this.fourthPanel.Controls)
                {
                    if (c is TextBox)
                        if (c.Text.Length < 2)
                        {
                            MessageBox.Show("Please fill in all required fields!", "Caption Warning",
                                                        MessageBoxButtons.OK, MessageBoxIcon.Warning, 0);
                            caption = Caption.ERROR;
                            break;
                        }
                }
            }
            if (caption != Caption.ERROR)
            {
                foreach (Control c in this.emergencyPanel.Controls)
                {
                    if (c is TextBox)
                        if (c.Text.Length < 2)
                        {
                            MessageBox.Show("Please fill in all required fields!", "Caption Warning",
                                                        MessageBoxButtons.OK, MessageBoxIcon.Warning, 0);
                            caption = Caption.ERROR;
                            break;
                        }
                }
            }

            if (caption != Caption.ERROR)
            {
                p.FirstName = this.firstNameTxt.Text.ToString();
                p.LastName = this.lastNameTxt.Text.ToString();
                p.MiddleName = this.middleNameTxt.Text.ToString();
                p.age = this.ageSelector.Value;
                p.FatherFirstName = this.fatherFirstNameBox.Text.ToString();
                p.FatherLastName = this.fatherLastNameBox.Text.ToString();
                p.MotherFirstName = this.MotherFirstNameBox.Text.ToString();
                p.MotherLastName = this.MotherLastNameBox.Text.ToString();
                p.Birthdate = this.DateOfBirthBox.Text.ToString();
                p.BirthCountry = this.CountryOfBirthBox.Text.ToString();
                p.BirthCity = this.CityOfBirthBox.Text.ToString();
                string[] allergyList = this.allergiesBox.Text.Split(',');   // initialize array
                p.Allergies = allergyList;
                p.Address = this.addressBox.Text.ToString();

                List<int> num = new List<int>();
                foreach (char c in this.phoneBox.Text)
                    num.Add((int)(Char.GetNumericValue(c)));
                List<int> alt = new List<int>();
                foreach (char i in this.altPhone.Text)
                    alt.Add((int)(Char.GetNumericValue(i)));
                p.HomePhone = num.ToArray();
                p.AltPhone = alt.ToArray();

                p.EmergencyContactFullName = this.emergencyContact.Text.ToString();
                List<int> em = new List<int>();
                foreach (char digit in this.emergencyPhone.Text.ToString())
                    em.Add((int)(Char.GetNumericValue(digit)));
                p.EmergencyContactPhone = em.ToArray();
            }
        }

        private void emergencyPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void emergencyPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void firstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void firstNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void middleNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void secondPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MotherFirstNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void fatherLastNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void fatherFirstNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CountryOfBirthBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void thirdPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void DateOfBirthBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void MotherLastNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void CityOfBirthBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void ageSelector_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void altPhone_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void phoneBox_Click(object sender, EventArgs e)
        {

        }

        private void addressBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void allergiesBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void emergencyContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void fourthPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
