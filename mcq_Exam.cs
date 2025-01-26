using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class mcq_Exam:Question
    {
        
        public List<Question> questions { get; set; } = new List<Question>();
        bool Cheak_Input_Int = false;
        //Exam ==> number of Question
        private int input_int = 0;
        int x, y;

        public void enter_MCQ()
        {
            Cheak_Input_Int = false;
            Console.WriteLine("Please Enter Question Body");
            string Adim_input = Console.ReadLine();
            do
            {
                Console.WriteLine("Please Enter Question Mark");
                Cheak_Input_Int = int.TryParse(Console.ReadLine(), out x);
            } while (!Cheak_Input_Int || (x < 0));

            Console.WriteLine("Enter Choices of Question");
            Question test = new Question();//enter answers of question
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Please Enter Choice {i + 1}:");
                string choiceText = Console.ReadLine();

                test.answers.Add(new Answers { Answer_ID = i +1, Answer_text = choiceText });
            }

            Cheak_Input_Int = false;
            do
            {
                Console.WriteLine("Enter Right Answer ID");
                Cheak_Input_Int = int.TryParse(Console.ReadLine(), out y);
            } while (!Cheak_Input_Int || (y < 0));

            test.Header_OF_Qestion = Adim_input;
            test.mark = x;
            test.Right_Answer_ID = y;
            questions.Add(test);

        }
        //Display For user
        public void Display_Question_MCQ()
        {
            int g;
            foreach (var test in questions)
            {
                Cheak_Input_Int = false;
                Console.WriteLine(test.Header_OF_Qestion);
                Console.WriteLine(test.Body_OF_Qestion);
                foreach (var Q in test.answers)
                {
                    Console.WriteLine(Q.Answer_text);
                }

                do
                {
                    Console.WriteLine("Enter Your Answer ID");
                    Cheak_Input_Int = int.TryParse(Console.ReadLine(), out  g);
                } while (!Cheak_Input_Int || (x < 0));
                test.User_Answer_ID = g;

            }
        }
        public void display_mQ_result(ref int tota,ref int coun)
        {
            foreach (var text in questions)
            {

                Console.WriteLine(text.Body_OF_Qestion);
                Console.WriteLine("Your answer is " + text.answers[text.User_Answer_ID - 1].Answer_text);
                Console.WriteLine("Right answer is " + text.answers[text.Right_Answer_ID - 1].Answer_text);

                if ((text.User_Answer_ID - 1) == (text.Right_Answer_ID - 1))
                    tota += text.mark;

                coun += text.mark;

            }
           
        }
    }
}
