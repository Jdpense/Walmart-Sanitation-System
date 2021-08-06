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
    public partial class debug_Window : Form
    {
        // This is a debug feature for testing purposes only
        public debug_Window()
        {
            InitializeComponent();
        }

        private void debug_Window_Load(object sender, EventArgs e)
        {
            viruses_numberDbg.Text = "0";
            casesScanned_Dbg.Text = "0";
        }
        // Transfers data from main class to the debug class
        // for contact info
        public void updateContactInfo(String phone, String company, String address)
        {
            phoneDebug.Text = phone;
            companyDebug.Text = company;
            addressDebug.Text = address;
        }
        // Transfers total cases and virus 
        public void updateTotalInfo(int cases, int virus)
        {
            viruses_numberDbg.Text = virus.ToString();
            casesScanned_Dbg.Text = cases.ToString();
        }

        // Transfers page number
        public void updatepageNum(int page)
        {
            pageN_dbg.Text = page.ToString();
        }

        // Transfers number of Products and it's list
        public void updateProductNumList(int productNum, List<string> list)
        {
            totalNum_Product.Text = productNum.ToString();
            productList.Text = String.Join(Environment.NewLine, list);
        }

    }
}
