using System;

namespace Atributos_e_Metodos_01_12_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem tony = new Personagem();
            tony.armadura = "Magic Plate Armor";

            Console.WriteLine(tony.nome);

            Console.WriteLine(tony.armadura);

            Console.WriteLine(tony.Atacar());
        }
    }
}
