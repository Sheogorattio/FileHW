using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public interface IAddDeletePoem
    {
        void Delete(string title);
        void Add(string title, string author, int year, string poem);
        void Clear();
    }
}
