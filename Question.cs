using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Question
    { 

        public string Header_OF_Qestion { set; get; }
        public string Body_OF_Qestion {  get; set; }
        public int mark { set; get; }
        public List<Answers>  answers{ set; get; }= new List<Answers>();
        public  int Right_Answer_ID { set; get; }
        public int User_Answer_ID { set; get; }

        public  Question()
        {
            Header_OF_Qestion= string.Empty;
            Body_OF_Qestion = string.Empty;
            answers = new List<Answers>(5);
        }
        

        





    }
}
