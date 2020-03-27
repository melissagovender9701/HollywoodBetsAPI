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
    public class TournamentController : Controller
    {
        //https://localhost:44394/api/tournament?sportId=5&countryId=2
        [HttpGet]
        public IEnumerable<Tournament> Get(int? id, int? countryId)
        {
            return GetTournaments(id, countryId);

        }
        public static IEnumerable<Tournament> GetTournaments(int? id, int? countryId)
        {
            var SportAndCountryTournaments = DataLogic.GetSportTournaments().Where(x => x.CountryId == countryId && x.SportId == id);
            var countriesTournament = from tournament in DataLogic.GetAllTournament()
                                      where SportAndCountryTournaments.Any(events => events.TournamentId == tournament.TournamentId)
                                      select tournament;
            return countriesTournament;
        }
    }
}