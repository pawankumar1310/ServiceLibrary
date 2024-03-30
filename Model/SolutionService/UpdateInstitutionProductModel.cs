namespace Model.SolutionService
{
    public class UpdateInstitutionProductModel
    {
        public required string InstitutionProductID{get;set;}
        public required string USRInstitutionID { get; set; }
        public string ProductSubscriptionID { get; set; }
        public string? PYMPaymentID { get; set; }
        public string? UpdatedBy { get; set; }
        public required DateTime StartDate { get; set; }
        public required DateTime EndDate { get; set; }
     
    }
}