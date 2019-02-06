using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_Grades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GradeCmd_Click(object sender, EventArgs e)
        {
            int mark;
            //Convert the mark from a string to an integer
            mark = Convert.ToInt16(txtMark.Text);
            if (mark >= 90)
            {
                MessageBox.Show("Distinction");
            }
            if (mark <= 89)
            {
                MessageBox.Show("Merit");
            }
            else if (mark <= 11)
                MessageBox.Show("Pass");
            if(mark <= 0)
            {
                MessageBox.Show("Fail");
            }

        }
        
    }
}
