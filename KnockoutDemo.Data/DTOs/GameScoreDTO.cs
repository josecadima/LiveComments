using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnockoutDemo.Data.DTOs
{
    public class GameScoreDTO
    {
        public string TeamName1 { get; set; }
        public int TeamScore1 { get; set; }
        
        public string TeamName2 { get; set; }
        public int TeamScore2 { get; set; }

        public DateTime Date { get; set; }
        public string Status { get; set; }
    }
}
