using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JP_Capstone_CSIS484
{
    public partial class ErrorMsg_Body : Form
    {
        public ErrorMsg_Body()
        {
            InitializeComponent();
        }
        // Closes out of the box
        private void ok_ButtonEM_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // Sets the default Error Msg
        public void SetMsgText(String msg)
        {
            errorMsg.Text = msg;
        }
    }
}
