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
            double periculosidade;
            double ti;
            double valealimentacao;
            double valetransporte;
            double irpf;

            //MessageBox.Show($"{salario}");

            if (funcao == "Médico")
            {
                periculosidade = salario * 0.20;
                salario = salario + periculosidade;
                MessageBox.Show($"salario inicial: {salario}");
            }

            else if (funcao == "TI")
            {
                ti = 5600;
                salario = salario + ti;
                MessageBox.Show($"salario inicial: {salario}");
            }

            else if(funcao == "ADM")
            {
                valetransporte = salario * 0.15;
                salario = salario + valetransporte;

                valealimentacao = 200;

                salario = salario + valealimentacao;
                MessageBox.Show($"salario inicial: {salario}");
            }

            if(salario > 5000)
            {
                irpf = salario * 0.17;
                salario = salario - irpf;
                MessageBox.Show($"salario final: {salario}");
            }
        }
    }
}
