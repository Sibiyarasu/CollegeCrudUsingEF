using DataAccessLibrary.Model;
using DataAccessLibrary.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeCrudUsingEF.Controllers
{
    public class StudentController : Controller
    {
        public IStudentInfo _Context;

        public StudentController(IStudentInfo context)
        {
            _Context = context;
        }
        // GET: StudentController
        public ActionResult List()
        {
            try
            {
                _Context.GetAllStudentInfo();
                return View("List", _Context.GetAllStudentInfo());
            }
            catch(Exception ex)
            {
                throw ex;
            }
           
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            try
            {
                var model = new StudentModel();
                model.Type = _Context.GetDeptType();
                return View("Create", model);
            }
            catch(Exception ex)
            {
                throw ex;
            }
          
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StudentModel collection)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    _Context.InsertStudentInfo(collection);

                }
                return RedirectToAction(nameof(List));


            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
