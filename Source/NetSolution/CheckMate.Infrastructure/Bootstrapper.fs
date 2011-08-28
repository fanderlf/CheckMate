namespace CheckMate.Infrastructure.Bootstrapper

open LightCore
open System
open System.Reflection

type IBootstrapperTask =
    abstract member Execute: IContainerBuilder -> unit

type Bootstrapper() =
    let containerBuilder = new ContainerBuilder()
    member x.ExecuteBootstrapperTasks assemblyName =
        let assembly = Assembly.LoadFile assemblyName
        let tasks = assembly.GetTypes() |> Seq.filter (fun t -> t.GetInterface("IBootstrapperTask") <> null)
        tasks |> Seq.map (fun t -> Activator.CreateInstance(t) :?> IBootstrapperTask) |> Seq.iter (fun i -> i.Execute(containerBuilder))

