namespace CheckMate.Services.Implementations

open CheckMate.Contracts.Services

type UserService() =
    interface IUserService with 
        member x.Login(username,password) =
            true



