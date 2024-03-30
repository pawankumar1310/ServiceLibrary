
namespace Model.UserService
{
    public class AddUrlModelRequest
    {
        public List<UpdateUrlModelRequest>? Urls { get; set; }

        public string? ReferenceID { get; set; }
       
    }
}