using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Exam
{
    internal class True_Or_False_Question : Question
    {

        public List<Question> questions { get; set; } = new List<Question>();
        bool Cheak_Input_Int = false;
        private int[] Arr_OF_Rigth_Answer = new int[100];//Exam ==> number of Question
        private int input_int = 0;
        int Z;
        int sum_Right_answer = 0;

        public void Enter_T_OR_F()
        {
            Cheak_Input_Int = false;
            Console.WriteLine("Please Enter Question Body");
            string Adim_input = Console.ReadLine();
            do
            {
                Console.WriteLine("Please Enter Question Mark");
                Cheak_Input_Int = int.TryParse(Console.ReadLine(), out Z);
            } while (!Cheak_Input_Int || (Z < 0));

            Question test = new Question();
            //Answers of Question
            Console.WriteLine("enter 1 for true 2 for false ");
            string inp= Console.ReadLine();
            if (inp == "1")
                Right_Answer_ID = 1;
            else
               Right_Answer_ID=2;

            
            questions.Add(test);
        }


        public void Dispaly_T_OR_F()
        {
            int g;
            foreach (var test in questions)
            {
                Cheak_Input_Int = false;
                Console.WriteLine(test.Header_OF_Qestion);
                Console.WriteLine(test.Body_OF_Qestion);
              

                do
                {
                    Console.WriteLine("Enter Your Answer 1 for True 2 for false");
                    Cheak_Input_Int = int.TryParse(Console.ReadLine(), out  g);
                   
                } while (!Cheak_Input_Int || (g < 1) );
                test.User_Answer_ID = g;
            }
        }


        public void display_T_reuslt(ref int total,ref int count)
        {
            foreach (var text in questions)
            {
                Console.WriteLine(text.Body_OF_Qestion);

                Console.WriteLine("Your answer is 1 mean True 2 mean false " + text.User_Answer_ID);
                Console.WriteLine("Right answer is  1 mean True 2 mean false " + text.Right_Answer_ID );

                if ((text.User_Answer_ID ) == (text.Right_Answer_ID))
                    total += text.mark;

                count += text.mark;

            }
           
        }

    }
}
