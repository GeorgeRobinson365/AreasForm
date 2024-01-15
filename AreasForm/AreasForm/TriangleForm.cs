using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreasForm
{
    public partial class TriangleForm : Form
    {
        public TriangleForm()
        {
            InitializeComponent();
            
    }
        private void button1_Click(object sender, EventArgs e)
        {
            double a = int.Parse(textBox1.Text);
            double b = int.Parse(textBox2.Text);
            double c = int.Parse(textBox3.Text);

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));


            double perimeter = a + b +c ;
            MessageBox.Show($"The area is: {area} and the perimeter is: {perimeter}");
        }
    }
}
