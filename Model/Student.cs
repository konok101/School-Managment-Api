﻿using System.ComponentModel.DataAnnotations;

namespace School_Managment.Model
{
    public class Student
    {
        public int Id { get; set; }

        public string? name {  get; set; }
      
         public int? student_id { get; set; }
       // public float? cgpa{  get; set; }
        public int? roll {  get; set; }
       public string? performance { get; set; }

    }
}
