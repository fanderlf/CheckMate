namespace CheckMate.Services

open CheckMate.Infrastructure.Bootstrapper
open CheckMate.Services.Implementations
open LightCore

type ServicesBootstrapperTask() =
    interface IBootstrapperTask with
        member x.Execute (containerBuilder:IContainerBuilder) =
            containerBuilder.Register<IUserService,UserService>() |> ignore

