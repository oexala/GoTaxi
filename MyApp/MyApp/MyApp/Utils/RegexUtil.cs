using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MyApp.Utils
{
    public class RegexUtil
    {
        public static Regex ValidEmailAddress()
        { 
            return new Regex(@"^[\w -\.] +@([\w -] +\.) +[\w -]{ 2,4}$");
        }

    }
}
