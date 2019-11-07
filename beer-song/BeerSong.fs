module BeerSong

let count = function
    | 0 -> "no more"
    | n -> n.ToString()

let descriptor = function
    | 1 -> "bottle"
    | _ -> "bottles"

let sayBeers n =
    sprintf "%s %s of beer" (count n) (descriptor n)

let sayTakeDown = function
    | 0 -> "Go to the store and buy some more"
    | 1 -> "Take it down and pass it around"
    | n -> "Take one down and pass it around"

let capitalize (s :string) =
    match s.[0] with
    | 'n' -> "N" + s.[1..]
    | _ -> s

let sayVerse n = [
    sprintf "%s on the wall, %s." (capitalize (sayBeers n)) (sayBeers n)
    sprintf "%s, %s on the wall." (sayTakeDown n) (sayBeers (if n > 0 then n - 1 else 99))
]

let recite (startBottles: int) (takeDown: int) = 
    [startBottles .. -1 .. (startBottles - takeDown + 1)]
    |> List.map (sayVerse)
    |> List.reduce (fun acc s -> acc @ [""] @ s)