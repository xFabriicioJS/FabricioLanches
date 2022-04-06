using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeunomeLanches
{
    internal class Program
    {
        struct Pedido
        {
            public string Id;
            public string Value;
            public string Name;


            public Pedido(string id, string value, string name)  //Construtor da Struct
            {
                Id = id;
                Value = value;
                Name = name;

            }

           

        }


            static void Main(string[] args)
        {
          Pedido lanche1 = new Pedido("01", "5", "X-Salada");
            Pedido lanche2 = new Pedido("02", "8", "X-Burger");
            Pedido lanche3 = new Pedido("03", "3", "HotDog");

            //Criando fila com a struct

            Queue<Pedido> fila = new Queue<Pedido>();
            fila.Enqueue(lanche1);
            fila.Enqueue(lanche2);
            fila.Enqueue(lanche3);

            foreach (var pedido in fila)
                Console.WriteLine($"O pedido é de um {pedido.Name}, com o valor de R${pedido.Value}, tendo o código de: {pedido.Id} ");
            Console.ReadKey();
            
        }

        
    }
}
