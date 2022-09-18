using System;

namespace adventOfCode
{
    public class Program
    {
        const string _fileInputDay1 = "day1/input.txt";
        const string _fileInputDay2 = "day2/input.txt";

        public static void Main(string[] args)
        {
            //day1
            int[] data1 = GetInput.ReadFile(_fileInputDay1).ToIntArray();

            DepthMeasurement m = new DepthMeasurement(data1);
            string day1part1Result = m.CountDeptIncrease(1).ToString();
            string day1part2Result = m.CountDeptIncrease(3).ToString();

            Console.WriteLine($"Day1 part1 :{day1part1Result}");
            Console.WriteLine($"Day1 part2 :{day1part2Result}");

            //day2
            List<Command> commands = GetInput.ReadFile(_fileInputDay2).ToDriveCommands();
            Submarine mySub = new Submarine(new Position { horizontal = 0, depth = 0, aim=0});
            Position position = mySub.executeCommands(commands);
            int multiply = position.horizontal * position.depth;

            //Console.WriteLine($"Day2 part 1 : position={position.horizontal} depth={position.depth} multiply={multiply}");
            Console.WriteLine($"Day2 part 2 : position={position.horizontal} depth={position.depth} multiply={multiply}");
        }
    }
}


