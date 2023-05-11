using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizPOG.Model
{
    public class Question
    {
        public string QuestContent { get; set; }
        public Answer Answer1 { get; set; }
        public Answer Answer2 { get; set; }
        public Answer Answer3 { get; set; }
        public Answer Answer4 { get; set; }
    }
}
