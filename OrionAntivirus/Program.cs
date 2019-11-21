using System;
using System.IO;
using System.Security;
using System.Security.Cryptography;
using System.Text;

namespace OrionAntivirus
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new App());
        }

        // Read database for matching malware MD5
        public static void readFile(string path) // File Checking process
        {
            String fileHash = generateHash(path); // Generate a hash for the subject file
            if (File.Exists(path))
            {
                Console.WriteLine("Database exists");

                using (FileStream file = File.OpenRead("test.txt"))
                {
                    using (StreamReader s = new StreamReader(file)) // Automatic file reader
                    {
                        while (!s.EndOfStream)
                        {
                            String line = s.ReadLine().ToLower();
                            Console.WriteLine(line + " ||||||| " + fileHash);

                            if (line.Equals(fileHash))
                            {
                                // Display message "Files Infected!"
                                // set label color
                                Console.WriteLine("Infected");
                            }
                            else
                            {
                                // Display message "No Risks Found!"
                                // set label color
                                Console.WriteLine("Clean");
                            }
                        }
                    }
                }
            }
        }

        // Generate an MD5 hash for the subject file
        static string generateHash(string filePath)
        {
            using (MD5 md5 = MD5.Create())
            {
                if (File.Exists(filePath))
                {
                    FileStream file = File.OpenRead(filePath); // Create abstract instance of subject file
                    file.Position = 0; // Start at top of file
                    Console.WriteLine("test");
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

        // Returns the MD5 hash as a hexadecimal
        static string printByteArray(byte[] hash)
        {
            string hex = "";
            
            for (int i = 0; i < hash.Length - 1; i++)
            {
                hex += hash[i].ToString("x2"); // Converts byte to hexadecimal string
            }

            return hex.ToLower(); // lowercase
        }
    }
}
