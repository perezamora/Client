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
        Task<Student> Get(int id);
        Task<int> Delete(int id);
        Task<Student> Create(Student student);
    }
}
