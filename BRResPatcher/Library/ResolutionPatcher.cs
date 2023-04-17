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

using System.Diagnostics;

namespace AtsusaKai.BRResPatcher
{
    /// <summary>
    /// Handles resolution patching.
    /// </summary>
    public class ResolutionPatcher
    {
        public const int VerifiedExe = 2998272;
        public const int MinimumResolutionHeight = 600;
        public const int DefaultResolutionIdx = 0x13;
        public const float ResolutionAspectRatio = 0.75f;
        public const string BattleRealmsBinary = "Battle_Realms_F.exe";
        public const string BattleRealmsConfig = "Battle_Realms.ini";

        private string m_InstallDirPath = "";
        private string[] m_RequiredFiles = new string[] { BattleRealmsBinary, BattleRealmsConfig };

        private Dictionary<byte, Resolution> m_Resolutions = new Dictionary<byte, Resolution>();

        public string InstallationFolderPath => m_InstallDirPath;

        public ResolutionPatcher()
        {
            Initialize();
        }

        private void Initialize()
        {         
            m_Resolutions.Add(0x07, new Resolution() { 
                Width = 512, 
                Height = 384,
                WidthOffsets = new int[] { 0x2380AD, 0x23822C, 0x2445C4, 0x2447B6 },
                HeightOffsets = new int[] { 0x2380B5, 0x238235, 0x2445CE, 0x2447BF }
            });

            m_Resolutions.Add(0x0B, new Resolution()
            {
                Width = 800,
                Height = 600,
                WidthOffsets = new int[] { 0x2380FA, 0x238273, 0x24460F, 0x2447FD },
                HeightOffsets = new int[] { 0x238102, 0x23827C, 0x244619, 0x244806 }
            });

            m_Resolutions.Add(0x0F, new Resolution()
            {
                Width = 1152,
                Height = 864,
                WidthOffsets = new int[] { 0x23814B, 0x2382C3, 0x244663, 0x244844 },
                HeightOffsets = new int[] { 0x238153, 0x2382CC, 0x24466D, 0x24484D }
            });

            m_Resolutions.Add(0x13, new Resolution()
            {
                Width = 1600,
                Height = 1200,
                WidthOffsets = new int[] { 0x23817B, 0x238313, 0x2446B7, 0x244894 },
                HeightOffsets = new int[] { 0x238191, 0x23831C, 0x2446C1, 0x24489D }
            });
        }

        /// <summary>
        /// Check if valid Battle Realms installation folder.
        /// </summary>
        /// <returns></returns>
        public bool VerifyInstallationFolder(string path)
        {
            if (path == string.Empty)
                return false;

            foreach (var file in m_RequiredFiles)
            {
                if (!File.Exists(Path.Combine(path, file)))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Checks if Battle Realms' exe is valid.
        /// </summary>
        /// <returns></returns>
        public bool VerifyBinary()
        {
            string filename = Path.Combine(m_InstallDirPath, BattleRealmsBinary);
            FileInfo info = new FileInfo(filename);
            return (info.Length == VerifiedExe);
        }

        /// <summary>
        /// Set Battle Realms' installation folder path.
        /// </summary>
        /// <param name="installationFolderPath"></param>
        public void SetInstallationFolder(string installationFolderPath)
        {
            m_InstallDirPath = installationFolderPath;
        }

        /// <summary>
        /// Returns recommended resolution based from the primary screen display resolution.
        /// </summary>
        /// <returns></returns>
        public (int, int) GetRecommendedResolution()
        {
            int height = Screen.PrimaryScreen.Bounds.Height;
            int width = (int)(height / ResolutionAspectRatio);

            return (width, height);
        }

        /// <summary>
        /// Performs patching.
        /// </summary>
        /// <param name="newWidth"></param>
        /// <param name="newHeight"></param>
        public bool Patch(int newWidth, int newHeight)
        {
            try
            {
                PatchExecutable(newWidth, newHeight);
                PatchConfig(newWidth, newHeight);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to patch.\r\n\r\nReason: {ex.Message}", "Patch Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        /// <summary>
        /// Applies the desired resolution to the executable.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        private void PatchExecutable(int width, int height)
        {
            string exePath = Path.Combine(m_InstallDirPath, BattleRealmsBinary);
            // Create backup first...
            BackupFile(exePath);

            // Patch resolution width
            foreach (int offset in m_Resolutions[DefaultResolutionIdx].WidthOffsets)
            {
                using (BinaryWriter writer = new BinaryWriter(new FileStream(exePath, FileMode.Open, FileAccess.ReadWrite)))
                {
                    writer.Seek(offset, SeekOrigin.Begin);
                    writer.Write(width);
                    writer.Close();
                }
            }

            // Patch resolution height
            foreach (int offset in m_Resolutions[DefaultResolutionIdx].HeightOffsets)
            {
                using (BinaryWriter writer = new BinaryWriter(new FileStream(exePath, FileMode.Open, FileAccess.ReadWrite)))
                {
                    writer.Seek(offset, SeekOrigin.Begin);
                    writer.Write(height);
                    writer.Close();
                }
            }
        }

        /// <summary>
        /// Applies the desired resolution to the config file.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        private void PatchConfig(int width, int height)
        {
            string iniPath = Path.Combine(m_InstallDirPath, BattleRealmsConfig);
            Debug.WriteLine(iniPath);
            // Create backup first...
            BackupFile(iniPath);

            INIConfigParser parser = new INIConfigParser(iniPath);
            parser.Write("VideoState", "width", width.ToString());
            parser.Write("VideoState", "height", height.ToString());
            parser.Write("VideoState", "depth", "32");
            parser.Write("VideoState", "hardwaretl", "1");
        }

        /// <summary>
        /// Create backup.
        /// </summary>
        /// <param name="filename"></param>
        public void BackupFile(string filename)
        {
            if (!File.Exists(filename))
            {
                MessageBox.Show($"Unable to make backup for '{filename}', the file does not exist.", "Backup Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string backupFilename = $"{filename}.BRResPatcher-backup";
            File.Copy(filename, backupFilename, true);
        }
    }
}
