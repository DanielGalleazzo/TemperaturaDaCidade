namespace WindowsFormsTemperatura
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void InserirNomeDaCidade_TextChanged(object sender, EventArgs e)
        {
            string cidade = InserirNomeDaCidade.Text;


        }

        private void App_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Celsius.Text = "Celsius";
        }

        private void Fah_Click(object sender, EventArgs e)
        {
            Fah.Text = "Fahrenheit";
        }
    }
}