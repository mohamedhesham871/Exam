using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Exam
{
    internal class Subject
    {
        public int SubjectID {  get; set; }
        public string Name { get; set; }
        public string Tpye_OF_Exam { get; set; }// 1 practical  2 Final
        public void Create_Exam()
        {

            Final_Exam final = new Final_Exam();
            Practical_Exam pract = new Practical_Exam();
            int I_check = 0;// i use it to know if it prctiacl or final
            //Write all thing needed in Exam
            Console.WriteLine("enter 1 for final exam  2 for practical");

            string ?take_inpute = Console.ReadLine();
            {
                
                if (take_inpute == "1")
                {
                    Tpye_OF_Exam = "Final Exam";
                    bool ISint = false;
                    int x, y;
                    //Enter Time of Exam
                    do
                    {
                        Console.WriteLine("Enter Time OF Exam from (30 to 180)");
                        ISint = int.TryParse(Console.ReadLine(), out x);
                    } while (!ISint);
                    final.TimeOFExam = x;
                    //Enter Time Of Question
                    do
                    {
                        Console.WriteLine("Enter Number of Question");
                        ISint = int.TryParse(Console.ReadLine(), out y);
                    } while (!ISint || y < 0);
                    final.Number_Of_Question = y;

                    for (int i = 1; i <= final.Number_Of_Question; i++)
                    {
                        Console.WriteLine("Enter 1 for Mcq and 2 for (True and False)");

                        take_inpute = Console.ReadLine();
                        if (take_inpute == "1")
                        {
                            final.enter_MCQ();
                        }
                        else if (take_inpute == "2")
                        {
                            final.Enter_T_F();
                        }
                        else
                        {
                            Console.WriteLine("Invalid input");
                            return;
                        }
                    }
                    I_check = 1;
                }
                //if it's practial
                else if (take_inpute == "2")
                {
                    Tpye_OF_Exam = "Practical Exam";
                    bool ISint = false;
                    int x, y;
                    //Enter Time of Exam
                    do
                    {
                        Console.WriteLine("Enter Time OF Exam from (30 to 180)");
                        ISint = int.TryParse(Console.ReadLine(), out x);
                    } while (!ISint);
                    pract.TimeOFExam = x;
                    //Enter Time Of Question
                    do
                    {
                        Console.WriteLine("Enter Number of Question");
                        ISint = int.TryParse(Console.ReadLine(), out y);
                    } while (!ISint || y < 0);
                    pract.Number_Of_Question = y;

                    for (int i = 1; i <= pract.Number_Of_Question; i++)
                    {
                        Console.WriteLine("Enter  Mcq ");

                            pract.enter_MCQ();
            
                    }
                    I_check = 2;
                }
                Console.Clear();
                Console.WriteLine("If want start Exam (Y/N)");
                string ss = Console.ReadLine();
                if (ss == "Y")
                {
                    if (I_check == 1)
                    {
                        final.Display_MCQ();

                        final.Display_Question_T_OR_F();

                        final.display_mcq_result();
                        final.display_TF_reuslt();
                        Console.WriteLine(final);
                    }
                    else
                    {
                        pract.Display_MCQ();
                        pract.display_pract();
                    }
                }
                else return;
            }
           

        }

    }
}
/*
 * a. Subject Id.
b. Subject Name.
c. Exam of the subject.
d. We need to implement functionality to create the exam of the subject.
 */