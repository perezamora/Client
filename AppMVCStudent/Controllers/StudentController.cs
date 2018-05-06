using AppMVCStudent.Business.Logic;
using AppMVCStudent.Common.Logic.Logger;
using AppMVCStudent.Common.Logic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;


namespace AppMVCStudent.Controllers
{
    public class StudentController : Controller
    {
        private readonly ILogger _log;
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService, ILogger log)
        {
            _studentService = studentService;
            _log = log;
        }

        public ActionResult Index()
        {
            _log.Debug(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var result = Task.Run(() => _studentService.GetAll()).Result;
            return View((IEnumerable<Student>)result);
        }

        public ActionResult Edit()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            _log.Debug(System.Reflection.MethodBase.GetCurrentMethod().Name + ":" + id);
            Student student;
            try
            {
                student = Task.Run(() => _studentService.Get(id)).Result;
            }
            catch (Exception)
            {
                return HttpNotFound();
            }

            return View(student);
        }

        public ActionResult Delete(int id)
        {
            _log.Debug(System.Reflection.MethodBase.GetCurrentMethod().Name + ":" + id);
            
            try
            {
                var result = Task.Run(() => _studentService.Delete(id)).Result;
            }
            catch (Exception)
            {
                return HttpNotFound();
            }
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student student)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = Task.Run(() => _studentService.Create(student)).Result;
                    return RedirectToAction("Index");
                }
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "error en validacion");
            }
            return View(student);
        }

    }
}