namespace LabForms
{
    public partial class FormExloler : Form
    {
        public FormExloler()
        {
            InitializeComponent();
        }
        private static void OpenForm(Form lab)
        {
            lab.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenForm(new Lab1());
        }


        private void button2_Click(object sender, EventArgs e)
        {
            OpenForm(new Lab2());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenForm(new Lab3());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenForm(new Lab4());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenForm(new Lab5());
        }
    }
}
