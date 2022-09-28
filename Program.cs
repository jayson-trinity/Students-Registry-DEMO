using Students_Registry_DEMO.Data_Center;
using Students_Registry_DEMO.Models;
using Students_Registry_DEMO.Services;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        Database database = new Database();
        AccountServices accountServices = new AccountServices();
        Console.WriteLine("DEMO SCHOOLS");

        String options = " ";
        while (options != "0")
        {
            Console.WriteLine("What would u like to do?");
            Console.WriteLine(" 1: Register\n 2: Login\n 3: View all Students\n 4: find a student by ID\n 5: Remove a Student\n 6: Delete all Students\n ");
            Console.WriteLine("To exit program press 0 ");
            options = Console.ReadLine();
            switch (options)
            {
                case "1":
                    accountServices.RegisterUser();
                    break;
                case "2":
                    accountServices.LoginUser();
                    break;
                case "3":
                    accountServices.GetAll();
                    break;
                case "4":
                    accountServices.GetUserById();
                    break;
                case "5":
                    accountServices.DeleteUser();
                    break;
                case "6":
                    accountServices.ClearDb();
                    break;
                case "0":
                    options = "0";
                    Console.WriteLine("Good Bye");
                    Environment.Exit(0);
                    break;

            }
            


        }

    }
    
}