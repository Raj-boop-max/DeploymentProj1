using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLLApp;
using DLLApp2;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClickThis_Click(object sender, EventArgs e)

        {
            String word = math.Word("Greatness!");
            String word2 = Class1.Word2("Comes with hardwork!");
            String result = word + "--" + word2;
            lblHelloWorld.Text = result;
        }

        
    }
}
