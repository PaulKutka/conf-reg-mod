using ConfReg.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfReg.DataAcess
{
    public class ConfRegDb : DbContext
    {
        public ConfRegDb() : base("name=ConfRegDb")
        {

        }

        public DbSet<Participants> Participants { get; set; }
    }
}
