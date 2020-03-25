using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Note FirstNote = new Note();
            Note SecondNote = new Note("Igram novi COD:Warzone", "DrImportance", "1.");
            Note ThirdNote = new Note("Vani pada snijeg :-)", "Weather.exe");
            Console.WriteLine(FirstNote.text + FirstNote.author);
            Console.WriteLine(SecondNote.text + SecondNote.author);
            Console.WriteLine(ThirdNote.text + ThirdNote.author);
            Console.WriteLine(FirstNote.ToString());
            TimeNote timenote = new TimeNote();
            Console.WriteLine(timenote.ToString());
        }
    }
}