using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CHHA_PlanOfCorrectinAudit.Models {
    public class CHHA_Quality_POC_Responses {
        [Key]
        public int ResponseId { get; set; }
        public string Patient_MRN { get; set; }
        public DateOnly? Date_Assigned { get; set; }
        public string Question { get; set; }
        public string Response { get; set; }
        public string Form { get; set; }
        public string? Key { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string? LastUpdatedBy { get; set; }
        public Guid RecordId { get; set; } // Unique identifier for this version
        public Guid OriginalRecordId { get; set; } // Identifier shared across all versions of the same logical record
        public bool IsCurrentVersion { get; set; } // True only for the latest version
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }

        // Foreign key and navigation property

        public int MetadataId { get; set; }
        [ForeignKey(nameof(MetadataId))]
        public CHHA_Quality_POC_Metadata Metadata { get; set; }
    }
}
