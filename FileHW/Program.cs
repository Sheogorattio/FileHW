using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryClass;

namespace FileHW
{
    internal class Program
    {
        static void Main()
        {
            MyLibrary lb = new MyLibrary("Library.txt");
            lb.Clear();
            lb.Add("Title 1", "Author 1", 1, "Grand\nPoem 1");
            lb.Add("Title 2", "Author 2", 2, "Grand\nPoem 2");
            lb.Add("Title 3", "Author 3", 3, "Grand\nPoem 3");
          //  lb.Delete("Title 2");
          //  lb.Print();
          Console.WriteLine(lb.SearchByTitle("Title 1"));

            Console.Read();
        }
    }
}
