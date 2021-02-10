using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cash_Register
{
    public partial class backround : Form
    {
        int computer = 750;
        int television = 500;
        int smartphone = 635;
        double tax = 0.13;
        double subtotal;
        double totalcost;
        double change;
        double tendered;
        
        

        public backround()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
