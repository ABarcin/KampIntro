using System;
using System.Collections.Generic;
using System.Text;

namespace Methodlar
{
    class Urun //encapculation kapsülleme ayrı ayrı yazıp düzensiz olan yapıyı düzenli hale getirmek
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int stokAdeti { get; set; }//sonradan ekledik :)

    }
}
