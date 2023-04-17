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

using AtsusaKai.BRResPatcher.Forms;

namespace AtsusaKai.BRResPatcher
{
    public partial class MainForm : Form
    {
        private ResolutionPatcher m_Patcher = new ResolutionPatcher();

        public MainForm()
        {
            InitializeComponent();
            Initialize();
        }

        /// <summary>
        /// Initialization.
        /// </summary>
        private void Initialize()
        {
            btnPatch.Enabled = false;

            bool firstRun = Properties.Settings.Default.FirstRun;
            if (firstRun)
            {
                Properties.Settings.Default.FirstRun = false;
            }

            string path = Properties.Settings.Default.InstallDir;

            if (VerifyInstallationFolder(path))
            {
                ToggleResolutionPanel(true);

                INIConfigParser config = new INIConfigParser(Path.Combine(path, ResolutionPatcher.BattleRealmsConfig));
                txtResWidth.Text = config.Read("VideoState", "width");
                txtResHeight.Text = config.Read("VideoState", "height");

                txtResWidth.Focus();
            }
            else
            {
                Properties.Settings.Default.InstallDir = "";
                ToggleResolutionPanel(false);
            }

            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Enable or disable resolution area.
        /// </summary>
        /// <param name="enabled"></param>
        private void ToggleResolutionPanel(bool enabled)
        {
            panelResolution.Enabled = enabled;
            txtResWidth.Focus();
        }

        /// <summary>
        /// Calculates ideal width based on height.
        /// </summary>
        private void NormalizeAspectRatio()
        {
            if (txtResHeight.Text == string.Empty)
            {
                MessageBox.Show("You must enter a height.", "Normalize Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtResHeight.Focus();

                return;
            }

            int height = int.Parse(txtResHeight.Text);

            if (height < ResolutionPatcher.MinimumResolutionHeight)
            {
                MessageBox.Show($"The minimum height is '{ResolutionPatcher.MinimumResolutionHeight}'.", "Normalize Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                height = ResolutionPatcher.MinimumResolutionHeight;
                txtResHeight.Text = height.ToString();
            }

            int width = (int)(height / ResolutionPatcher.ResolutionAspectRatio);

            txtResWidth.Text = width.ToString();
        }

        /// <summary>
        /// Accept digits only for width and height text boxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilterNumberOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            btnPatch.Enabled = (txtResWidth.Text != string.Empty && txtResHeight.Text != string.Empty);
        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string path = folderBrowser.SelectedPath;

                if (VerifyInstallationFolder(path))
                {
                    ToggleResolutionPanel(true);

                    Properties.Settings.Default.InstallDir = path;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    ToggleResolutionPanel(false);
                    MessageBox.Show("This folder does not contain Battle Realms game files.", "Invalid Installation Folder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// Verifies installation directory and game files.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private bool VerifyInstallationFolder(string path)
        {
            if (m_Patcher.VerifyInstallationFolder(path))
            {
                txtInstallDir.Text = path;

                m_Patcher.SetInstallationFolder(path);

                if (!m_Patcher.VerifyBinary())
                {
                    ToggleResolutionPanel(false);
                    MessageBox.Show("Potentially corrupted/modified binary or incorrect version of Battle Realms detected.\r\n\r\nMake sure the installed game is:\r\nBattle Realms Complete v1.0.0.8 (GOG)", "Invalid Game", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    return true;
                }
            }

            return false;
        }

        private void btnRecommend_Click(object sender, EventArgs e)
        {
            (int width, int height) = m_Patcher.GetRecommendedResolution();

            txtResHeight.Text = $"{height}";
            txtResWidth.Text = $"{width}";
        }

        private void btnNormalize_Click(object sender, EventArgs e)
        {
            NormalizeAspectRatio();
        }

        private void btnPatch_Click(object sender, EventArgs e)
        {
            bool w_OK = int.TryParse(txtResWidth.Text, out int width);
            bool h_OK = int.TryParse(txtResHeight.Text, out int height);
            bool canPatch = w_OK && h_OK;

            if (canPatch)
            {
                if (m_Patcher.Patch(width, height))
                {
                    MessageBox.Show($"Patch successful.\r\n\r\nResolution: {width}x{height}", "Patch Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                return;
            }

            MessageBox.Show("Unable to patch.\r\n\r\nReason: Invalid resolution.", "Patch Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer", @"https://github.com/AtsusaKai/Battle-Realms-Resolution-Patcher/blob/master/README.md");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutForm form = new AboutForm())
            {
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog();
            }
        }
    }
}