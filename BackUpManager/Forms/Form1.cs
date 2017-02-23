using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BackUpManager
{
    public partial class frmMain : Form
    {
        
        string myPic, myVid, myMus, myDoc, myDL, myDesk;
        string dirToPaste;
        string empty = string.Empty;
        string files;
        string copiedFiles;
        int countPic, countVid, countMus, countDoc=0, countDL, countDesk;
        int count;
        string newDest;
        int countCopied; //This is the interger number that on update show us how much files copied.
        int b;
        Thread th; 
        ArrayList folderName;
        


        public frmMain()
        {
            InitializeComponent();
            Name = "BackUpMe";
            myPic = KnownFolders.GetPath(KnownFolder.Pictures);
            myVid = KnownFolders.GetPath(KnownFolder.Videos);
            myMus = KnownFolders.GetPath(KnownFolder.Music);
            myDoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            myDL = KnownFolders.GetPath(KnownFolder.Downloads);
            myDesk = KnownFolders.GetPath(KnownFolder.Desktop);
            th = new Thread(checkWhatCopy);
            folderName = new ArrayList();
            foreach (string know in Directory.GetDirectories(myDoc))
            {
                folderName.Add(know);

            }


            b = folderName.Count;
            countPic = Directory.GetFiles(myPic, "*.*", SearchOption.AllDirectories).Length;
            countVid = Directory.GetFiles(myVid, "*.*", SearchOption.AllDirectories).Length;
            countMus = Directory.GetFiles(myMus, "*.*", SearchOption.AllDirectories).Length;
            countDL = Directory.GetFiles(myDL, "*.*", SearchOption.AllDirectories).Length;
            countDesk = Directory.GetFiles(myDesk, "*.*", SearchOption.AllDirectories).Length;

            for (int i = 0; i < b; i++)
            {
                if ((folderName[i].ToString() != myDoc + "\\My Music") && (folderName[i].ToString() != myDoc + "\\My Pictures") && (folderName[i].ToString() != myDoc + "\\My Videos"))
                {
                    countDoc += Directory.GetFiles(folderName[i].ToString(), "*.*", SearchOption.AllDirectories).Length;
                }

            }
            count = countPic + countDesk + countVid + countDL + countMus;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            th.Start();
            tmrProgress.Start();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFolder();
        }

        private void chkDL_Click(object sender, EventArgs e)
        {
            if (chkDL.Checked)
            {
                countFiles(countDL, true);
            }
            else
            {
                countFiles(countDL, false);
            }
        }

        private void chkDesk_Click(object sender, EventArgs e)
        {
            if (chkDesk.Checked)
            {
                countFiles(countDesk, true);
            }
            else
            {
                countFiles(countDesk, false);
            }
        }

        private void chkDoc_Click(object sender, EventArgs e)
        {
            if (chkDoc.Checked)
            {
                countFiles(countDoc, true);
            }
            else
            {
                countFiles(countDoc, false);
            }
        }

        private void tmrProgress_Tick(object sender, EventArgs e)
        {
            checkCopiedFiles();
        }

        private void tmrFilesCheck_Tick(object sender, EventArgs e)
        {
            
            lblFiles.Text = string.Format("Files: {0}", count);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            tmrFilesCheck.Start();
            

        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            
            

            txtDestinationPath.Text = folderName.ToString();
        }

        private void chkVid_Click(object sender, EventArgs e)
        {
            if (chkVid.Checked)
            {
                countFiles(countVid, true);
            }
            else
            {
                countFiles(countVid, false);
            }
        }

        private void chkMus_Click(object sender, EventArgs e)
        {
            if (chkMus.Checked)
            {
                countFiles(countMus, true);
            }
            else
            {
                countFiles(countMus, false);
            }
        }

        private void chkPic_Click(object sender, EventArgs e)
        {
            if (chkPic.Checked)
            {
                countFiles(countPic, true);
            }
            else
            {
                countFiles(countPic, false);
            }

        }
        
        private void openFolder()
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            MessageBox.Show("Note this. You must create a new folder.", "Note this:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ofd.ShowDialog();
            txtDestinationPath.Text = ofd.SelectedPath.ToString();
            dirToPaste = txtDestinationPath.Text;

        }

        private void checkCopiedFiles()
        {
            //Every Tick
            try
            {
                countCopied = Directory.GetFiles(dirToPaste, "*.*", SearchOption.AllDirectories).Length;
                copiedFiles = countCopied.ToString();
                lblCurCopiedFiles.Text = string.Format("Current Copied Files: {0}", copiedFiles);
            }
            catch (Exception)
            {
                
            }
            
        }

        private void checkWhatCopy()
        {
            dirToPaste = txtDestinationPath.Text;
            if (dirToPaste == "")
                return;
            

            try
            {
                if (chkPic.Checked)
                {
                    newDest = string.Empty;
                    newDest = Path.Combine(dirToPaste , "Picture");
                    Directory.CreateDirectory(newDest);
                    CopyAll(new DirectoryInfo(myPic), new DirectoryInfo(newDest));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                if (chkMus.Checked)
                {
                    newDest = string.Empty;
                    newDest = Path.Combine(dirToPaste, "Music");
                    Directory.CreateDirectory(newDest);
                    CopyAll(new DirectoryInfo(myMus), new DirectoryInfo(newDest));
                    
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }


            try
            {
                if (chkVid.Checked)
                {
                    newDest = string.Empty;
                    newDest = Path.Combine(dirToPaste, "Videos");
                    Directory.CreateDirectory(newDest);
                    CopyAll(new DirectoryInfo(myVid), new DirectoryInfo(newDest));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            try
            {
                if (chkDoc.Checked)
                {
                    newDest = string.Empty;
                    newDest = Path.Combine(dirToPaste, "Documents");
                    Directory.CreateDirectory(newDest);
                    CopyAll(new DirectoryInfo(myDoc), new DirectoryInfo(newDest));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            try
            {
                if (chkDL.Checked)
                {
                    newDest = string.Empty;
                    newDest = Path.Combine(dirToPaste, "Download");
                    Directory.CreateDirectory(newDest);
                    CopyAll(new DirectoryInfo(myDL), new DirectoryInfo(newDest));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                if (chkDesk.Checked)
                {
                    newDest = string.Empty;
                    newDest = Path.Combine(dirToPaste, "Desktop");
                    Directory.CreateDirectory(newDest);
                    CopyAll(new DirectoryInfo(myDesk), new DirectoryInfo(newDest));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CopyAll(DirectoryInfo oOriginal, DirectoryInfo oFinal)
        {
            foreach (DirectoryInfo oFolder in oOriginal.GetDirectories())
                this.CopyAll(oFolder, oFinal.CreateSubdirectory(oFolder.Name));

            foreach (FileInfo oFile in oOriginal.GetFiles())
                oFile.CopyTo(oFinal.FullName + @"\" + oFile.Name, true);
        }

        private void countFiles(int countFiles, bool isChecked)
        {
            //Legend
            //countFiles είναι ο αριθμός που θα στείλουμε
            //isChecked για να δούμε αν θα κάνει πρόσθεση ή αφαίρεση
            if (isChecked)
            {
                count += countFiles;
            }
            else
            {
                count -= countFiles;
            }

            files = count.ToString();
            lblFiles.Text = string.Format("Files: {0}", files);

        }

        private static void DirectoryCopy(
        string sourceDirName, string destDirName, bool copySubDirs)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();

            // If the source directory does not exist, throw an exception.
            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            // If the destination directory does not exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }


            // Get the file contents of the directory to copy.
            FileInfo[] files = dir.GetFiles();

            foreach (FileInfo file in files)
            {
                // Create the path to the new copy of the file.
                string temppath = Path.Combine(destDirName, file.Name);

                // Copy the file.
                file.CopyTo(temppath, false);
            }

            // If copySubDirs is true, copy the subdirectories.
            if (copySubDirs)
            {

                foreach (DirectoryInfo subdir in dirs)
                {
                    // Create the subdirectory.
                    string temppath = Path.Combine(destDirName, subdir.Name);

                    // Copy the subdirectories.
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }


        public void ShowProgress()
        {
            Form progress = new Progress(count, dirToPaste);
            progress.ShowDialog();
        }


        }

}

