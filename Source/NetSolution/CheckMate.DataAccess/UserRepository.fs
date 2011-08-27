module CheckMate.DataAccess.User

open CheckMate.Domain
open Raven.Client
open Raven.Client.Document


let store = new DocumentStore()
store.Url <- "http://localhost:8080"
store.Initialize() 

let session = store.OpenSession()

let GetUserByUsername username =
    session.Load "users/1"

let SaveUser user =
    session.Store user
    session.SaveChanges()