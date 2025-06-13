using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;

namespace CHHA_PlanOfCorrectinAudit.Models {
    [Table("CHHA_Quality_POC_Metadata")]
    public class CHHA_Quality_POC_Metadata {
        [Key]
        public int Id { get; set; }  // usually keep PK non-nullable
        public string? Patient_MRN { get; set; }
        public string? Patient_Name { get; set; }
        public string? Patient_Status { get; set; }
        public string? Program { get; set; }
        public string? Borough_of_Care { get; set; }
        public DateOnly? Start_of_Care_Date { get; set; }
        public string? Financial_Class { get; set; }
        public string? Payer { get; set; }
        public string? Category { get; set; }
        public string? Assigned_Reviewer { get; set; }
        public DateOnly? Date_Assigned { get; set; }
        public string? Form { get; set; }
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


