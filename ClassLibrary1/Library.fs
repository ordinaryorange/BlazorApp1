namespace ClassLibrary1

open FSharp.Control



type Tester() =
    static member DoAsyncSeq () =
        task {
            let! x = AsyncSeq.init 10 id |> AsyncSeq.toAsyncEnum |> AsyncSeq.ofAsyncEnum |> AsyncSeq.length
            return x
        }
        
