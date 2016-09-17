
open System
(* giacomo parmigiani *)
open FSharp.Core

let fizz x = 
    x % 3 = 0

let buzz x =
    x % 5 = 0

let testFizzBuzz x = 
    match x with
    | _ when fizz x && buzz x -> "fizzBuzz"
    | _ when buzz x -> "buzz"
    | _ when fizz x -> "fizz"
    | _ -> x.ToString()

[1..100] 
|> Seq.iter (fun n -> printfn "%s" (testFizzBuzz n))
