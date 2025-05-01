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
        string apiKey = "3ffe0230a7417daf36c0c422d9206e39";
        string url = $"http://api.openweathermap.org/data/2.5/weather?q={cidade}&appid={apiKey}&units=metric&lang=pt";

        using (HttpClient cliente = new HttpClient())
        {
            try
            {
                HttpResponseMessage response = await cliente.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string resposta = await response.Content.ReadAsStringAsync();
                JObject clima = JObject.Parse(resposta);
                string descricao = clima["weather"][0]["description"].ToString();
                double temperatura = Convert.ToDouble(clima["main"]["temp"].ToString());
                Console.WriteLine($"Clima em:" + cidade + " Condição do clima:" + descricao + " Sua temperatura é de: "+ temperatura + "°C");
                if (temperatura < 15)
                {
                    Console.WriteLine("Leve uma blusa, está frio");
                }
                if (descricao.Contains("Chuva", StringComparison.OrdinalIgnoreCase) ||
                    descricao.Contains("Nublado", StringComparison.OrdinalIgnoreCase) ||
                    descricao.Contains("Chovendo", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Usar guarda-chuva, pode estar chovendo ou choverá");
                }

            }
            catch (Exception error)
            {
                Console.WriteLine("Código do erro: " + error.Message);
            }
        }
    }
}
