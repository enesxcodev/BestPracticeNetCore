namespace BestPractice.ResultPattern
{
    public enum ResultStatus
    {
        Ok,
        Created,
        NoContent,
        BadRequest,
        Unauthorized,
        Forbidden,
        NotFound,
        Conflict,
        UnprocessableEntity,
        InternalServerError
    }
}
