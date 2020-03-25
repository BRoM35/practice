using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _1212.Controllers
{
    [ApiController]
    [Route("numbers/{number}")]
    public class NumberController : ControllerBase
    {
      
        private static readonly string[] BasicNumbers = new[]
        {
            "ноль", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять",
            "десять", "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать"
        };

        private static readonly string[] DozensNumbers = new[]
        {
            "ноль", "десять", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто"
        };

        private static string GetNumber(int number)
        {
            var result = "";

            if (number / 1000000 > 0)
            {
                result += $"{GetNumber(number / 1000000)} миллион(-а, -ов) ";
                number %= 1000000;
            }

            if (number / 1000 > 0)
            {
                result += $"{GetNumber(number / 1000)} тысяч(-а, -и) ";
                number %= 1000;
            }

            if (number / 100 > 0)
            {
                result += $"{GetNumber(number / 100)} сто(-а, -и) ";
                number %= 100;
            }

            if (number > 0)
            {
                if (number > 20)
                {
                    result += $"{DozensNumbers[number / 10]} ";
                    number %= 10;
                }

                if (number < 20)
                {
                    result += BasicNumbers[number];
                }
            }

            return result;
        }

        [HttpGet]
        public string Get(int number) => number != 0 ? GetNumber(number) : "ноль";
    }
}