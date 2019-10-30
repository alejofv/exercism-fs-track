module QueenAttack

let create (position: int * int) =
    let inBoard x = x >= 0 && x <= 7

    let x,y = position
    inBoard x && inBoard y

let canAttack (queen1: int * int) (queen2: int * int) = 
    let sameRowCol (x1,y1) (x2,y2) = x1 = x2 || y1 = y2
    let diagonal (x1,y1) (x2,y2) = abs (x1 - x2) = abs (y1 - y2)

    match queen1, queen2 with
    | q1,q2 when q1 = q2 -> failwith "Two queens in the same space"
    | q1,q2 -> sameRowCol q1 q2 || diagonal q1 q2
    | _ -> false