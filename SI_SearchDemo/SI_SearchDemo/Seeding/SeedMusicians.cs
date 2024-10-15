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
            if (db.Musicians.Count() == 50)
            {
                throw new NotSupportedException("The database already contains all 50 musicians!");
            }

            //for debugging purposes
            Int32 intMusiciansAdded = 0;
            String strMusicianName = "Begin"; //helps to keep track of error on books

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
            AllMusicians.Add(new Musician
            {
                Name = "Lily Evans",
                Age = 25,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Saxophone")
            });

            AllMusicians.Add(new Musician
            {
                Name = "James Potter",
                Age = 30,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Guitar")
            });

            AllMusicians.Add(new Musician
            {
                Name = "Hermione Granger",
                Age = 28,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Piano")
            });

            AllMusicians.Add(new Musician
            {
                Name = "Harry Black",
                Age = 32,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Trumpet")
            });

            AllMusicians.Add(new Musician
            {
                Name = "Ginny Weasley",
                Age = 26,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Violin")
            });

            AllMusicians.Add(new Musician
            {
                Name = "Ron Weasley",
                Age = 29,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Flute")
            });

            AllMusicians.Add(new Musician
            {
                Name = "Tom Riddle",
                Age = 35,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Drum Set")
            });

            AllMusicians.Add(new Musician
            {
                Name = "Sirius Black",
                Age = 33,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Tuba")
            });

            AllMusicians.Add(new Musician
            {
                Name = "Remus Lupin",
                Age = 31,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Synthesizer")
            });

            AllMusicians.Add(new Musician
            {
                Name = "Severus Snape",
                Age = 34,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Marimba")
            });

            AllMusicians.Add(new Musician
            {
                Name = "Albus Dumbledore",
                Age = 40,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Clarinet")
            });

            AllMusicians.Add(new Musician
            {
                Name = "Minerva McGonagall",
                Age = 45,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "French Horn")
            });

            AllMusicians.Add(new Musician
            {
                Name = "Bellatrix Lestrange",
                Age = 36,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Oboe")
            });

            AllMusicians.Add(new Musician
            {
                Name = "Neville Longbottom",
                Age = 27,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Cello")
            });

            AllMusicians.Add(new Musician
            {
                Name = "Cho Chang",
                Age = 24,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Bass Guitar")
            });

            AllMusicians.Add(new Musician
            {
                Name = "Luna Lovegood",
                Age = 23,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Harp")
            });

            AllMusicians.Add(new Musician
            {
                Name = "Draco Malfoy",
                Age = 29,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Trombone")
            });

            AllMusicians.Add(new Musician
            {
                Name = "Fleur Delacour",
                Age = 27,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Vibraphone")
            });

            AllMusicians.Add(new Musician
            {
                Name = "Cedric Diggory",
                Age = 28,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Accordion")
            });

            AllMusicians.Add(new Musician
            {
                Name = "Arthur Weasley",
                Age = 41,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Bagpipes")
            });

            AllMusicians.Add(new Musician
            {
                Name = "Molly Weasley",
                Age = 39,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Harmonica")
            });

            AllMusicians.Add(new Musician
            {
                Name = "Fred Weasley",
                Age = 23,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Banjo")
            });

            AllMusicians.Add(new Musician
            {
                Name = "George Weasley",
                Age = 23,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Electric Violin")
            });

            AllMusicians.Add(new Musician
            {
                Name = "Viktor Krum",
                Age = 26,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Bassoon")
            });

            AllMusicians.Add(new Musician
            {
                Name = "Mad-Eye Moody",
                Age = 50,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Triangle")
            });

            AllMusicians.Add(new Musician
            {
                Name = "Nymphadora Tonks",
                Age = 28,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Saxophone")
            });

            AllMusicians.Add(new Musician
            {
                Name = "Kingsley Shacklebolt",
                Age = 38,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Guitar")
            });

            AllMusicians.Add(new Musician
            {
                Name = "Horace Slughorn",
                Age = 55,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Piano")
            });

            AllMusicians.Add(new Musician
            {
                Name = "Dolores Umbridge",
                Age = 45,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Trumpet")
            });

            AllMusicians.Add(new Musician
            {
                Name = "Lucius Malfoy",
                Age = 42,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Violin")
            });

            AllMusicians.Add(new Musician
            {
                Name = "Peter Pettigrew",
                Age = 37,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Flute")
            });

            AllMusicians.Add(new Musician
            {
                Name = "Cornelius Fudge",
                Age = 50,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Drum Set")
            });

            AllMusicians.Add(new Musician
            {
                Name = "Gilderoy Lockhart",
                Age = 48,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Tuba")
            });

            AllMusicians.Add(new Musician
            {
                Name = "Rita Skeeter",
                Age = 43,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Synthesizer")
            });

            AllMusicians.Add(new Musician
            {
                Name = "Percy Weasley",
                Age = 31,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Marimba")
            });

            AllMusicians.Add(new Musician
            {
                Name = "Charlie Weasley",
                Age = 36,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Clarinet")
            });

            AllMusicians.Add(new Musician
            {
                Name = "Bill Weasley",
                Age = 38,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "French Horn")
            });

            AllMusicians.Add(new Musician
            {
                Name = "Hagrid",
                Age = 52,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Oboe")
            });

            AllMusicians.Add(new Musician
            {
                Name = "Dobby",
                Age = 20,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Cello")
            });

            AllMusicians.Add(new Musician
            {
                Name = "Kreacher",
                Age = 40,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Bass Guitar")
            });

            AllMusicians.Add(new Musician
            {
                Name = "Firenze",
                Age = 35,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Harp")
            });

            AllMusicians.Add(new Musician
            {
                Name = "Griphook",
                Age = 29,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Trombone")
            });

            AllMusicians.Add(new Musician
            {
                Name = "Barty Crouch Jr.",
                Age = 33,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Vibraphone")
            });

            AllMusicians.Add(new Musician
            {
                Name = "Igor Karkaroff",
                Age = 42,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Accordion")
            });

            AllMusicians.Add(new Musician
            {
                Name = "Fenrir Greyback",
                Age = 47,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Bagpipes")
            });

            AllMusicians.Add(new Musician
            {
                Name = "Aberforth Dumbledore",
                Age = 55,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Harmonica")
            });

            AllMusicians.Add(new Musician
            {
                Name = "Xenophilius Lovegood",
                Age = 50,
                Instrument = db.Instruments.FirstOrDefault(i => i.Name == "Banjo")
            });

            // Loop through the list to add or update the musicians
            try
            {
                foreach (Musician musicianToAdd in AllMusicians)
                {
                    // Track the individual musician entry
                    strMusicianName = musicianToAdd.Name;

                    // Check if the musician is already in the database
                    Musician dbMusician = db.Musicians.FirstOrDefault(m => m.Name == musicianToAdd.Name);

                    // If musician is null, they're not in the database
                    if (dbMusician == null)
                    {
                        // Add the musician to the database
                        db.Musicians.Add(musicianToAdd);
                        db.SaveChanges();
                        intMusiciansAdded += 1;
                    }
                    else // If musician exists, update fields
                    {
                        dbMusician.Name = musicianToAdd.Name;
                        dbMusician.Age = musicianToAdd.Age;
                        dbMusician.Instrument = musicianToAdd.Instrument;
                        db.Update(dbMusician);
                        db.SaveChanges();
                        intMusiciansAdded += 1;
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
