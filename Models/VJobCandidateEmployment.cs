using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PruebaPracticaGB.Models
{
    public partial class VJobCandidateEmployment
    {
        public int JobCandidateId { get; set; }
        public DateTime? EmpStartDate { get; set; }
        public DateTime? EmpEndDate { get; set; }
        public string EmpOrgName { get; set; }
        public string EmpJobTitle { get; set; }
        public string EmpResponsibility { get; set; }
        public string EmpFunctionCategory { get; set; }
        public string EmpIndustryCategory { get; set; }
        public string EmpLocCountryRegion { get; set; }
        public string EmpLocState { get; set; }
        public string EmpLocCity { get; set; }
    }
}
