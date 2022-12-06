namespace api_base.Utils
{
    public enum StatusCode : ushort
    {
        #region 1xx informational response
        #endregion

        #region 2xx success
        Ok = 200,
        Created = 201,
        #endregion

        #region 3xx redirection
        NoContent = 204,
        Found = 302,
        NotModified = 304,
        #endregion

        #region 4xx client errors
        BadRequest = 400,
        Unauthorized = 401,
        Forbidden = 403,
        NotFound = 404,
        Conflict = 409,
        Gone = 410,
        #endregion

        #region 5xx server errors
        InternalServerError = 500,
        NotImplemented = 501,
        ServiceUnavailable = 503,
        #endregion
    }
}