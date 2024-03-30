namespace Model.UserService
{
    public class UpdateInstituteRequestModel
    {
        public string InstitutionID  {get;set;}

        public string InstitutionCode   {get;set;}
        public string Name { get; set; }
        public string YearOfEstablishment { get; set; }
        public string AffiliationID { get; set; }
        public string UpdatedBy { get; set; }
        public string url { get; set; }
        public List<string> institutionFacilities { get; set; }
        public List<string> institutionGovernance { get; set; }
        public string AdditionalAddress { get; set; }
        public string Landmark { get; set; }
        public string ZipCodeID { get; set; }
        public string ownerShipID { get; set; }
        
        public string Names { get; set; }
        public string Gender { get; set; }
        public DateTime JoiningDate { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }
        public List<string> Categories { get; set; }
        public List<string> Levels { get; set; }
        public List<string> Courses { get; set; }
        public List<string> Management { get; set; }
        public List<string> Association { get; set; }
        

    }
}   