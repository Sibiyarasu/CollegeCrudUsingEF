using DataAccessLibrary.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccessLibrary
{
    public class Context :DbContext
    {
        public Context(DbContextOptions options):base(options)
        {

        }

        public DbSet<StudentModel> studentInfo { get; set; }
        public DbSet<StudentDropDown> studentDropDown { get; set; }
    }
}
