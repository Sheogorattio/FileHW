using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchPoem
{
    public interface ISearch
    {
        string SearchByTitle(string title);
        string SearchByAuthor(string Author);
        string SearchByYear(string year);
    }
}
