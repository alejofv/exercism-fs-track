module GradeSchool

type School = Map<int, string list>

let empty: School = School []

let grade (number: int) (school: School): string list = 
    match Map.tryFind number school with
    | Some x -> x
    | None -> []
    |> List.sort

let roster (school: School): string list = 
    school
    // Map.map "replaces" the values and returns a new Map
    |> Map.map (fun _ roster -> List.sort roster)
    |> Map.toList
    |> List.collect (fun (_,roster) -> roster)

let add (student: string) (number: int) (school: School): School = 
    // We don't care for sorting here, so simply add the student to the beginning :D
    let roster = student :: (grade number school)
    Map.add number roster school