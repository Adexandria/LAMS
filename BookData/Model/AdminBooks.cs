using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookData.Model
{
    public class AdminBooks : IBook
    {
        private readonly AppDbcontext db;
        public AdminBooks(AppDbcontext db)
        {
            this.db = db;
        }
        public Books Add(Books books)
        {
            db.Books.Add(books);
            return books;
        }

        public int Commit()
        {
           return db.SaveChanges();
        }
    }
}
