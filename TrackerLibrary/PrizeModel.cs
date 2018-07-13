using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Teams place standing
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Team PlaceName in standing
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Prize amount for the winner
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Prize percentage for winning team
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
