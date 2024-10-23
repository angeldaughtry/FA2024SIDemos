using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

using SI_SearchDemoSolution.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace SI_SearchDemoSolution.DAL
{
    //NOTE: This class definition references the user class for this project.  
    //If your User class is called something other than AppUser, you will need
    //to change it in the line below
    public class AppDbContext: IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){ }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //this code makes sure the database is re-created on the $5/month Azure tier
            builder.HasPerformanceLevel("Basic");
            builder.HasServiceTier("Basic");
            base.OnModelCreating(builder);
        }

        //TODO: Add Dbsets here.  Products is included as an example.  
        public DbSet<Musician> Musicians { get; set; }
        public DbSet<Instrument> Instruments { get; set; }
    }
}
