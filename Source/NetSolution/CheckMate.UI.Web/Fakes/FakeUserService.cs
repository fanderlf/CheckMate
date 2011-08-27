using CheckMate.UI.Web.Services;

namespace CheckMate.UI.Web.Fakes
{
    public class FakeUserService:IUserService
    {
        public bool Login(string username, string password)
        {
            if (username == "florian" && password == "1234")
                return true;

            return false;
        }

        public void CreateUser(string username, string password)
        {
            throw new System.NotImplementedException();
        }
    }
}