using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _03_LabExer_1.Organization;

namespace _03_LabExer_1
{
    public partial class FrmConfirm : Form
    {
        public FrmConfirm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lblStudenNo.Text = StudentInfo.SetStudentNo.ToString();
            lblName.Text = StudentInfo.SetFullname;
            lblProgram.Text = StudentInfo.SetProgram;
            lblBirthday.Text = StudentInfo.SetBirthday;
            lblGender.Text = StudentInfo.SetGender;
            lblContactNo.Text = StudentInfo.SetContactNo.ToString();
            lblAge.Text = StudentInfo.SetAge.ToString();

            
        }
    }
}
