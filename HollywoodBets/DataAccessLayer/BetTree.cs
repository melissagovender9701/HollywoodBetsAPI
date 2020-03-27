using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HollywoodBets.DataAccessLayer
{
    public class BetTree
    {
        public int BetTypeId { get; set; }
        public string BetTypeName { get; set; }

        public BetTree(int bettypeid,string bettypename)
        {
            BetTypeId = bettypeid;
            BetTypeName = bettypename;
        }
        public BetTree()
        {

        }
    }
}
