module RobotSimulator

type Direction = North | East | South | West
type Position = int * int
type Robot = { direction: Direction; position: Position }

let create direction position = { direction = direction; position = position }

let turnLeft  = function | North -> West | West -> South | South -> East | East -> North
let turnRight = function | North -> East | East -> South | South -> West | West -> North

let advance { direction = direction; position = (x,y) } =
    match direction with
    | North -> (x, y + 1)
    | South -> (x, y - 1)
    | East -> (x + 1, y)
    | West -> (x - 1, y)

let parse robot instruction = 
    match instruction with
    | 'A' -> { robot with position = advance robot }
    | 'R' -> { robot with direction = turnRight robot.direction }
    | 'L' -> { robot with direction = turnLeft robot.direction }
    | _ -> robot

let move instructions robot = 
    instructions
    |> Seq.fold parse robot
