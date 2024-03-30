namespace Model.UserService
{
    public class AddInstituteModelRequest
    {
        public string Name { get; set; }
        public string YearOfEstablishment { get; set; } // Updated to match char(4) in SQL
        public string AffiliationID { get; set; }
        public string CreatedBy { get; set; }

        public string url {  get; set; }    
        public List<string> institutionFacilities { get; set; }

        public List<string> institutionGovernance { get; set; }
        public List<string> Categories { get; set; }
        public List<string> Levels { get; set; }
        public List<string> Courses { get; set; }
        public List<string> Management { get; set; }
        public List<string> Association { get; set; }
    }

}