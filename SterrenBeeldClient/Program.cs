using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace SterrenBeeldClient
{
    class Program
    {
        static async Task Main()
        {
            Console.WriteLine("Welkom op de Sterrenbeeld applicatie");
            Console.WriteLine("Gelieve volgende gegevens in te geven:");
            Console.WriteLine();
            Console.Write("Dag: ");
            int.TryParse(Console.ReadLine(), out int dag);
            Console.WriteLine();
            Console.Write("Maand: ");
            int.TryParse(Console.ReadLine(), out int maand);

            //Api aanspreken met ingevoerde dag en maand
            //Mijn localhost op azure virtual machine veranderd regelmatig van localhost-adres (is niet altijd 5000 bij mij).
            using var client = new HttpClient();            
            var response = await client.GetAsync($"http://localhost:50354/sterrenbeelden/{dag}-{maand}");

            //switch op verschillende reponsecodes
            switch (response.StatusCode)
            {
                case HttpStatusCode.OK:
                    var sterrenbeeld = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Je sterrenbeeld is " + sterrenbeeld);
                    break;
                case HttpStatusCode.BadRequest:
                    Console.WriteLine("Bad Request, controleer invoergegevens");
                    break;
                default:
                    Console.WriteLine("Technisch probleem, contacteer wouter keymis!");
                    break;
            }

        }
    }
}
