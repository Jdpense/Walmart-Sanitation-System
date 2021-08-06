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
    public partial class scan_Results : Form
    {
        // Create an instance of the first form as a class for this form
        public scan_Results()
        {
            InitializeComponent();
        }

        // Trasfer data from previous form to this one 
        public void transferVarData(int count, String name1, String name2, String[] s_Array, int strandnum)
        {
            virusStrain_List.Text = "";
            infoBox_TopMid.Text = count.ToString();
            infoBox_BotMid.Text = s_Array[strandnum];
            label_TopMid.Text = name1;
            label_BotMid.Text = name2;
            print_Strainslist(s_Array, count);
        }

        private void scan_Results_Load(object sender, EventArgs e)
        {

        }

        // This method prints out the list of strains spotted
        private void print_Strainslist(String[] s_Array, int count) 
        {
            if (count == 0)
            {
                virusStrain_List.Text = s_Array[0];
            }

            else
            {
                // Create the virus strains list through a "for" loop
            for (int i = 1; i <= count; i++) 
            {
                   virusStrain_List.Text += s_Array[i];
                    // Prevent any unnessary padding from being forumlated  
                    if (i < count)
                    { 
                        virusStrain_List.Text += ", ";
                    }
                   
            }
            }
        }

        // This button closes out the scan results
        private void ok_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        // These buttons scroll the virus strand arrays
        private void arrowRight_Click(object sender, EventArgs e)
        {
        //    mainsys.chkMenuPageforStrandArr("right");
        }

        private void arrowLeft_Click(object sender, EventArgs e)
        {
        //    mainsys.chkMenuPageforStrandArr("left");
        }
    }
}

// Create popup results
//     results.Show();
// Transfer data from this main body to the popup form
//    results.transferVarData(virusFound, textBoxTopMidArr[1], textBoxBotMidArr[1], currentScannedStrains, currentlySelected_Strand);
// Create an instance of the new pop form for the scan results
//  scan_Results results = new scan_Results();