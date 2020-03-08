module KindergartenGarden

type Plant = | Grass | Clover | Radishes | Violets

let plants (diagram: string) student = 
    let students = [ "Alice"; "Bob"; "Charlie"; "David"; "Eve"; "Fred"; "Ginny" ; "Harriet" ; "Ileana" ; "Joseph" ; "Kincaid" ; "Larry" ]
    let index = students |> List.findIndex (fun x -> x = student)

    diagram.Split [| '\n' |]
        |> List.ofArray // string [] -> string list
        |> List.map (fun str -> str.Substring(index * 2, 2)) // string list -> string list (only the student's garden)
        |> List.reduce (+) // string list -> string (XX+YY)
        |> List.ofSeq // string -> char list
        |> List.map (function
                        | 'G' -> Plant.Grass
                        | 'C' -> Plant.Clover
                        | 'R' -> Plant.Radishes
                        | 'V' -> Plant.Violets
                        | _ -> failwith "Unrecognized plant") // char list -> Plant list
