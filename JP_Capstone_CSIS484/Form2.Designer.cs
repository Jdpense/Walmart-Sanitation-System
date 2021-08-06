
namespace JP_Capstone_CSIS484
{
    partial class debug_Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.phoneDebug = new System.Windows.Forms.Label();
            this.companyDebug = new System.Windows.Forms.Label();
            this.addressDebug = new System.Windows.Forms.Label();
            this.casesScanned_Dbg = new System.Windows.Forms.Label();
            this.viruses_numberDbg = new System.Windows.Forms.Label();
            this.pageN_dbg = new System.Windows.Forms.Label();
            this.productList = new System.Windows.Forms.Label();
            this.totalNum_Product = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // phoneDebug
            // 
            this.phoneDebug.AutoSize = true;
            this.phoneDebug.Location = new System.Drawing.Point(32, 32);
            this.phoneDebug.Name = "phoneDebug";
            this.phoneDebug.Size = new System.Drawing.Size(35, 13);
            this.phoneDebug.TabIndex = 0;
            this.phoneDebug.Text = "label1";
            // 
            // companyDebug
            // 
            this.companyDebug.AutoSize = true;
            this.companyDebug.Location = new System.Drawing.Point(32, 61);
            this.companyDebug.Name = "companyDebug";
            this.companyDebug.Size = new System.Drawing.Size(35, 13);
            this.companyDebug.TabIndex = 1;
            this.companyDebug.Text = "label2";
            // 
            // addressDebug
            // 
            this.addressDebug.AutoSize = true;
            this.addressDebug.Location = new System.Drawing.Point(32, 91);
            this.addressDebug.Name = "addressDebug";
            this.addressDebug.Size = new System.Drawing.Size(35, 13);
            this.addressDebug.TabIndex = 2;
            this.addressDebug.Text = "label3";
            // 
            // casesScanned_Dbg
            // 
            this.casesScanned_Dbg.AutoSize = true;
            this.casesScanned_Dbg.Location = new System.Drawing.Point(32, 121);
            this.casesScanned_Dbg.Name = "casesScanned_Dbg";
            this.casesScanned_Dbg.Size = new System.Drawing.Size(35, 13);
            this.casesScanned_Dbg.TabIndex = 3;
            this.casesScanned_Dbg.Text = "label1";
            // 
            // viruses_numberDbg
            // 
            this.viruses_numberDbg.AutoSize = true;
            this.viruses_numberDbg.Location = new System.Drawing.Point(32, 158);
            this.viruses_numberDbg.Name = "viruses_numberDbg";
            this.viruses_numberDbg.Size = new System.Drawing.Size(35, 13);
            this.viruses_numberDbg.TabIndex = 4;
            this.viruses_numberDbg.Text = "label1";
            // 
            // pageN_dbg
            // 
            this.pageN_dbg.AutoSize = true;
            this.pageN_dbg.Location = new System.Drawing.Point(32, 189);
            this.pageN_dbg.Name = "pageN_dbg";
            this.pageN_dbg.Size = new System.Drawing.Size(35, 13);
            this.pageN_dbg.TabIndex = 5;
            this.pageN_dbg.Text = "label1";
            // 
            // productList
            // 
            this.productList.AutoSize = true;
            this.productList.Location = new System.Drawing.Point(128, 32);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(25, 13);
            this.productList.TabIndex = 6;
            this.productList.Text = "Null";
            // 
            // totalNum_Product
            // 
            this.totalNum_Product.AutoSize = true;
            this.totalNum_Product.Location = new System.Drawing.Point(32, 222);
            this.totalNum_Product.Name = "totalNum_Product";
            this.totalNum_Product.Size = new System.Drawing.Size(13, 13);
            this.totalNum_Product.TabIndex = 7;
            this.totalNum_Product.Text = "0";
            // 
            // debug_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 270);
            this.Controls.Add(this.totalNum_Product);
            this.Controls.Add(this.productList);
            this.Controls.Add(this.pageN_dbg);
            this.Controls.Add(this.viruses_numberDbg);
            this.Controls.Add(this.casesScanned_Dbg);
            this.Controls.Add(this.addressDebug);
            this.Controls.Add(this.companyDebug);
            this.Controls.Add(this.phoneDebug);
            this.Name = "debug_Window";
            this.Text = "Debug Window";
            this.Load += new System.EventHandler(this.debug_Window_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label phoneDebug;
        private System.Windows.Forms.Label companyDebug;
        private System.Windows.Forms.Label addressDebug;
        private System.Windows.Forms.Label casesScanned_Dbg;
        private System.Windows.Forms.Label viruses_numberDbg;
        private System.Windows.Forms.Label pageN_dbg;
        private System.Windows.Forms.Label productList;
        private System.Windows.Forms.Label totalNum_Product;
    }
}