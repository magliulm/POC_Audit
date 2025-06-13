using System;
using System.ComponentModel.DataAnnotations;

namespace CHHA_PlanOfCorrectinAudit.ViewModel {
    public class FormInputModel_MissedVisit {
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


        // missed visit response fields
        public DateOnly? DateOfReview { get; set; }
        public int? Total_SN_Visits_Ordered { get; set; }
        public int? Missed_SN_Visits { get; set; }
        public int? Instances_Missed_SN_Visit_Documentation { get; set; }
        public int? Instances_Provider_Notification_Missed_SN { get; set; }

        public int? Total_PT_Visits_Ordered { get; set; }
        public int? Missed_PT_Visits { get; set; }
        public int? Instances_Missed_PT_Visit_Documentation { get; set; }
        public int? Instances_Provider_Notification_Missed_PT { get; set; }

        public int? Total_OT_Visits_Ordered { get; set; }
        public int? Missed_OT_Visits { get; set; }
        public int? Instances_Missed_OT_Visit_Documentation { get; set; }
        public int? Instances_Provider_Notification_Missed_OT { get; set; }

        public int? Total_SW_Visits_Ordered { get; set; }
        public int? Missed_SW_Visits { get; set; }
        public int? Instances_Missed_SW_Visit_Documentation { get; set; }
        public int? Instances_Provider_Notification_Missed_SW { get; set; }

        public int? Missed_HHA_Visits { get; set; }
        public int? Missed_HHA_Visits_Count { get; set; }
        public int? Instances_Missed_HHA_Visit_Documentation { get; set; }
        public int? Instances_Provider_Notification_Missed_HHA { get; set; }

        // Other fields
        public DateTime? Case_Closure_Date { get; set; }
        public string Chart_Review_Status { get; set; }
        public string Chart_Review_Outcome { get; set; }
        public string Responsible_Clinician_Staff { get; set; }
        public string Staff_Last_Name { get; set; }
        public string Responsible_Director { get; set; }
        public DateTime? Date_of_Escalation_to_Director { get; set; }
        public string Notes { get; set; }
        public string Corrected_Staff_Name { get; set; }
    }
}
