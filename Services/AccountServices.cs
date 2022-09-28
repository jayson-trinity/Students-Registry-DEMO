using Students_Registry_DEMO.Data_Center;
using Students_Registry_DEMO.Interfaces;
using Students_Registry_DEMO.Models;

namespace Students_Registry_DEMO.Services
{
    internal class AccountServices : IAccountServices
    {
        
        Database db = new Database();
        public void RegisterUser()
        {
            StudentModel std = new StudentModel();

            Console.WriteLine("Enter Firstname");
            std.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Lastname");
            std.LastName = Console.ReadLine();
            Console.WriteLine("Enter Email");
            std.Email = Console.ReadLine();
            Console.WriteLine("Enter Password");
            std.Password = Console.ReadLine();
            std.Id = db.NoOfStudent() + 1;

            var regStd = db.AddStudent(std);
            if (regStd)
            {
                Console.WriteLine("Registered");
            }
            else
            {
                Console.WriteLine("Error Occured");
            }
            return;
        }

        public void LoginUser()
        { 
            LoginModel login = new LoginModel();
            Console.WriteLine("Enter Email"); 
            login.Email = Console.ReadLine();
            Console.WriteLine("Enter password");
            login.Password = Console.ReadLine();
            var logCheck = db.RegCheck(login.Email, login.Password);
            if (logCheck != null)
            {
                Console.WriteLine("Login Successful");
                return; 
            }
            Console.WriteLine("incorrect username or password");
            
        }

        public void GetAll()
        {
            var l = db.GetAllStudents();
            Console.WriteLine("All Students\n");
            foreach (var student in l)
            {
                
                Console.WriteLine($" {student.Id}. | {student.FirstName} {student.LastName} | {student.Email}");
                //Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            }
        }

        public void DeleteUser()
        {
            try
            {
                Console.WriteLine("Enter User Id");
                int id = int.Parse(Console.ReadLine());
                var res = db.RemoveStudent(id);
                if (res)
                {
                    Console.WriteLine("Student Deleted");
                    return;
                }
                Console.WriteLine("student not found");
            }
            catch (Exception)
            {
                Console.WriteLine("invalid id");
                DeleteUser();
            }

        }

        public void GetUserById()
        {
            try
            {
                Console.WriteLine("Enter User Id");
                int id = int.Parse(Console.ReadLine());
                var student = db.GetStudent(id);
                if (student != null)
                {
                    Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine($"{student.Id} | {student.FirstName} {student.LastName} | {student.Email} | {student.Email}");
                    Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------");

                }
                Console.WriteLine("student not found");
            }
            catch (Exception)
            {
                Console.WriteLine("invalid id");
                GetUserById();
            }
        }

        public void ClearDb()
        {
            db.ClearDatabase();
        }
    }
}
