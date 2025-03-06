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
        CountBox.Text = selectedCCount.CountNumber.ToString();
        CostBox.Text = selectedCCount.Cost.ToString();
        DatePicker1.Text = selectedCCount.Date.ToString();
    }

    private void EditButton_Click(object sender, EventArgs e)
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
