using Students_Registry_DEMO.Models;

namespace Students_Registry_DEMO.Interfaces
{
    internal interface IAccountServices
    {
        void ClearDb();
        void DeleteUser();
        void GetAll();
        void GetUserById();
        void LoginUser();
       void RegisterUser();
    }
}