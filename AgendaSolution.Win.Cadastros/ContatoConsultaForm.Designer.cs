namespace AgendaSolution.Win.Cadastros
{
    partial class ContatoConsultaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ConsultaGroupBox1 = new GroupBox();
            ResultadoGroupBox2 = new GroupBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            ConsultaGroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ConsultaGroupBox1
            // 
            ConsultaGroupBox1.Controls.Add(textBox1);
            ConsultaGroupBox1.Controls.Add(button2);
            ConsultaGroupBox1.Controls.Add(button1);
            ConsultaGroupBox1.Controls.Add(label1);
            ConsultaGroupBox1.Location = new Point(15, 21);
            ConsultaGroupBox1.Name = "ConsultaGroupBox1";
            ConsultaGroupBox1.Size = new Size(862, 228);
            ConsultaGroupBox1.TabIndex = 0;
            ConsultaGroupBox1.TabStop = false;
            ConsultaGroupBox1.Text = "Opções de Filtro";
            ConsultaGroupBox1.Enter += groupBox1_Enter;
            // 
            // ResultadoGroupBox2
            // 
            ResultadoGroupBox2.Location = new Point(12, 275);
            ResultadoGroupBox2.Name = "ResultadoGroupBox2";
            ResultadoGroupBox2.Size = new Size(862, 228);
            ResultadoGroupBox2.TabIndex = 1;
            ResultadoGroupBox2.TabStop = false;
            ResultadoGroupBox2.Text = "Resultado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 56);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // button1
            // 
            button1.Location = new Point(412, 52);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Consulta";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(507, 51);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Novo";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(63, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(322, 23);
            textBox1.TabIndex = 3;
            // 
            // ContatoConsultaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 550);
            Controls.Add(ResultadoGroupBox2);
            Controls.Add(ConsultaGroupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ContatoConsultaForm";
            Text = "ContatoConsultaForm";
            ConsultaGroupBox1.ResumeLayout(false);
            ConsultaGroupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ConsultaGroupBox1;
        private GroupBox ResultadoGroupBox2;
        private Button button2;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
    }
}