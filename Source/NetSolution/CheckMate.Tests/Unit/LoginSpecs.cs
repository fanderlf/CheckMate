using System.Web.Mvc;
using CheckMate.Contracts.Services;
using CheckMate.UI.Web.Controllers;
using CheckMate.UI.Web.Models;
using Machine.Fakes;
using Machine.Specifications;

namespace CheckMate.Tests.Unit
{
    [Subject(typeof(UserController))]
    public class When_login_submitting_valid_login_data:WithSubject<UserController>
    {
        private Establish it = () => The<IUserService>().WhenToldTo(x => x.Login("testuser", "1234")).Return(true);

        private Because of = () =>
        {
            var userLoginViewModel = new UserLoginViewModel()
                                     {
                                         Username = "testuser",
                                         Password = "1234"
                                     };

            _result = Subject.Login(userLoginViewModel);
        };

        private It should_redirect_to_user_homepage = () =>
        {
            var redirect = (RedirectToRouteResult) _result;
            redirect.RouteValues["action"].ShouldEqual("Home");
        };

        private static ActionResult _result;
    }

    [Subject(typeof(UserController))]
    public class When_going_to_the_login_page:WithSubject<UserController>
    {
        private Establish it = () => { };

        private Because of = () =>
        {
            _result = Subject.Login();
        };

        private It should_show_an_empty_data_to_the_user = () =>
        {
            var redirect = (ViewResult) _result;
            var userLoginViewModel = (UserLoginViewModel) redirect.Model;
            userLoginViewModel.Username.ShouldBeEmpty();
            userLoginViewModel.Password.ShouldBeEmpty();
            
        };

        private static ActionResult _result;
    }

}