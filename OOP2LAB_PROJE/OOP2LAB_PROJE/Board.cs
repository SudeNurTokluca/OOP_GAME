using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP2LAB_PROJE
{
    internal class Board
    {
        Size boyut;
        List<ŞekilButton> şekiller;
        public int puan;
        public Board(Size b,int P)
        {
            şekiller = new List<ŞekilButton>();
            boyut = b;
            puan = P;
        }
        public Size size {
            get
            {
                return boyut;
            }
        }
       
        public List<ŞekilButton> Get_Şekiller()
        {
            return şekiller;
        }
        public void Şekil_Ekle(ŞekilButton ş)
        {
            şekiller.Add(ş);
        }
    }
}
