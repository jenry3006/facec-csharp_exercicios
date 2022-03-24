using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacecExercicioListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Por favor informe seu nome");
                var nome = Console.ReadLine();

                Console.WriteLine("Informe sua data de nascimento agora!! No formato dd/mm/yyyy");
                var dataNascimento = DateTime.Parse(Console.ReadLine());

                Console.WriteLine(ObterMensagemFaixaEtaria(nome, dataNascimento));

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);  
            } finally
            {
                Console.ReadLine();           
            }   

        }

        private static string ObterMensagemFaixaEtaria(string nome, DateTime dataNascimento)
        {
            var idade = DateTime.Today.Year - dataNascimento.Year;
            if (idade >=60)
                return $"{nome} é velho";
            else if (idade >= 20 && idade <= 59)
                return $"{nome} é adulto";
            return $"{nome} é jovem";
        }
    }
}
