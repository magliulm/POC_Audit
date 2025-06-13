using System;
using System.ComponentModel.DataAnnotations;

namespace CHHA_PlanOfCorrectinAudit.ViewModel {
    public class FormInputModel_Tioc {
        public string Patient_MRN { get; set; }
        public string Patient_Name { get; set; }
        public string Patient_Status { get; set; }
        public string Program { get; set; }
        public string Borough_of_Care { get; set; }
        public DateOnly Start_of_Care_Date { get; set; }
        public string Financial_Class { get; set; }
        public string Payer { get; set; }
        public string Category { get; set; }
        public string Assigned_Reviewer { get; set; }
        public DateOnly Date_Assigned { get; set; }
        public string FormName { get; set; }
        public string Key { get; set; }


        // Response fields
        public DateOnly? DateOfReview { get; set; }  // Date of Review
        public string WasReferralDateClearlyOutlinedInReferralNote { get; set; }  // Was the referral date clearly outlined in the referral note?
        public string WasMDOrderedSOCClearlyDocumented { get; set; }  // Was the MD ordered Start of Care (SOC) clearly documented in the referral note?
        public string WasCareStartedTimelyBasedOnSOCDate { get; set; }  // Based on SOC Date, was care started timely?
        public string WasMDNotifiedTimelyOfSOCChange { get; set; }  // Was MD notified timely of the need to make any changes to SOC, if applicable?
        public string WasDelayInSOCorROCNoteFound { get; set; }  // Was a delay in SOC/ROC note found in chart?
        public DateOnly? CaseClosureDate { get; set; }  // Case Closure Date
        public string ChartReviewStatus { get; set; }  // Chart Review Status
        public string ChartReviewOutcome { get; set; }  // Chart Review Outcome
        public string ResponsibleClinicianOrStaff { get; set; }  // Responsible Clinician(s) or Staff
        public string StaffLastName { get; set; }  // Staff Last Name (Formula field, name is still needed)
        public string ResponsibleDirector { get; set; }  // Responsible Director
        public DateOnly? DateOfEscalationToDirector { get; set; }  // Date of Escalation to Director
        public string Notes { get; set; }  // Notes
        public string CorrectedStaffName { get; set; }  // Corrected Staff Name



    }
}
