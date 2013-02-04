using System.Data.Entity;
using KnockoutDemo.Data.Entities;

namespace KnockoutDemo.Data
{
    public class EntityContext : DbContext
    {
        public EntityContext()
            : base("EntitiesConnection")
        {
        }

        public DbSet<GameTransmition> GameTransmitions { get; set; }
    }
}
