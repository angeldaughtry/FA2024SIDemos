using System;
using System.ComponentModel.DataAnnotations;

namespace SI_ModelPractice1Solution.Models
{
    public class RentalProperty
    {
        [Display(Name = "Rental Property ID")]
        public Int32 RentalPropertyID { get; set; }

        [Display(Name = "Property Name:")]
        public String RentalPropertyName { get; set; }

        [Display(Name = "Monthly Rent:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Range(0, Int32.MaxValue, ErrorMessage = "Monthly rent must be at least 0.")]
        public Int32 MonthlyRent { get; set; }

        [Display(Name = "Lease Term (Months):")]
        public Int32 LeaseTermInMonths { get; set; }

        //------calculated properties below-----

        //option 1: auto-implemented property
        [Display(Name = "Total Lease Cost")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Int32 TotalLeaseCost { get; set; }


        //option 1: associated method
        public void calcTotalLeaseCost()
        {
            TotalLeaseCost = (MonthlyRent * LeaseTermInMonths) + SecurityDeposit;
        }

        //option 2: property block
        [Display(Name = "Security Deposit:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Int32 SecurityDeposit
        {
            get { return MonthlyRent * 2; }
        }

    }
}

