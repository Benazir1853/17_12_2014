using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSVLib;

namespace DailyExpenseApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string path = @"E:\dailyExpense.csv";

        private void saveButton_Click(object sender, EventArgs e)
        {
            string amount = amountTextBox.Text;
            string particular = particularTextBox.Text;
            string categoryEntry = categoryForEntryComboBox.Text;
            FileStream aFileStream = new FileStream(path, FileMode.Append);
          CsvFileWriter aStreamWriter = new CsvFileWriter(aFileStream);
            List<string> dailyExpense = new List<string>();
            dailyExpense.Add(amount);
            dailyExpense.Add(categoryEntry);
            dailyExpense.Add(particular);
            aStreamWriter.WriteRow(dailyExpense);
            aFileStream.Close();
            //aStreamWriter.Write(amount + "," + categoryEntry + "," + particular);
            //aStreamWriter.WriteLine();
            //aStreamWriter.Close();
            //aFileStream.Close();
            MessageBox.Show("Saved");
            particularTextBox.Text = "";
            amountTextBox.Text = "";
            categoryForEntryComboBox.Text = "";
         
        }

        private void showSummaryButton_Click(object sender, EventArgs e)
        {
            FileStream aFileStream = new FileStream(path, FileMode.Open);
            CsvFileReader aCsvFileReader = new CsvFileReader(aFileStream);
            List<string> dailyList = new List<string>();

            int sum = 0;
            int max = 0;
            while (aCsvFileReader.ReadRow(dailyList))
            {

                foreach (var item in dailyList)
                {
                    string amount = dailyList[0];
                    string category = dailyList[1];
                    string particular = dailyList[2];


                    //MessageBox.Show(amount + "" + category + "" + particular);
                    int x = Convert.ToInt32(amount);

                    sum = sum + x;


                    //if (max <x)



                    //int max = dailyList[0].Max();
                    //maximumExpenseTextBox.Text = Convert.ToString(max);
                    //showListBox.Items.Add(studentRegNo + " " + studentName);
                }
                
            }
            totalExpenseTextBox.Text = Convert.ToString(sum);
               
            //maximumExpenseTextBox.Text = Convert.ToString(max);
            aFileStream.Close();
        }

        private void showCategorywiseButton_Click(object sender, EventArgs e)
        {
            //string catagory = categoryForViewComboBox.Text;
            //if (catagory == "HouseRent")
            //{
            //    listBox1.Show("");
            //}
        }
    }
}
