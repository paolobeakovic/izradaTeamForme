using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Predstavlja jedan tim u matchupu
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Predstavlja podove za jedan tim
        /// </summary>
        public double Score { get; set; }
        public MatchupModel ParentMatchup { get; set; }
    }
}
