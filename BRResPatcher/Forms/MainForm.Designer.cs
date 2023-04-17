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
namespace AtsusaKai.BRResPatcher
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            mainMenuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            viewHelpToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            mainStatusStrip = new StatusStrip();
            statusText = new ToolStripStatusLabel();
            label1 = new Label();
            txtInstallDir = new TextBox();
            btnBrowse = new Button();
            panelResolution = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            btnNormalize = new Button();
            btnRecommend = new Button();
            btnPatch = new Button();
            txtResHeight = new TextBox();
            label4 = new Label();
            txtResWidth = new TextBox();
            label3 = new Label();
            label2 = new Label();
            folderBrowser = new FolderBrowserDialog();
            mainMenuStrip.SuspendLayout();
            mainStatusStrip.SuspendLayout();
            panelResolution.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            mainMenuStrip.Location = new Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Size = new Size(511, 24);
            mainMenuStrip.TabIndex = 0;
            mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(93, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewHelpToolStripMenuItem, toolStripSeparator1, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            viewHelpToolStripMenuItem.Size = new Size(127, 22);
            viewHelpToolStripMenuItem.Text = "View &Help";
            viewHelpToolStripMenuItem.Click += viewHelpToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(124, 6);
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(127, 22);
            aboutToolStripMenuItem.Text = "&About...";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // mainStatusStrip
            // 
            mainStatusStrip.Items.AddRange(new ToolStripItem[] { statusText });
            mainStatusStrip.Location = new Point(0, 264);
            mainStatusStrip.Name = "mainStatusStrip";
            mainStatusStrip.Size = new Size(511, 22);
            mainStatusStrip.SizingGrip = false;
            mainStatusStrip.TabIndex = 1;
            mainStatusStrip.Text = "statusStrip1";
            // 
            // statusText
            // 
            statusText.BackColor = SystemColors.Control;
            statusText.Name = "statusText";
            statusText.Size = new Size(39, 17);
            statusText.Text = "Ready";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 2;
            label1.Text = "Installation Folder";
            // 
            // txtInstallDir
            // 
            txtInstallDir.BackColor = Color.WhiteSmoke;
            txtInstallDir.Location = new Point(12, 58);
            txtInstallDir.Name = "txtInstallDir";
            txtInstallDir.ReadOnly = true;
            txtInstallDir.Size = new Size(401, 23);
            txtInstallDir.TabIndex = 0;
            txtInstallDir.TabStop = false;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(419, 58);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 23);
            btnBrowse.TabIndex = 1;
            btnBrowse.Text = "Browse...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // panelResolution
            // 
            panelResolution.BackColor = SystemColors.Control;
            panelResolution.Controls.Add(label8);
            panelResolution.Controls.Add(label7);
            panelResolution.Controls.Add(label6);
            panelResolution.Controls.Add(label5);
            panelResolution.Controls.Add(btnNormalize);
            panelResolution.Controls.Add(btnRecommend);
            panelResolution.Controls.Add(btnPatch);
            panelResolution.Controls.Add(txtResHeight);
            panelResolution.Controls.Add(label4);
            panelResolution.Controls.Add(txtResWidth);
            panelResolution.Controls.Add(label3);
            panelResolution.Controls.Add(label2);
            panelResolution.Dock = DockStyle.Bottom;
            panelResolution.Enabled = false;
            panelResolution.Location = new Point(0, 93);
            panelResolution.Name = "panelResolution";
            panelResolution.Size = new Size(511, 171);
            panelResolution.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(16, 140);
            label8.Name = "label8";
            label8.Size = new Size(140, 12);
            label8.TabIndex = 8;
            label8.Text = "* Patch - applies the resolution";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(16, 126);
            label7.Name = "label7";
            label7.Size = new Size(244, 12);
            label7.TabIndex = 8;
            label7.Text = "* Normalize - corrects entered resolution's aspect ratio ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(16, 112);
            label6.Name = "label6";
            label6.Size = new Size(186, 12);
            label6.TabIndex = 8;
            label6.Text = "* Recommend - suggests ideal resolution";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(16, 95);
            label5.Name = "label5";
            label5.Size = new Size(63, 12);
            label5.TabIndex = 7;
            label5.Text = "Quick Guide";
            // 
            // btnNormalize
            // 
            btnNormalize.Location = new Point(335, 77);
            btnNormalize.Name = "btnNormalize";
            btnNormalize.Size = new Size(164, 23);
            btnNormalize.TabIndex = 5;
            btnNormalize.Text = "Normalize";
            btnNormalize.UseVisualStyleBackColor = true;
            btnNormalize.Click += btnNormalize_Click;
            // 
            // btnRecommend
            // 
            btnRecommend.Location = new Point(335, 48);
            btnRecommend.Name = "btnRecommend";
            btnRecommend.Size = new Size(164, 23);
            btnRecommend.TabIndex = 4;
            btnRecommend.Text = "Recommend";
            btnRecommend.UseVisualStyleBackColor = true;
            btnRecommend.Click += btnRecommend_Click;
            // 
            // btnPatch
            // 
            btnPatch.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnPatch.Location = new Point(335, 106);
            btnPatch.Name = "btnPatch";
            btnPatch.Size = new Size(164, 51);
            btnPatch.TabIndex = 6;
            btnPatch.Text = "Patch";
            btnPatch.UseVisualStyleBackColor = true;
            btnPatch.Click += btnPatch_Click;
            // 
            // txtResHeight
            // 
            txtResHeight.Location = new Point(141, 60);
            txtResHeight.Name = "txtResHeight";
            txtResHeight.Size = new Size(100, 23);
            txtResHeight.TabIndex = 3;
            txtResHeight.TextAlign = HorizontalAlignment.Center;
            txtResHeight.TextChanged += ValueChanged;
            txtResHeight.KeyPress += FilterNumberOnly;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(141, 42);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 3;
            label4.Text = "Height:";
            // 
            // txtResWidth
            // 
            txtResWidth.Location = new Point(16, 60);
            txtResWidth.Name = "txtResWidth";
            txtResWidth.Size = new Size(100, 23);
            txtResWidth.TabIndex = 2;
            txtResWidth.TextAlign = HorizontalAlignment.Center;
            txtResWidth.TextChanged += ValueChanged;
            txtResWidth.KeyPress += FilterNumberOnly;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 42);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 3;
            label3.Text = "Width:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 10);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 2;
            label2.Text = "Set Resolution";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(511, 286);
            Controls.Add(panelResolution);
            Controls.Add(btnBrowse);
            Controls.Add(txtInstallDir);
            Controls.Add(label1);
            Controls.Add(mainStatusStrip);
            Controls.Add(mainMenuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mainMenuStrip;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Battle Realms Resolution Patcher";
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            mainStatusStrip.ResumeLayout(false);
            mainStatusStrip.PerformLayout();
            panelResolution.ResumeLayout(false);
            panelResolution.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mainMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem viewHelpToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private StatusStrip mainStatusStrip;
        private ToolStripStatusLabel statusText;
        private Label label1;
        private TextBox txtInstallDir;
        private Button btnBrowse;
        private Panel panelResolution;
        private FolderBrowserDialog folderBrowser;
        private Button btnNormalize;
        private Button btnRecommend;
        private Button btnPatch;
        private TextBox txtResHeight;
        private Label label4;
        private TextBox txtResWidth;
        private Label label3;
        private Label label2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
    }
}