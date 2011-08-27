namespace CheckMate.Services.Implementations

open CheckMate.Domain
open CheckMate.DataAccess.User
open CheckMate.DataAccess.RavenStore
open CheckMate.UI.Web.Services
open Raven.Client

type UserService()=
    interface IUserService with 
        member x.Login(username,password) =
            GetUserByUsername(username) |> MatchPassword password
        member x.CreateUser(username,password) =
            SaveUser {Id = null;Username = username; PasswordHash = HashPassword password}
