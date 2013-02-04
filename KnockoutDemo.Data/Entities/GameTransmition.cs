using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnockoutDemo.Data.Entities
{
    public class GameTransmition
    {
        public Guid Id { get; set; }
        public IEnumerable<GamePeriod> Periods { get; set; }
        public GameScore Score { get; set; }
        public IEnumerable<GameComment> Comments { get; set; }
    }
}
