using ComposicaoPedido.Entities;
using ComposicaoPedido.Entities.Enums;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            Console.Write("");
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            string birth = Console.ReadLine();

            Client client = new Client(name, email, birth);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus orderstatus = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now, orderstatus, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Product name: ");
                string namep = Console.ReadLine();

                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());

                Product product = new Product(namep, price);

                Console.Write("Quantity: ");
                int qtd = int.Parse(Console.ReadLine());
                OrderItem orderitem = new OrderItem(qtd,product);

                order.AddItem(orderitem);



                
            }

            Console.WriteLine(order);
        }
    }
}
