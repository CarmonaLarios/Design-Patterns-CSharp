using System;

namespace FaktoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha o transporte desejado:");
            Console.WriteLine("1) Carro  2) Moto  3) Avião");
            int opcaoUsuario = int.Parse(Console.ReadLine());

            TransporteFaktory transporteFaktory = new TransporteFaktory();
            Transporte transporte = transporteFaktory.CriarTransporte((Tipos.ETipoTransporte) opcaoUsuario);

            Console.WriteLine($"O transporte escolhido foi: {transporte.descricao}");
            Console.WriteLine($"Capacidade de passageiros: {transporte.totalPassageiros}");
            Console.ReadKey();
        }
    }
}
