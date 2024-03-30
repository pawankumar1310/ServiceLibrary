namespace Model.ResourceService
{
     public class UpdateImageModelRequest
    {
        public required byte[] Content { get; set; }
        public required string UserReferenceId { get; set; }
    }
}