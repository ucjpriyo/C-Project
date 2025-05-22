using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string taskName = txtTask.Text;
            string dueDate = txtDueDate.Text;

            // No validation in v1.0
            string taskEntry = taskName + " - Due: " + dueDate;
            listBoxTasks.Items.Add(taskEntry);

            // Clear inputs
            txtTask.Clear();
            txtDueDate.Clear();
        }

    }
}
