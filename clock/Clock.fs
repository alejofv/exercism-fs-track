module Clock

let toMinutes (hour,minutes) = hour * 60 + minutes
let toClock totalMinutes =
    match ((totalMinutes / 60) % 24, totalMinutes % 60) with
    | (h,m) when h >= 0 && m >= 0 -> (h,m)
    | (h,m) when h > 0 && m < 0 -> (h - 1,60 + m)
    | (h,m) when h < 0 && m >= 0 -> (24 + h,m)
    | (h,m) when h <= 0 && m < 0 -> (24 + h - 1,60 + m)
    | _ -> failwith "Unrecognized hour"

let create hours minutes = 
    (hours, minutes) |> toMinutes |> toClock

let add minutes clock = 
    (toMinutes clock) + minutes |> toClock

let subtract minutes clock = 
    (toMinutes clock) - minutes |> toClock

let display clock = 
    let (hours,minutes) = clock
    sprintf "%02i:%02i" hours minutes