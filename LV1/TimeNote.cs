using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV1
{
    class TimeNote : Note
    {
        DateTime time = DateTime.Now;
        public TimeNote() : base()
        {
            DateTime now = DateTime.Now;
            this.time = now;
        }
        public TimeNote(string text, string author, string importancylevel, DateTime time)
        : base(text, author, importancylevel)
        {
            this.time = time;
        }
        public DateTime Time
        {
            get { return this.time; }
            set { this.time = value; }
        }
        public override string ToString()
        {
            return base.ToString() + " vrijeme je: " + this.time;
        }

    }
}
