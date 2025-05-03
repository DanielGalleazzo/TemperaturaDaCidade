using Newtonsoft.Json;

namespace WindowsFormsTemperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {

        }
        string unidade = "metric";
        private void btnCelsius_Click(object sender, EventArgs e)
        {
            unidade = "metric";
        }

        private void btnFahrenheit_Click(object sender, EventArgs e)
        {
            unidade = "imperial";
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            string cidade = txtCidade.Text;
            string apiKey = "3ffe0230a7417daf36c0c422d9206e39";
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={cidade}&appid={apiKey}&units={unidade}&lang=pt_br";
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string resultado = await response.Content.ReadAsStringAsync();

                    dynamic dados = JsonConvert.DeserializeObject(resultado);

                    double temperatura = dados.main.temp;
                    string condicao = dados.weather[0].description;

                    lblTemperatura.Text = $"Temperatura atual: {temperatura} {(unidade == "metric" ? "°C" : "°F")}";
                    lblCondicao.Text = $"Condição do clima: {condicao}";
                    lblSugestao.Text = $"Sugestão: {GerarSugestao(condicao)}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }
        private string GerarSugestao(string condicao)
        {
            condicao = condicao.ToLower();

            if (condicao.Contains("chuva")) return "Fique atento com a chuva";
            if (condicao.Contains("nublado")) return "Clima nublado, possível chuva";
            if (condicao.Contains("sol")) return "Ensolarado";
            return "Preste atenção no clima!.";
        }

        private void lblCondicao_Click(object sender, EventArgs e)
        {

        }
    }
}
