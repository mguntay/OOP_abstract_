using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Abstruct_
{
    public abstract class Enstruman
    {
        public string Markasi { get; set; }
        public string Aciklamasi { get; set; }
        public abstract string Cal();

    }
    public class Bateri :Enstruman
    {
        public override string Cal()
        {
            return "Bateri Sesi";
        }
    }
    public class Keman :Enstruman
    {
        public override string Cal()
        {
            return "Keman Sesi";
        }
    }

}
