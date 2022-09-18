namespace adventOfCode
{
    public class Submarine
    {

        public Position currentPosition {get; set;}

        public Submarine(Position position)
        {
            currentPosition = position;
        }

        public Position executeCommands(List<Command> commands)
        {            
            commands.ForEach(command => move(command));
            return currentPosition;
        }

        private void move(Command command)
        {
            if(command.direction == Command.move.up.ToString())
                {
                    //currentPosition.depth -= command.unit;   **part 1
                    currentPosition.aim -= command.unit;
                }
            else if(command.direction == Command.move.down.ToString())
                {
                    //currentPosition.depth += command.unit;   **part1
                    currentPosition.aim += command.unit;
                }
            else if(command.direction == Command.move.forward.ToString())
                {
                    currentPosition.horizontal += command.unit;
                    currentPosition.depth += currentPosition.aim * command.unit; //part 2
                }
        }
    }
}