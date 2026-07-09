using BestPractice.ResultPattern;

namespace SoruHavuzu.ADMIN.Controllers;

/// <summary>
/// Admin MVC controller'larının temel sınıfı.
/// Ortak yetkilendirme, TempData mesajları ve ModelState yardımcılarını içerir.
/// </summary>
[Authorize(Policy = AdminPolicies.AdminOnly)]
public abstract class AdminControllerBase : Controller
{
    #region TempData Messages

    protected void Success(string message)
        => TempData[TempDataKeys.Success] = message;

    protected void Error(string message)
        => TempData[TempDataKeys.Error] = message;

    protected void Warning(string message)
        => TempData[TempDataKeys.Warning] = message;

    protected void Info(string message)
        => TempData[TempDataKeys.Info] = message;

    #endregion

    #region ModelState

    protected void AddApiErrors(Result result)
    {
        if (result.IsSuccess)
            return;

        if (result.Errors.Any())
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error);
            }

            return;
        }

        ModelState.AddModelError(string.Empty, "İşlem başarısız.");
    }

    /// <summary>
    /// Formda kullanılmayan nested model alanlarının ModelState kayıtlarını temizler.
    /// </summary>
    protected void RemoveModelStatePrefix(string prefix)
    {
        var keys = ModelState.Keys
            .Where(k =>
                k.Equals(prefix, StringComparison.OrdinalIgnoreCase) ||
                k.StartsWith(prefix + ".", StringComparison.OrdinalIgnoreCase))
            .ToList();

        foreach (var key in keys)
        {
            ModelState.Remove(key);
        }
    }

    #endregion

    #region Redirect Helpers

    protected RedirectToActionResult RedirectSuccess(
        string actionName,
        string message)
    {
        Success(message);
        return RedirectToAction(actionName)!;
    }

    protected RedirectToActionResult RedirectSuccess(
        string actionName,
        string controllerName,
        string message)
    {
        Success(message);
        return RedirectToAction(actionName, controllerName)!;
    }

    protected RedirectToActionResult RedirectError(
        string actionName,
        string message)
    {
        Error(message);
        return RedirectToAction(actionName)!;
    }

    protected RedirectToActionResult RedirectError(
        string actionName,
        string controllerName,
        string message)
    {
        Error(message);
        return RedirectToAction(actionName, controllerName)!;
    }

    #endregion
}