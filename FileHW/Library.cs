using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHW;
using Library;
using FileInteraction;
using SearchPoem;

namespace LibraryClass
{
    public class MyLibrary:IAddDeletePoem, IPrintFile,ISearch
    {
        readonly string path;
        public string Path { get { return path; } }
        public MyLibrary(string path)
        {
            this.path = path;
        }

        public void Delete(string title)
        {
            StreamReader sr = new StreamReader(path);
            string buff = sr.ReadToEnd();
            sr.Close();
            string target = "Title:" + title + "\n";
            int startIndex = buff.IndexOf(target);
            int endIndex = buff.IndexOf("--------", startIndex) + "--------\n".Length;
            buff =buff.Remove(startIndex, endIndex- startIndex);
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(buff);
            sw.Close();
        }
        public void Add(string title, string author, int year, string poem)
        {
            StreamWriter sw = new StreamWriter(path,true);
            string note = "\nTitle:" + title +"\nAuthor:" + author + "\nYear:"+ year.ToString() +"\n" +"\\\n"+ poem + "\n--------";
            sw.Write(note);
            sw.Close();
        }
        public void Clear()
        {
            StreamWriter sw = new StreamWriter(path);
            sw.Flush();
            sw.Close();
        }

        public void Print()
        {
            StreamReader sr = new StreamReader(path);
            string buff = sr.ReadToEnd();
            sr.Close();
            Console.WriteLine(buff);
        }

        public static void PrintFile(string _path)
        {
            StreamReader sr = new StreamReader(_path);
            string buff = sr.ReadToEnd();
            sr.Close();
            Console.WriteLine(buff);
        }

        public string SearchByTitle(string title)
        {
            string target = "Title:" + title;
            StreamReader sr = new StreamReader(path);
            string buff = sr.ReadToEnd();
            sr.Close();
            int begIndex = buff.IndexOf(target);
            int startIndex = buff.IndexOf("\\\n", begIndex)+1;
            int endIndex = buff.IndexOf("--------")-1;
            string res = buff.Substring(startIndex+1, endIndex- startIndex);
            return res;
        }

        public string SearchByAuthor(string Author)
        {
            string target = "Author:" + Author;
            StreamReader sr = new StreamReader(path);
            string buff = sr.ReadToEnd();
            sr.Close();
            int begIndex = buff.IndexOf(target);
            int startIndex = buff.IndexOf("\\\n", begIndex) + 1;
            int endIndex = buff.IndexOf("--------") - 1;
            string res = buff.Substring(startIndex + 1, endIndex - startIndex);
            return res;
        }

        public string SearchByYear(string year)
        {
            string target = "Year:" + year;
            StreamReader sr = new StreamReader(path);
            string buff = sr.ReadToEnd();
            sr.Close();
            int begIndex = buff.IndexOf(target);
            int startIndex = buff.IndexOf("\\\n", begIndex) + 1;
            int endIndex = buff.IndexOf("--------") - 1;
            string res = buff.Substring(startIndex + 1, endIndex - startIndex);
            return res;
        }
    }
}
