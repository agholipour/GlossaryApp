using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Glossary.Model;
using Glossary.Web.Infrastructure;
using Glossary.Web.Models;
using Microsoft.AspNet.Identity;

namespace Glossary.Web.Controllers
{
    public class GlossaryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public GlossaryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public ActionResult Index()
        {
            var glossaryTrems = _unitOfWork.GlossaryTermRepository
               .GetGlossaryTerms();

            var result = Mapper.Map<IEnumerable<GlossaryTerm>, IEnumerable<GlossaryTermViewModel>>(glossaryTrems);

            return View(result);
        }

        public ActionResult Add()
        {
            var viewModel = new GlossaryTermViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Add(GlossaryTermViewModel glossaryTermViewModel)
        {
            if (ModelState.IsValid)
            {
                var domain = Mapper.Map<GlossaryTermViewModel, GlossaryTerm>(glossaryTermViewModel);
                
                _unitOfWork.GlossaryTermRepository.Add(domain);
                _unitOfWork.Complete();

                return RedirectToAction("Index");
            }
            return View(glossaryTermViewModel);
        }

        public ActionResult Edit(int glossaryTermId)
        {
            var glossaryTerm = _unitOfWork.GlossaryTermRepository.GetGlossaryTerm(glossaryTermId);
            if (glossaryTerm == null)
            {
                return HttpNotFound();
            }
            var viewModel = Mapper.Map<GlossaryTerm, GlossaryTermViewModel>(glossaryTerm);
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Edit(GlossaryTermViewModel glossaryTermViewModel)
        {
            if (!ModelState.IsValid) return HttpNotFound();

            var domain = _unitOfWork.GlossaryTermRepository.GetGlossaryTerm(glossaryTermViewModel.Id);
            domain.Modify(glossaryTermViewModel.Term, glossaryTermViewModel.Definition);
            _unitOfWork.Complete();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public JsonResult Delete(int id)
        {
            var domain = _unitOfWork.GlossaryTermRepository.GetGlossaryTerm(id);
            if (domain == null)
            {
                return Json("no item found in database");
            }

            _unitOfWork.GlossaryTermRepository.Remove(domain);
            _unitOfWork.Complete();

            return Json("");
        }

    }
}