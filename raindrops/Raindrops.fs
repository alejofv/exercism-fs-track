module Raindrops

let convert (number: int): string = 
    let factors = [(3,"Pling");(5,"Plang");(7,"Plong")]

    let hasFactor n f = n % f = 0

    let rainspeak =
        factors
        |> List.filter(fun (f,w) -> hasFactor number f)
        |> List.map(fun (f,w) -> w)

    match rainspeak with
    | [] -> number.ToString()
    | _ -> List.fold(+) "" rainspeak