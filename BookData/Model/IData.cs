using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookData.Model
{
   public interface IData
    {
        IEnumerable<Details> GetDetails { get; }
        Details Add(Details Users);
        int Commit();
    }
}
