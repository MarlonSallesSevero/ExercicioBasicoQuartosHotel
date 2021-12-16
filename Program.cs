using System;

namespace ExercicioQuartosHotel
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Quarto[] quartos = new Quarto[10];
            Console.Write("Quantos Estudantes Vao se Ospedar?");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe quartos de 0 a 9 !!!!");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Informe o numero do quarto:");
                int num = int.Parse(Console.ReadLine());
                if (num <= 9 && num >= 0)
                {
                    Console.Write($"Informe o nome do hospede {i + 1} :");
                    string nome = Console.ReadLine();
                    Console.Write($"Informe o email do hospede {i + 1} :");
                    string email = Console.ReadLine();
                    Console.Write($"Informe a idade do hospede {i + 1}:");
                    int idade = int.Parse(Console.ReadLine());
                    Console.Write("Informe a diaria:");
                    double diaria = double.Parse(Console.ReadLine());
                    Console.WriteLine("----------------------------------------------------");
                    quartos[num] = new Quarto(num, nome, idade, email, diaria);
                }
                else
                {
                    Console.WriteLine("Num Invalido!!!");
                    break;
                }
            }
            for (int z = 0; z < n; z++)
            {
                if (quartos[z] != null)
                {
                    Console.WriteLine($"Quarto {quartos[z].Num}, hospedado por {quartos[z].Nome}, {quartos[z].Idade} anos\n" +
                    	$"Valor diario:{quartos[z].Diaria}\nEmail : {quartos[z].Email}\n" +
                    		$"----------------------------------------------------------------------");
                }
            }
        }
    }
}
