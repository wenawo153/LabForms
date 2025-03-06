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
        List<ReadErrors> errors = [];

        if (!int.TryParse(CountBox.Text, out int count))
        {
            errors.Add(ReadErrors.CountError);
            CountBox.ForeColor = Color.Red;
        }
        if (!int.TryParse(ValueBox.Text, out int value))
        {
            errors.Add(ReadErrors.ValueError);
            ValueBox.ForeColor = Color.Red;
        }
        if (!int.TryParse(CostBox.Text, out int cost))
        {
            errors.Add(ReadErrors.CostError);
            CostBox.ForeColor = Color.Red;
        }

        if (errors.Count != 0)
        {
            var readErrorsStr = ReadErrorTool.GenerateReadErrorString(errors);
            MessageBox.Show($"Неверный ввод полей: {readErrorsStr}!", "Ошибка ввода!");
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
}
