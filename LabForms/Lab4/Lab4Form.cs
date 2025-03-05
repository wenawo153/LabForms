namespace LabForms;

public partial class Lab4Form : Form
{
    private LinkedList<double> sourceList = [];
    private LinkedList<double> resultList = [];

    public Lab4Form()
    {
        InitializeComponent();
    }

    private void SwithToDefaultParams()
    {
        dTextBox.ForeColor = Color.Black;
        d1TextBox.ForeColor = Color.Black;
        d2TextBox.ForeColor = Color.Black;
    }

    private void InitList()
    {
        bool isError = false;
        if (double.TryParse(dTextBox.Text, out double d))
        {
            isError = true;
            dTextBox.ForeColor = Color.Red;
        };
        if (double.TryParse(d1TextBox.Text, out double d1))
        {
            isError = true;
            d1TextBox.ForeColor = Color.Red;
        };
        if (double.TryParse(d2TextBox.Text, out double d2))
        {
            isError = true;
            d2TextBox.ForeColor = Color.Red;
        };
        if (isError)
        {
            MessageBox.Show("Ошибка ввода!", "Проверьте поля D");
            return;
        }

    }
}