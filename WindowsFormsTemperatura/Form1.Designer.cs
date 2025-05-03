namespace WindowsFormsTemperatura
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCidade = new TextBox();
            btnCelsius = new Button();
            btnFahrenheit = new Button();
            btnBuscar = new Button();
            lblTemperatura = new Label();
            lblSugestao = new Label();
            lblCondicao = new Label();
            SuspendLayout();
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(178, 196);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(220, 23);
            txtCidade.TabIndex = 0;
            txtCidade.TextChanged += txtCidade_TextChanged;
            // 
            // btnCelsius
            // 
            btnCelsius.Location = new Point(178, 302);
            btnCelsius.Name = "btnCelsius";
            btnCelsius.Size = new Size(110, 42);
            btnCelsius.TabIndex = 1;
            btnCelsius.Text = "Celsius";
            btnCelsius.UseVisualStyleBackColor = true;
            btnCelsius.Click += btnCelsius_Click;
            // 
            // btnFahrenheit
            // 
            btnFahrenheit.Location = new Point(288, 302);
            btnFahrenheit.Name = "btnFahrenheit";
            btnFahrenheit.Size = new Size(110, 42);
            btnFahrenheit.TabIndex = 2;
            btnFahrenheit.Text = "Fahrenheit";
            btnFahrenheit.UseVisualStyleBackColor = true;
            btnFahrenheit.Click += btnFahrenheit_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(178, 350);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(220, 42);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Avançar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblTemperatura
            // 
            lblTemperatura.AutoSize = true;
            lblTemperatura.Location = new Point(728, 152);
            lblTemperatura.Name = "lblTemperatura";
            lblTemperatura.Size = new Size(19, 15);
            lblTemperatura.TabIndex = 4;
           
            // 
            // lblSugestao
            // 
            lblSugestao.AutoSize = true;
            lblSugestao.Location = new Point(692, 277);
            lblSugestao.Name = "lblSugestao";
            lblSugestao.Size = new Size(25, 15);
            lblSugestao.TabIndex = 5;
         
            // 
            // lblCondicao
            // 
            lblCondicao.AutoSize = true;
            lblCondicao.Location = new Point(728, 214);
            lblCondicao.Name = "lblCondicao";
            lblCondicao.Size = new Size(31, 15);
            lblCondicao.TabIndex = 6;
            lblCondicao.Click += lblCondicao_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Insira_o_nome_da_cidade__1_;
            ClientSize = new Size(978, 550);
            Controls.Add(lblCondicao);
            Controls.Add(lblSugestao);
            Controls.Add(lblTemperatura);
            Controls.Add(btnBuscar);
            Controls.Add(btnFahrenheit);
            Controls.Add(btnCelsius);
            Controls.Add(txtCidade);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCidade;
        private Button btnCelsius;
        private Button btnFahrenheit;
        private Button btnBuscar;
        private Label lblTemperatura;
        private Label lblSugestao;
        private Label lblCondicao;
    }
}
