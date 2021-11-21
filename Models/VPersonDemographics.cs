using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PruebaPracticaGB.Models
{
    public partial class VPersonDemographics
    {
        public int BusinessEntityId { get; set; }
        public decimal? TotalPurchaseYtd { get; set; }
        public DateTime? DateFirstPurchase { get; set; }
        public DateTime? BirthDate { get; set; }
        public string MaritalStatus { get; set; }
        public string YearlyIncome { get; set; }
        public string Gender { get; set; }
        public int? TotalChildren { get; set; }
        public int? NumberChildrenAtHome { get; set; }
        public string Education { get; set; }
        public string Occupation { get; set; }
        public bool? HomeOwnerFlag { get; set; }
        public int? NumberCarsOwned { get; set; }
    }
}
