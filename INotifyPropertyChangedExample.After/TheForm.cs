using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INotifyPropertyChangedExample.After
{
    public partial class TheForm : Form
    {

        public TheClass TheClass { get; set; }

        public TheForm()
        {
            InitializeComponent();
        }

        private void TheForm_Load(object sender, EventArgs e)
        {
            TheClass = new TheClass();

            // ReSharper disable once SuspiciousTypeConversion.Global
            ((INotifyPropertyChanged)TheClass).PropertyChanged += TheClass_PropertyChanged;
        }

        private void TheClass_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            txtOutput.AppendText("Property Changed " + e.PropertyName + "\r\n");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            TheClass.FirstName = txtFirstName.Text;
            txtOutput.AppendText("----------------------\r\n");
        }

        private void btnUpdate2_Click(object sender, EventArgs e)
        {
            TheClass.LastName = txtLastName.Text;
            txtOutput.AppendText("----------------------\r\n");
        }
    }
}
