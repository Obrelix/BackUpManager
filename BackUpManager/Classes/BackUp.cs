using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackUpManager
{
    public class BackUp
    {
        public string pathFrom { get; set; }
        public string pathTo { get; set; }
        public string descr { get; set; }
        public DateTime Date = new DateTime();
        public List<DateTime> historyList = new List<DateTime>();
        private string _lastRun;
        public string lastRun { get { return _lastRun; }
            set { _lastRun = (historyList.Count < 1) ? "Never" : historyList[historyList.Count - 1].ToString(); } }
       

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
            return historyList[historyList.Count - 1].ToString();
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
        
        public void AddWeeks(double weeks)
        {
            Date = Date.AddDays(weeks * 7.0);
        }
        
        public void AddDays(double days)
        {
            Date = Date.AddDays(days);
        }
        
        public void AddHours(double hours)
        {
            Date = Date.AddHours(hours);
        }
        
        public void AddMinutes(double minutes)
        {
            Date = Date.AddMinutes(minutes);
        }
        
        public void AddSeconds(double seconds)
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

        private  void AddExtraTime()
        {
            switch (Mode)
            {
                case 0:
                    AddWeeks(ModeValue);
                    break;
                case 1:
                    AddDays(ModeValue);
                    break;
                case 2:
                    AddHours(ModeValue);
                    break;
                case 3:
                    AddMinutes(ModeValue);
                    break;
                case 4:
                    AddSeconds(ModeValue);
                    break;
                case 5:
                    AddSeconds(0);
                    break;
            }
        }


        public BackUp(string pthFrom, string pthTo, string Job, DateTime dt, int mod, int modV, string modDescr)
        {
            pathFrom = pthFrom;
            pathTo = pthTo;
            descr = Job;
            setDate(dt);
            Mode = mod;
            ModeValue = modV;
            ModeDescr = modDescr;
            if(Mode == 5)
            {
                schedule = "Manual";
            }
            else
            {
                AddExtraTime();
                schedule = "Every " + ModeValue + " " + ModeDescr ;
            }
            displayInit();
        }

        public void displayInit()
        {
            _lastRun = (historyList.Count < 1) ? "Never" : historyList[historyList.Count - 1].ToString();
            display[0] = descr;
            display[1] = pathFrom;
            display[2] = pathTo;
            display[3] = this.schedule;
            display[4] = lastRun;
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
}
