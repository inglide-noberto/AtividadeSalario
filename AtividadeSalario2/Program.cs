using AtividadeSalario2.Models;

class Program
{
    static void Main(string[] args)
    {
        Colaboradores funcionario = new Colaboradores();

        do
        {
            Console.WriteLine("********* SEJA BEM VINDO *********\n");
            Console.WriteLine("\nSelecione a operação que deseja realizar: ");
            Console.WriteLine("\n 1 - Atualizar Salário \n 2 - Fechar sistema");
            Console.Write("\n Digite a opção: ");
            string opcao = Console.ReadLine();

            if (opcao == "2")
            {
                break;
            }
            Console.Clear();

            Console.WriteLine("********* ATUALIZAR SALÁRIO *********\n");
            Console.Write("Digite o nome do funcionário: ");
            funcionario.NomeFuncionario = Console.ReadLine();
            
            Console.Write("Digite o cargo do funcionário: ");
            funcionario.Funcao = Console.ReadLine();

            Console.Write("Digite a data de inicio do funcionário: ");
            funcionario.DataInicio = Console.ReadLine();
            
            Console.Write("Digite o salário inicial do funcionário: ");
            funcionario.SalarioInicial = double.Parse(Console.ReadLine());

            funcionario.ValidarData(funcionario.DataInicio);

        }
        while (true);

    }
}