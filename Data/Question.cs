using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrehistoryMethodApp.Data
{
    public class Question
    {
        public List<Answer> Answers { get; set; }
        public string Text { get; set; }
        public string Advices { get; set; }

        public string WrongAnswer { get; set; }
    }
}
