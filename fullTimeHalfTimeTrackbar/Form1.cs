using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fullTimeHalfTimeTrackbar
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void btnWhatStatus_Click(object sender, EventArgs e)
        {

        }

        private void trkCredits_Scroll(object sender, EventArgs e)
        {
            int credits = trkCredits.Value;

            //Show trackBar value in lblCredits for user feedback
            lblCredits.Text = trkCredits.Value.ToString();

            //Calculate status and display in lblStatus
            if (credits >= 12)
            {
                lblStatus.Text = "Full time";
            }
            else if (credits >= 6)
            {
                lblStatus.Text = "Half time";
            }
            else
            {
                lblStatus.Text = "Less than half time";
            }
        }
    }
}
