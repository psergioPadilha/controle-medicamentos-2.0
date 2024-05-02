using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleMedicamentos.ConsoleApp.Compartilhado;

namespace ControleMedicamentos.ConsoleApp.ModuloFuncionario
{
    internal class Funcionario : EntidadeBase
    {
        public string nomeFuncionario { get; set; }
        public string telefone { get; set; }
        public string cpf { get; set; }

        public Funcionario(string nomeFuncionario, string telefone, string cpf)
        {
            this.nomeFuncionario = nomeFuncionario;
            this.telefone = telefone;
            this.cpf = cpf;
        }


        public override string[] Validar()
        {
            string[] erros = new string[3];
            int contadorErros = 0;

            if (string.IsNullOrEmpty(nomeFuncionario.Trim()))
                erros[contadorErros++] = ("O campo \"nome\" é obrigatório");

            if (string.IsNullOrEmpty(telefone.Trim()))
                erros[contadorErros++] = ("O campo \"telefone\" é obrigatório");

            if (string.IsNullOrEmpty(cpf.Trim()))
                erros[contadorErros++] = ("O campo \"CPF\" é obrigatório");

            string[] errosFiltrados = new string[contadorErros];

            Array.Copy(erros, errosFiltrados, contadorErros);

            return errosFiltrados;
        }
    }
}
