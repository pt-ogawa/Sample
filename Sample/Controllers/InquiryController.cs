using Sample.Models.ViewModel.Inquiry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sample.Domains.Applications;
using Sample.UseCases.Inquiry;

namespace Sample.Controllers
{
    public class InquiryController : Controller
    {
        private ISendInquiryUserCase SendInquiryUserCase { get; set; }

        public InquiryController(ISendInquiryUserCase sendInquiryUserCase)
        {
            SendInquiryUserCase = sendInquiryUserCase;
        }

        [HttpGet]
        public ActionResult Input()
        {
            var inputViewModel = TempData["input"]?? new InputViewModel();
            var modelState = (ModelStateDictionary) TempData["modelState"];
            if (modelState != null) {
                ModelState.Merge(modelState);
            }

            return View(inputViewModel);
        }

        [HttpPost]
        public ActionResult Input(InputViewModel input)
        {
            TempData["input"] = input;
            TempData["modelState"] = ModelState;
            if (!ModelState.IsValid) {
                return RedirectToAction(nameof(Input));
            }

            return RedirectToAction(nameof(Confirm));
        }

        [HttpGet]
        public ActionResult Confirm()
        {
            var inputViewModel = (InputViewModel) TempData.Peek("input");
            if(inputViewModel == null) {
                return RedirectToAction(nameof(Input));
            }

            var confirmViewModel = new ConfirmViewModel(inputViewModel.Name, inputViewModel.Age, inputViewModel.Sex, inputViewModel.InquiryTypes, inputViewModel.Content);
            TempData["confirm"] = confirmViewModel;

            return View(confirmViewModel);
        }


        [HttpPost]
        public ActionResult Confirm(InputViewModel input)
        {
            var confirmViewModel = (ConfirmViewModel)TempData.Peek("confirm");
            if (confirmViewModel == null)
            {
                return RedirectToAction(nameof(Input));
            }
            var request = new SendInquiryRequest(confirmViewModel.Name, confirmViewModel.Age, confirmViewModel.Sex, confirmViewModel.InquiryTypes, confirmViewModel.Content);
            var response = SendInquiryUserCase.Handle(request);

            return RedirectToAction(nameof(Finish));
        }


        [HttpGet]
        public ActionResult Finish()
        {
            TempData.Remove("input");
            TempData.Remove("confirm");
            TempData.Remove("modelState");
            return View();
        }
    }
}