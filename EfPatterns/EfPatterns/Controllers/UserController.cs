using EfPatterns.Domain;
using EfPatterns.Domain.Repository;
using EfPatterns.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EfPatterns.Controllers
{
    public class UserController : Controller
    {
        IUnitOfWork<User> UnitOfWorkUser { get; set; }

        public UserController()
        {
            this.UnitOfWorkUser = new UserRepository();
        }
        
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        // GET: User/Details/5
        public ActionResult Details(Guid id)
        {
            var model = this.UnitOfWorkUser.GetById(id);
            return View(model);
        }

        // GET: User/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(User model)
        {
            try
            {
                this.UnitOfWorkUser.Save(model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(Guid id)
        {
            var model = this.UnitOfWorkUser.GetById(id);
            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, User model)
        {
            try
            {
                model.Id = id;
                this.UnitOfWorkUser.Update(model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id)
        {
            try
            {
                // TODO: Add delete logic here
                var model = this.UnitOfWorkUser.Where(x => x.Id == id).FirstOrDefault();
                this.UnitOfWorkUser.Delete(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
