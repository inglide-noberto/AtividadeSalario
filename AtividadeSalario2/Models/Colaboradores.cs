
namespace AtividadeSalario2.Models
{
    public class Colaboradores
    {
        public string NomeFuncionario;
        public string Funcao;
        public string DataInicio;
        public double SalarioInicial;

        public override string ToString()
        {
            return ("Funcionario cadastrado! " + NomeFuncionario +
                    ", Função: " + Funcao + " com salario inicial: "+ SalarioInicial);
        }
        public void ValidarData(string data)
        {
            ColaboradorAntigo CA = new ColaboradorAntigo(SalarioInicial);

            DateTime data1, data2;
            TimeSpan resultado;

            data1 = DateTime.Parse(data);
            data2 = DateTime.Now;

            resultado = data2- data1;
            int tempo = (resultado.Days / 30 / 12);

            if(tempo < 4 )
            {
                ColaboradorNovo novo= new ColaboradorNovo();
                novo.ToString2();
            }
            else
            {
                ColaboradorAntigo antigo = new ColaboradorAntigo(SalarioInicial);
                antigo.Percentual(SalarioInicial);
            }

        }
    }
}
