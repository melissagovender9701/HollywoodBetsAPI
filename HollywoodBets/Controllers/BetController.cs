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
    public class BetController : ControllerBase
    {
        //https://localhost:44394/api/bet?tournamentid=1
        [HttpGet]
        public IEnumerable<BetTree> Get(int? tournamentid)
        {
            return GetBetByTournament(tournamentid).ToArray();
        }

        private List<BetTree> GetBetByTournament(int? tournamentid)
        {
            return DataLogic.GetBetsByTournament(tournamentid);
        }
    }
}