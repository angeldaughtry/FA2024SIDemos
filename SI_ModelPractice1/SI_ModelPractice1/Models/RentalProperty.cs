using System.ComponentModel.DataAnnotations;

namespace SI_ModelPractice1.Models
{
    public class RentalProperty
    {
        // Create a unique identifier for the rental property
        [Display(Name = "Rental Property ID:")]
        public Int32 RentalPropertyID { get; set; }

        // Create a name for the rental property
        [Display(Name = "Property Name:")]
        public String RentalPropertyName { get; set; }

        // Create a property for the monthly rent with a validation to ensure the minimum value is 0
        [Display(Name = "Monthly Rent:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Range(0, Double.MaxValue, ErrorMessage = "Monthly rent must be at least 0.")]
        public Int32 MonthlyRent { get; set; }

        // Lease term in months
        [Display(Name = "Lease Term (Months):")]
        public Int32 LeaseTermInMonths { get; set; }

        // Calculate the security deposit to be 2 times the monthly rent
        [Display(Name = "Security Deposit:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal SecurityDeposit
        {
            get { return MonthlyRent * 2; }
        }

        // Method to calculate the total cost of the lease
        [Display(Name = "Total Lease Cost:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal TotalLeaseCost
        {
            get { return (MonthlyRent * LeaseTermInMonths) + SecurityDeposit; }
        }
    }
}
