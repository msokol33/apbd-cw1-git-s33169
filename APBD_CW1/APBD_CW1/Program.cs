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

        public static int CalculateMax(int[] values)
        {
            var max = values[0];
            foreach (var value in values)
            {
                if (max < value)
                {
                    max = value;
                }
            }
            return max;
        }

        public static int CalculateMin(int[] values)
        {
            return 0;
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var maximum = CalculateMax([1, 3, 5, 7, 8, 11, 22, 33]);
            Console.WriteLine(maximum);
        }
    }
}