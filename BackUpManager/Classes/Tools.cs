using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackUpManager
{

    public static class Tools
        {
            public static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
            {
                // Get the subdirectories for the specified directory.
                DirectoryInfo dir = new DirectoryInfo(sourceDirName);

                if (!dir.Exists)
                {
                    throw new DirectoryNotFoundException(
                        "Source directory does not exist or could not be found: "
                        + sourceDirName);
                }

                DirectoryInfo[] dirs = dir.GetDirectories();
                // If the destination directory doesn't exist, create it.
                if (!Directory.Exists(destDirName))
                {
                    Directory.CreateDirectory(destDirName);
                }

                // Get the files in the directory and copy them to the new location.
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo file in files)
                {
                    string temppath = Path.Combine(destDirName, file.Name);
                    file.CopyTo(temppath, false);
                }

                // If copying subdirectories, copy them and their contents to new location.
                if (copySubDirs)
                {
                    foreach (DirectoryInfo subdir in dirs)
                    {
                        string temppath = Path.Combine(destDirName, subdir.Name);
                        DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                    }
                }
            }

        public static void doBackUp(BackUp obj, NotifyIcon notifyIcon_Main, List<BackUp> backUpList, string saveFile, DataGridView dtgrdvDisplay)
        {
            string dirPath = obj.pathTo + "/" + obj.descr + "_Backup_" +
               DateTime.Now.Day + "-" +
               DateTime.Now.Month + "-" +
               DateTime.Now.Year + "_" +
               DateTime.Now.Hour + "_" +
               DateTime.Now.Minute + "_" +
               DateTime.Now.Second;
            try
            {
                Tools.DirectoryCopy(obj.pathFrom, dirPath, true);

                notifyIcon_Main.BalloonTipTitle = "New Backup Created";
                notifyIcon_Main.BalloonTipText = obj.descr +
                    Environment.NewLine + "From:" + obj.pathFrom +
                    Environment.NewLine + "To:" + obj.pathTo;
                notifyIcon_Main.ShowBalloonTip(500);
                DirectoryInfo di = new DirectoryInfo(obj.pathFrom+ "/");
                obj.size = di.EnumerateFiles("*", SearchOption.AllDirectories).Sum(fi => fi.Length);
                obj.size /= 1024;
                obj.size /= 1024;
                obj.size = Math.Round(obj.size, 2);
                obj.files = Directory.GetFiles(obj.pathFrom, "*.*", SearchOption.AllDirectories).Length;
                obj.historyDateList.Add(obj.Date);
                obj.folders = Directory.GetDirectories(obj.pathFrom).Length;
                obj.historyList.Add(new BackUpHistory(obj.Date, true, obj.size, obj.files, obj.folders));
                BackUp.AddExtraTime(obj);
                obj.displayInit();

                SaveBackUp(backUpList, saveFile);
                gridRefresh(backUpList, dtgrdvDisplay);
            }
            catch
            {

            }
        }


        public static List<BackUp> LoadBackup(string savePath,  string saveFile, DataGridView dtgrdvDisplay)
        {
            List<BackUp> backUpList = new List<BackUp>();
            Directory.CreateDirectory(savePath);
            try
            {
                if (File.Exists(saveFile))
                {
                    backUpList.Clear();
                    backUpList = JsonConvert.DeserializeObject<List<BackUp>>(System.IO.File.ReadAllText(saveFile));
                    enableBackups(backUpList);
                    gridRefresh(backUpList, dtgrdvDisplay);

                    return backUpList;
                    
                    }
                else
                {
                    using (System.IO.FileStream fs = System.IO.File.Create(saveFile))
                    {
                        for (byte i = 0; i < 100; i++)
                        {
                            fs.WriteByte(i);
                        }
                    }
                    LoadBackup(savePath, saveFile, dtgrdvDisplay);
                    return backUpList;
                }

            

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                backUpList.Clear();
                return backUpList;
            }

        }

        public static void gridRefresh(List<BackUp> backUpList, DataGridView dtgrdvDisplay)
        {

            dtgrdvDisplay.Rows.Clear();
            foreach (BackUp obj in backUpList)
            {
                dtgrdvDisplay.Rows.Add(obj.display);
            }

        }

        public static void SaveBackUp(List<BackUp> backUpList, string saveFile)
        {

            try
            {
                string contentsToWriteToFile = Newtonsoft.Json.JsonConvert.SerializeObject(backUpList.ToArray(), Newtonsoft.Json.Formatting.Indented);

                System.IO.File.WriteAllText(saveFile, contentsToWriteToFile);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static void enableBackups(List<BackUp> backUpList)
        {
            foreach (BackUp bk in backUpList)
            {
                if (bk.Mode != 5)
                {
                    while (DateTime.Compare(bk.Date, DateTime.Now) < 0)
                    {
                        bk.historyList.Add(new BackUpHistory(bk.Date, false, 0, 0, 0));
                        BackUp.AddExtraTime(bk);
                    }
                }
            }
        }
    }

}
