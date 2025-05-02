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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
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
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(168, 321);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(302, 321);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 19);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(982, 514);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(InserirNomeDaCidade);
            Name = "App";
            Text = "Form1";
            Load += App_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private TextBox InserirNomeDaCidade;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}