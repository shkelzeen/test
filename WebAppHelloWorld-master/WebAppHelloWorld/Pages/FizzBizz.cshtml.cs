using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppHelloWorld.Pages
{
    public class FizzBizzModel : PageModel
    {
        public string Message { get; private set; } = "PageModel in C#";
        public List<string> Numbers { get; private set; } = new List<string>();
        public int Number { get; private set; } = 100;
        public void OnGet()
        {
            Message = GetFizzBizz(Number);
            Numbers = Message.Split(Environment.NewLine, StringSplitOptions.None).ToList();
        }
        private string GetFizzBizz(int number)
        {
            string line = string.Empty;
            StringBuilder sbuild = new StringBuilder();

            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0)
                    line = "Fizz";
                if (i % 5 == 0)
                    line += "Buzz";
                if (string.IsNullOrEmpty(line))
                    line = $"{i}";

                sbuild.AppendLine(line);
                line = string.Empty;
            }
            return sbuild.ToString();
        }

    }
}