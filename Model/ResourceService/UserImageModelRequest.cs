namespace Model.ResourceService
{
    public class UserImageModelRequest
    {
        public required string Label { get; set; }
        public required string Name { get; set; }
        public required byte[] Content { get; set; }
        public required string UserReferenceId { get; set; }
    }
}