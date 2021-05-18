using PartialViewDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialViewDemo.Repositories
{
    public class HQRepo
    {
        public HQ Read()
        {

            return new HQ 
            { 
            Street ="BrusselsAvenue", Number="3",Zip="3080", State="New york"
            };
        }
    }
}
