using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOneAPI.Services
{
    public class ReverseItNumberServices
    {
         public string ReverseNumbers(string Number1){
            bool intValue = int.TryParse(Number1, out int newValue);
            if (intValue == false){
                return "Please Enter A number";
            }

             int temp, remainder, reverse = 0;
            temp = newValue;
            while (newValue > 0)
            {
                remainder = newValue % 10;
                reverse = reverse * 10 + remainder;
                newValue /= 10;
            }
            return $"Entered: {temp} Reversed: {reverse}";

        }
    }
}