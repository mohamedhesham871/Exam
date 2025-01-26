using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Practical_Exam:Exam
    {
        mcq_Exam mcq_Exam = new mcq_Exam();
        //Enter Question for MCQ
        public void enter_MCQ()
        {
            mcq_Exam.enter_MCQ();

        }
        //Display Question (MCQ )for user and enter Answer for it

        public void Display_MCQ()
        {

            mcq_Exam.Display_Question_MCQ();
        }

        public  void display_pract()
        {
            foreach(var text in mcq_Exam.questions)
            {
                Console.WriteLine(text.Body_OF_Qestion);
                Console.WriteLine("Right answer is " + text.answers[text.Right_Answer_ID - 1].Answer_text);
              
            }
        }
    }
}
