using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleMedicamentos.ConsoleApp.Compartilhado;
using ControleMedicamentos.ConsoleApp.ModuloMedicamento;
using ControleMedicamentos.ConsoleApp.ModuloPaciente;

namespace ControleMedicamentos.ConsoleApp.ModuloRequisicaoEntrada
{
    internal class RequisicaoEntrada : EntidadeBase
    {
        public Medicamento Medicamento { get; set; }
        //public Fornecedor fornecedor { get; set; }
        public DateTime DataRequisicao { get; set; }
        public int QuantidadeRetirada { get; set; }

        public override string[] Validar()
        {
            throw new NotImplementedException();
        }

        public bool EntradaMedicamento()
        {
            if (Medicamento.Quantidade < QuantidadeRetirada)
                return false;

            Medicamento.Quantidade -= QuantidadeRetirada;
            return true;
        }
    }
}
