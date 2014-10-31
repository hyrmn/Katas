#r "FsUnit.NUnit.dll"
#r "nunit.framework.dll"

open NUnit.Framework
open FsUnit

[<TestFixture>] 
type ``Given that I want to fizzbuzz it all up in this joint`` () =
    [<Test>] member x.``When I fizzbuzz 3 I get fizz back`` () = 1 |> should equal 2;;