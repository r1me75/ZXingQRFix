using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QRPoc.Models
{
    public class Menu
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Menu(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
