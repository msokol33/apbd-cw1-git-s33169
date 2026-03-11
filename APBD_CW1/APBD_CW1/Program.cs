namespace APBD_CW1
{
    public class Program
    {
        private IGitService _gitService;

        public Program(IGitService gitService)
        {
            _gitService = gitService;
        }

        public static int CalculateAverage(int[] values)
        {
            var sum = 0;
            return sum;
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");            
        }
    }
}