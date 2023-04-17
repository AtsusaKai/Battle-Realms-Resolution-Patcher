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

using System.Runtime.InteropServices;
using System.Text;

namespace AtsusaKai.BRResPatcher
{
    /// <summary>
    /// Simple INI file parser.
    /// </summary>
    public class INIConfigParser
    {
        private string m_IniFilePath;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="filePath">Path of the INI file.</param>
        public INIConfigParser(string filePath)
        {
            m_IniFilePath = filePath;
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        internal static extern uint GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, uint nSize, string lpFileName);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        internal static extern bool WritePrivateProfileString(string lpAppName, string lpKeyName, string lpString, string lpFileName);

        /// <summary>
        /// Returns the value of a setting.
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public string Read(string section, string key)
        {
            if (!Validate())
                return string.Empty;

            var result = new StringBuilder(255);

            GetPrivateProfileString(section, key, "", result, 255, m_IniFilePath);

            return result.ToString();
        }

        /// <summary>
        /// Writes the value of a setting.
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Write(string section, string key, string value)
        {
            if (!Validate())
                return;

            WritePrivateProfileString(section, key, value, m_IniFilePath);
        }

        /// <summary>
        /// Check if the INI is valid.
        /// </summary>
        /// <returns></returns>
        public bool IsValid()
        {
            return File.Exists(m_IniFilePath);
        }

        /// <summary>
        /// Verbose validation.
        /// </summary>
        /// <returns></returns>
        private bool Validate()
        {
            if (!IsValid())
            {
                MessageBox.Show("INI file is invalid. Please make sure the path is correct.", "INI Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
