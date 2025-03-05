using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabForms.Extensions
{
    public partial class ErrorDialog : Form
    {
        public ErrorDialog(string errorName, string? errorMessege)
        {
            InitializeComponent();

            ErrorLabel.Text = errorName;
            ErrorMessegaLabel.Text = errorMessege;
        }
    }
}
