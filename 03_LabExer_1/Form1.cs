using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using _03_LabExer_1.Organization;


namespace _03_LabExer_1
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StudentInfo.SetFullname = txtLastName.Text + ", "
                    + txtFirstName.Text + " " + txtMi.Text;
                StudentInfo.SetStudentNo = int.Parse(txtStudent.Text);
                StudentInfo.SetProgram = comboBox1.Text;
                StudentInfo.SetGender = comboBox2.Text;
                StudentInfo.SetContactNo = long.Parse(txtNum.Text);
                StudentInfo.SetAge = int.Parse(txtAge.Text);
                StudentInfo.SetBirthday = dateTimePicker1.Value.ToString("yyyy-MM-dd");

                FrmConfirm frm = new FrmConfirm();
                frm.ShowDialog();
            }

            catch(FormatException)
            {
                MessageBox.Show("Invalid Student No. Format");
            }
            catch(Exception SetFullName)
            {
                MessageBox.Show("Invalid Name Format");
            }
            
 
            finally
            {
                Console.WriteLine("VALIDATION DONE.");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] ListofProgram = new string[]
           {
                "BS INFORMATION TECHNOLOGY",
                "BS COMPUTER SCIENCE",
                "BS INFORMATION SYSTEM",
                "BS ACCOUNTANCY",
                "BS HOSPITALITY MANAGEMENT",
                "BS TOURISM MANAGEMENT",
           };
            for (int i = 0; i < ListofProgram.Length; i++)
            {
                comboBox1.Items.Add(ListofProgram[i].ToString());
            }
            String[] ListofGen = new string[] {
                "MALE",
                "FEMALE"
            };
            for (int i = 0; i < ListofGen.Length; i++)
            {
                comboBox2.Items.Add(ListofGen[i].ToString());
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}