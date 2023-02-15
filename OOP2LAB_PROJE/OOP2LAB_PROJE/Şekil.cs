using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP2LAB_PROJE
{
    internal class Şekil
    {
        private int model; // 0->daire 3->üçgen 4->kare
        private Color renk; 
        public Image image ;

        public Point konum;
        public Şekil(int model, Color renk)
        {
            this.model = model;
            this.renk = renk;
            if (model == 0)
            {
                if (renk == Color.Red)
                {
                    image = Image.FromFile("Kırmızı_Daire.png");
                }
                else if (renk == Color.Green)
                {
                    image = Image.FromFile("Yeşil_Daire.png");
                }
                else if (renk == Color.Yellow)
                {
                    image = Image.FromFile("Sarı_Daire.png");
                }
            }
            else if (model == 3)
            {
                if (renk == Color.Red)
                {
                    image = Image.FromFile("Kırmızı_Üçgen.png");
                }
                else if (renk == Color.Green)
                {
                    image = Image.FromFile("Yeşil_Üçgen.png");
                }
                else if (renk == Color.Yellow)
                {
                    image = Image.FromFile("Sarı_Üçgen.png");
                }
            }
            else if (model == 4)
            {
                if (renk == Color.Red)
                {
                    image = Image.FromFile("Kırmızı_Kare.png");
                }
                else if (renk == Color.Green)
                {
                    image = Image.FromFile("Yeşil_Kare.png");
                }
                else if (renk == Color.Yellow)
                {
                    image = Image.FromFile("Sarı_Kare.png");
                }
            }
        }
        public Şekil(Point konum)
        {
            this.konum = konum;
        }



    }
}
