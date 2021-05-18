using PartialViewDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialViewDemo.Repositories
{
    public class HiltonRepo
    {
        private static Dictionary<int, Hilton> hilton = new Dictionary<int, Hilton>();
        static HiltonRepo()
        {
            hilton[1] = new Hilton { Id = 1, NickName = "Arizona", Value = 5000_000, YearBuilt = new DateTime(2001, 10, 23) };
            hilton[2] = new Hilton { Id = 2, NickName = "Bronx", Value = 6000_000, YearBuilt = new DateTime(1993, 09, 15) };
            hilton[3] = new Hilton { Id = 3, NickName = "Blue", Value = 3000_000, YearBuilt = new DateTime(2003, 03, 28) };
            hilton[4] = new Hilton { Id = 4, NickName = "NewYork", Value = 2000_000, YearBuilt = new DateTime(1987, 02, 03) };
            hilton[5] = new Hilton { Id = 5, NickName = "Texas", Value = 4000_000, YearBuilt = new DateTime(2010, 12, 09) };
        }

        public List<Hilton> Find()
        {
            return hilton.Values.ToList();
        }
    }
}
