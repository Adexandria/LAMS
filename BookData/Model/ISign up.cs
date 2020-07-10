using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookData.Model
{
   public interface ISign_up
    {
        Signup Add(Signup signup);
        int Commit();
        Signup GetAll(string username);
        Signup UserSearch(string username, string password);
    }
}
