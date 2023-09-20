using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Model
{
 public    class StudentModel
    {
        public StudentModel()
        {
            Type =  new List<StudentDropDown>();
        }
        
        [Key]
       public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Dept { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [NotMapped]
        public List<StudentDropDown> Type { get; set; }


    }
}
