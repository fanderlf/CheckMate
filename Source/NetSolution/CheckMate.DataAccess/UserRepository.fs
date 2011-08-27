module CheckMate.DataAccess.User

open CheckMate.Domain
open Raven.Client.Document

let GetUserByUsername username =
    {Username= "florian"; PasswordHash= "1234"}
    