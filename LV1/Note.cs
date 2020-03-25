using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV1
{

    class Note
    {
        private String Text;
        private String Author;
        private String ImportancyLevel;

        string getValue() { return ImportancyLevel; }
        void setValue(string value) { ImportancyLevel = value; }
        public string text
        {
            get { return this.Text; }
            set { this.Text = value; }
        }
        public string author
        {
            get { return this.Author; }
        }

        public Note()
        {
            this.Text = "Danas radim prvi online LV.";
            this.Author = "Ivan Čordašić";
            this.ImportancyLevel = "1.";
        }

        public Note(string text, string author, string importancylevel)
        {
            this.Text = text;
            this.Author = author;
            this.ImportancyLevel = importancylevel;
        }
        public Note(string text, string author)
        {
            this.Text = text;
            this.Author = author;
        }
        public override string ToString()
        {
            return (this.ImportancyLevel + this.author);
        }
    }
}
