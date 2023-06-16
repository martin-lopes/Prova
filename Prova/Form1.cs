using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_cadastrar_Click(object sender, EventArgs e)
        {
            string matricula = tx_matricula.Text;
            string cpf = tx_cpf.Text;
            string nome = tx_nome.Text;
            string funcao = tx_funcao.Text;
            //string t_salario = tx_salario.Text;

            double salario = Convert.ToDouble(tx_salario.Text);
            
            //MessageBox.Show($"{salario}");

            Funcionario f = new Funcionario(matricula, cpf, nome, funcao, salario);

            (double n1, double n2) = f.Salario();
            lb_salariototal.Text = $"Salário total: {n1}";
            lb_irpf.Text = $"IRPF: {n2}";
        }
    }
}
