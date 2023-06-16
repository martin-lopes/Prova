namespace Prova
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tx_matricula = new System.Windows.Forms.TextBox();
            this.lb_cadastro = new System.Windows.Forms.Label();
            this.lb_matricula = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            this.lb_funcao = new System.Windows.Forms.Label();
            this.lb_salario = new System.Windows.Forms.Label();
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.tx_cpf = new System.Windows.Forms.MaskedTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tx_salario = new System.Windows.Forms.TextBox();
            this.tx_funcao = new System.Windows.Forms.ComboBox();
            this.button_cadastrar = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.lb_salariototal = new System.Windows.Forms.Label();
            this.lb_irpf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tx_matricula
            // 
            this.tx_matricula.Location = new System.Drawing.Point(151, 130);
            this.tx_matricula.Name = "tx_matricula";
            this.tx_matricula.Size = new System.Drawing.Size(261, 22);
            this.tx_matricula.TabIndex = 0;
            // 
            // lb_cadastro
            // 
            this.lb_cadastro.AutoSize = true;
            this.lb_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cadastro.Location = new System.Drawing.Point(46, 9);
            this.lb_cadastro.Name = "lb_cadastro";
            this.lb_cadastro.Size = new System.Drawing.Size(704, 69);
            this.lb_cadastro.TabIndex = 1;
            this.lb_cadastro.Text = "Cadastro de Funcionário";
            this.lb_cadastro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_matricula
            // 
            this.lb_matricula.AutoSize = true;
            this.lb_matricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_matricula.Location = new System.Drawing.Point(63, 130);
            this.lb_matricula.Name = "lb_matricula";
            this.lb_matricula.Size = new System.Drawing.Size(82, 22);
            this.lb_matricula.TabIndex = 2;
            this.lb_matricula.Text = "Matrícula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(451, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "CPF:";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome.Location = new System.Drawing.Point(63, 195);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(53, 20);
            this.lb_nome.TabIndex = 4;
            this.lb_nome.Text = "Nome";
            // 
            // lb_funcao
            // 
            this.lb_funcao.AutoSize = true;
            this.lb_funcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_funcao.Location = new System.Drawing.Point(63, 248);
            this.lb_funcao.Name = "lb_funcao";
            this.lb_funcao.Size = new System.Drawing.Size(64, 20);
            this.lb_funcao.TabIndex = 5;
            this.lb_funcao.Text = "Função";
            // 
            // lb_salario
            // 
            this.lb_salario.AutoSize = true;
            this.lb_salario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_salario.Location = new System.Drawing.Point(63, 300);
            this.lb_salario.Name = "lb_salario";
            this.lb_salario.Size = new System.Drawing.Size(66, 20);
            this.lb_salario.TabIndex = 6;
            this.lb_salario.Text = "Salário:";
            // 
            // tx_nome
            // 
            this.tx_nome.Location = new System.Drawing.Point(151, 193);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(261, 22);
            this.tx_nome.TabIndex = 7;
            // 
            // tx_cpf
            // 
            this.tx_cpf.Location = new System.Drawing.Point(504, 134);
            this.tx_cpf.Mask = "000,000,000-00";
            this.tx_cpf.Name = "tx_cpf";
            this.tx_cpf.Size = new System.Drawing.Size(100, 22);
            this.tx_cpf.TabIndex = 8;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(0, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 20);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tx_salario
            // 
            this.tx_salario.Location = new System.Drawing.Point(151, 300);
            this.tx_salario.Name = "tx_salario";
            this.tx_salario.Size = new System.Drawing.Size(100, 22);
            this.tx_salario.TabIndex = 10;
            // 
            // tx_funcao
            // 
            this.tx_funcao.FormattingEnabled = true;
            this.tx_funcao.Items.AddRange(new object[] {
            "Médico",
            "TI",
            "ADM"});
            this.tx_funcao.Location = new System.Drawing.Point(151, 248);
            this.tx_funcao.Name = "tx_funcao";
            this.tx_funcao.Size = new System.Drawing.Size(121, 24);
            this.tx_funcao.TabIndex = 11;
            // 
            // button_cadastrar
            // 
            this.button_cadastrar.Location = new System.Drawing.Point(213, 388);
            this.button_cadastrar.Name = "button_cadastrar";
            this.button_cadastrar.Size = new System.Drawing.Size(100, 37);
            this.button_cadastrar.TabIndex = 12;
            this.button_cadastrar.Text = "Cadastrar";
            this.button_cadastrar.UseVisualStyleBackColor = true;
            this.button_cadastrar.Click += new System.EventHandler(this.button_cadastrar_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(489, 388);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(84, 37);
            this.button_cancelar.TabIndex = 13;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            // 
            // lb_salariototal
            // 
            this.lb_salariototal.AutoSize = true;
            this.lb_salariototal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_salariototal.Location = new System.Drawing.Point(210, 350);
            this.lb_salariototal.Name = "lb_salariototal";
            this.lb_salariototal.Size = new System.Drawing.Size(103, 20);
            this.lb_salariototal.TabIndex = 14;
            this.lb_salariototal.Text = "Salário total:";
            // 
            // lb_irpf
            // 
            this.lb_irpf.AutoSize = true;
            this.lb_irpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_irpf.Location = new System.Drawing.Point(501, 350);
            this.lb_irpf.Name = "lb_irpf";
            this.lb_irpf.Size = new System.Drawing.Size(51, 20);
            this.lb_irpf.TabIndex = 15;
            this.lb_irpf.Text = "IRPF:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_irpf);
            this.Controls.Add(this.lb_salariototal);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_cadastrar);
            this.Controls.Add(this.tx_funcao);
            this.Controls.Add(this.tx_salario);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tx_cpf);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.lb_salario);
            this.Controls.Add(this.lb_funcao);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_matricula);
            this.Controls.Add(this.lb_cadastro);
            this.Controls.Add(this.tx_matricula);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_matricula;
        private System.Windows.Forms.Label lb_cadastro;
        private System.Windows.Forms.Label lb_matricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Label lb_funcao;
        private System.Windows.Forms.Label lb_salario;
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.MaskedTextBox tx_cpf;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox tx_salario;
        private System.Windows.Forms.ComboBox tx_funcao;
        private System.Windows.Forms.Button button_cadastrar;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Label lb_salariototal;
        private System.Windows.Forms.Label lb_irpf;
    }
}

