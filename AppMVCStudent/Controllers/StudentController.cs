using AppMVCStudent.Business.Logic;
using AppMVCStudent.Common.Logic.Logger;
using AppMVCStudent.Common.Logic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}