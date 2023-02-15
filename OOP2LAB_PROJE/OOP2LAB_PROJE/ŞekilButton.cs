using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace OOP2LAB_PROJE
{
    public class ŞekilButton:Button
    {
        public int model; // 0->daire 3->üçgen 4->kare
        public Color renk;
        public bool visited=false;
        //public Image image ;

        //public Point konum;
        public ŞekilButton(int model, Color renk)
        {
            this.model = model;
            this.renk = renk;
            if (model == 0)
            {
                if (renk == Color.Red)
                {
                    this.Image = Image.FromFile("Kırmızı_Daire.png");
                }
                else if (renk == Color.Green)
                {
                    this.Image = Image.FromFile("Yeşil_Daire.png");
                }
                else if (renk == Color.Yellow)
                {
                    this.Image = Image.FromFile("Sarı_Daire.png");
                }
            }
            else if (model == 3)
            {
                if (renk == Color.Red)
                {
                    this.Image = Image.FromFile("Kırmızı_Üçgen.png");
                }
                else if (renk == Color.Green)
                {
                    this.Image = Image.FromFile("Yeşil_Üçgen.png");
                }
                else if (renk == Color.Yellow)
                {
                    this.Image = Image.FromFile("Sarı_Üçgen.png");
                }
            }
            else if (model == 4)
            {
                if (renk == Color.Red)
                {
                    this.Image = Image.FromFile("Kırmızı_Kare.png");
                }
                else if (renk == Color.Green)
                {
                    this.Image = Image.FromFile("Yeşil_Kare.png");
                }
                else if (renk == Color.Yellow)
                {
                    this.Image = Image.FromFile("Sarı_Kare.png");
                }
            }
        }
        public ŞekilButton(Point location)
        {
            this.Location = location;
        }

        public ŞekilButton()
        {
            
        }

    }
}
