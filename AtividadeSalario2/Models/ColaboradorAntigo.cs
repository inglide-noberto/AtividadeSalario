using System.Globalization;

namespace AtividadeSalario2.Models
{
    public class ColaboradorAntigo : Colaboradores
    {
        public ColaboradorAntigo(double salarioInicial)
        {
            SalarioInicial = salarioInicial;
        }
        public void Percentual(double salario)
        {
            this.SalarioInicial = salario;
            double x, percentual;

            if(salario > 7000)
            {
                x = 10;
            }
            else
            {
                Console.Write("Digite a porcentagem de aumento para esse funcionário. ***SOMENTE NUMEROS***");
                x = int.Parse(Console.ReadLine());
            }
            percentual = (x / 100) * salario;
            salario += percentual;

            Console.WriteLine("\nSalário atualizado: "+salario.ToString("F2", CultureInfo.InvariantCulture));
            Thread.Sleep(3000);
            Console.Clear();
        }
    }
}
