namespace CheckMate.Services.Implementations

open CheckMate.Domain
open CheckMate.DataAccess.User
open CheckMate.DataAccess.RavenStore

type IUserService =
    abstract member Login: string -> string -> bool
    abstract member CreateUser: string -> string -> unit

type UserService()=
    interface IUserService with 
        member x.Login username password =
            //GetUserByUsername(username) |> MatchPassword password
            username = "florian" && password = "12"
        member x.CreateUser username password  =
            SaveUser {Id = null;Username = username; PasswordHash = HashPassword password}
