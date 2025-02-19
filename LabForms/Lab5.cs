using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabForms
{
    public partial class Lab5 : Form
    {
        private int a;
        private int b;

        public Lab5()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                var timeA = int.Parse(textBox1.Text);
                var timeB = int.Parse(textBox2.Text);

                int threeSymbolsNumberCount = 0;
                if (timeA / 100 < 10 && timeA / 100 > 0) threeSymbolsNumberCount++;
                if (timeB / 100 < 10 && timeB / 100 > 0) threeSymbolsNumberCount++;

                if (threeSymbolsNumberCount != 1) return;

                a = timeA;
                b = timeB;
            }
            catch
            {
                throw new ParseException();
            }
        }

        private class ParseException : Exception
        {
            public ParseException() : base(message: "Ошибка ввода!") { }
        }
    }
}
