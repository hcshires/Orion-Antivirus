using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace OrionAntivirus
{
    public partial class App : Form
    {
        private static string path;
        private static string database = "md5.txt";
        private static string fileHash;
        private static readonly string initStatus = "Click Browse to scan a file.";
        private static readonly string initDelete = "Click Delete to delete the infected file.";

        public App()
        {
            InitializeComponent();
        }

        private void App_Load(object sender, EventArgs e)
        {
            /* Init Components */
            statusLbl.Text = initStatus;
            statusLbl.ForeColor = Color.Gray;
            deleteLbl.Text = initDelete;
            deleteLbl.ForeColor = Color.Gray;
            deleteBtn.Enabled = true;
            deleteTip.SetToolTip(deleteBtn, "Delete the selected file");
            browseTip.SetToolTip(browseBtn, "Browse for a file to scan");
            isInfectedLbl.Text = "";
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            scanLog.Text = "";
            deleteLbl.Text = initDelete;
            deleteLbl.ForeColor = Color.Gray;
            fileDialog.ShowDialog(); // Open Dialog
        }

        private void FileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            path = fileDialog.FileName;
            filePathTxt.Text = path;

            deleteProgress.Value = 0;

            fileHash = HashGenerator.GenerateHash(path); // Generate a hash for the subject file
            ReadFile(path, fileHash);
        }

        /* Read A File's MD5 hashes and compare it with known malware MD5 Hashes in a text file */
        private void ReadFile(string path, string hash)
        {
            if (File.Exists(path))
            {
                scanLog.Text += "File to scan identified at \n" + path + "\nMD5 Hash Database Found: " + database;
                hashTxt.Text = hash;
                bool isInfected = false;

                using (FileStream file = File.OpenRead(database))
                {
                    using (StreamReader s = new StreamReader(file)) // Automatic file reader
                    {
                        while (!s.EndOfStream)
                        {
                            String line = s.ReadLine().ToLower();
                            scanLog.Text += "\nScanning... " + line + " at hash: " + hash;
                            Console.WriteLine("Scanning... " + line + " at hash: " + hash);

                            statusLbl.Text = "Scaning File...";
                            statusLbl.ForeColor = Color.Orange;

                            if (line.Equals(hash))
                            {
                                statusLbl.Text = "Your file contains Malware! \nSelect the tab above to delete the file";
                                statusLbl.ForeColor = Color.Red;
                                scanLog.Text += "\nINFECTED! Identified as " + hash;
                                isInfected = true;
                                isInfectedLbl.Text = "";
                                deleteBtn.Enabled = true;
                                break;
                            }
                        }

                        if (s.EndOfStream && !isInfected)
                        {
                            statusLbl.Text = "No Malware Found.";
                            statusLbl.ForeColor = Color.Green;
                            deleteBtn.Enabled = false;
                            isInfectedLbl.Text = "Your file isn't infected. No need to delete it!";
                        }
                    }
                }
            }
            else
            {
                scanLog.Text += "\nERROR: Selected File Doesn't Exist! Try another file.";
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            deleteLbl.Text = "Deleting file...";
            scanLog.Text += "\nDeleting infected file...";
            deleteLbl.ForeColor = Color.Orange;
            if (File.Exists(path))
            {
                deleteTimer.Start();
                File.Delete(path);
            } else
            {
                deleteLbl.Text = "File Not Found. Try browsing for another.";
                scanLog.Text += "\nERROR: The file you are trying to delete doesn't exist!";
            }
        }

        private void WebsiteLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            websiteLink.LinkVisited = true;
            System.Diagnostics.Process.Start("https://veloticstechnologies.github.io");
        }

        private void DeleteTimer_Tick(object sender, EventArgs e)
        {
            deleteTimer.Interval = 10;
            if (deleteProgress.Value >= deleteProgress.Maximum)
            {
                deleteLbl.Text = "File deleted successfully.";
                scanLog.Text += "\nFile deleted successfully";
                deleteLbl.ForeColor = Color.Green;
                deleteTimer.Stop();

                /* Reset Tab 1 */
                statusLbl.Text = initStatus;
                statusLbl.ForeColor = Color.Gray;
            } else
            {
                deleteProgress.Value += 10;
            }
        }
    }
}
