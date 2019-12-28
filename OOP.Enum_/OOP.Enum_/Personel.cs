using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP.Enum_
{
    public enum Departman
    {
        Yazılım,
        Sistem,
        TeknikCizim,
        Ofis,
        Muhasebe
    }
    public class Personel
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public Color SacRengi { get; set; }
        public Departman Departman { get; set; }
    }
}
