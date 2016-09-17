open System
open FSharp.Core

type FB = | Fizz | Buzz | FizzBuzz

let fizz x = 
    x % 3 = 0

let buzz x =
    x % 5 = 0

let testFizzBuzz x = 
    match x with
    | _ when fizz x && buzz x -> Some(FizzBuzz)
    | _ when buzz x -> Some(Buzz)
    | _ when fizz x -> Some(Fizz)
    | _ -> None

let fizzBuzzString x =
    match x with
        | Fizz -> "fizz"
        | Buzz -> "buzz"
        | _ -> "FizzBuzz"

let printFizzBuzz x =
    let result = 
        match (testFizzBuzz x) with 
        |Some(y) -> fizzBuzzString y
        |_ -> x.ToString()
    printfn "%d : %s" x result

//some "basic" unit tests
[0;1;3;5;15] |> Seq.iter printFizzBuzz

[1..100] 
|> Seq.iter printFizzBuzz
