using System;
using System.ComponentModel.DataAnnotations;

namespace CHHA_PlanOfCorrectinAudit.ViewModel {
    public class FormInputModel_WoundCare {
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
        public DateOnly? DateOfReview { get; set; }  // Date of Review
        public int TotalSkilledNursingVisits { get; set; }  // Total # Skilled Nursing Visits

        public string WoundType { get; set; }  // What Type of Wound(s) Did Patient Have? (e.g. surgical, pressure ulcer, stasis ulcer, diabetic ulcer, traumatic wound, etc.)
        public string WoundOrderInReferral { get; set; }  // Was a Wound Order in the Referral? 
        public string IsWoundCareOrderComplete { get; set; }  // Was the Wound Care Order Complete/Correct (location, solution to cleanse with, dressing to use, etc.)?
        public string WasWoundMeasuredWeekly { get; set; }  // Was the Wound Measured at least 1x/week During Episode?
        public string WereWoundImagesUploadedInEpic { get; set; }  // Were Wound Images Uploaded in Epic?
        public string IsWoundCaseConferenceDocumented { get; set; }  // At least one Wound Case Conference Documented?
        public string IsWoundCareAlignmentWithMDOrders { get; set; }  // Was Documented Wound Care in Alignment w/ MD Orders?
        public string WereWoundCareInterventionsRevised { get; set; }  // Were Wound Care Interventions Revised Following Change in Wound Treatment Order?
        public string WasWoundLocationSpecified { get; set; }  // Was Location of all Wounds Specified?
        public int TotalVisitsWithWoundDrainageAndCharacteristics { get; set; }  // Total # Visits with recorded wound drainage & characteristics
        public int WoundCareTeachingInstances { get; set; }  // # of Instances of Wound Care Teachings
        public string WasWillingAbleCaregiverDocumented { get; set; }  // Was a Willing & Able Caregiver Documented?
        public string HasFiniteEndDateForDailyVisitsOver21Days { get; set; }  // Finite/ Predictable End Date for Daily Visits Over 21 Days?
        public string DidClinicianDocumentWhatWasDone { get; set; }  // Did Clinician(s) Document Exactly What Was Done During Each Wound Care Visit?

        public DateOnly? CaseClosureDate { get; set; }  // Case Closure Date
        public string ChartReviewStatus { get; set; }  // Chart Review Status
        public string ChartReviewOutcome { get; set; }  // Chart Review Outcome
        public string ResponsibleClinicianOrStaff { get; set; }  // Responsible Clinician(s) or Staff
        public string StaffLastName { get; set; }  // Staff Last Name (formula field)
        public string ResponsibleDirector { get; set; }  // Responsible Director
        public DateOnly? DateOfEscalationToDirector { get; set; }  // Date of Escalation to Director
        public string Notes { get; set; }  // Notes
        public string CorrectedStaffName { get; set; }  // Corrected Staff Name

        public string WasWoundDrainageDocumentedOnce { get; set; }  // Wound Drainage & Characteristics Documented at least Once?
        public string WasWoundCareTeachingDocumentedOnce { get; set; }  // Wound Care Teaching Documented At Least Once?




    }
}
