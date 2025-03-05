namespace LabForms.Lab2.DialogForms;

public partial class EditRowTableDialog : Form
{
    private readonly Lab2Form fatherForm;
    private readonly CCount selectedCCount;

    public EditRowTableDialog(
        Lab2Form fatherForm,
        CCount selectedCCount)
    {
        this.fatherForm = fatherForm;
        this.selectedCCount = selectedCCount;

        InitializeComponent();
        InitBoxes();
    }

    private void InitBoxes()
    {
        ValueBox.Text = selectedCCount.Value.ToString();
        CountBox.Text = selectedCCount.Value.ToString();
        CostBox.Text = selectedCCount.Value.ToString();
        DatePicker1.Text = selectedCCount.Date.ToString();
    }

    private void EditButton_Click(object sender, EventArgs e)
    {
        bool isError = false;

        if (!int.TryParse(CountBox.Text, out int count))
        {
            isError = true;
            CountBox.ForeColor = Color.Red;
        }
        if (!int.TryParse(ValueBox.Text, out int value))
        {
            isError = true;
            ValueBox.ForeColor = Color.Red;
        }
        if (!int.TryParse(CostBox.Text, out int cost))
        {
            isError = true;
            CostBox.ForeColor = Color.Red;
        }

        if (isError)
        {
            MessageBox.Show("Ошибка ввода!", $"Неверный ввод полей!");
            return;
        }

        var date = DateTime.Parse(DatePicker1.Text);

        fatherForm.EditList(new()
        {
            Cost = cost,
            Date = date,
            CountNumber = count,
            Id = selectedCCount.Id,
            Value = value,
        }, false);

        Close();
    }
}
