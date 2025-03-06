using System.Security.Cryptography;
using LabForms.Lab2;
using LabForms.Lab2.DialogForms;

namespace LabForms;

public partial class Lab2Form : Form
{
    private readonly List<CCount> cCounts = [];
    private readonly BindingSource bindingSource;

    public Lab2Form()
    {
        InitializeComponent();

        var itemsCount = RandomNumberGenerator.GetInt32(3, 10);
        for (int i = 1; i <= itemsCount; i++)
        {
            var countNumber = RandomNumberGenerator.GetInt32(10, 100);
            var value = RandomNumberGenerator.GetInt32(20, 400);
            var cost = RandomNumberGenerator.GetInt32(100, 1000);
            var dateTime = DateTime.Now - TimeSpan.FromDays(RandomNumberGenerator.GetInt32(1000));
            cCounts.Add(new(i, countNumber, value, cost, dateTime));
        }


        bindingSource = new()
        {
            DataSource = cCounts
        };
        dataGridView1.AutoGenerateColumns = true;
        dataGridView1.DataSource = bindingSource;

        dataGridView1.Columns[1].HeaderText = "Номер счет-фактуры";
        dataGridView1.Columns[2].HeaderText = "Сумма к уплате";
        dataGridView1.Columns[3].HeaderText = "Стоимость приобретения";
        dataGridView1.Columns[4].HeaderText = "Дата выписки счет-фактуры";
    }

    public void EditList(CCount cCount, bool isNew)
    {
        if (isNew)
            bindingSource.Add(cCount);
        else
            for (int i = 0; i < cCounts.Count; i++)
            {
                if (cCounts[i].Id == cCount.Id) cCounts[i] = cCount;
            }
        Refresh();
    }

    public int GetLegacyId()
    {
        var max = cCounts.Select(_ => _.Id).Max();
        return max + 1;
    }

    private void AddButton_Click(object sender, EventArgs e)
    {
        var dialog = new AddRowTableDialor(this);
        dialog.ShowDialog();
    }

    private void EditButton_Click(object sender, EventArgs e)
    {
        var row = dataGridView1.SelectedRows;
        if (row.Count != 1)
        {
            MessageBox.Show("Должна быть выбрана одна строка", "Ошибка!");
            return;
        };

        var dialog = new EditRowTableDialog(this, ParseRow(row[0]));
        dialog.ShowDialog();
    }

    private void DeleteButton_Click(object sender, EventArgs e)
    {
        var rows = dataGridView1.SelectedRows;

        for (int i = 0; i < rows.Count; i++)
        {
            try
            {
                var cCount = cCounts.First(_ => _.Id == (int)(rows[i].Cells[0].Value)!);
                bindingSource.Remove(cCount);
            }
            catch { }
        }
    }

    private static CCount ParseRow(DataGridViewRow row)
    {
        return new()
        {
            Id = (int)(row.Cells[0].Value)!,
            CountNumber = (int)(row.Cells[1].Value)!,
            Value = (int)(row.Cells[2].Value)!,
            Cost = (int)(row.Cells[3].Value)!,
            Date = (DateTime)row.Cells[4].Value!,
        };
    }
}
