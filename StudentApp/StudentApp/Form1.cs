using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Student aStudent = new Student();

        private void showButton_Click(object sender, EventArgs e)
        {
            aStudent.regNo = regNoTextBox.Text;
            aStudent.firstName = firstNameTextBox.Text;
            aStudent.lastName = lastNameTextBox.Text;
            string fullName = aStudent.GetFullName();
            MessageBox.Show("Name:" + fullName + "\nRegNo: " + aStudent.regNo);
            ClearTextBoxes();
        }

        private void retrieveButton_Click(object sender, EventArgs e)
        {
            regNoTextBox.Text = aStudent.regNo;
            lastNameTextBox.Text = aStudent.lastName;
            firstNameTextBox.Text = aStudent.firstName;
        }

        public void ClearTextBoxes()
        {
            regNoTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            firstNameTextBox.Text = string.Empty;
        }
    }
}
