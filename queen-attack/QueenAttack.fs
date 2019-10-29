module QueenAttack

let create (position: int * int) =
    match position with
    | x,_ when x < 0 || x > 7 -> false
    | _,y when y < 0 || y > 7 -> false
    | _ -> true

let canAttack (queen1: int * int) (queen2: int * int) = 
    match queen1, queen2 with
    | q1,q2 when q1 = q2 -> failwith "Two queens in the same space"
    | (x1,_),(x2,_) when x1 = x2 -> true
    | (_,y1),(_,y2) when y1 = y2 -> true
    | (x1,y1),(x2,y2) when abs (x1 - x2) = abs (y1 - y2) -> true
    | _ -> false