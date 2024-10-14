using SI_SearchDemo.DAL;
using SI_SearchDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SI_SearchDemo.Seeding
{
    public static class SeedMusicians
    {
        public static void SeedAllMusicians(AppDbContext db)
        {
            // Create a new list for all of the musicians
            List<Musician> AllMusicians = new List<Musician>();

            AllMusicians.Add(new Musician
            {
                Name = "John Doe",
                Age = 30,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Saxophone")
            });

            AllMusicians.Add(new Musician
            {
                Name = "Jane Smith",
                Age = 25,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Guitar")
            });

            AllMusicians.Add(new Musician
            {
                Name = "Alex Brown",
                Age = 28,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Piano")
            });

            // Create some counters to help debug problems
            String strMusicianName = "Start";

            // Loop through the list to add or update the musicians
            try
            {
                foreach (Musician seedMusician in AllMusicians)
                {
                    // Update the counter
                    strMusicianName = seedMusician.Name;

                    // Check if the musician is already in the database
                    Musician dbMusician = db.Musicians.FirstOrDefault(m => m.Name == seedMusician.Name);

                    // If musician is null, they're not in the database
                    if (dbMusician == null)
                    {
                        // Add the musician to the database
                        db.Musicians.Add(seedMusician);
                        db.SaveChanges();
                    }
                    else // If musician exists, update fields
                    {
                        dbMusician.Age = seedMusician.Age;
                        dbMusician.Instrument = seedMusician.Instrument;
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex) // Throw error if there is a problem in the database
            {
                StringBuilder msg = new StringBuilder();
                msg.Append("There was a problem adding the musician with the name: ");
                msg.Append(strMusicianName);
                throw new Exception(msg.ToString(), ex);
            }
        }
    }
}
