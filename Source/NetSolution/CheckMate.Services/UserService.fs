namespace CheckMate.Services.Implementations

open CheckMate.Contracts.Services

type UserService(canLoginUser) =
    let canLoginUser = canLoginUser

    interface IUserService with 
        member x.Login(username,password) =
            canLoginUser username password