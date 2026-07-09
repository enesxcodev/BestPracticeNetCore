using BestPractice.ResultPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPractice.BaseController
{
    public class MvcControllerBaseUsage
    {
        public void Usage()
        {

            //başarılı sonuç
            //if (result.IsFailure)
            //{
            //    AddApiErrors(result);
            //    return View(model);
            //}
            //return RedirectSuccess(nameof(Index), "Soru başarıyla eklendi.");

            //başarısız sonuç
            //if (result.IsFailure)
            //{
            //    AddApiErrors(result);
            //    return View(model);
            //}

            //delete
            //var result = await _mediator.Send(command);

            //if (result.IsFailure)
            //{
            //    return RedirectError(nameof(Index), result.Errors.First());
            //}

            //return RedirectSuccess(nameof(Index), "Kayıt silindi.");
        }
    }
