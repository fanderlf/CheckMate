module CheckMate.DataAccess.RavenStore

open Raven.Client.Document

let store = new DocumentStore()

let initStore =
    store.Url <- "http://localhost:8080"
    store.Initialize


