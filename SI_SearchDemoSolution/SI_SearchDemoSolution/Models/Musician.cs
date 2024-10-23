using System;
using System.ComponentModel.DataAnnotations;

namespace SI_SearchDemoSolution.Models
{
	public class Musician
	{
        public Int32 MusicianId { get; set; }

        [Display(Name = "Musician Name")]
        public String Name { get; set; }

        [Display(Name = "Musician Age")]
        public Int32 Age { get; set; }

        // Navigation property to the associated Instrument
        public Instrument Instrument { get; set; }
    }
}

