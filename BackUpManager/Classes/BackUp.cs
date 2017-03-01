using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class BackUp
    {
        public string pathFrom { get; set; }
        public string pathTo { get; set; }
        public List<string> pathToList { get; set; } = new List<string>();
        public string descr { get; set; }

        public DateTime Date = new DateTime();
        public List<DateTime> historyDateList = new List<DateTime>();
        public List<BackUpHistory> historyList = new List<BackUpHistory>();
        private string _lastRun;
        public long files { get; set; }
        public long folders { get; set; }
        public double size { get; set; }
        

        public string lastRun { get { return _lastRun; }
            set { _lastRun = (historyDateList.Count < 1) ? "Never" : historyDateList[historyDateList.Count - 1].ToString(); } }


        public void displayInit()
        {
            _lastRun = (historyDateList.Count < 1) ? "Never" : historyDateList[historyDateList.Count - 1].ToString();
            display[0] = descr;
            display[1] = pathFrom;
            display[2] = pathTo;
            display[3] = this.schedule;
            display[4] = lastRun;
            
        }

        public void objInit()
        {
            DirectoryInfo di = new DirectoryInfo(pathFrom );
            size = di.EnumerateFiles("*", SearchOption.AllDirectories).Sum(fi => fi.Length);
            size /= 1024;
            size /= 1024;
            size = Math.Round(size, 2);
            files = Directory.GetFiles(pathFrom, "*.*", SearchOption.AllDirectories).Length;
            
            folders = Directory.GetDirectories(pathFrom, "*.*", SearchOption.AllDirectories).Length;

        }
        public void setDate(DateTime dt)
        {
            Date = dt;
        }

        public string schedule
        {
            get;
            set;
        }

        public string getLastRun()
        {
            return historyDateList[historyDateList.Count - 1].ToString();
        }

        public string[] display = new string[5];

        
        public int Mode { get; set; }
        
        public int ModeValue { get; set; }
        
        public string ModeDescr { get; set; }
        
        public int Hours
        {
            get { return Date.Hour; }
        }
        
        public int Minutes
        {
            get { return Date.Minute; }
        }
        
        public int Seconds
        {
            get { return Date.Second; }
        }
        
        public TimeSpan TmSp { get; set; }
        
        public double TSTotalSeconds
        {
            get { return TmSp.TotalSeconds; }
        }
        
        private void AddWeeks(double weeks)
        {
            Date = Date.AddDays(weeks * 7.0);
        }

        private void AddDays(double days)
        {
            Date = Date.AddDays(days);
        }

        private void AddHours(double hours)
        {
            Date = Date.AddHours(hours);
        }

        private void AddMinutes(double minutes)
        {
            Date = Date.AddMinutes(minutes);
        }

        private void AddSeconds(double seconds)
        {
            Date = Date.AddSeconds(seconds);
        }

        public static void AddExtraTime(BackUp obj)
        {
            switch (obj.Mode)
            {
                case 0:
                    obj.AddWeeks(obj.ModeValue);
                    break;
                case 1:
                    obj.AddDays(obj.ModeValue);
                    break;
                case 2:
                    obj.AddHours(obj.ModeValue);
                    break;
                case 3:
                    obj.AddMinutes(obj.ModeValue);
                    break;
                case 4:
                    obj.AddSeconds(obj.ModeValue);
                    break;
                case 5:
                    obj.AddSeconds(0);
                    break;
            }
        }

        public void pathToListAdd(string pthTo)
        {
            int i = 0;
            while(pathToList.Count > 5)
            {
            try
            {
                Directory.Delete(pathToList[i], true);
            }
            catch(Exception e)
            {
                MessageBox.Show("Directory " + pathToList[i] + "Does not Exist" + Environment.NewLine + e.Message);
            }
                
                pathToList.Remove(pathToList[i]);
                i++;
            }
            pathToList.Add(pthTo + "\\" + descr + "_Backup_" +
                Date.Day + "-" +
                Date.Month + "-" +
                Date.Year + "_" +
                Date.Hour + "_" +
                Date.Minute + "_" +
                Date.Second);
        }


        public BackUp(string pthFrom, string pthTo, string Job, DateTime dt, int mod, int modV, string modDescr)
        {
            

            pathFrom = pthFrom;
            descr = Job;
            setDate(dt);
            pathTo = pthTo;
            Mode = mod;
            ModeValue = modV;
            ModeDescr = modDescr;
            if(Mode == 5)
            {
                schedule = "Manual";
            }
            else
            {
                schedule = "Every " + ModeValue + " " + ModeDescr ;
            }
            displayInit();
        }


        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3} {4} {5} {6} {7}", 
                "Name: ", descr,
                "   From: ", pathFrom,
                "   To: ", pathTo,
                "   Last Run: ", lastRun);
        }
    }

