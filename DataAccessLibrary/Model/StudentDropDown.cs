﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Model
{
  public   class StudentDropDown
    {

        [Key]

        public int Id { get; set; }

        public string Dept { get; set; }
    }
}
