namespace BestPractice.ResultPattern
{
    public class Result
    {
        protected Result(
            bool isSuccess,
            ResultStatus status,
            string? message = null,
            IReadOnlyCollection<string>? errors = null)
        {
            IsSuccess = isSuccess;
            Status = status;
            Message = message;
            Errors = errors ?? Array.Empty<string>();
        }

        public bool IsSuccess { get; }

        public ResultStatus Status { get; }

        public string? Message { get; }

        public IReadOnlyCollection<string> Errors { get; }

        public static Result Success(string? message = null)
            => new(true, ResultStatus.Ok, message);

        public static Result Created(string? message = null)
            => new(true, ResultStatus.Created, message);

        public static Result NoContent()
            => new(true, ResultStatus.NoContent);

        public static Result BadRequest(params string[] errors)
            => new(false, ResultStatus.BadRequest, errors: errors);

        public static Result Unauthorized(string? message = null)
            => new(false, ResultStatus.Unauthorized, message);

        public static Result Forbidden(string? message = null)
            => new(false, ResultStatus.Forbidden, message);

        public static Result NotFound(string? message = null)
            => new(false, ResultStatus.NotFound, message);

        public static Result Conflict(params string[] errors)
            => new(false, ResultStatus.Conflict, errors: errors);

        public static Result Validation(params string[] errors)
            => new(false, ResultStatus.UnprocessableEntity, errors: errors);

        public static Result Failure(string? message = null)
            => new(false, ResultStatus.InternalServerError, message);
    }

    public sealed class Result<T> : Result
    {
        private Result(
            T? value,
            bool isSuccess,
            ResultStatus status,
            string? message = null,
            IReadOnlyCollection<string>? errors = null)
            : base(isSuccess, status, message, errors)
        {
            Value = value;
        }

        public T? Value { get; }

        public static Result<T> Success(T value, string? message = null)
            => new(value, true, ResultStatus.Ok, message);

        public static Result<T> Created(T value, string? message = null)
            => new(value, true, ResultStatus.Created, message);

        public static Result<T> NoContent()
            => new(default, true, ResultStatus.NoContent);

        public static Result<T> BadRequest(params string[] errors)
            => new(default, false, ResultStatus.BadRequest, errors: errors);

        public static Result<T> Unauthorized(string? message = null)
            => new(default, false, ResultStatus.Unauthorized, message);

        public static Result<T> Forbidden(string? message = null)
            => new(default, false, ResultStatus.Forbidden, message);

        public static Result<T> NotFound(string? message = null)
            => new(default, false, ResultStatus.NotFound, message);

        public static Result<T> Conflict(params string[] errors)
            => new(default, false, ResultStatus.Conflict, errors: errors);

        public static Result<T> Validation(params string[] errors)
            => new(default, false, ResultStatus.UnprocessableEntity, errors: errors);

        public static Result<T> Failure(string? message = null)
            => new(default, false, ResultStatus.InternalServerError, message);
    }
}
