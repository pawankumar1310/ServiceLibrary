

namespace Model.NotificationService
{
    public class InsertOrUpdateOTPModelRequest
    {
        public int Otp {  get; set; }
        public string? CommunicationMethod { get; set;}
        public string? CountryID  { get; set;}
    }
}
