namespace LINQConsoleApp
{
    internal static class Program
    {

        [STAThread]
        static void Main(string[] args)
        {
            string[] carNames = {  };

            var query = from name in carNames
                        where name.Contains("e")
                        select name;
            foreach (string name in query)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }          
    }
}