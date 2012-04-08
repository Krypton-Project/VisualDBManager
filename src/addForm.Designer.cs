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

namespace VisualDBManager
{
    partial class addForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            this.emergencyPanel = new System.Windows.Forms.Panel();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.middleNameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.secondPanel = new System.Windows.Forms.Panel();
            this.MotherFirstNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fatherLastNameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fatherFirstNameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.thirdPanel = new System.Windows.Forms.Panel();
            this.CountryOfBirthBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DateOfBirthBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MotherLastNameBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CityOfBirthBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ageSelector = new System.Windows.Forms.NumericUpDown();
            this.fourthPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.altPhone = new System.Windows.Forms.Label();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.allergiesBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.emergencyContact = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.emergencyPhone = new System.Windows.Forms.TextBox();
            this.layout.SuspendLayout();
            this.emergencyPanel.SuspendLayout();
            this.secondPanel.SuspendLayout();
            this.thirdPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageSelector)).BeginInit();
            this.fourthPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // layout
            // 
            this.layout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.layout.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.layout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.layout.ColumnCount = 1;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.2364F));
            this.layout.Controls.Add(this.panel1, 0, 5);
            this.layout.Controls.Add(this.fourthPanel, 0, 3);
            this.layout.Controls.Add(this.thirdPanel, 0, 2);
            this.layout.Controls.Add(this.secondPanel, 0, 1);
            this.layout.Controls.Add(this.emergencyPanel, 0, 0);
            this.layout.Location = new System.Drawing.Point(0, 0);
            this.layout.Name = "layout";
            this.layout.RowCount = 6;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.23077F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.76923F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.layout.Size = new System.Drawing.Size(903, 451);
            this.layout.TabIndex = 0;
            this.layout.Paint += new System.Windows.Forms.PaintEventHandler(this.layout_Paint);
            // 
            // emergencyPanel
            // 
            this.emergencyPanel.Controls.Add(this.ageSelector);
            this.emergencyPanel.Controls.Add(this.label10);
            this.emergencyPanel.Controls.Add(this.middleNameTxt);
            this.emergencyPanel.Controls.Add(this.label2);
            this.emergencyPanel.Controls.Add(this.lastNameTxt);
            this.emergencyPanel.Controls.Add(this.label1);
            this.emergencyPanel.Controls.Add(this.firstNameTxt);
            this.emergencyPanel.Controls.Add(this.firstNameLabel);
            this.emergencyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emergencyPanel.Location = new System.Drawing.Point(5, 5);
            this.emergencyPanel.Name = "emergencyPanel";
            this.emergencyPanel.Size = new System.Drawing.Size(893, 56);
            this.emergencyPanel.TabIndex = 0;
            this.emergencyPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.emergencyPanel_Paint);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(3, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(97, 21);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name:";
            this.firstNameLabel.Click += new System.EventHandler(this.firstNameLabel_Click);
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.Location = new System.Drawing.Point(7, 24);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.Size = new System.Drawing.Size(257, 22);
            this.firstNameTxt.TabIndex = 1;
            this.firstNameTxt.TextChanged += new System.EventHandler(this.firstNameTxt_TextChanged);
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Location = new System.Drawing.Point(272, 24);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(257, 22);
            this.lastNameTxt.TabIndex = 3;
            this.lastNameTxt.TextChanged += new System.EventHandler(this.lastNameTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Last Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // middleNameTxt
            // 
            this.middleNameTxt.Location = new System.Drawing.Point(539, 24);
            this.middleNameTxt.Name = "middleNameTxt";
            this.middleNameTxt.Size = new System.Drawing.Size(194, 22);
            this.middleNameTxt.TabIndex = 5;
            this.middleNameTxt.TextChanged += new System.EventHandler(this.middleNameTxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(536, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Middle Name (optional):";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // secondPanel
            // 
            this.secondPanel.Controls.Add(this.MotherFirstNameBox);
            this.secondPanel.Controls.Add(this.label3);
            this.secondPanel.Controls.Add(this.fatherLastNameBox);
            this.secondPanel.Controls.Add(this.label4);
            this.secondPanel.Controls.Add(this.fatherFirstNameBox);
            this.secondPanel.Controls.Add(this.label5);
            this.secondPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secondPanel.Location = new System.Drawing.Point(5, 69);
            this.secondPanel.Name = "secondPanel";
            this.secondPanel.Size = new System.Drawing.Size(893, 58);
            this.secondPanel.TabIndex = 1;
            this.secondPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.secondPanel_Paint);
            // 
            // MotherFirstNameBox
            // 
            this.MotherFirstNameBox.Location = new System.Drawing.Point(539, 24);
            this.MotherFirstNameBox.Name = "MotherFirstNameBox";
            this.MotherFirstNameBox.Size = new System.Drawing.Size(351, 22);
            this.MotherFirstNameBox.TabIndex = 5;
            this.MotherFirstNameBox.TextChanged += new System.EventHandler(this.MotherFirstNameBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(536, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mother First Name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // fatherLastNameBox
            // 
            this.fatherLastNameBox.Location = new System.Drawing.Point(272, 24);
            this.fatherLastNameBox.Name = "fatherLastNameBox";
            this.fatherLastNameBox.Size = new System.Drawing.Size(257, 22);
            this.fatherLastNameBox.TabIndex = 3;
            this.fatherLastNameBox.TextChanged += new System.EventHandler(this.fatherLastNameBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(268, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Father Last Name:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // fatherFirstNameBox
            // 
            this.fatherFirstNameBox.Location = new System.Drawing.Point(7, 24);
            this.fatherFirstNameBox.Name = "fatherFirstNameBox";
            this.fatherFirstNameBox.Size = new System.Drawing.Size(257, 22);
            this.fatherFirstNameBox.TabIndex = 1;
            this.fatherFirstNameBox.TextChanged += new System.EventHandler(this.fatherFirstNameBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Father First Name:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // thirdPanel
            // 
            this.thirdPanel.Controls.Add(this.CityOfBirthBox);
            this.thirdPanel.Controls.Add(this.label9);
            this.thirdPanel.Controls.Add(this.CountryOfBirthBox);
            this.thirdPanel.Controls.Add(this.label6);
            this.thirdPanel.Controls.Add(this.DateOfBirthBox);
            this.thirdPanel.Controls.Add(this.label7);
            this.thirdPanel.Controls.Add(this.MotherLastNameBox);
            this.thirdPanel.Controls.Add(this.label8);
            this.thirdPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thirdPanel.Location = new System.Drawing.Point(5, 135);
            this.thirdPanel.Name = "thirdPanel";
            this.thirdPanel.Size = new System.Drawing.Size(893, 55);
            this.thirdPanel.TabIndex = 2;
            this.thirdPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.thirdPanel_Paint);
            // 
            // CountryOfBirthBox
            // 
            this.CountryOfBirthBox.Location = new System.Drawing.Point(539, 24);
            this.CountryOfBirthBox.Name = "CountryOfBirthBox";
            this.CountryOfBirthBox.Size = new System.Drawing.Size(151, 22);
            this.CountryOfBirthBox.TabIndex = 5;
            this.CountryOfBirthBox.TextChanged += new System.EventHandler(this.CountryOfBirthBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(536, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Country of Birth:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // DateOfBirthBox
            // 
            this.DateOfBirthBox.Location = new System.Drawing.Point(272, 24);
            this.DateOfBirthBox.Name = "DateOfBirthBox";
            this.DateOfBirthBox.Size = new System.Drawing.Size(257, 22);
            this.DateOfBirthBox.TabIndex = 3;
            this.DateOfBirthBox.TextChanged += new System.EventHandler(this.DateOfBirthBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(268, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Date of Birth (DD/MM/YY)";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // MotherLastNameBox
            // 
            this.MotherLastNameBox.Location = new System.Drawing.Point(7, 24);
            this.MotherLastNameBox.Name = "MotherLastNameBox";
            this.MotherLastNameBox.Size = new System.Drawing.Size(257, 22);
            this.MotherLastNameBox.TabIndex = 1;
            this.MotherLastNameBox.TextChanged += new System.EventHandler(this.MotherLastNameBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mother Last Name:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // CityOfBirthBox
            // 
            this.CityOfBirthBox.Location = new System.Drawing.Point(701, 24);
            this.CityOfBirthBox.Name = "CityOfBirthBox";
            this.CityOfBirthBox.Size = new System.Drawing.Size(151, 22);
            this.CityOfBirthBox.TabIndex = 7;
            this.CityOfBirthBox.TextChanged += new System.EventHandler(this.CityOfBirthBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(696, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 21);
            this.label9.TabIndex = 6;
            this.label9.Text = "City Of Birth:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(749, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 21);
            this.label10.TabIndex = 6;
            this.label10.Text = "Age:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // ageSelector
            // 
            this.ageSelector.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageSelector.Location = new System.Drawing.Point(752, 20);
            this.ageSelector.Name = "ageSelector";
            this.ageSelector.Size = new System.Drawing.Size(126, 26);
            this.ageSelector.TabIndex = 7;
            this.ageSelector.ValueChanged += new System.EventHandler(this.ageSelector_ValueChanged);
            // 
            // fourthPanel
            // 
            this.fourthPanel.Controls.Add(this.textBox1);
            this.fourthPanel.Controls.Add(this.altPhone);
            this.fourthPanel.Controls.Add(this.phoneBox);
            this.fourthPanel.Controls.Add(this.addressBox);
            this.fourthPanel.Controls.Add(this.label13);
            this.fourthPanel.Controls.Add(this.allergiesBox);
            this.fourthPanel.Controls.Add(this.label14);
            this.fourthPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fourthPanel.Location = new System.Drawing.Point(5, 198);
            this.fourthPanel.Name = "fourthPanel";
            this.fourthPanel.Size = new System.Drawing.Size(893, 72);
            this.fourthPanel.TabIndex = 3;
            this.fourthPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.fourthPanel_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(701, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // altPhone
            // 
            this.altPhone.AutoSize = true;
            this.altPhone.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altPhone.Location = new System.Drawing.Point(696, 7);
            this.altPhone.Name = "altPhone";
            this.altPhone.Size = new System.Drawing.Size(86, 21);
            this.altPhone.TabIndex = 6;
            this.altPhone.Text = "Alt. Phone";
            this.altPhone.Click += new System.EventHandler(this.altPhone_Click);
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(539, 33);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(151, 22);
            this.phoneBox.TabIndex = 5;
            this.phoneBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(272, 33);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(257, 22);
            this.addressBox.TabIndex = 3;
            this.addressBox.TextChanged += new System.EventHandler(this.addressBox_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(268, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 21);
            this.label13.TabIndex = 2;
            this.label13.Text = "Address:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // allergiesBox
            // 
            this.allergiesBox.Location = new System.Drawing.Point(7, 33);
            this.allergiesBox.Name = "allergiesBox";
            this.allergiesBox.Size = new System.Drawing.Size(257, 22);
            this.allergiesBox.TabIndex = 1;
            this.allergiesBox.TextChanged += new System.EventHandler(this.allergiesBox_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(243, 21);
            this.label14.TabIndex = 0;
            this.label14.Text = "Allergies: (item, item, item, ...)";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.emergencyPhone);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.emergencyContact);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 341);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 105);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(278, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(211, 21);
            this.label15.TabIndex = 2;
            this.label15.Text = "Emergency Phone Number:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // emergencyContact
            // 
            this.emergencyContact.Location = new System.Drawing.Point(7, 33);
            this.emergencyContact.Name = "emergencyContact";
            this.emergencyContact.Size = new System.Drawing.Size(257, 22);
            this.emergencyContact.TabIndex = 1;
            this.emergencyContact.TextChanged += new System.EventHandler(this.emergencyContact_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(3, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(160, 21);
            this.label16.TabIndex = 0;
            this.label16.Text = "Emergency Contact:";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // emergencyPhone
            // 
            this.emergencyPhone.Location = new System.Drawing.Point(282, 33);
            this.emergencyPhone.Name = "emergencyPhone";
            this.emergencyPhone.Size = new System.Drawing.Size(144, 22);
            this.emergencyPhone.TabIndex = 3;
            this.emergencyPhone.TextChanged += new System.EventHandler(this.emergencyPhone_TextChanged);
            // 
            // addForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layout);
            this.Name = "addForm";
            this.Size = new System.Drawing.Size(903, 451);
            this.layout.ResumeLayout(false);
            this.emergencyPanel.ResumeLayout(false);
            this.emergencyPanel.PerformLayout();
            this.secondPanel.ResumeLayout(false);
            this.secondPanel.PerformLayout();
            this.thirdPanel.ResumeLayout(false);
            this.thirdPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageSelector)).EndInit();
            this.fourthPanel.ResumeLayout(false);
            this.fourthPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox lastNameTxt;
        public System.Windows.Forms.TextBox firstNameTxt;
        public System.Windows.Forms.TextBox DateOfBirthBox;
        public System.Windows.Forms.TextBox MotherLastNameBox;
        public System.Windows.Forms.TextBox fatherLastNameBox;
        public System.Windows.Forms.TextBox fatherFirstNameBox;
        public System.Windows.Forms.TextBox addressBox;
        public System.Windows.Forms.TextBox allergiesBox;
        public System.Windows.Forms.TextBox emergencyContact;
        public System.Windows.Forms.TextBox emergencyPhone;
        public System.Windows.Forms.TableLayoutPanel layout;
        public System.Windows.Forms.Panel emergencyPanel;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label firstNameLabel;
        public System.Windows.Forms.TextBox middleNameTxt;
        public System.Windows.Forms.Panel thirdPanel;
        public System.Windows.Forms.TextBox CountryOfBirthBox;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Panel secondPanel;
        public System.Windows.Forms.TextBox MotherFirstNameBox;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox CityOfBirthBox;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.NumericUpDown ageSelector;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Panel fourthPanel;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label altPhone;
        public System.Windows.Forms.TextBox phoneBox;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label16;
    }
}
