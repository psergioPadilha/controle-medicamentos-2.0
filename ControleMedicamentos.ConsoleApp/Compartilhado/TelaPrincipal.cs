﻿namespace ControleMedicamentos.ConsoleApp.Compartilhado
{
    internal static class TelaPrincipal
    {
        public static char ApresentarMenuPrincipal()
        {
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("|       Controle de Medicamentos       |");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine();

            Console.WriteLine("1 - Cadastro de Pacientes");
            Console.WriteLine("2 - Cadastro de Medicamentos");
            Console.WriteLine("3 - Cadastro de Requisições de Saída");
            Console.WriteLine("4 - Cadastro de Funcionários");
            Console.WriteLine("5 - Cadastro de Fornecedor");

            Console.WriteLine("S - Sair");

            Console.WriteLine();

            Console.Write("Escolha uma das opções: ");

            char opcaoEscolhida = Console.ReadLine()[0];

            return opcaoEscolhida;
        }
    }
}
