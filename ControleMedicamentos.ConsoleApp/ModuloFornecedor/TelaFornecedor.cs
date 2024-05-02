using ControleMedicamentos.ConsoleApp.Compartilhado;

namespace ControleMedicamentos.ConsoleApp.ModuloFornecedor
{
    internal class TelaFornecedor : TelaBase
    {
        public override void VisualizarRegistros(bool exibirTitulo)
        {
            if (exibirTitulo)
            {
                ApresentarCabecalho();
                Console.WriteLine("Visializando Fornecedores...");
            }
            Console.WriteLine();

            Console.WriteLine(
                "{0, -10} | {1, -20} | {2, -20} | {3, -20}",
                "Id", "Nome", "Telefone", "Cnpj"
                );

            EntidadeBase[] fornecedoresCadatrados = repositorio.SelecionarTodos();

            foreach (Fornecedor fornecedor in fornecedoresCadatrados)
            {
                if (fornecedor == null)
                    continue;

                Console.WriteLine(
                    "{0, -10} | {1, -20} | {2, -20} |{3, -20}",
                    fornecedor.Id, fornecedor.Nome, fornecedor.Telefone, fornecedor.Cnpj
                );
            }

            Console.ReadLine();
            Console.WriteLine();
        }
        protected override EntidadeBase ObterRegistro()
        {
            Console.WriteLine("Digite o nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o telefone: ");
            string telefone = Console.ReadLine();

            Console.WriteLine("Digite o cnpj: ");
            string cnpj = Console.ReadLine();

            Fornecedor fornecedor = new Fornecedor(nome, telefone, cnpj);
            return fornecedor;
        }
    }
}
