using System;
using System.Collections.Generic;
using System.Text;

namespace RegexPattern
{
    /*
    ^ -             is starting pointing of regex pattern.
    $ -             ending point of regex pattern.
    [0-9a-zA-Z] brackets can be used to mention permissible.
    \+
    \s                 to have a whitespace
    |                   or pattern
    []{3}              permissible charactors with 3 count
      []{3,}          permissible charactors atleast 3 times
    []{3,10}        min 3 chars and max 10
    *	*?	            Used to match the preceding character zero or more times.
+	+?	            Used to match the preceding character one or more times.
?	??	                Used to match the preceding character zero or one time.
{n}	{n}?	        Used to match the preceding character exactly n times.
{n, }	{n, }?	    Used to match the preceding character at least n times.
{n, m}	{n, m}?	Used to match the preceding character from n to m times.
     */
    public class Patterns
    {
        public static string PinCodePattern = "^[0-9]{6}$";
        /*
         //   Format                Pattern
        // xxxxxxxxxx           ^[0 - 9]{ 10}$
        // xxx - xxxx - xxxx   ^[0 - 9]{ 3} -[0 - 9]{ 4}-[0 - 9]{ 4}$
         */
        public static string PhoneNumberPattern = @"(^[0-9]{10}$)|(^[0-9]{3}-[0-9]{4}-[0-9]{4}$)";

        // ashok.andani007@gmail.com
        public static string EmailPattern = @"[a-z]{3,7}.?[a-z0-9]{3,8}@[a-z]{3,8}.(com|org)$";
    }
}
