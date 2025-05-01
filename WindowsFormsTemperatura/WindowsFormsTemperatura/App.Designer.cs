namespace WindowsFormsTemperatura
{
    partial class App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            InserirNomeDaCidade = new TextBox();
            Celsius = new Button();
            Fah = new Button();
            SuspendLayout();
            // 
            // InserirNomeDaCidade
            // 
            InserirNomeDaCidade.Location = new Point(206, 190);
            InserirNomeDaCidade.Name = "InserirNomeDaCidade";
            InserirNomeDaCidade.Size = new Size(157, 23);
            InserirNomeDaCidade.TabIndex = 1;
            InserirNomeDaCidade.TextChanged += InserirNomeDaCidade_TextChanged;
            // 
            // Celsius
            // 
            Celsius.Location = new Point(168, 309);
            Celsius.Name = "Celsius";
            Celsius.Size = new Size(108, 42);
            Celsius.TabIndex = 2;
            Celsius.Text = "Celsius";
            Celsius.UseVisualStyleBackColor = true;
            Celsius.Click += button1_Click;
            // 
            // Fah
            // 
            Fah.Location = new Point(298, 309);
            Fah.Name = "Fah";
            Fah.Size = new Size(108, 42);
            Fah.TabIndex = 3;
            Fah.Text = "Fahrenheit ";
            Fah.UseVisualStyleBackColor = true;
            Fah.Click += Fah_Click;
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(982, 514);
            Controls.Add(Fah);
            Controls.Add(Celsius);
            Controls.Add(InserirNomeDaCidade);
            Name = "App";
            Text = "Form1";
            Load += App_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private TextBox InserirNomeDaCidade;
        private Button Celsius;
        private Button Fah;
    }
}
