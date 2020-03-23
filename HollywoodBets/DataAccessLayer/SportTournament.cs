﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HollywoodBets.DataAccessLayer
{
    public class SportTournament
    {
        public int SportId { get; set; }
        public int TournamentId { get; set; }
        public int CountryId { get; set; }

        public SportTournament(int sportId, int tournamentId, int countryId)
        {
            SportId = sportId;
            TournamentId = tournamentId;
            CountryId = countryId;
        }
    }
}
