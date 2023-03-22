namespace Holiday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total;
            Console.Write("Ededi daxil edin: ");
            int number = int.Parse(Console.ReadLine()!);

            for(int i = 0; i <= 10; i++)
            {
                if(i >= 0)
                {
                    total = number * i;
                    Console.WriteLine("Hasil: " + total);
                }
            }

        }
    }
}