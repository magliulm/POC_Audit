using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CHHA_PlanOfCorrectinAudit.Models {
    public class CHHA_Quality_POC_Responses {
        [Key]
        public int ResponseId { get; set; }

        [Required(ErrorMessage = "Patient MRN is required.")]
        public string Patient_MRN { get; set; } = null!;

        [Required(ErrorMessage = "Date Assigned is required.")]
        public DateOnly? Date_Assigned { get; set; }

        [Required(ErrorMessage = "Question is required.")]
        public string Question { get; set; } = null!;

        public string? Response { get; set; } // This can be nullable if responses can be empty

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

        [Required]
        public string RecordStatus { get; set; } = "Draft";

        // Foreign key and navigation property

        [Required]
        public int MetadataId { get; set; }

        [ForeignKey(nameof(MetadataId))]
        public CHHA_Quality_POC_Metadata Metadata { get; set; } = null!;

        [NotMapped]
        public DateTime? DateResponse {
            get => DateTime.TryParse(Response, out var dt) ? dt : null;
            set => Response = value?.ToString("yyyy-MM-dd");
        }

        [NotMapped]
        public int? IntResponse {
            get => int.TryParse(Response, out var i) ? i : null;
            set => Response = value?.ToString();
        }
    }
}
