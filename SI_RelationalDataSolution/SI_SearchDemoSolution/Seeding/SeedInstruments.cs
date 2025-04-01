using SI_SearchDemoSolution.DAL;
using SI_SearchDemoSolution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SI_SearchDemoSolution.Seeding
{
    public static class SeedInstruments
    {
        public static void SeedAllInstruments(AppDbContext db)
        {
            // check to see if all the genres have already been added
            if (db.Instruments.Count() == 25)
            {
                //exit the program - we don't need to do any of this
                NotSupportedException ex = new NotSupportedException("Instrument record count is already 25!");
                throw ex;
            }
            Int32 intInstrumentsAdded = 0; // for debugging purposes

            // Create a new list for all the instruments
            List<Instrument> AllInstruments = new List<Instrument>();

            AllInstruments.Add(new Instrument
            {
                Name = "Saxophone",
                InstrumentType = InstrumentType.Woodwind
            });

            AllInstruments.Add(new Instrument
            {
                Name = "Guitar",
                InstrumentType = InstrumentType.String
            });

            AllInstruments.Add(new Instrument
            {
                Name = "Piano",
                InstrumentType = InstrumentType.Keyboard
            });

            AllInstruments.Add(new Instrument
            {
                Name = "Trumpet",
                InstrumentType = InstrumentType.Brass
            });

            AllInstruments.Add(new Instrument
            {
                Name = "Violin",
                InstrumentType = InstrumentType.String
            });

            AllInstruments.Add(new Instrument
            {
                Name = "Flute",
                InstrumentType = InstrumentType.Woodwind
            });

            AllInstruments.Add(new Instrument
            {
                Name = "Drum Set",
                InstrumentType = InstrumentType.Percussion
            });

            AllInstruments.Add(new Instrument
            {
                Name = "Tuba",
                InstrumentType = InstrumentType.Brass
            });

            AllInstruments.Add(new Instrument
            {
                Name = "Synthesizer",
                InstrumentType = InstrumentType.Electronic
            });

            AllInstruments.Add(new Instrument
            {
                Name = "Marimba",
                InstrumentType = InstrumentType.Percussion
            });

            AllInstruments.Add(new Instrument
            {
                Name = "Clarinet",
                InstrumentType = InstrumentType.Woodwind
            });

            AllInstruments.Add(new Instrument
            {
                Name = "French Horn",
                InstrumentType = InstrumentType.Brass
            });

            AllInstruments.Add(new Instrument
            {
                Name = "Oboe",
                InstrumentType = InstrumentType.Woodwind
            });

            AllInstruments.Add(new Instrument
            {
                Name = "Cello",
                InstrumentType = InstrumentType.String
            });

            AllInstruments.Add(new Instrument
            {
                Name = "Bass Guitar",
                InstrumentType = InstrumentType.String
            });

            AllInstruments.Add(new Instrument
            {
                Name = "Harp",
                InstrumentType = InstrumentType.String
            });

            AllInstruments.Add(new Instrument
            {
                Name = "Trombone",
                InstrumentType = InstrumentType.Brass
            });

            AllInstruments.Add(new Instrument
            {
                Name = "Vibraphone",
                InstrumentType = InstrumentType.Percussion
            });

            AllInstruments.Add(new Instrument
            {
                Name = "Accordion",
                InstrumentType = InstrumentType.Keyboard
            });

            AllInstruments.Add(new Instrument
            {
                Name = "Bagpipes",
                InstrumentType = InstrumentType.Woodwind
            });

            AllInstruments.Add(new Instrument
            {
                Name = "Harmonica",
                InstrumentType = InstrumentType.Woodwind
            });

            AllInstruments.Add(new Instrument
            {
                Name = "Banjo",
                InstrumentType = InstrumentType.String
            });

            AllInstruments.Add(new Instrument
            {
                Name = "Electric Violin",
                InstrumentType = InstrumentType.Electronic
            });

            AllInstruments.Add(new Instrument
            {
                Name = "Bassoon",
                InstrumentType = InstrumentType.Woodwind
            });

            AllInstruments.Add(new Instrument
            {
                Name = "Triangle",
                InstrumentType = InstrumentType.Percussion
            });


            // Create some counters to help debug problems
            String strInstrumentName = "Start";

            // Loop through the list to add or update the instruments
            try
            {
                foreach (Instrument instrumentToAdd in AllInstruments)
                {
                    // Update the counter
                    strInstrumentName = instrumentToAdd.Name;

                    // Check if the instrument is already in the database
                    Instrument dbInstrument = db.Instruments.FirstOrDefault(i => i.Name == instrumentToAdd.Name);

                    // If instrument is null, it's not in the database
                    if (dbInstrument == null)
                    {
                        // Add the instrument to the database
                        db.Instruments.Add(instrumentToAdd);
                        db.SaveChanges();
                        intInstrumentsAdded += 1;
                      
                    }
                    else // If instrument exists, update fields
                    {
                        dbInstrument.Name = instrumentToAdd.Name;
                        dbInstrument.InstrumentType = instrumentToAdd.InstrumentType;
                        db.Update(dbInstrument);
                        db.SaveChanges();
                        intInstrumentsAdded += 1;
                    }
                }
            }
            catch (Exception ex) // Throw error if there is a problem in the database
            {
                StringBuilder msg = new StringBuilder();
                msg.Append("There was a problem adding the instrument with the name: ");
                msg.Append(strInstrumentName);
                throw new Exception(msg.ToString(), ex);
            }
        }
    }
}
