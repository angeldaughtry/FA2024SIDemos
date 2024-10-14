using System;
using System.ComponentModel.DataAnnotations;

namespace SI_SearchDemo.Models
{
    public enum InstrumentType { Brass, Woodwind, Percussion, String, Keyboard, Electronic}

    public class Instrument
	{
        public Int32 InstrumentId { get; set; }

        [Display(Name = "Instrument Name")]
        public String Name { get; set; }

        [Display(Name = "Instrument Type")]
        public InstrumentType InstrumentType { get; set; } // E.g., "Brass", "String", etc.

        // Navigational property for instruments - a single instrument will be associated with many musicians
        public List<Musician> Musicians { get; set; }

        // Constructor to initialize the list
        public Instrument()
        {
            Musicians ??= new List<Musician>();
        }
    }
}

