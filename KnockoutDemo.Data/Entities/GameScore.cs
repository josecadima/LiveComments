using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnockoutDemo.Data.Entities
{
    public class GameScore
    {
        public Guid Id { get; set; }

        public string TeamName1 { get; set; }
        public string TeamName2 { get; set; }

        public string TeamScore1 { get; set; }
        public string TeamScore2 { get; set; }
    }
}
