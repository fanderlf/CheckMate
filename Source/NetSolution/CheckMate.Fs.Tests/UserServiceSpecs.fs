// Learn more about F# at http://fsharp.net

module UserServiceSpecs

open NaturalSpec
open CheckMate.Services
open CheckMate.Contracts.Services
open CheckMate.Services.Implementations

let canLoginUser username password = (username = "florian" && password = "1234")

let userService = new UserService(canLoginUser)

let logging_in_as_user (username:string) (password:string) (service:IUserService) =
    service.Login(username,password)

[<Scenario>]
let ``When I ask the User Service to login a User with correct crendentials it``() =
    As userService
    |> When logging_in_as_user "florian" "1234" 
    |> It should equal true
    |> Verify