using ComposicaoPedido.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicaoPedido.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }

        public OrderStatus Status { get; set; }
        public List<OrderItem> list { get; set; } = new List<OrderItem>();

        public Client Client { get; set; }
           
        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;

        }

        public void AddItem(OrderItem order)
        {
            list.Add(order);
        }

        public void RemoveItem (OrderItem order)
        {
            list.Remove(order);
        }

        public double Total()
        {
            double sum = 0;
            foreach(OrderItem obj in list)
            {
                sum=sum+(obj.SubTotal());
            }

            return sum;
        }


        public override string ToString()
        {
           

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order Summary:");
            sb.AppendLine("Order moment: " + Moment);
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine(Client.ToString());
            sb.AppendLine("Order items");

            for(int i= 0; i < list.Count; i++)
            {
                sb.AppendLine(list[i].ToString()+", Subtotal: " + list[i].SubTotal().ToString("F2"));

            }
            sb.AppendLine("Total price: " + Total().ToString("F2"));

            return sb.ToString();



        }
    }
}
