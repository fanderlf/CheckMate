namespace CheckMate.Services.Implementations

open CheckMate.Domain
open CheckMate.DataAccess.User
open  CheckMate.UI.Web.Services

type UserService() =
    interface IUserService with 
        member x.Login(username,password) =
            GetUserByUsername(username) |> MatchPassword password