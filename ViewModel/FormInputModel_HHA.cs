using System.ComponentModel.DataAnnotations;

namespace CHHA_PlanOfCorrectinAudit.ViewModel {
    public class FormInputModel_HHA {
        [Required(ErrorMessage = "Patient MRN is required")]
        public int? Patient_MRN { get; set; }

        [Required(ErrorMessage = "Patient Name is required")]
        public string? Patient_Name { get; set; }

        [Required(ErrorMessage = "Patient Status is required")]
        public string? Patient_Status { get; set; }
        public static readonly List<string> PatientStatusOptions = new List<string>
        {
            "Active",
            "Closed"
        };

        [Required(ErrorMessage = "Program is required")]
        public string? Program { get; set; }
        public static readonly List<string> ProgramOptions = new List<string>
        {
            "Adult",
            "MCH"
        };


        [Required(ErrorMessage = "Borough of Care is required")]
        public string? Borough_of_Care { get; set; }
        public static readonly List<string> BoroughOfCareOptions = new List<string>
        {
            "Bronx",
            "Brooklyn",
            "Manhattan",
            "Queens"
        };

        [Required(ErrorMessage = "Start of Care Date is required")]
        public DateOnly? Start_of_Care_Date { get; set; }

        [Required(ErrorMessage = "Financial Class is required")]
        public string? Financial_Class { get; set; }
        public static readonly List<string> FinancialClassOptions = new List<string>
        {
            "Commercial",
            "Medicaid",
            "Medicaid Managed Care",
            "Medicare",
            "Medicare Managed Care",
            "No Fault",
            "Self-Pay"
        };

        [Required(ErrorMessage = "Payer is required")]
        public string? Payer { get; set; }
        public static readonly List<string> PayerOptions = new()
        {
            "Healthfirst Comm",
            "Metroplus McR",
            "Unitedhealthcare McD",
            "Fidelis Care Comm",
            "Fidelis Care Ny McD",
            "Healthfirst McD",
            "Metroplus McD",
            "Medicare",
            "Emblemhealth McR",
            "Villagecare McR",
            "Healthfirst McR",
            "Elderplan McR",
            "New York Medicaid",
            "Affinity By Molina Health Plan McD",
            "Unitedhealthcare McR",
            "Geico Insurance",
            "Anthem Bcbs Healthplus Comm",
            "Anthem Bcbs Healthplus McD",
            "Emblemhealth McD",
            "Wellcare McR",
            "Metroplus Comm",
            "Senior Health Partners",
            "Emblem health McD"
        };


        [Required(ErrorMessage = "Category is required")]
        public string? Category { get; set; }

        [Required(ErrorMessage = "Assigned Reviewer is required")]
        public string? Assigned_Reviewer { get; set; }

        [Required(ErrorMessage = "Date Assigned is required")]
        public DateOnly? Date_Assigned { get; set; }

        [Required(ErrorMessage = "Form Name is required")]
        public string? FormName { get; set; }

        [Required(ErrorMessage = "Key is required")]
        public string? Key { get; set; }


        // Responses:

        [Required(ErrorMessage = "Date Of Review is required")]
        public DateOnly? DateOfReview { get; set; }

        [Required(ErrorMessage = "Date Of Review Completion is required")]
        public DateOnly? DateOfReviewCompletion { get; set; }

        [Required(ErrorMessage = "Episode Discharge Date is required")]
        public DateOnly? EpisodeDischargeDate { get; set; }

        [Required(ErrorMessage = "Frequency Duration Present is required")]
        public string? FrequencyDurationPresent { get; set; }

        [Required(ErrorMessage = "Duties Checked On POC is required")]
        public string? DutiesCheckedOnPOC { get; set; }

        [Required(ErrorMessage = "Duties Have Frequency is required")]
        public string? DutiesHaveFrequency { get; set; }

        [Required(ErrorMessage = "Diet Match 485 is required")]
        public string? DietMatch485 { get; set; }

        [Required(ErrorMessage = "POC Signed By Nurse is required")]
        public string? POCSignedByNurse { get; set; }

        [Required(ErrorMessage = "Individualized Tasks is required")]
        public string? IndividualizedTasks { get; set; }

        [Required(ErrorMessage = "Supervision Every 14 Days is required")]
        public string? SupervisionEvery14Days { get; set; }

        [Required(ErrorMessage = "Reviewer Notes is required")]
        public string? ReviewerNotes { get; set; }

        [Required(ErrorMessage = "Chart Review Outcome is required")]
        public string? ChartReviewOutcome { get; set; }
        public static readonly List<string> ChartReviewOutcomeOptions = new()
        {
            "Corrections Needed",
            "Satisfactory"
        };

        [Required(ErrorMessage = "Involved Staff is required")]
        public string? InvolvedStaff { get; set; }

        [Required(ErrorMessage = "Column3 is required")]
        public string? Column3 { get; set; }

        [Required(ErrorMessage = "Overseeing Manager is required")]
        public string? OverseeingManager { get; set; }

        [Required(ErrorMessage = "Date Escalated is required")]
        public DateOnly? DateEscalated { get; set; }

        [Required(ErrorMessage = "Additional Notes is required")]
        public string? AdditionalNotes { get; set; }

        [Required(ErrorMessage = "Corrected Staff Name is required")]
        public string? CorrectedStaffName { get; set; }

        [Required(ErrorMessage = "Record Status is required")]
        public string? RecordStatus { get; set; }

        public static readonly List<string> YesNoOptions = new List<string> { "Yes", "No" };

    }
}
