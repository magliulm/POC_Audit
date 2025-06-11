using System.ComponentModel.DataAnnotations;

namespace CHHA_PlanOfCorrectinAudit.ViewModel {
    public class FormInputModel1 {
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
        public DateTime? DateOfReview { get; set; }
        public DateTime? DateOfReviewCompletion { get; set; }
        public DateTime? EpisodeDischargeDate { get; set; }
        public string FrequencyDurationPresent { get; set; }
        public string DutiesCheckedOnPOC { get; set; }
        public string DutiesHaveFrequency { get; set; }
        public string DietMatch485 { get; set; }
        public string POCSignedByNurse { get; set; }
        public string IndividualizedTasks { get; set; }
        public string SupervisionEvery14Days { get; set; }
        public string ReviewerNotes { get; set; }
        public string ChartReviewOutcome { get; set; }
        public string InvolvedStaff { get; set; }
        public string Column3 { get; set; }
        public string OverseeingManager { get; set; }
        public DateTime? DateEscalated { get; set; }
        public string AdditionalNotes { get; set; }
        public string CorrectedStaffName { get; set; }

    }
}