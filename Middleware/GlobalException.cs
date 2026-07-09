using System.Text.Json;

namespace BestPractice.API.Middlewares;

public sealed class GlobalExceptionMiddleware(
    RequestDelegate next,
    ILogger<GlobalExceptionMiddleware> logger,
    IHostEnvironment environment)
{
    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await next(context);
        }
        catch (Exception exception)
        {
            logger.LogError(
                exception,
                "Unhandled exception. TraceId: {TraceId}",
                context.TraceIdentifier);

            await HandleExceptionAsync(context, exception, environment);
        }
    }

    private static async Task HandleExceptionAsync(
        HttpContext context,
        Exception exception,
        IHostEnvironment environment)
    {
        var response = exception switch
        {
            UnauthorizedAccessException => CreateResponse(
                StatusCodes.Status401Unauthorized,
                exception.Message,
                context),

            KeyNotFoundException => CreateResponse(
                StatusCodes.Status404NotFound,
                exception.Message,
                context),

            ArgumentException => CreateResponse(
                StatusCodes.Status400BadRequest,
                exception.Message,
                context),

            InvalidOperationException => CreateResponse(
                StatusCodes.Status409Conflict,
                exception.Message,
                context),

            _ => CreateResponse(
                StatusCodes.Status500InternalServerError,
                environment.IsDevelopment()
                    ? exception.ToString()
                    : "Beklenmeyen bir hata oluştu.",
                context)
        };

        context.Response.StatusCode = response.StatusCode;
        context.Response.ContentType = "application/json";

        await context.Response.WriteAsync(
            JsonSerializer.Serialize(response));
    }

    private static ExceptionResponse CreateResponse(
        int statusCode,
        string message,
        HttpContext context)
    {
        return new ExceptionResponse
        {
            StatusCode = statusCode,
            Message = message,
            TraceId = context.TraceIdentifier
        };
    }
}