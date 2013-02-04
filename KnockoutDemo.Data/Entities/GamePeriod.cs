using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnockoutDemo.Data.Entities
{
    public class GamePeriod
    {
        public Guid Id { get; set; }
        public string Period { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
    }
}
