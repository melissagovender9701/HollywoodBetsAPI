using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HollywoodBets.DataAccessLayer
{
    public class EventTournament
    {
        public int tournamentId { get; set; }
        public int eventId { get; set; }

        public EventTournament(int tournamentid, int eventid)
        {
            tournamentId = tournamentId;
            eventId = eventid;
        }
    }
}
