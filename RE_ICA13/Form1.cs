using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;

namespace RE_ICA13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
    public class MyRandom : Random
    {
        private int maxSize;
        public MyRandom(int maxSize)
        {
            this.maxSize = maxSize;
        }
        public Rectangle NextDrawerRect(CDrawer gdi)
        {

            return new Rectangle();
        }
    
    }
  


}
