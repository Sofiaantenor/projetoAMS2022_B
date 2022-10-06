using System;

namespace ATV_QuantidadeDeDiasMensaisComIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
             string Meses;

            Console.WriteLine("Digite aqui um número correspondente a um mês ou o nome do mês em qustão, o que preferir: ");
              Meses = Console.ReadLine();
            

            if (Meses == "1")
            {
                Console.WriteLine(" O mês de Janeiro tem 31 dias ");
            }
            else if (Meses == "Janeiro")
            {
                Console.WriteLine(" Esse mês tem 31 dias ");
            }
            else if (Meses == "2")
            {
                Console.WriteLine(" O mês de Fevereiro tem geralmente 28 dias, mas em anos bissextos possui 29 dias");
            }
            else if (Meses == "Fevereiro")
            {
                Console.WriteLine(" Esse mês tem geralmente 28 dias, mas em anos bissextos possui 29 dias");
            }
            else if (Meses == "3")
            {
                Console.WriteLine(" O mês de Março tem 31 dias");
            }
            else if (Meses == "Março")
            {
                Console.WriteLine(" Esse mês tem 31 dias");
            }
            else if (Meses == "4")
            {
                Console.WriteLine(" O mês de Abril tem 30 dias");
            }
            else if (Meses == "Abril")
            {
                Console.WriteLine(" Esse mês tem 30 dias");
            }
            else if (Meses == "5")
            {
                Console.WriteLine(" O mês de Maio tem 31 dias");
            }
            else if (Meses == "Maio")
            {
                Console.WriteLine(" O mês de Maio tem 31 dias");
            }
            else if (Meses == "6")
            {
                Console.WriteLine(" O mês de Junho tem 30 dias");
            }
            else if (Meses == "Junho")
            {
                Console.WriteLine(" Esse mês tem 30 dias");
            }
            else if (Meses == "7")
            {
                Console.WriteLine(" O mês de Julho tem 31 dias");
            }
            else if (Meses == "Julho")
            {
                Console.WriteLine(" Esse mês tem 31 dias");
            }
            else if (Meses == "8")
            {
                Console.WriteLine(" O mês de Agosto tem 31 dias");
            }
            else if (Meses == "Agosto")
            {
                Console.WriteLine(" Esse mês tem 31 dias");
            }
            else if (Meses == "9")
            {
                Console.WriteLine(" O mês de Setembro tem 30 dias");
            }
            else if (Meses == "Setembro")
            {
                Console.WriteLine(" Esse mês tem 30 dias");
            }
            else if (Meses == "10")
            {
                Console.WriteLine(" O mês de Outubro tem 31 dias");
            }
            else if (Meses == "Outubro")
            {
                Console.WriteLine(" Esse mês tem 31 dias");
            }
            else if (Meses == "11")
            {
                Console.WriteLine(" O mês de Novembro tem 30 dias");
            }
            else if (Meses == "Novembro")
            {
                Console.WriteLine(" Esse mês tem 30 dias");
            }
            else if (Meses == "12")
            {
                Console.WriteLine(" O mês de Dezembro tem 31 dias");
            }
            else if (Meses == "Dezembro")
            {
                Console.WriteLine(" Esse mês tem 31 dias");
            }
            else 
            {
                Console.WriteLine(" Ocorreu algum erro de digitação, por favor corrijio-o!");
            }
        }
    }
}
