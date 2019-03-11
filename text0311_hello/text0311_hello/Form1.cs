using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace text0311_hello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Hello!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = DateTime.Now.ToString();
            //button2 OK OK
            //master OK OK
        }
    }
}
