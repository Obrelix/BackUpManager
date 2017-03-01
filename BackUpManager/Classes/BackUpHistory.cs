using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class BackUpHistory
    {
        public DateTime datetime = new DateTime();
        public string date { get; set; }
        public string time { get; set; }
        public bool done { get; set; }
        public double size { get; set; }
        public long fileCount { get; set; }
        public long directoryCount { get; set; }


        public BackUpHistory(DateTime dt, bool done, double size, long files, long dirCount)
        {
            datetime = dt;
            date = datetime.ToShortDateString();
            time = datetime.ToLongTimeString();
            this.done = done;
            this.size = size;
            this.fileCount = files;
            directoryCount = dirCount;
        }

    }
