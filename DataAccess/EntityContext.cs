using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace DataAccess
{
    public class EntityContext : DbContext
    {
        public EntityContext() : base("name=DbConnectionString") { }

        public DbSet<PartModel> Parts { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }
    }
}
