namespace CheckMate.Infrastructure.Bootstrapper

open LightCore
open System
open System.Reflection

type IBootstrapperTask =
    abstract member Execute: IContainerBuilder -> unit

type Bootstrapper(containerBuilder:IContainerBuilder) =
    let containerBuilder = containerBuilder
    member x.ExecuteBootstrapperTasks (assembly:Assembly) =
        assembly.GetTypes() 
            |> Seq.filter (fun t -> t.GetInterface("IBootstrapperTask") <> null)
            |> Seq.map (fun t ->  Activator.CreateInstance(t) :?> IBootstrapperTask) 
            |> Seq.iter (fun i -> i.Execute(containerBuilder))

