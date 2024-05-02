using ControleMedicamentos.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using ControleMedicamentos.ConsoleApp.Compartilhado;

namespace ControleMedicamentos.ConsoleApp.ModuloFornecedor
{
    internal class Fornecedor : EntidadeBase
    {

        public Fornecedor(string nome, string telefone, string cnpj)
        {
            Nome = nome;
            Telefone = telefone;
            Cnpj = cnpj;
        }

        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cnpj { get; set; }

        public override string[] Validar()
        {
            string[] erros = new string[3];
            int contadorErros = 0;

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros[contadorErros++] = ("O campo \"nome\" é obrigatório");

            if(string.IsNullOrEmpty(Telefone))
                erros[contadorErros++] = ("O campo \"telefone\" é obrigatório");

            if (string.IsNullOrEmpty(Cnpj))
                erros[contadorErros++] = ("O campo \"cnpj\" é obrigatório");


            string[] errosFiltrados = new string[contadorErros];

            Array.Copy(erros, errosFiltrados, contadorErros);

            return errosFiltrados;
        }
    }
}
