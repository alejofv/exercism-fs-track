module Bob

open System

let response (input: string): string = 
    let trimmed = input.Trim()

    let empty = String.IsNullOrWhiteSpace(trimmed)
    let question = trimmed.EndsWith("?")
    let yell = Seq.exists Char.IsLetter trimmed && trimmed = trimmed.ToUpperInvariant()

    if empty then "Fine. Be that way!"
    elif yell then
        if question then "Calm down, I know what I'm doing!"
        else "Whoa, chill out!"
    elif question then "Sure."
    else "Whatever."
