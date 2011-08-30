using CheckMate.Infrastructure.Bootstrapper;
using CheckMate.Services.Implementations;
using CheckMate.UI.Web.Fakes;
using LightCore;

namespace CheckMate.UI.Web.Bootstrapper
{
    public class WebUiBootstrapperTask:IBootstrapperTask
    {
        public void Execute(IContainerBuilder containerBuilder)
        {
            //containerBuilder.Register<IUserService, UserService>();
        }
    }
}