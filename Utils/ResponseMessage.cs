namespace api_base.Utils
{
    public static class ResponseMessage
    {
        public const string InternalServerError = "An internal error has occurred.";
        public const string Success = "The request has been successfully performed.";
        public const string NotFound = "Nothing was found based on your request.";
        public const string Created = "Created successfully.";
        public const string Deleted = "Deleted successfully.";
        public const string Updated = "Updated successfully.";
        public const string BadRequest = "The request could not be performed.";
        public const string NoContent = "The request did not return any content.";
    }
}