using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HollywoodBets.DataAccessLayer
{
    public class CountryTree
    {
        public int id { get; set; }
        public string countryName { get; set; }
        public string countryFlag { get; set; }

        public CountryTree(int countryid, string countryname, string countryflag)
        {
            id = countryid;
            countryName = countryname;
            countryFlag = countryflag;
        }
        public CountryTree()
        {

        }
    }
}
