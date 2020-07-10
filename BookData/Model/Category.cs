using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core.Metadata.Edm;

namespace BookData.Model
{ 
    
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public enum Categories
        {
            
            Action,
            Adventure,
            Classics,
            ComicBook,
            Detective,
            Mystery,
            Fantasy,
            HistoricalFiction,
            Horror,
            LiteraryFiction,
            Romance,
            ScienceFiction,
            ShortStories,
            Thrillers
        }

    }
}