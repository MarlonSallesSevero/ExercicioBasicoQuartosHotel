using System;
namespace ExercicioQuartosHotel
{
    public class Quarto
    {
        public int Num { get; private set; }
        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public string Email { get; private set; }
        public double Diaria { get; private set; }
        public Quarto(int num, string nome, int idade, string email, double diaria)
        {
            Num = num;
            Nome = nome;
            Idade = idade;
            Email = email;
            Diaria = diaria;
        }
    }
}
