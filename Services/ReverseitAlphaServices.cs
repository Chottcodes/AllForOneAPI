using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOneAPI.Services
{
    public class ReverseitAlphaServices
    {
         public string reversestring(string input){
            string Emptyword="";
            for (int i = input.Length - 1; i >= 0; i--){
             Emptyword += input[i];
            }
                return Emptyword;
        }
    }
}