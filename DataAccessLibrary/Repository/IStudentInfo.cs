using DataAccessLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Repository
{
     public interface IStudentInfo
    {
        public List<StudentModel> GetAllStudentInfo();
        public StudentModel GetStudentById(int id);
        public void InsertStudentInfo(StudentModel model);
        public void UpdateStudentInfo(StudentModel model);
        public void DeteteStudentInfo(int id);

        public List<StudentDropDown> GetDeptType();


    }
}
