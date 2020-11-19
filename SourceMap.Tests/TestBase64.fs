module Tests

open System
open FsUnit
open Xunit
open SourceMap.Base64

[<Fact>]
let ``test out of range encoding`` () =
    (fun () -> encode -1 |> ignore) |> should throw typeof<ArgumentException>
    (fun () -> encode 64 |> ignore) |> should throw typeof<ArgumentException>

[<Fact>]
let ``test normal encoding and decoding`` () =
    for i = 0 to 63 do
        encode i |> ignore