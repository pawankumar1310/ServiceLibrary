
namespace Constant.StoredProcedure
{
    public class CommunicationDB
    {
        public const string SaveOTP = "InsertOrUpdateOtp";
        public const string ValidateOtp = "sp_ValidateOtpForEmail";
        public const string DeleteOtp = "DeleteOtp";
        public const string CheckExistingOtpForEmail = "GetExistingOtpforEmail";
    }
}
