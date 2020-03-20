using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HollywoodBets.Models
{
    public class SportsTree
    {
        public int id { get; set; }
        public string name { get; set; }
        public string image { get; set; }

        public SportsTree(int sportsId, string sportsName, string logo)
        {
            id = sportsId;
            name = sportsName;
            image = logo;
        }
    }
}
