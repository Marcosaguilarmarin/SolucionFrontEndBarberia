namespace FrontEndBarberia.Controllers

open System
open System.Collections.Generic
open System.Linq
open System.Threading.Tasks
open Microsoft.AspNetCore.Mvc
open Microsoft.Extensions.Logging

type ServiciosController (logger : ILogger<ServiciosController>) =
    inherit Controller()



    member this.Error () =
        this.View();

    member this.Servicios ()=
        this.View();