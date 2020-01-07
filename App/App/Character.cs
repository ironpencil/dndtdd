using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class Character
    {
        public string Name { get; set; }
        public Alignment Alignment { get; set; }
        public int ArmorClass { get; set; } = 10;

        public Character() { }

        public Character(string name)
        {
            Name = name;
        }
    }
}
