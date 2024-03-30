namespace Model.UserService
{
    public class RegisterUserModelRequest
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? CountryID { get; set; }
        public string? PhoneNumber { get; set; }
        public string? EmailAddress { get; set; }
        public string? AdditionalAddress{ get; set; }
        public string? ZipcodeID {get; set; }
    }
}