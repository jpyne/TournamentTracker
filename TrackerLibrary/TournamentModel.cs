using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// Name of the Trounamnet
        /// </summary>
        public string TournamentName { get; set; }
        
        /// <summary>
        /// Entry fee pet team 
        /// </summary>
        public decimal EntryFee { get; set; }
        
        /// <summary>
        /// Teams that are participating in the Tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// Prizes in the Trounamnet for winners and runners etc
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Rounds in the Tournament
        /// </summary>
        public List<MatchupModel> Rounds { get; set; } = new List<MatchupModel>();

    }
}
