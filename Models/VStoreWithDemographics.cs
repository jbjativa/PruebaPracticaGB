using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PruebaPracticaGB.Models
{
    public partial class VStoreWithDemographics
    {
        public int BusinessEntityId { get; set; }
        public string Name { get; set; }
        public decimal? AnnualSales { get; set; }
        public decimal? AnnualRevenue { get; set; }
        public string BankName { get; set; }
        public string BusinessType { get; set; }
        public int? YearOpened { get; set; }
        public string Specialty { get; set; }
        public int? SquareFeet { get; set; }
        public string Brands { get; set; }
        public string Internet { get; set; }
        public int? NumberEmployees { get; set; }
    }
}
