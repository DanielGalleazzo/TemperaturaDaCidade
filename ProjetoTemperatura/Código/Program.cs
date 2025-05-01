using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
class Program
{
    static async Task Main()
    {
        Console.Write("Digite a cidade: ");
        string cidade = Console.ReadLine();
        string apiKey = "Insira aqui a sua api"; 
        string url = $"http://api.openweathermap.org/data/2.5/weather?q={cidade}&appid={apiKey}&units=metric&lang=pt";

        using (HttpClient client = new HttpClient())
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string resposta = await response.Content.ReadAsStringAsync();
                JObject clima = JObject.Parse(resposta);

                string descricao = clima["weather"][0]["description"].ToString();
                string temperatura = clima["main"]["temp"].ToString();

                Console.WriteLine($"Clima em: "+ cidade + descricao + temperatura + "°C");
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("Erro ao obter os dados: " + e.Message);
            }
        }
    }
}
