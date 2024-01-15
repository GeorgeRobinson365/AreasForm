namespace AreasForm
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TriangleForm T = new TriangleForm();
            T.Show();
            Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CircleForm C = new CircleForm();
            C.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RectangleForm R = new RectangleForm();
            R.Show();
            Hide();
        }
    }
}
