using DataAccessLibrary.Model;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Repository
{
    public class StudentInfo : IStudentInfo
    {

        private readonly Context _Context;
    
        public StudentInfo(Context context)
        {
            _Context = context;
        }
        void IStudentInfo.DeteteStudentInfo(int id)
        {
            throw new NotImplementedException();
        }

      public   List<StudentModel> GetAllStudentInfo()
        {
            try
            {
                var res = _Context.studentInfo.FromSqlRaw($"exec dbo.GetAllStudentInfo").ToList();
                return res;
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            catch(Exception ex)
            {
                throw ex;
            }
         
        }

      public  List<StudentDropDown> GetDeptType()
        {
            try
            {
                var res= _Context.studentDropDown.FromSqlRaw<StudentDropDown>($"exec dbo.GetDept").ToList();
                return res;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        StudentModel IStudentInfo.GetStudentById(int id)
        {
            throw new NotImplementedException();
        }

      public   void InsertStudentInfo(StudentModel model)
        {
            try
            {
                _Context.Database.ExecuteSqlRaw($"EXEC DBO.InsertStudentInfo '{model.Name}','{model.Dept}','{model.DOB}'");

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void IStudentInfo.UpdateStudentInfo(StudentModel model)
        {
            throw new NotImplementedException();
        }
    }
}
