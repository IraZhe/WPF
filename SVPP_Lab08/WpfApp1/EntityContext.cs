using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Models;

namespace WpfApp1
{
    public class EntityContext : DbContext
    {
        public EntityContext():base("DefaultConnection")
        {
            Database.SetInitializer(new DataBaseInitializer());
        }
        public DbSet<Student> Students { get; set; }
    }
}
