/**
 * Copyright (c) 2023 Atsusa Kai (Karl Vincent Init)
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 **/
namespace AtsusaKai.BRResPatcher.Forms
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            label1 = new Label();
            groupBox1 = new GroupBox();
            linkGit = new LinkLabel();
            linkEmail = new LinkLabel();
            lblDesc = new Label();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            lblVersion = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(295, 25);
            label1.TabIndex = 0;
            label1.Text = "Battle Realms Resolution Patcher";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(linkGit);
            groupBox1.Controls.Add(linkEmail);
            groupBox1.Controls.Add(lblDesc);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(486, 159);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // linkGit
            // 
            linkGit.AutoSize = true;
            linkGit.LinkColor = Color.Teal;
            linkGit.Location = new Point(82, 128);
            linkGit.Name = "linkGit";
            linkGit.Size = new Size(349, 15);
            linkGit.TabIndex = 1;
            linkGit.TabStop = true;
            linkGit.Text = "https://github.com/AtsusaKai/Battle-Realms-Resolution-Patcher";
            linkGit.LinkClicked += linkGit_LinkClicked;
            // 
            // linkEmail
            // 
            linkEmail.AutoSize = true;
            linkEmail.LinkColor = Color.Teal;
            linkEmail.Location = new Point(82, 110);
            linkEmail.Name = "linkEmail";
            linkEmail.Size = new Size(126, 15);
            linkEmail.TabIndex = 1;
            linkEmail.TabStop = true;
            linkEmail.Text = "kai.atsusa@gmail.com";
            linkEmail.LinkClicked += linkEmail_LinkClicked;
            // 
            // lblDesc
            // 
            lblDesc.Location = new Point(6, 49);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(474, 37);
            lblDesc.TabIndex = 0;
            lblDesc.Text = "This software is developed for Battle Realms Complete (GOG) v1.0.0.8 to allow custom resolutions with Battle Realms, including widescreen resolutions.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(6, 110);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 0;
            label6.Text = "Email:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(6, 128);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 0;
            label7.Text = "Github:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(82, 92);
            label5.Name = "label5";
            label5.Size = new Size(152, 15);
            label5.TabIndex = 0;
            label5.Text = "AtsusaKai (Karl Vincent Init)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(6, 92);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 0;
            label4.Text = "Created by: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(187, 15);
            label2.TabIndex = 0;
            label2.Text = "Copyright © 2023 Karl Vincent Init";
            // 
            // lblVersion
            // 
            lblVersion.Location = new Point(398, 13);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(100, 23);
            lblVersion.TabIndex = 2;
            lblVersion.Text = "Version: 1.0.0.0";
            lblVersion.TextAlign = ContentAlignment.MiddleRight;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 204);
            Controls.Add(lblVersion);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutForm";
            Text = "About";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label lblVersion;
        private LinkLabel linkGit;
        private LinkLabel linkEmail;
        private Label lblDesc;
        private Label label6;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label2;
    }
}