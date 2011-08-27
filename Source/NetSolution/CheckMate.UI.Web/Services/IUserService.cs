namespace CheckMate.UI.Web.Services
{
    public interface IUserService
    {
        bool Login(string username, string password);
        void CreateUser(string username, string password);
    }
}