namespace Assignment2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName;
            double maths, physics, chemistry;

            Console.Write("Enter Student Name: ");
            studentName = Console.ReadLine();

            Console.Write("Enter Your Maths Mark: ");
            while (!double.TryParse(Console.ReadLine(), out maths))
            {
                if (maths < 0 || maths <= 100)
                {
                    Console.WriteLine("Mark Should be a positive integer!! Enter your Maths Mark: ");
                }
            }

            Console.Write("Enter Your Physics Mark: ");
            while (!double.TryParse(Console.ReadLine(), out physics))
            {
                if (physics < 0 || physics <= 100)
                {
                    Console.WriteLine("Mark Should be a positive integer!! Enter your Physics Mark: ");
                }
            }

            Console.Write("Enter Your Chemistry Mark: ");
            while (!double.TryParse(Console.ReadLine(), out chemistry))
            {
                if (chemistry < 0 || chemistry <= 100)
                {
                    Console.WriteLine("Mark Should be a positive integer!! Enter your Chemistry Mark: ");

                }
            }

            //calculating marks
            double totalMark1 = maths + physics + chemistry;
            double totalMark2 = maths + physics;

            //checking eligibility
            if ((maths >= 65 && physics >= 55 && chemistry >= 50) || (totalMark1 >= 180 || totalMark2 >= 140))
            {
                Console.WriteLine($"Congratulations {studentName}!! Eligible for Admission");
            }
            else
            {
                Console.WriteLine($"Sorry {studentName}!! Not Eligible for Admission");
            }

        }
    }
}
