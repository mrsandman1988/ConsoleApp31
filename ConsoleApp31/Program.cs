using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp31
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            SQLSaveManager saveManager = new();
            Article article = new Article(saveManager);
            article.Title= "About asp.net mvc 7.0";
            article.Text = "This article....";
            article.Save();

            MongoSaveManager mongo = new();

            Article article1 = new Article(mongo);
            article.Title = "About asp.net mvc 7.0";
            article.Text = "This article....";
            article.Save();


            //

            var result = Calc(10, 20);
            Console.WriteLine(result.Item1);
            Console.WriteLine(result.Item2);
            Console.WriteLine(result.Item3);
            Console.WriteLine(result.Item4);

            var values = (1, 10, "Jora", true,4,5,5);
            (int price, int discount, string name) values1 = (100, 50, "Jora");
           var price =   values1.price;
        }

        static Tuple<int,int,int,int> Calc(int number1, int number2)
        {
            var result1 = number1+ number2;
            var result2 = number2- number1;
            var result3 = number2 / number1;
            var result4 = number1 * number2;
            return Tuple.Create(result1, result2, result3, result4);
        }

        
        


    }
}