using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatLichKhamBenh.Code
{
    public class Utilities
    {
        public static string IdTaiKhoanSessionLogonValue
        {
            get
            {
                object value = HttpContext.Current.Session["IdTaiKhoanSessionValue"];
                return value == null ? "" : (string)value;
            }
            set
            {
                HttpContext.Current.Session["IdTaiKhoanSessionValue"] = value;
            }
        }
    }
}