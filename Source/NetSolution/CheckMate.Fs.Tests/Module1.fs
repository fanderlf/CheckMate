// Learn more about F# at http://fsharp.net

module Module1

open NaturalSpec

let invert x = x + 1

[<Scenario>]
let ``When the number is 2 it should return 3 - just a test to get NaturalSpec up and running``() =
    Given 2
    |> When invert
    |> It should equal 3
    |> Verify