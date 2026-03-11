namespace APBD_CW1
{
    public class Program
    {
        private IGitService _supply;

        public Program(IGitService gitService)
        {
            _supply = gitService;
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
            int min = values[0];
            foreach (var value in values)
            {
                if (min > value)
                {
                    min = value;
                }
            }
            
            return min;
        }
        
        public static void Main(string[] args)
        {   
            int[] calcData = [11, 1, 3, 5, 7, 8, 11, 22, 33, 15];
            Console.WriteLine("Hello World!");
            var maximum = CalculateMax(calcData); // 33
            
            var minimum = CalculateMin(calcData); // 1
            Console.WriteLine($"Maksymalna wartosc z tablicy:  {maximum}");
            Console.WriteLine($"Minimalna wartosc z tablicy:  {minimum}");
        }
    }
}