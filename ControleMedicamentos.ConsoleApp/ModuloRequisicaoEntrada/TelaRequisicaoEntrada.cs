using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleMedicamentos.ConsoleApp.Compartilhado;
using ControleMedicamentos.ConsoleApp.ModuloFuncionario;
using ControleMedicamentos.ConsoleApp.ModuloMedicamento;
using ControleMedicamentos.ConsoleApp.ModuloRequisicao;
using Microsoft.Win32;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ControleMedicamentos.ConsoleApp.ModuloRequisicaoEntrada
{

    internal class TelaRequisicaoEntrada : TelaBase
    {
        public Medicamento medicamento = null;
        //public Fornecedor fornecedor = null;
        public Funcionario funcionario = null;

        public override void Registrar()
        {
            ApresentarCabecalho();

            Console.WriteLine($"Cadastrando {tipoEntidade}...");

            Console.WriteLine();

            RequisicaoEntrada entidade = (RequisicaoEntrada)ObterRegistro();

            string[] erros = entidade.Validar();

            if (erros.Length > 0)
            {
                ApresentarErros(erros);
                return;
            }

            bool conseguiuDarEntrada = entidade.EntradaMedicamento();

            if (!conseguiuDarEntrada)
            {
                ExibirMensagem("A quantidade de retirada informada não está disponível.", ConsoleColor.DarkYellow);
                return;
            }

            repositorio.Cadastrar(entidade);

            ExibirMensagem($"O {tipoEntidade} foi cadastrado com sucesso!", ConsoleColor.Green);
        }

        public override void VisualizarRegistros(bool exibirTitulo)
        {
            throw new NotImplementedException();
        }

        protected override EntidadeBase ObterRegistro()
        {
            throw new NotImplementedException();
        }
    }
}

//Registrar Requisição de Entrada:
//O usuário poderá fazer uma requisição de entrada de medicamento que incluirá:
//  * data da requisição;
//  * dados do medicamento;
//  * dados do fornecedor;
//  * dados do funcionário;
//  * quantidade requisitada do medicamento.
//  * a quantidade do medicamento deve ser atualizada.
//
//Visualizar Requisições de Entrada:
//Exibe uma lista exibindo detalhes de todas as requisições de Entrada registradas.
