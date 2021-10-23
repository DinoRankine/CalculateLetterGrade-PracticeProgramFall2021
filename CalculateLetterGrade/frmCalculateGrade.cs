using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateLetterGrade
{
    public partial class frmCalculateGrade : Form
    {
        public frmCalculateGrade()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //1) hidden label on the form
            // - if number grade is 85 or higher, display Dean's List
            // - use constant for 85
            int grade = Convert.ToInt32(txtNumberGrade.Text);
            const int DEANMARK = 85;

            if (grade >= DEANMARK)
                lblDean.Text = "Dean's List";
            //2) if number grade is 60 or above
            // - display Pass in outcome, otherwise Fail
            // - use constants for 60, Pass and Fail
            const int PASSMARK = 60;
            const string PASS = "Pass", FAIL = "Fail";


            if (grade >= PASSMARK)
                lblOutcome.Text = PASS;
            else
                lblOutcome.Text = FAIL;

            //3) the letter grade is calculated as follows
            //assume integer entered
            // - above 100: invalid
            // - below 0: invalid
            // - 95-100: A+
            // - 90-94: A
            // - 80-89: B
            // - 70-79: C
            // - 60-69: D
            // - 0 -59: F
            // use numeric and string literals, no constants

 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the form
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //clear textbox and labels
            txtNumberGrade.Text = "";
            lblDean.Text = "";
            lblLetter.Text = "";
            lblOutcome.Text = "";

            //focus
            txtNumberGrade.Focus();
        }
    }
}
