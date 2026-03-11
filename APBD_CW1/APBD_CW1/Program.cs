namespace APBD_CW1
{
    public class Program
    {
        private IGitService _gitService;

        public Program(IGitService gitService)
        {
            _gitService = gitService;
        }

        public static double CalculateAverage(int[] values)
        {
            var sum = 0;
            foreach (var value in values)
            {
               sum += value; 
            }
            
            return sum / values.Length;
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");            
        }
    }
}