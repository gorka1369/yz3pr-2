using System;
using System.Text.RegularExpressions;

namespace yz3pr_2
{
    class Program
    {
        static bool IsPhone(string s)
        {
            return Regex.IsMatch(s, @" ^\+7[\s\(]?{ 3}[\s\)]? [\s\-]?d{3}[\-\s]?\d{2}[\-\s]?\d{2}$");
        }
        static bool IsZip(string s)
        {
            return Regex.IsMatch(s, @" ^\d{5}(\-\d{4})?$");
        }
       
        static string ReformatPhone(string s)
        {
            Match m = Regex.Match(s, @"^\(?(\d{3})\)?[\s\-]?(\d{3})\-?(\d{4})$"); return
                string.Format("({0}) {1}-{2}", m.Groups[1], m.Groups[2], m.Groups[3]);
        }
         static void Main(string[] args) {
            string[] text = {"+7(926)269-25-11","11144455785",
        "996578484",
        "+7 926 269 22 1 1"};

            //Console.WriteLine(IsPhone(Console.ReadLine()));
            foreach (string s in text)
            {
                if (IsPhone(s)) Console.WriteLine(ReformatPhone(s) + "telefon nomer");
                else
                    if (IsZip(s))
                    Console.WriteLine(s + "eto zip code ");
                else Console.WriteLine(s + "neponyatno");
            }
        }
    }
}
