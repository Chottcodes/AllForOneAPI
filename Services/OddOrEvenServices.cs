using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOneAPI.Services
{
    public class OddOrEvenServices
    {
        public string OddOrEvenResult(string Number1)
        {
         bool intValue = int.TryParse(Number1, out int newValue);

         if(intValue == false){
            return "Please Enter A Number";
         }

            if (newValue % 2 == 0)
            {
                return $"{newValue} is even";
            }
            else
            {
                return $"{newValue} is odd";
            }
        }
    }
}