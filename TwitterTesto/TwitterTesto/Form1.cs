using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitterTesto
{
    public partial class Form1 : Form
    {

        static string toSet = "NUTTIN";

        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("Point 11");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //testLabel.Text = toSet;
            Console.WriteLine("Point 10");
        }

        public static void setLabel(string s)
        {
            toSet = s.Substring(100, 20);
            Console.Write("WE GOT HEREEEEEEEEEEE" + toSet);
            Console.WriteLine("Point 12");
            
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            Program.refresh();
            testLabel.Text = toSet;
            Console.WriteLine("Point 13");
        }

        private void testLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
