using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookData.Model
{
    public class AdminRepository :ILogin
    {
        private AppDbcontext db;
        public AdminRepository(AppDbcontext db)
        {

            this.db = db;

           
        }

        public Details GetDetails(string admin,string password)
        {
           
                return db.Details.Where(a=>a.UserName==admin && a.Password==password).FirstOrDefault();
            
        }

    }
}
