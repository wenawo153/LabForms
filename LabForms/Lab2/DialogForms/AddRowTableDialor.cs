using System.ComponentModel;

namespace LabForms.Lab2.DialogForms;

public partial class AddRowTableDialor : Form
{
    private readonly Lab2Form fatherForm;

    public AddRowTableDialor(Lab2Form fatherForm)
    {
        this.fatherForm = fatherForm;

        InitializeComponent();
    }

    private void AddButton_Click(object sender, EventArgs e)
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

        var id = fatherForm.GetLegacyId();
        var date = DateTime.Parse(DatePicker1.Text);

        fatherForm.EditList(new()
        {
            Cost = cost,
            Date = date ,
            CountNumber = count,
            Id = id,
            Value = value,
        }, true);

        Close();
    }

    public enum ReadErrors
    {
        CountError,
        ValueError,
        CostError
    }
}
