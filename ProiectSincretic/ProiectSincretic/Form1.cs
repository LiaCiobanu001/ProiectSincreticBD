namespace ProiectSincretic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAutentificare_Click(object sender, EventArgs e)
        {
            Form f = new Form2();
            f.ShowDialog();
        }
    }
}