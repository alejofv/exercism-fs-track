module Leap

let leapYear (year: int): bool = 
    let divisible x y = x % y = 0

    divisible year 4 && (not (divisible year 100) || divisible year 400)