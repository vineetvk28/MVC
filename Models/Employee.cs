﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Jitendra_Joshi_Assignment.Models
{
        public class Employee
        {
            [Display(Name = "First Name")]
            //[Required(ErrorMessage = "First Name is Reqiured")]
            public string FirstName { get; set; }
            [Display(Name = "Last name")]
           // [Required(ErrorMessage = "Last name is Required")]
            public string LastName { get; set; }
            [Display(Name = "Years of Experience")]
           // [Range(2, 20, ErrorMessage = "Experience must be of 2 years and maximum of 20 Years")]
            public int YearsOfExperience { get; set; }
            public int EmployeeCode { get; set; }
            [EmailAddress(ErrorMessage = "Email address is invalid")]
            [Required(ErrorMessage = "Email is Required")]
             public string Email { get; set; }
            [DataType(DataType.PhoneNumber)]
            [RegularExpression(@"\(?\d{3}\)?[-\.]? *\d{3}[-\.]? *[-\.]?\d{4}", ErrorMessage = "Phone number is invalid")]
            public int PhoneNumber { get; set; }
        }
    }