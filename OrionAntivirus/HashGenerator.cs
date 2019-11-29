using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace OrionAntivirus
{
    static class HashGenerator
    {

        /// <summary>
        /// The main entry point for the app0lication.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new App());
        }

        // Generate an MD5 hash for the subject file
        public static string GenerateHash(string filePath)
        {
            using (MD5 md5 = MD5.Create())
            {
                if (File.Exists(filePath))
                {
                    FileStream file = File.OpenRead(filePath); // Create abstract instance of subject file
                    file.Position = 0; // Start at top of file
                    byte[] hashValue = md5.ComputeHash(file); // Store md5 hash

                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < hashValue.Length; i++)
                    {
                        sb.Append(hashValue[i].ToString("X2"));
                    }

                    file.Close();

                    return sb.ToString().ToLower();
                }
                else
                {
                    Console.WriteLine("File does not exist!");

                    return "";
                }

            }
        }
    }
}
