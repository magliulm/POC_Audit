using CHHA_PlanOfCorrectinAudit.Models;

public class ChartReviewEditViewModel {
    public CHHA_Quality_POC_Metadata Metadata { get; set; } = new();
    public List<CHHA_Quality_POC_Responses> Responses { get; set; } = new();
}
