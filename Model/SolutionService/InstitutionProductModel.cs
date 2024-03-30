namespace Model.SolutionService
{
    public class InstitutionProductModel
    {
        public required string InstitutionProductID { get; set; }
        public required string USRInstitutionID { get; set; }
        public required string ProductSubscriptionID { get; set; }
        public string? PYMPaymentID { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
    
}