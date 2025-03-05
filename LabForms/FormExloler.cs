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

        private void Lab1Button_Click(object sender, EventArgs e)
        {
            OpenForm(new Lab1Form());
        }

        private void Lab2Button_Click(object sender, EventArgs e)
        {
            OpenForm(new Lab2Form());
        }

        private void Lab3Button_Click(object sender, EventArgs e)
        {
            OpenForm(new Lab3Form());
        }

        private void Lab4Button_Click(object sender, EventArgs e)
        {
            OpenForm(new Lab4Form());
        }

        private void Lab5Button_Click(object sender, EventArgs e)
        {
            OpenForm(new Lab5Form());
        }

        private void Lab6Button_Click(object sender, EventArgs e)
        {
            //OpenForm(new Lab6Form());
        }

        private void Lab7Button_Click(object sender, EventArgs e)
        {
            //OpenForm(new Lab7Form());
        }

        private void Lab8Button_Click(object sender, EventArgs e)
        {
            //OpenForm(new Lab8Form());
        }
    }
}
