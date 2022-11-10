using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorial___recursion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(textBox1.Text);
                int y = factorial(x);
                label1.Text = "factorial " + x + " = " + y;
            }
            catch
            {
                
            }
         }

        int factorial (int x)
        {
            if (x == 0) return 1;
            return (x * factorial(x-1));
        }
    }
}
