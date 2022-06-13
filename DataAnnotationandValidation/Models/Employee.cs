using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using DataAnnotationandValidation.Common;

namespace DataAnnotationandValidation.Models
{
    public class Employee
    {
        public Guid EmployeeId
        {
            get;
            set;
        }
        [Required (ErrorMessage ="Enter the FirstName")]
        [StringLength(15)]
        public string FirstName
        {
            get;
            set;
        }

        [Required]
        [StringLength(15,MinimumLength =2,ErrorMessage =" Lastname should cintain minimum 2 chars and max 15 chars")]
        public string LastName
        {
            get;
            set;
        }
        [Range(22,70,ErrorMessage ="Age should between 22 to 70")]
        public int Age
        {
            get;
            set;
        }
        [DateRange("1-1-2002",ErrorMessage ="dob bw 1-1-2000 to current date")]
       // [Range(typeof(DateTime),"1-1-1990", ErrorMessage =" DOB BW 1-1-1990 to 1-1-2005")]
        [DisplayFormat(DataFormatString ="{0:d}",ApplyFormatInEditMode =true)]
        public DateTime DateOfBirth
        {
            get;
            set;
        }
        [MinLength(5,ErrorMessage ="Address should contain min 5 chars")]
        [MaxLength(100, ErrorMessage = "Max length of the addrees should 100 chras")]
        public string Address
        {
            get;
            set;
        }
        public string Mobile
        {
            get;
            set;
        }

        public string PostalCode
        {
            get;
            set;
        }
        [Required(ErrorMessage ="Enter the Email")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
         @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
         @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",ErrorMessage ="Enter valid email id")]
        public string EmailId
        {
            get;
            set;
        }
        public string UserName
        {
            get;
            set;
        }
        [DataType(DataType.Password)]
        public string Password
        {
            get;
            set;
        }
        [DataType(DataType.Password)]
        public string ConfirmPassword
        {
            get;
            set;
        }
        [DataType(DataType.Url)]
        public string URL
        {
            get;
            set;
        }
    }
}