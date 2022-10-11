using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var convo = new RonVSKanyeAPI(client);

            //call the method

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Kanye: {convo.KanyeTalking()}");
                Console.WriteLine();
                Console.WriteLine($"Ron: {convo.RonTalking()}");
                Console.WriteLine();
            }
            

        }
    }
}