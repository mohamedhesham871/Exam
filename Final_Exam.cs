using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Transactions;

namespace Exam
{
    internal class Final_Exam:Exam
    {
        public int Total_Mark = 0;
        public int count = 0;
        mcq_Exam mcq_Exam = new mcq_Exam();
        True_Or_False_Question True_Or_False = new True_Or_False_Question();

        public void enter_mcqOR_T(string x)
        {
            if (x == "1")
            {
                enter_MCQ();
            }
            else if (x == "2")
            {
                Enter_T_F();
            }
                
        }


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



        // enter True OR false 
        public void Enter_T_F()
        {
                True_Or_False.Enter_T_OR_F();
        } 
        //Dispaly for user
        public void Display_Question_T_OR_F()
        {
            True_Or_False.Dispaly_T_OR_F();
        }


        public void display_mcq_result()
        {
            mcq_Exam.display_mQ_result(ref Total_Mark,ref count);
        }
        public void display_TF_reuslt()
        {
            True_Or_False.display_T_reuslt(ref Total_Mark, ref count);
        }
        public override string ToString()
        {
            return $"you got {Total_Mark} of {count}";
        }
    }
}
