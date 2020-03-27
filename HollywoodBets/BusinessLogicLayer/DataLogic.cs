using HollywoodBets.DataAccessLayer;
using HollywoodBets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HollywoodBets.Business_Logic_Layer
{
    public class DataLogic
    {
        public static List<SportsTree> SportsList { get; set; }
        public static List<CountryTree> CounrtyList { get; set; }
        public static List<CountrySportsTree> CountrySportsList { get; set; }
        public static List<EventTree> EventList { get; set; }
        public static List<BetTree> BetList { get; set; }
        public static List<BetTournament> BetTournamentList { get; set; }
        public DataLogic()
        {
            this.Sports();
            this.Countries();
            CountrySports();
        }

        public List<SportsTree> Sports()
        {
            SportsList = new List<SportsTree>
            {
                new SportsTree(1, "Betgames Africa", "https://new.hollywoodbets.net/assets/images/icons/Betgames.svg"),
                new SportsTree(2, "Live In-Play","https://new.hollywoodbets.net/assets/images/icons/live-in-play.svg"),
                new SportsTree(3, "Sport Exotics","https://new.hollywoodbets.net/assets/images/icons/sport-exotics.svg"),
                new SportsTree(4, "Horse Racing","https://new.hollywoodbets.net/assets/images/icons/horse-racing.svg"),
                new SportsTree(5, "Soccer","https://new.hollywoodbets.net/assets/images/icons/soccer.svg"),
                new SportsTree(6, "Lucky Numbers","https://new.hollywoodbets.net/assets/images/icons/lucky-numbers.svg"),
                new SportsTree(7, "Tennis","https://new.hollywoodbets.net/assets/images/icons/tennis.svg"),
                new SportsTree(8, "Rugby","https://new.hollywoodbets.net/assets/images/icons/rugby.svg"),
                new SportsTree(9, "Cricket","https://new.hollywoodbets.net/assets/images/icons/cricket.svg"),
                new SportsTree(10, "Golf","https://new.hollywoodbets.net/assets/images/icons/golf.svg"),
                new SportsTree(11, "American Football","https://new.hollywoodbets.net/assets/images/icons/american-football.svg"),
                new SportsTree(12, "Aussie Rules","https://new.hollywoodbets.net/assets/images/icons/aussie-rules.svg"),
                new SportsTree(13, "Badminton","https://new.hollywoodbets.net/assets/images/icons/badminton.svg"),
                new SportsTree(14, "Bandy","https://new.hollywoodbets.net/assets/images/icons/bandy.svg"),
                new SportsTree(15, "Baseball","https://new.hollywoodbets.net/assets/images/icons/baseball.svg"),
                new SportsTree(16, "Basketball","https://new.hollywoodbets.net/assets/images/icons/basketball.svg"),
                new SportsTree(17, "Boxing","https://new.hollywoodbets.net/assets/images/icons/boxing.svg"),
                new SportsTree(18, "Cycling","https://new.hollywoodbets.net/assets/images/icons/cycling.svg"),
                new SportsTree(19, "Darts","https://new.hollywoodbets.net/assets/images/icons/darts.svg"),
                new SportsTree(20, "Floorball","https://new.hollywoodbets.net/assets/images/icons/floorball.svg"),
                new SportsTree(21, "Futsal","https://new.hollywoodbets.net/assets/images/icons/futsal.svg"),
                new SportsTree(22, "Handball","https://new.hollywoodbets.net/assets/images/icons/handball.svg"),
                new SportsTree(23, "Ice Hockey","https://new.hollywoodbets.net/assets/images/icons/ice-hockey.svg"),
                new SportsTree(24, "MMA","https://new.hollywoodbets.net/assets/images/icons/mma.svg"),
                new SportsTree(25, "Motorsport","https://new.hollywoodbets.net/assets/images/icons/motorsport.svg"),
                new SportsTree(26, "Netball","https://new.hollywoodbets.net/assets/images/icons/soccer.svg"),
                new SportsTree(27, "Snooker","https://new.hollywoodbets.net/assets/images/icons/snooker.svg"),
                new SportsTree(28, "Squash","https://new.hollywoodbets.net/assets/images/icons/snooker.svg"),
                new SportsTree(29, "Volleyball","https://new.hollywoodbets.net/assets/images/icons/volleyball.svg")
            };
            return SportsList;
        }

        public List<CountryTree> Countries()
        {
            CounrtyList = new List<CountryTree>
            {
             new CountryTree(1, "Afghanistan", "https://cdn.countryflags.com/thumbs/afghanistan/flag-400.png"),
             new CountryTree(2, "Albania", "https://cdn.countryflags.com/thumbs/albania/flag-400.png"),
             new CountryTree(3, "Algeria", "https://cdn.countryflags.com/thumbs/algeria/flag-400.png"),
             new CountryTree(5, "Andorra", "https://cdn.countryflags.com/thumbs/andorra/flag-400.png"),
             new CountryTree(6, "Angola", "https://cdn.countryflags.com/thumbs/angola/flag-400.png"),
             new CountryTree(7, "Antigua and Barbuda", "https://cdn.countryflags.com/thumbs/antigua-and-barbuda/flag-400.png"),
             new CountryTree(8, "Argentina", "https://cdn.countryflags.com/thumbs/argentina/flag-400.png"),
             new CountryTree(9, "Armenia", "https://cdn.countryflags.com/thumbs/armenia/flag-400.png"),
             new CountryTree(10, "Australia", "https://cdn.countryflags.com/thumbs/australia/flag-400.png"),
             new CountryTree(11, "Austria", "https://cdn.countryflags.com/thumbs/austria/flag-400.png"),
             new CountryTree(12, "Azerbaijan", "https://cdn.countryflags.com/thumbs/azerbaijan/flag-400.png"),
             new CountryTree(13, "Bahamas", "https://cdn.countryflags.com/thumbs/bahamas/flag-400.png"),
             new CountryTree(14, "Bahrain", "https://cdn.countryflags.com/thumbs/bahrain/flag-400.png")
            };
            return CounrtyList;
        }

        public static List<CountrySportsTree> CountrySports()
        {
            CountrySportsList = new List<CountrySportsTree>
            {
                new CountrySportsTree(5, 1),
                new CountrySportsTree(5, 2),
                new CountrySportsTree(5, 3),
            };
            return CountrySportsList;
        }

        public static CountryTree GetCountryByID(long id)
        {
            for (int i = 0; i < DataLogic.CounrtyList.Count; i++)
            {
                if (CounrtyList[i].id == id)
                {
                    return CounrtyList[i];
                }
            }
            return new CountryTree();
        }

        public static List<Tournament> GetAllTournament()
        {
            return new List<Tournament>
            {
                new Tournament(1,"Copa del Rey"),
                new Tournament(2,"DFB Pokal"),
                new Tournament(3,"A-League"),
                new Tournament(4,"Campeonato Potiguar"),
                new Tournament(5,"Veikkausliiga"),
                new Tournament(6,"Allsvenskan")
            };
        }

        public static List<SportTournament> GetSportTournaments()
        {
            return new List<SportTournament>
            {
                new SportTournament(5,1,1),
                new SportTournament(5,2,2),
                new SportTournament(5,4,4),
                new SportTournament(5,6,1)
            };
        }

        public static List<EventTree> GetEvents()
        {
            EventList = new List<EventTree>
            {
                new EventTree(1, 1, "ATL BILBAO vs SOCIEDAD", new DateTime(2020, 3, 26, 10, 30,0)),
                new EventTree(1, 2, "MELBOURNE CITY FC vs ADELAIDE", new DateTime(2020, 3, 26, 10, 40,0)),
                new EventTree(2, 3,"BLUE BULLS vs SHARKS",  new DateTime(2020, 3, 26, 10, 40,0))
            };
            return EventList;
        }
        public static List<BetTree> GetBetTypes()
        {
            BetList = new List<BetTree>
            {
                new BetTree(1,"Full Time"),
                new BetTree(2,"Double Chance"),
                new BetTree(3,"Both Teams to Score"),
                new BetTree(4,"Double Chance and Both Teams Score"),
                new BetTree(5,"Additional Totals"),
                new BetTree(6,"First 10 mins"),
                new BetTree(7,"Totals"),
                new BetTree(8,"Half Time"),
                new BetTree(9,"Matchbet & Both Team to Score"),
                new BetTree(10,"Double Chance and Total"),
                new BetTree(11,"Half Time/Full Time"),
                new BetTree(12,"Handicap")
            };
            return BetList;
        }

        public static List<BetTournament> GetBetTournaments()
        {
            BetTournamentList =  new List<BetTournament>
            {
                new BetTournament(1,new List<int>{1,2,3}),
                new BetTournament(2,new List<int>{1,2,3,4}),
                new BetTournament(3,new List<int>{1,2,3,4,5})
            };
            return BetTournamentList;
        }

        public static List<BetTree> GetBetsByTournament(int? tournamentid)
        {
            BetTournament bet = GetBetTournaments().Find(x => x.TournamentID == tournamentid);
            List<BetTree> betTypes = new List<BetTree>();
            if (bet != null)
            {
                for (int i = 0; i < bet.BetTypeID.Count; i++)
                {
                    betTypes.Add(GetBetTypes().Find(y => y.BetTypeId == bet.BetTypeID[i]));
                }
            }
            return betTypes;
        }
    }
   
}
