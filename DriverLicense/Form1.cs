using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DriverLicense
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string[] correctAnswer = { "A", "A", "A", "A", "A", "A", "A", "A", "A", "A", "A", "A", "A", "A", "A",
                "A","A","A","A","A"};
            
            string[] studentArr = new string[20];

            List<string> incorect = new List<string>();
            int count = 0, i = 0, qn = 0;
            try
            {
                string filename = textBox1.Text;
                StreamReader inputFile = File.OpenText(filename);
                while (i< 20)
                {

                    studentArr[i] = inputFile.ReadLine();
                    if (studentArr[i] == correctAnswer[i])
                    {
                        count++;
                    }
                    else
                    {
                        qn = i + 1;
                        incorect.Add(qn.ToString());
                    }
                    i++;
                }
                inputFile.Close();

                if (count >= 15)
                {
                    label5.Text = "Result: You passed";
                }
                else
                {
                    label5.Text = "Result: You failed";
                }
                label4.Text = "";
                foreach (string str in incorect)
               {
                   label4.Text +=  str + " ";
               }
            }
            catch {


                MessageBox.Show("loh"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label5.Text = "";
            label4.Text = "";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
