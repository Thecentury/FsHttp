
namespace FsHttp

open System

[<AutoOpen>]
module Config =

    let mutable internal defaultTimeout:TimeSpan = TimeSpan.FromSeconds 10.0

    let setTimeout (timeout:TimeSpan) =
        if timeout.TotalMilliseconds <= 0.0 then failwith "Negative timeout given."
        defaultTimeout <- timeout