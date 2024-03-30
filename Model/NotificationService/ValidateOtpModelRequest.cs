

namespace Model.NotificationService
{
    public class ValidateOtpModelRequest
    {
        public int Otp {  get; set; }
        public string? CommunicationMethod { get; set;}
    }
}
