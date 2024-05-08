using ControleMedicamentos.ConsoleApp.Compartilhado;
using ControleMedicamentos.ConsoleApp.ModuloMedicamento;
using ControleMedicamentos.ConsoleApp.ModuloFornecedor;

namespace ControleMedicamentos.ConsoleApp.ModuloRequisicao
{
    internal class RequisicaoEntrada : EntidadeBase
    {

        public Medicamento medicamento { get; set; }
        public Fornecedor fornecedor { get; set; }
        public DateTime dataRequisicaoEntrada { get; set; }
        public int quantidadeEntrada { get; set; }

        public RequisicaoEntrada(Medicamento medicamentoSelecionado, Fornecedor fornecedorSelecionado, int quantidade)
        {
            this.medicamento = medicamentoSelecionado;
            this.fornecedor = fornecedorSelecionado;
            this.dataRequisicaoEntrada = DateTime.Now;
            this.quantidadeEntrada = quantidade;
        }

        public override string[] Validar()
        {
            string[] erros = new string[3];
            int contadorErros = 0;

            if (medicamento == null)
                erros[contadorErros++] = "O medicamento precisa ser preenchido";

            if (fornecedor == null)
                erros[contadorErros++] = "O fornecedor precisa ser informado";

            if (quantidadeEntrada < 1)
                erros[contadorErros++] = "Por favor informe uma quantidade válida";

            string[] errosFiltrados = new string[contadorErros];

            Array.Copy(erros, errosFiltrados, contadorErros);

            return errosFiltrados;
        }

        public bool AcrescentarMedicamento()
        {
            medicamento.Quantidade += quantidadeEntrada;
            return true;
        }
    }
}

//Registrar Requisição de Entrada:
//
//O usuário poderá fazer uma requisição de entrada de medicamento que incluirá:
    //data da requisição, dados do medicamento, dados do fornecedor, dados do funcionário e a quantidade requisitada do medicamento.
    //A quantidade do medicamento deve ser atualizada.
    //Visualizar Requisições de Entrada: Exibe uma lista exibindo detalhes de todas as requisições de Entrada registradas.
