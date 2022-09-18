namespace adventOfCode
{
    public class Command
    {
        public string? direction {get; set;}
        public int unit {get; set;}
        public enum move
        {
            up,
            down,
            forward
        }
    }
}