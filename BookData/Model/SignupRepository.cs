﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookData.Model
{
    public class SignupRepository : ISign_up
    {
        private readonly AppDbcontext db;
        public SignupRepository(AppDbcontext db)
        {
            this.db = db;
        }
        public Signup Add(Signup signup)
        {
           
             db.Signups.Add(signup);
            return signup;

        }

        public int Commit()
        {
            return db.SaveChanges();
        }

        public string GetAll(string username)
        {
            var query = db.Signups.Where(a=>a.UserName==username).FirstOrDefault();
          var pass = Encryption.DecodeFrom64(query.Password);
            return pass;
        }

       

        public Signup UserSearch(string username, string password)
        {
            return db.Signups.Where(p => p.UserName == username && p.Password == password ).FirstOrDefault();
        }
    }
}
