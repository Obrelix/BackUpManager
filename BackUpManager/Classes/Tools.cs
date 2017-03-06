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
            
            try
            {
                obj.objInit();
                obj.pathToListAdd(obj.pathTo);
                
                DirectoryCopy(obj.pathFrom, obj.pathToList[obj.pathToList.Count - 1], true);

                notifyIcon_Main.BalloonTipTitle = "New Backup Created";
                notifyIcon_Main.BalloonTipText = obj.descr +
                    Environment.NewLine + "From:" + obj.pathFrom +
                    Environment.NewLine + "To:" + obj.pathTo;
                notifyIcon_Main.ShowBalloonTip(500);

                
                obj.historyDateList.Add(DateTime.Now);
                obj.historyList.Add(new BackUpHistory(DateTime.Now, true, obj.size, obj.files, obj.folders));

                
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

                    File.WriteAllText(saveFile, "[ ]");
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
