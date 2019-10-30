module Accumulate

let rec accumulate (func: 'a -> 'b) (input: 'a list): 'b list = 
    // So, I can't use List.map...
    match input with
    | [] -> []
    | first::other -> func first :: accumulate func other
