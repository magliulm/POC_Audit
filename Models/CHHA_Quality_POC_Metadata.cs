using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;

namespace CHHA_PlanOfCorrectinAudit.Models {
    [Table("CHHA_Quality_POC_Metadata")]
    public class CHHA_Quality_POC_Metadata {
        [Key]
        public int Id { get; set; }  // usually keep PK non-nullable

        [Required(ErrorMessage = "Patient MRN is required.")]
        public string Patient_MRN { get; set; } = null!;

        [Required(ErrorMessage = "Patient Name is required.")]
        public string Patient_Name { get; set; } = null!;

        [Required(ErrorMessage = "Patient Status is required.")]
        public string Patient_Status { get; set; } = null!;

        [Required(ErrorMessage = "Program is required.")]
        public string Program { get; set; } = null!;

        [Required(ErrorMessage = "Borough of Care is required.")]
        public string Borough_of_Care { get; set; } = null!;

        [Required(ErrorMessage = "Start of Care Date is required.")]
        public DateOnly? Start_of_Care_Date { get; set; }

        [Required(ErrorMessage = "Financial Class is required.")]
        public string Financial_Class { get; set; } = null!;

        [Required(ErrorMessage = "Payer is required.")]
        public string Payer { get; set; } = null!;

        [Required(ErrorMessage = "Category is required.")]
        public string Category { get; set; } = null!;

        [Required(ErrorMessage = "Assigned Reviewer is required.")]
        public string Assigned_Reviewer { get; set; } = null!;

        [Required(ErrorMessage = "Date Assigned is required.")]
        public DateOnly Date_Assigned { get; set; }

        [Required(ErrorMessage = "Form is required.")]
        public string Form { get; set; } = null!;

        public string? Key { get; set; }

        public DateTime? LastUpdated { get; set; }
        public string? LastUpdatedBy { get; set; }

        public Guid RecordId { get; set; } // Unique identifier for this version
        public Guid OriginalRecordId { get; set; } // Identifier shared across all versions of the same logical record
        public bool IsCurrentVersion { get; set; } // True only for the latest version

        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }

        public string RecordStatus { get; set; } = "Draft";

        // Navigation property
        public ICollection<CHHA_Quality_POC_Responses>? Responses { get; set; } = new List<CHHA_Quality_POC_Responses>();
    }
}
