using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookData.Model
{
    public interface IBook
    {
        Books Add(Books books);
        int Commit();
    }
}
