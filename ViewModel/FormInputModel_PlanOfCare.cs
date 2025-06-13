using System;
using System.ComponentModel.DataAnnotations;

namespace CHHA_PlanOfCorrectinAudit.ViewModel {
    public class FormInputModel_PlanOfCare {
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
        public DateOnly? DateOfReview { get; set; }
        public string Is_Diabetic_Patient_With_Wound { get; set; }
        public string Vital_Signs_Documented_Every_Visit { get; set; }
        public string Vital_Signs_Documented_Within_5_Days_Of_SOC { get; set; }
        public string SN_CarePlan_Interventions_Addr_By_Nurse { get; set; }
        public string SN_CarePlan_Freq_Of_Interventions_Met { get; set; }
        public string PT_CarePlan_Interventions_Addr { get; set; }
        public string PT_CarePlan_Freq_Of_Interventions_Met { get; set; }
        public string OT_CarePlan_Interventions_Addr { get; set; }
        public string OT_CarePlan_Freq_Of_Interventions_Met { get; set; }
        public string SW_CarePlan_Interventions_Addr { get; set; }
        public string SW_CarePlan_Freq_Of_Interventions_Met { get; set; }
        public string DM_Wound_POC_Interventions_Present { get; set; }
        public string DM_Wound_Interventions_Addr_By_Clinician { get; set; }
        public DateOnly? Case_Closure_Date { get; set; }
        public string Chart_Review_Status { get; set; }
        public string Chart_Review_Outcome { get; set; }
        public string Responsible_Clinician_Staff { get; set; }
        public string Responsible_Director { get; set; }
        public DateOnly? Date_of_Escalation_to_Director { get; set; }
        public string Column1 { get; set; }
        public string Corrected_Staff_Name { get; set; }
        public string Notes { get; set; }

    }
}
