using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace MVC5HomeWork.Models.Validations
{
    public class 手機格式驗證Attribute : DataTypeAttribute
    {
        private static Regex _regex = new Regex(@"\d{4}-\d{6}", RegexOptions.IgnoreCase);

        public 手機格式驗證Attribute() : base(DataType.Text)
        {
            this.ErrorMessage = "手機格是不正確";
        }

        public override bool IsValid(object value)
        {
            if (value == null) { return true; }
            string str = Convert.ToString(value);
            return str != null && _regex.Match(str).Length > 0;
        }
    }
}