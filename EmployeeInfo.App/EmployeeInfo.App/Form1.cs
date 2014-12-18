using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInfo.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EmployeeInfo aEmployeeInfo = new EmployeeInfo();
        

        private void showButton_Click(object sender, EventArgs e)
        {
            aEmployeeInfo.id = idTextBox.Text;
            aEmployeeInfo.name = nameTextBox.Text;
            aEmployeeInfo.salary = Convert.ToDouble(salaryTextBox.Text);
            MessageBox.Show("Employee ID: "+aEmployeeInfo.id+ "\nEmployee Name: "+aEmployeeInfo.name+ "\nEmployee Salary:  " +aEmployeeInfo.salary);
            idTextBox.Text = "";
            nameTextBox.Text = "";
            salaryTextBox.Text = "";
        }

        private void retrieveButton_Click(object sender, EventArgs e)
        {
            idTextBox.Text = aEmployeeInfo.id;
            nameTextBox.Text = aEmployeeInfo.name;
            salaryTextBox.Text = Convert.ToString(aEmployeeInfo.salary);

        }
    }
}
