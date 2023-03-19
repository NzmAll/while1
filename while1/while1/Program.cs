using System.Xml.Schema;

namespace while1;
internal class Program
{
    static void Main(string[] args)
    {

        Console.Write("Sayı daxil edin : ");
        decimal counter = decimal.Parse(Console.ReadLine()!);
        decimal total = 0;
        decimal discountPrice;

        while (counter > 0)
        {


            Console.Write("Firma : ");
            string firm = Console.ReadLine()!;

            Console.Write("Ayaqqabı sayı : ");
            decimal countOfShoe = decimal.Parse(Console.ReadLine()!);

            Console.Write("Birinin qiyməti ($) : ");
            decimal priceOfOne = decimal.Parse(Console.ReadLine()!);

            decimal all_price = countOfShoe * priceOfOne;

            total = total + all_price;

            Console.WriteLine("Hamısının birlikdə qiyməti($): " + all_price);
            Console.WriteLine(" ");

            counter--;
        }

        if (total > 1000)
        {
            Console.WriteLine("1000-dən yuxarı alış-veriş etdiyiniz üçün endirim qazandınız!!!");
            Console.WriteLine("");

            Console.Write("Endirim faizi : ");
            discountPrice = decimal.Parse(Console.ReadLine()!);
            total = total - total * discountPrice / 100;
            Console.WriteLine("Endirimli qiymeti : " + total);

        }

        else
        {
            Console.Write("Yekun : " + total);
        }
    }
}
