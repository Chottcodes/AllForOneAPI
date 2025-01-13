using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOneAPI.Services
{
    public class AddingTwoNumbersServices
    {
        public string AdddingNumbers(string Number1, string Number2)
        {

            bool validnum1 = int.TryParse(Number1, out int num1);
            bool validnum2 = int.TryParse(Number2, out int num2);
            int sum = num1 + num2;
            if (!validnum1 || !validnum2)
            {
                return "Please Enter Numbers";
            }
            return $"The Sum of {num1} plus {num2} is {sum}.";
        }
    }
}