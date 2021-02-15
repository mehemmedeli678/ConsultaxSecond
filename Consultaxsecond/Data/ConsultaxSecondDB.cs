using Consultaxsecond.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consultaxsecond.Data
{
    public class ConsultaxSecondDB: DbContext
    {
        public ConsultaxSecondDB(DbContextOptions<ConsultaxSecondDB> options) : base(options)
        {
        }

        public DbSet<Blog> Product { get; set; }
        public DbSet<Categories> Users { get; set; }
        public DbSet<CustomerReguest> CustomerReguest { get; set; }
        public DbSet<OurProjekts> OurProjekts { get; set; }
        public DbSet<Section1> Section1 { get; set; }
        public DbSet<Section2> Section2 { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<WhoWeAre> WhoWeAre { get; set; }
    }
}


