﻿using CheckMate.Contracts.Services;

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
    }
}