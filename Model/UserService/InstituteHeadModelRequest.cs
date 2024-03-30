namespace Model.UserService
{
    public class InstituteHeadModelRequest
    {
        public string Names { get; set; }
        public string Gender { get; set; }
        public DateTime JoiningDate { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }
        public string InstitutionId { get; set; }
    }

}