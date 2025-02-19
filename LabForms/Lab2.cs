using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabForms
{
    public partial class Lab2 : Form
    {
        private List<Ccount> ccounts = [];

        public Lab2()
        {
            InitializeComponent();

            var itemsCount = RandomNumberGenerator.GetInt32(3, 10);
            for (int i = 0; i < itemsCount; i++)
            {
                var countNumber = RandomNumberGenerator.GetInt32(10, 100);
                var value = RandomNumberGenerator.GetInt32(20, 400);
                var cost = RandomNumberGenerator.GetInt32(100, 1000);
                var dateTime = DateTime.Now - TimeSpan.FromDays(RandomNumberGenerator.GetInt32(1000));
                ccounts.Add(new(i, countNumber, value, countNumber, dateTime));
            }

            BindingSource bindingSource = new()
            {
                DataSource = ccounts
            };
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = bindingSource;
        }

        private class Ccount
        {
            public int Id { get; set; }

            public int CountNumber { get; set; }
            public int Value { get; set; }
            public int Cost { get; set; }

            public DateTime Date { get; set; }

            public Ccount() { }

            public Ccount(Ccount ccount)
            {
                Id = ccount.Id;
                CountNumber = ccount.CountNumber;
                Value = ccount.Value;
                Cost = ccount.Cost;
                Date = ccount.Date;
            }

            public Ccount(int id, int countNumber, int value, int cost, DateTime date)
            {
                Id = id;
                CountNumber = countNumber;
                Value = value; 
                Cost = cost;
                Date = date;
            }

            public override string ToString()
            {
                return $"Id: {Id}, CountNumber: {CountNumber}, Value: {Value}, Cost: {Cost}, Date: {Date}";
            }
        }
    }
}
