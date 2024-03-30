namespace Model.UserService
{
    public class GetUserInstDetailsModel
    {
        public string InstitutionID { get; set; }
        public string InstitutionName { get; set; }
        public string YearOfEstablishment { get; set; }
        public List<string> CategoryID { get; set; }
        public List<string> CategoryName { get; set; }

        public List<string> LevelID { get; set; }
        public List<string> LevelName { get; set; }

        public List<string> CourseID { get; set; }
        public List<string> CourseName { get; set; }

        public List<string> ManagementID { get; set; }
        public List<string> ManagementName { get; set; }

        public List<string> AssociationID { get; set; }
        public List<string> AssociationName { get; set; }

        public string HeadName { get; set; }
        public string Gender { get; set; }
        public DateTime JoiningDate { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailID { get; set; }

        public List<string> OwnershipID { get; set; }
        public List<string> OwnershipTypeName { get; set; }

        public List<string> GovernanceID { get; set; }
        public string AffiliationNumber { get; set; }
        public List<string> GovernanceName { get; set; }

        public List<string> FacilityID { get; set; }
        public List<string> FacilityName { get; set; }

        public string InstitutionIDValue { get; set; }

        // New properties for address details
        public string AddressID { get; set; }
        public string AdditionalAddress { get; set; }
        public string LandMark { get; set; }
        public string UTLzipCodeID { get; set; }
        public string url {get;set;}
    }
}