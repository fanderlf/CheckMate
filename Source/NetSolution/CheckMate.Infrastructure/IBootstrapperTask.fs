namespace CheckMate.Infrastructure.Bootstrapper

open LightCore

type IBootstrapperTask =
    abstract member Execute: IContainerBuilder -> unit

