using System;
using System.ComponentModel.DataAnnotations;

namespace CHHA_PlanOfCorrectinAudit.ViewModel {
    public class FormInputModel_RxRec {
        public string Patient_MRN { get; set; }
        public string Patient_Name { get; set; }
        public string Patient_Status { get; set; }
        public string Program { get; set; }
        public string Borough_of_Care { get; set; }
        public DateOnly? Start_of_Care_Date { get; set; }
        public string Financial_Class { get; set; }
        public string Payer { get; set; }
        public string Category { get; set; }
        public string Assigned_Reviewer { get; set; }
        public DateOnly? Date_Assigned { get; set; }
        public string FormName { get; set; }
        public string Key { get; set; }


        // Response fields
        public DateOnly? DateOfReview { get; set; }
        public string IssuesEscalatedToMD_DuringRxReview { get; set; }
        public string ChangeInCondition_ReportedToMD_Within24Hrs { get; set; }
        public string RxProfile_AccuratelyReflectsHomeMeds { get; set; }
        public string AllPRN_HaveClinicalReason_InRxProfile { get; set; }
        public string AllMedications_HaveIndications { get; set; }
        public string Documentation_DrugFoodInteraction { get; set; }
        public string Documentation_DrugDrugInteraction { get; set; }
        public string Documentation_RxReconciliation_WithMD { get; set; }
        public string Documentation_PrePourOrPrefilledRx_InNotes { get; set; }
        public DateOnly? CaseClosureDate { get; set; }
        public string ChartReviewStatus { get; set; }
        public string ChartReviewOutcome { get; set; }
        public string ResponsibleClinicianOrStaff { get; set; }
        public string StaffLastName { get; set; }  // (Formula field, name is still needed)
        public string ResponsibleDirector { get; set; }
        public DateOnly? DateOfEscalationToDirector { get; set; }
        public string Notes { get; set; }
        public string CorrectedStaffName { get; set; }


    }
}
