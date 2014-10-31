#r "FsUnit.NUnit.dll"
#r "nunit.framework.dll"

open NUnit.Framework
open FsUnit

let fizzbuzz number = 
    let divisibleBy modulus = (number % modulus) = 0
    match divisibleBy 3, divisibleBy 5 with
        | true,  false -> "fizz"
        | false, true -> "buzz"
        | true,  true -> "fizzbuzz"
        | false, false -> sprintf "%d" number

[<TestFixture>] 
type ``Given that I want to fizzbuzz it all up in this joint`` () =
    [<Test>] member x.``When I fizzbuzz 3 I get fizz back`` () = 1 |> should equal 2;;