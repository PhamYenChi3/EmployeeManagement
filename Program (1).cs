using System;
namespace EmployeeInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("INPUT INFORMATION\n=======================");
                Console.Write("\nEnter ID: ");
                string id = Console.ReadLine();

                Console.WriteLine("\nEnter First Name: ");
                string firstName = Console.ReadLine();

                Console.WriteLine("\nEnter Last Name");
                string lastName = Console.ReadLine();

                Console.WriteLine("\nEnter Email");
                string email = Console.ReadLine();

                Console.WriteLine("\nEnter Phone Number: ");
                string phone = Console.ReadLine();

                Console.Write("\nEnter Date of Birth(mm/dd/yyyy");
                DateTime dateofBirth = Convert.ToDateTime(Console.ReadLine());

                Console.Write("\nJoining DAte(mm/dd/yyyy");
                DateTime JoiningDateTime = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("\nDESIGNATIONS:\n=======================" +
                    "\n1.Ceo\n2.President\n3.SoftwareEngineer\n4.TrainingEngineer\n5.ProjectManager" +
                    "\n6.SystemEngineer\n7.WebDeveloper\n8.QualityAnalyst");
                Console.Write("\nInput any one serial number of the desginations given above: ")
                    int deg = Int32.Parse(Console.ReadLine());

                Employee anEmployee = new Employee(id, firstName, lastName, email, phone, dateofBirth, JoiningDateTime, deg);
                Console.Write()

            }
        }
    }
}
