using System;
public class Funcionario
{
    string matricula;
    string cpf;
    string nome;
    string funcao;
    double salario;

    double periculosidade;
    double ti;
    double valealimentacao;
    double valetransporte;
    double irpf = 0.0;

    public Funcionario(string matricula, string cpf, string nome, string funcao, double salario)
    {
        this.matricula = matricula;
        this.cpf = cpf;
        this.nome = nome;
        this.funcao = funcao;
        this.salario = salario;
    }

    public (double, double) Salario()
    {
        if (funcao == "Médico")
        {
            periculosidade = salario * 0.20;
            salario = salario + periculosidade;
            //return (salario, irpf);
            //MessageBox.Show($"salario inicial: {salario}");
        }

        else if (funcao == "TI")
        {
            ti = 5600;
            salario = salario + ti;
            //return (salario, irpf);
            //MessageBox.Show($"salario inicial: {salario}");
        }

        else if (funcao == "ADM")
        {
            valetransporte = salario * 0.15;
            salario = salario + valetransporte;

            valealimentacao = 200;

            salario = salario + valealimentacao;
            //return (salario, irpf);
            //MessageBox.Show($"salario inicial: {salario}");
        }

        if (salario > 5000)
        {
            irpf = salario * 0.17;
            salario = salario - irpf;
            //return (salario, irpf);
            //MessageBox.Show($"salario final: {salario}");
        }

        return (salario, irpf);
    }

}
