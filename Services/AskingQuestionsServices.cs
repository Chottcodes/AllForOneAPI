using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOneAPI.Services
{
    public class AskingQuestionsServices
    {
        public string AskingQuestion(string Name, int Time)
        {
            return $"Hello {Name}, You woke Up at {Time}";
        }

    }
}