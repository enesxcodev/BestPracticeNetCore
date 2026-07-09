namespace BestPractice.API.Middlewares;

public sealed class ExceptionResponse
{
    public bool IsSuccess => false;

    public int StatusCode { get; init; }

    public string Message { get; init; } = default!;

    public IReadOnlyCollection<string> Errors { get; init; } = [];

    public string? TraceId { get; init; }
}