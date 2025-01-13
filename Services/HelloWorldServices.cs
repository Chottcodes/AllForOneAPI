using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOneAPI.Services
{
    public class HelloWorldServices
    {
        public string SayHello (string Name)
        {
            return $"Hello {Name}, Nice To Meet You";
        }
    }
}