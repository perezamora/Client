using AppMVCStudent.Common.Logic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMVCStudent.Business.Logic
{
    public interface IStudentService
    {
        Task<List<Student>> GetAll();
        Task<Student> Get();
        Task<Student> Set(Student student);
    }
}
