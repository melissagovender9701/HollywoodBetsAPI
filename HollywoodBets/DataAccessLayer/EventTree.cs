using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace HollywoodBets.DataAccessLayer
{
    public class EventTree
    {
        public int TournamentId { get; set; }
        public int EventID { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public EventTree(int tournamentId, int eventId,string eventName,DateTime eventDate)
        {
            TournamentId = tournamentId;
            EventID = eventId;
            EventName = eventName;
            EventDate = eventDate;
        }
        public EventTree()
        {

        }
    }
   
}
