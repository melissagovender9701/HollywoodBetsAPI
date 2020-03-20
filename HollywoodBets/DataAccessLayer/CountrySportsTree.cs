using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HollywoodBets.DataAccessLayer
{
    public class CountrySportsTree
    {
        public int sportsId { get; set; }
        public int countryId { get; set; }

        public CountrySportsTree(int sportsid, int countryid)
        {
            sportsId = sportsid;
            countryId = countryid;
        }
    }
}
