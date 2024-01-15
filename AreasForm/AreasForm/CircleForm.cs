using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AreasForm
{
    public partial class CircleForm : Form
    {
        public CircleForm()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = int.Parse(textBox1.Text);
            double area = Math.PI * (a * a);
            double perimeter = 2 * Math.PI * a;
            MessageBox.Show($"The area is: {area} and the perimeter is: {perimeter}");
        }
    }
}
