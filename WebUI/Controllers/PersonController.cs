using Application.Services;
using Application.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPersonService _service;
        public PersonController(IPersonService service)
        {
            _service = service;
        }
        // GET: PersonController
        public ActionResult Index()
        {
            List<PersonListItem> personListItem = _service.GetAll();
            return View(personListItem);
        }

        // GET: PersonController/Details/5
        public ActionResult Details(int id)
        {
            PersonDetail person = _service.GetById(id);
            return View(person);
        }

        // GET: PersonController/Create
        public ActionResult Create()
        {
            return View(new PersonCreate());
        }

        // POST: PersonController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PersonCreate person)
        {
            try
            {
                _service.Add(person);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(person);
            }
        }

        // GET: PersonController/Edit/5
        public ActionResult Edit(int id)
        {
            PersonDetail person = _service.GetById(id);
            return View(person);
        }

        // POST: PersonController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PersonDetail person)
        {
            try
            {
                _service.Edit(person);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(person);
            }
        }

        // GET: PersonController/Delete/5
        public ActionResult Delete(int id)
        {
            PersonDetail person = _service.GetById(id);
            return View(person);
        }

        // POST: PersonController/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                _service.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(_service.GetById(id));
            }
        }
    }
}
