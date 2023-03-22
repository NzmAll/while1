namespace atHome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // String-de bosluq varsa onu silsin

            //Console.Write("Stringi daxil edin: ");
            //string name = Convert.ToString(Console.ReadLine()!);

            //for(int i  = 0; i < name.Length; i++)
            //{
            //    if (name[i] == ' ')
            //    {
            //        continue;
            //    }
            //    Console.Write(name[i]);
            //}





            Console.Write("Stringi daxil edin: ");
            string name = Convert.ToString(Console.ReadLine()!);

            char[] uppercaseLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] lowerLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            for (int i = 0; i < uppercaseLetters.Length; i++) 
            {
                for(int j = 0; j < lowerLetters.Length; j++)
                {
                    if ( name[i] == uppercaseLetters[i]) ;
                    {
                        name = lowerLetters[j];
                        Console.WriteLine(name);
                    }
                }
            }



        }
    }
}