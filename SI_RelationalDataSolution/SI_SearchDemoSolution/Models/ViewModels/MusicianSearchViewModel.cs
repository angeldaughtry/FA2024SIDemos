using System;
using System.ComponentModel.DataAnnotations;

namespace SI_SearchDemoSolution.Models
{
    public enum AgeRange { GreaterThan, LessThan}
	public class MusicianSearchViewModel
	{
        // textbox
        [Display(Name = "Search by Name")]
        public String? SelectedName { get; set; }

        [Display(Name = "Type of Search: ")]
        public AgeRange SelectedAgeRange { get; set; }

        // numeric input
        [Range(minimum: 0, maximum: 120, ErrorMessage = "Age must be at least 1.")]
        [Display(Name = "Search by Age")]
        public Int32? SelectedAge { get; set; }

        // dropdown
        [Display(Name = "Search by Instrument:")]
        public Int32? SelectedInstrumentId { get; set; }

    }
}

