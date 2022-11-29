namespace AtividadeSalario2.Models
{
    public class ColaboradorNovo : Colaboradores
    {
        public void ToString2()
        {
            Console.WriteLine($"\n** ATENÇÃO ** \nO Colaborador não atinge os requisitos necessários para ter ajuste salarial.\n" +
                   $"Escolha outro colaborador ou feche o programa!\n");

            Thread.Sleep(5000);
            Console.Clear();
        }
    }
}
