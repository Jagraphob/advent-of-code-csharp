
namespace adventOfCode
{
    public static class GetInput 
    {
        public static string[] ReadFile(string fileName) 
        {
            return File.ReadAllLines(fileName);
        }

        //this is a class extension method
        public static int[] ToIntArray(this string[] arr)
        {
            return Array.ConvertAll(arr, s => int.Parse(s));
        }

        public static List<Command> ToDriveCommands(this string[] arr)
        {
            List<Command> commands = new List<Command>();

            foreach(string item in arr)
            {
                string[] token = item.Split(" ");
                commands.Add(new Command { direction = token[0], unit = int.Parse(token[1])});  
            }

            return commands;
        }
    }
}