using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HollywoodBets.Business_Logic_Layer;
using HollywoodBets.DataAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HollywoodBets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        //https://localhost:44394/api/event?tournamentId=1
        [HttpGet]
        public IEnumerable<EventTree> Get(int? tournamentId)
        {
            return GetTournamentEVent(tournamentId).ToArray();
        }
        public List<EventTree> GetTournamentEVent(int? tournamentId)
        {
            return DataLogic.GetEvents().FindAll(x => x.TournamentId == tournamentId);
        }
    }
}