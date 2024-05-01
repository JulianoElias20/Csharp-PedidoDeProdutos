using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicaoPedido.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public string Birth { get; set; }

        public Client()
        {
        }

        public Client(string name, string email, string birth)
        {
            Name = name;
            Email = email;
            Birth = birth;
        }

        public override string ToString()
        {
            return $"Client: {Name} ({Birth}) - {Email}";
        }
    }
}
