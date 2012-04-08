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
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.divider = new System.Windows.Forms.SplitContainer();
            this.leftLayout = new System.Windows.Forms.TableLayoutPanel();
            this.readSelectionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.readFirstName = new System.Windows.Forms.TextBox();
            this.readLastName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addFirstName = new System.Windows.Forms.TextBox();
            this.addLastName = new System.Windows.Forms.TextBox();
            this.addUserTabNew = new System.Windows.Forms.Button();
            this.verticalPanel = new System.Windows.Forms.SplitContainer();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.createProfile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.divider)).BeginInit();
            this.divider.Panel1.SuspendLayout();
            this.divider.Panel2.SuspendLayout();
            this.divider.SuspendLayout();
            this.leftLayout.SuspendLayout();
            this.readSelectionPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verticalPanel)).BeginInit();
            this.verticalPanel.Panel1.SuspendLayout();
            this.verticalPanel.Panel2.SuspendLayout();
            this.verticalPanel.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // divider
            // 
            this.divider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.divider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divider.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.divider.Location = new System.Drawing.Point(0, 0);
            this.divider.Name = "divider";
            // 
            // divider.Panel1
            // 
            this.divider.Panel1.Controls.Add(this.leftLayout);
            // 
            // divider.Panel2
            // 
            this.divider.Panel2.Controls.Add(this.verticalPanel);
            this.divider.Size = new System.Drawing.Size(761, 415);
            this.divider.SplitterDistance = 103;
            this.divider.TabIndex = 0;
            // 
            // leftLayout
            // 
            this.leftLayout.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.leftLayout.ColumnCount = 1;
            this.leftLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.leftLayout.Controls.Add(this.readSelectionPanel, 0, 1);
            this.leftLayout.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.leftLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftLayout.Location = new System.Drawing.Point(0, 0);
            this.leftLayout.Name = "leftLayout";
            this.leftLayout.RowCount = 3;
            this.leftLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.34711F));
            this.leftLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.65289F));
            this.leftLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.leftLayout.Size = new System.Drawing.Size(99, 411);
            this.leftLayout.TabIndex = 0;
            // 
            // readSelectionPanel
            // 
            this.readSelectionPanel.Controls.Add(this.readFirstName);
            this.readSelectionPanel.Controls.Add(this.readLastName);
            this.readSelectionPanel.Controls.Add(this.button1);
            this.readSelectionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.readSelectionPanel.Location = new System.Drawing.Point(3, 118);
            this.readSelectionPanel.Name = "readSelectionPanel";
            this.readSelectionPanel.Size = new System.Drawing.Size(93, 117);
            this.readSelectionPanel.TabIndex = 1;
            // 
            // readFirstName
            // 
            this.readFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.readFirstName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readFirstName.Location = new System.Drawing.Point(3, 3);
            this.readFirstName.Name = "readFirstName";
            this.readFirstName.Size = new System.Drawing.Size(84, 26);
            this.readFirstName.TabIndex = 2;
            this.readFirstName.Text = "name";
            // 
            // readLastName
            // 
            this.readLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.readLastName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readLastName.Location = new System.Drawing.Point(3, 35);
            this.readLastName.Name = "readLastName";
            this.readLastName.Size = new System.Drawing.Size(84, 26);
            this.readLastName.TabIndex = 4;
            this.readLastName.Text = "last name";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(3, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "read";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.addFirstName);
            this.flowLayoutPanel1.Controls.Add(this.addLastName);
            this.flowLayoutPanel1.Controls.Add(this.addUserTabNew);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(93, 109);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // addFirstName
            // 
            this.addFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addFirstName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFirstName.Location = new System.Drawing.Point(3, 3);
            this.addFirstName.Name = "addFirstName";
            this.addFirstName.Size = new System.Drawing.Size(84, 26);
            this.addFirstName.TabIndex = 0;
            this.addFirstName.Text = "name";
            // 
            // addLastName
            // 
            this.addLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addLastName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLastName.Location = new System.Drawing.Point(3, 35);
            this.addLastName.Name = "addLastName";
            this.addLastName.Size = new System.Drawing.Size(84, 26);
            this.addLastName.TabIndex = 1;
            this.addLastName.Text = "last name";
            // 
            // addUserTabNew
            // 
            this.addUserTabNew.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addUserTabNew.Location = new System.Drawing.Point(3, 67);
            this.addUserTabNew.Name = "addUserTabNew";
            this.addUserTabNew.Size = new System.Drawing.Size(84, 30);
            this.addUserTabNew.TabIndex = 1;
            this.addUserTabNew.Text = "Create";
            this.addUserTabNew.UseVisualStyleBackColor = true;
            this.addUserTabNew.Click += new System.EventHandler(this.addUserTabNew_Click);
            // 
            // verticalPanel
            // 
            this.verticalPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.verticalPanel.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.verticalPanel.Location = new System.Drawing.Point(0, 0);
            this.verticalPanel.Name = "verticalPanel";
            this.verticalPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // verticalPanel.Panel1
            // 
            this.verticalPanel.Panel1.Controls.Add(this.tabControl);
            // 
            // verticalPanel.Panel2
            // 
            this.verticalPanel.Panel2.Controls.Add(this.flowLayoutPanel2);
            this.verticalPanel.Size = new System.Drawing.Size(650, 411);
            this.verticalPanel.SplitterDistance = 370;
            this.verticalPanel.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Enabled = false;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(650, 370);
            this.tabControl.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.createProfile);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(650, 37);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // createProfile
            // 
            this.createProfile.Enabled = false;
            this.createProfile.Location = new System.Drawing.Point(3, 3);
            this.createProfile.Name = "createProfile";
            this.createProfile.Size = new System.Drawing.Size(124, 30);
            this.createProfile.TabIndex = 0;
            this.createProfile.Text = "Create Profile";
            this.createProfile.UseVisualStyleBackColor = true;
            this.createProfile.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 415);
            this.Controls.Add(this.divider);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visual DataBase Manager -- 2012";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.divider.Panel1.ResumeLayout(false);
            this.divider.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.divider)).EndInit();
            this.divider.ResumeLayout(false);
            this.leftLayout.ResumeLayout(false);
            this.readSelectionPanel.ResumeLayout(false);
            this.readSelectionPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.verticalPanel.Panel1.ResumeLayout(false);
            this.verticalPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.verticalPanel)).EndInit();
            this.verticalPanel.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.SplitContainer divider;
        private System.Windows.Forms.TableLayoutPanel leftLayout;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox addFirstName;
        private System.Windows.Forms.TextBox addLastName;
        private System.Windows.Forms.Button addUserTabNew;
        private System.Windows.Forms.SplitContainer verticalPanel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button createProfile;
        private System.Windows.Forms.FlowLayoutPanel readSelectionPanel;
        private System.Windows.Forms.TextBox readFirstName;
        private System.Windows.Forms.TextBox readLastName;
        private System.Windows.Forms.Button button1;
    }
}

