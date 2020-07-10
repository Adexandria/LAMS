using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookData.Model
{
 public  interface ILogin
    {
        public Details GetDetails(string admin,string password);
    }
}
