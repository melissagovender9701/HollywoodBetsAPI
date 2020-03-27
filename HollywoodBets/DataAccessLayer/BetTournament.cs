using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HollywoodBets.DataAccessLayer
{
    public class BetTournament
    {
        public int TournamentID { get; set; }
        public List<int> BetTypeID { get; set; }

        public BetTournament()
        {

        }

        public BetTournament(int tournamentid, List<int> bettypeid)
        {
            TournamentID = tournamentid;
            BetTypeID = bettypeid;
        }
    }
}
