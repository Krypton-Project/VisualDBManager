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
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace VisualDBManager
{
    public partial class Form1 : Form
    {
        public string profile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\dbprofiles\\";
        List<person> people = new List<person>();
        public int userCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BringToFront();
        }

        public string StreamProfile(person prof, string directory)
        {
            int count = 0;
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);
            string filename = string.Empty;
            foreach (string s in Directory.GetFiles(directory))
            {
                if (s.IndexOf(prof.FirstName) != -1 && s.IndexOf(prof.LastName) != -1)
                    ++count;
            }

            if (count == 0)
            {
                filename = (directory + (prof.FirstName + prof.LastName).ToString()).ToString();
                using (System.IO.StreamWriter writer = new System.IO.StreamWriter(filename.ToString()))
                {
                    /* User */
                    writer.WriteLine(prof.FirstName);
                    writer.WriteLine(prof.LastName);
                    writer.WriteLine(prof.MiddleName);
                    writer.Dispose();   // end stream
                }
            }

            return filename.ToString();
        }

        private void addUserTabNew_Click(object sender, EventArgs e)
        {
            if (this.tabControl.TabCount > 0)
                this.tabControl.Controls.Remove(this.tabControl.SelectedTab);
            if (addFirstName.Text.Length > 0 && addLastName.Text.Length > 0 && addFirstName.Text != "name" && addLastName.Text.IndexOf(
                "name") == -1)
            {
                var _person = new person();
                _person.FirstName = addFirstName.Text.ToString();
                _person.LastName = addLastName.Text.ToString();
                TabPage tb = new TabPage();
                tb.Text = "Form " + (userCount + 1).ToString();
                tabControl.Controls.Add(tb);
                tb.BringToFront();
                tb.BackColor = Color.Gainsboro;                
                people.Add(_person);
                var frm = new addForm();
                frm.firstNameTxt.Text = _person.FirstName.ToString();
                frm.lastNameTxt.Text = _person.LastName.ToString();
                tb.Controls.Add(frm);
                frm.Dock = DockStyle.Fill;
                this.addFirstName.Text = string.Empty;
                this.addLastName.Text = string.Empty;
                this.tabControl.Enabled = true;
                this.createProfile.Enabled = true;
            }
            else MessageBox.Show("Fields must contain suitable text!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string all = "penicillin Phencyclidine";
            string[] li = all.Split(' ');
            int[] homeph = { 0,0,0,0,0,0,0};
            var per = new person();
            per.EnterProfile("null", "null", "null", 19,
                "null", "null", "null", "null",
                "null,null", "Canada", "Thunder Bay", li,
                "null", homeph, homeph, "null",
                homeph);
            if (tabControl.TabCount > 0)
            {
                ((addForm)tabControl.SelectedTab.Controls[0]).PassToObject(ref per);
                per.WriteProfile(profile);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool b = true;
            foreach (Control c in this.readSelectionPanel.Controls)
            {
                if (c is TextBox && c.Text.Length >= 2)
                    continue;
                else
                {
                    b = false;
                    break;
                }

            }
            if (true)
            {
                string fname = (readFirstName.Text + readLastName.Text);
                if (this.tabControl.TabCount > 0)
                    this.tabControl.Controls.Remove(this.tabControl.SelectedTab);
                foreach (string s in Directory.GetFiles(profile))
                {
                    if (s.IndexOf(fname.ToString()) != (-1) && fname.Length > 2)
                    {
                        using (System.IO.StreamReader reader = new System.IO.StreamReader(profile + fname.ToString()))
                        {
                            string _data = reader.ReadToEnd();
                            string[] data = _data.Split('\n');
                            addForm frm = new addForm();
                            try
                            {
                                frm.firstNameTxt.Text = data[0];
                                frm.lastNameTxt.Text = data[1];
                                frm.middleNameTxt.Text = data[2];
                                //frm.ageSelector.Value = (decimal)data[3]; 
                                frm.fatherFirstNameBox.Text = data[4];
                                frm.fatherLastNameBox.Text = data[5];
                                frm.MotherFirstNameBox.Text = data[6];
                                frm.MotherLastNameBox.Text = data[7];
                                frm.DateOfBirthBox.Text = data[8];
                                frm.CountryOfBirthBox.Text = data[9];
                                frm.CityOfBirthBox.Text = data[10];
                                string[] allergyList = data[11].Split(',');  // initialize array                                
                                foreach (string ss in allergyList)
                                    frm.allergiesBox.Text += ss.ToString();
                                frm.addressBox.Text = data[12];
                                frm.phoneBox.Text = data[13];
                                frm.altPhone.Text = data[14];
                                frm.emergencyContact.Text = data[15];
                                frm.emergencyPhone.Text = data[16];
                                TabPage tb = new TabPage();
                                tb.Text = "Form " + (userCount + 1).ToString();
                                tabControl.Controls.Add(tb);
                                tb.BringToFront();
                                tb.BackColor = Color.Gainsboro;
                                tb.Controls.Add(frm);
                                frm.Dock = DockStyle.Fill;
                                frm.Enabled = false;
                                tb.BringToFront();
                            }
                            catch
                            {
                                MessageBox.Show("Error: invalid database.\nPlease contact the software vendor.", "Unhandled Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error, 0, MessageBoxOptions.ServiceNotification);
                            }
                            reader.Dispose();
                        }
                        this.createProfile.Enabled = false;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("User does not exist. Try creating this user!.", "Oops! :P",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning, 0);
                        break;
                    }
                }
            }
        }
    }
}
