namespace CalcIMC
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
            lb_nome = new Label();
            lb_cpf = new Label();
            lb_sexo = new Label();
            lb_peso = new Label();
            lb_altura = new Label();
            lb_idade = new Label();
            lb_resultado = new Label();
            tx_peso = new TextBox();
            tx_nome = new TextBox();
            tx_altura = new TextBox();
            tx_idade = new TextBox();
            mtb_cpf = new MaskedTextBox();
            cb_sexo = new ComboBox();
            bt_limpar = new Button();
            bt_calcular = new Button();
            bt_sair = new Button();
            label1 = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // lb_nome
            // 
            lb_nome.AutoSize = true;
            lb_nome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_nome.Location = new Point(61, 89);
            lb_nome.Name = "lb_nome";
            lb_nome.Size = new Size(56, 20);
            lb_nome.TabIndex = 0;
            lb_nome.Text = "Nome:";
            // 
            // lb_cpf
            // 
            lb_cpf.AutoSize = true;
            lb_cpf.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_cpf.Location = new Point(71, 144);
            lb_cpf.Name = "lb_cpf";
            lb_cpf.Size = new Size(39, 20);
            lb_cpf.TabIndex = 1;
            lb_cpf.Text = "CPF:";
            // 
            // lb_sexo
            // 
            lb_sexo.AutoSize = true;
            lb_sexo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_sexo.Location = new Point(315, 141);
            lb_sexo.Name = "lb_sexo";
            lb_sexo.Size = new Size(46, 20);
            lb_sexo.TabIndex = 2;
            lb_sexo.Text = "Sexo:";
            // 
            // lb_peso
            // 
            lb_peso.AutoSize = true;
            lb_peso.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_peso.Location = new Point(71, 199);
            lb_peso.Name = "lb_peso";
            lb_peso.Size = new Size(46, 20);
            lb_peso.TabIndex = 3;
            lb_peso.Text = "Peso:";
            // 
            // lb_altura
            // 
            lb_altura.AutoSize = true;
            lb_altura.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_altura.Location = new Point(229, 199);
            lb_altura.Name = "lb_altura";
            lb_altura.Size = new Size(57, 20);
            lb_altura.TabIndex = 4;
            lb_altura.Text = "Altura:";
            // 
            // lb_idade
            // 
            lb_idade.AutoSize = true;
            lb_idade.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_idade.Location = new Point(392, 199);
            lb_idade.Name = "lb_idade";
            lb_idade.Size = new Size(52, 20);
            lb_idade.TabIndex = 5;
            lb_idade.Text = "Idade:";
            // 
            // lb_resultado
            // 
            lb_resultado.AutoSize = true;
            lb_resultado.Location = new Point(61, 278);
            lb_resultado.Name = "lb_resultado";
            lb_resultado.Size = new Size(71, 20);
            lb_resultado.TabIndex = 6;
            lb_resultado.Text = "resultado";
            // 
            // tx_peso
            // 
            tx_peso.BorderStyle = BorderStyle.FixedSingle;
            tx_peso.Location = new Point(139, 197);
            tx_peso.Name = "tx_peso";
            tx_peso.Size = new Size(71, 27);
            tx_peso.TabIndex = 7;
            // 
            // tx_nome
            // 
            tx_nome.BorderStyle = BorderStyle.FixedSingle;
            tx_nome.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            tx_nome.Location = new Point(139, 86);
            tx_nome.Name = "tx_nome";
            tx_nome.Size = new Size(389, 31);
            tx_nome.TabIndex = 9;
            // 
            // tx_altura
            // 
            tx_altura.BorderStyle = BorderStyle.FixedSingle;
            tx_altura.Location = new Point(306, 197);
            tx_altura.Name = "tx_altura";
            tx_altura.Size = new Size(71, 27);
            tx_altura.TabIndex = 10;
            // 
            // tx_idade
            // 
            tx_idade.BorderStyle = BorderStyle.FixedSingle;
            tx_idade.Location = new Point(457, 197);
            tx_idade.Name = "tx_idade";
            tx_idade.Size = new Size(71, 27);
            tx_idade.TabIndex = 11;
            // 
            // mtb_cpf
            // 
            mtb_cpf.BorderStyle = BorderStyle.FixedSingle;
            mtb_cpf.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            mtb_cpf.Location = new Point(139, 138);
            mtb_cpf.Mask = "000,000,000-00";
            mtb_cpf.Name = "mtb_cpf";
            mtb_cpf.RightToLeft = RightToLeft.No;
            mtb_cpf.Size = new Size(154, 31);
            mtb_cpf.TabIndex = 12;
            // 
            // cb_sexo
            // 
            cb_sexo.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cb_sexo.ForeColor = SystemColors.WindowFrame;
            cb_sexo.FormattingEnabled = true;
            cb_sexo.Items.AddRange(new object[] { "Masculino", "Feminino", "Prefiro Não Dizer" });
            cb_sexo.Location = new Point(384, 138);
            cb_sexo.Name = "cb_sexo";
            cb_sexo.Size = new Size(144, 33);
            cb_sexo.TabIndex = 13;
            cb_sexo.Text = "escolha aqui...";
            // 
            // bt_limpar
            // 
            bt_limpar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bt_limpar.Location = new Point(61, 237);
            bt_limpar.Name = "bt_limpar";
            bt_limpar.Size = new Size(225, 29);
            bt_limpar.TabIndex = 14;
            bt_limpar.Text = "Limpar";
            bt_limpar.UseVisualStyleBackColor = true;
            bt_limpar.Click += bt_limpar_Click;
            // 
            // bt_calcular
            // 
            bt_calcular.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bt_calcular.Location = new Point(303, 237);
            bt_calcular.Name = "bt_calcular";
            bt_calcular.Size = new Size(225, 29);
            bt_calcular.TabIndex = 15;
            bt_calcular.Text = "Calcular";
            bt_calcular.UseVisualStyleBackColor = true;
            bt_calcular.Click += button2_Click;
            // 
            // bt_sair
            // 
            bt_sair.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bt_sair.Location = new Point(61, 387);
            bt_sair.Name = "bt_sair";
            bt_sair.Size = new Size(467, 29);
            bt_sair.TabIndex = 16;
            bt_sair.Text = "Sair";
            bt_sair.UseVisualStyleBackColor = true;
            bt_sair.Click += bt_sair_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(194, 28);
            label1.Name = "label1";
            label1.Size = new Size(226, 35);
            label1.TabIndex = 17;
            label1.Text = "Cálculo de IMC";
            // 
            // panel1
            // 
            panel1.Location = new Point(8, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(592, 426);
            panel1.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 439);
            Controls.Add(label1);
            Controls.Add(bt_sair);
            Controls.Add(bt_calcular);
            Controls.Add(bt_limpar);
            Controls.Add(cb_sexo);
            Controls.Add(mtb_cpf);
            Controls.Add(tx_idade);
            Controls.Add(tx_altura);
            Controls.Add(tx_nome);
            Controls.Add(tx_peso);
            Controls.Add(lb_resultado);
            Controls.Add(lb_idade);
            Controls.Add(lb_altura);
            Controls.Add(lb_peso);
            Controls.Add(lb_sexo);
            Controls.Add(lb_cpf);
            Controls.Add(lb_nome);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_nome;
        private Label lb_cpf;
        private Label lb_sexo;
        private Label lb_peso;
        private Label lb_altura;
        private Label lb_idade;
        private Label lb_resultado;
        private TextBox tx_peso;
        private TextBox tx_nome;
        private TextBox tx_altura;
        private TextBox tx_idade;
        private MaskedTextBox mtb_cpf;
        private ComboBox cb_sexo;
        private Button bt_limpar;
        private Button bt_calcular;
        private Button bt_sair;
        private Label label1;
        private Panel panel1;
    }
}