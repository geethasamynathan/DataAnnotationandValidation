using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataAnnotationandValidation.Common
{
    public class DateRangeAttribute : RangeAttribute
    {
        public DateRangeAttribute(string minimumval):base(typeof(DateTime),minimumval,DateTime.Now.ToShortDateString())
        {

        }
    }
}