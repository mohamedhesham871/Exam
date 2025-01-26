namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();
            Console.WriteLine("Enter Subject ID");
            int input = 0;
            bool flag = false;
            do
            {
                flag = int.TryParse(Console.ReadLine(), out input);

            }while(!flag);
            subject.SubjectID =input;
            Console.WriteLine("Enter Subject name");
            subject.Name = Console.ReadLine();
            subject.Create_Exam();
        
            

        }
    }
}
