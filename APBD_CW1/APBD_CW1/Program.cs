namespace APBD_CW1
{
    public class Program
    {
        private IGitService _gitService;

        public Program(IGitService gitService)
        {
            _gitService = gitService;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");            
        }
    }
}