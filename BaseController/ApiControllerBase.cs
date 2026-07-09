using BestPractice.ResultPattern;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace YourProject.Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public abstract class ApiControllerBase : ControllerBase
{
    [NonAction]
    protected IActionResult ToActionResult(Result result)
    {
        return result.Status switch
        {
            ResultStatus.Ok => Ok(result),
            ResultStatus.Created => StatusCode(StatusCodes.Status201Created, result),
            ResultStatus.NoContent => NoContent(),

            ResultStatus.BadRequest => BadRequest(result),
            ResultStatus.Unauthorized => Unauthorized(result),
            ResultStatus.Forbidden => StatusCode(StatusCodes.Status403Forbidden, result),
            ResultStatus.NotFound => NotFound(result),
            ResultStatus.Conflict => Conflict(result),
            ResultStatus.UnprocessableEntity => UnprocessableEntity(result),

            _ => StatusCode(StatusCodes.Status500InternalServerError, result)
        };
    }

    [NonAction]
    protected IActionResult ToActionResult<T>(Result<T> result)
    {
        return result.Status switch
        {
            ResultStatus.Ok => Ok(result),
            ResultStatus.Created => StatusCode(StatusCodes.Status201Created, result),
            ResultStatus.NoContent => NoContent(),

            ResultStatus.BadRequest => BadRequest(result),
            ResultStatus.Unauthorized => Unauthorized(result),
            ResultStatus.Forbidden => StatusCode(StatusCodes.Status403Forbidden, result),
            ResultStatus.NotFound => NotFound(result),
            ResultStatus.Conflict => Conflict(result),
            ResultStatus.UnprocessableEntity => UnprocessableEntity(result),

            _ => StatusCode(StatusCodes.Status500InternalServerError, result)
        };
    }
}