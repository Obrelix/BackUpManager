using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class ListId
    {
        private int _mode;

        public int Mode
        {
            get { return _mode; }
            set { _mode = (value < 0) ? 0 : value; }
        }
        
        public string Descr { get; set; }
        public ListId()
        {

        }
        public ListId(int md, string descr)
        {
            this.Mode = md;
            this.Descr = descr;
        }
    }

