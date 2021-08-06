
namespace JP_Capstone_CSIS484
{
    partial class body
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
            this.main_Menu = new System.Windows.Forms.Button();
            this.product_ScanProgress = new System.Windows.Forms.Button();
            this.contacts = new System.Windows.Forms.Button();
            this.label_Top = new System.Windows.Forms.Label();
            this.label_TopMid = new System.Windows.Forms.Label();
            this.label_BotMid = new System.Windows.Forms.Label();
            this.label_Bottom = new System.Windows.Forms.Label();
            this.scan_Progress = new System.Windows.Forms.ProgressBar();
            this.scanProduct = new System.Windows.Forms.Button();
            this.infoBox_Top = new System.Windows.Forms.TextBox();
            this.infoBox_TopMid = new System.Windows.Forms.TextBox();
            this.infoBox_BotMid = new System.Windows.Forms.TextBox();
            this.infoBox_Bottom = new System.Windows.Forms.TextBox();
            this.arrowRight = new System.Windows.Forms.Button();
            this.arrowLeft = new System.Windows.Forms.Button();
            this.productInfo_Button = new System.Windows.Forms.Button();
            this.selectionBox_Menu = new System.Windows.Forms.ComboBox();
            this.menu_Title = new System.Windows.Forms.Label();
            this.add_ProductButton = new System.Windows.Forms.Button();
            this.product_TxtBoxList = new System.Windows.Forms.RichTextBox();
            this.save_Button = new System.Windows.Forms.Button();
            this.load_Button = new System.Windows.Forms.Button();
            this.saveFile_ProductList = new System.Windows.Forms.SaveFileDialog();
            this.delete_button = new System.Windows.Forms.Button();
            this.login_button = new System.Windows.Forms.Button();
            this.register_button = new System.Windows.Forms.Button();
            this.log_button2 = new System.Windows.Forms.Button();
            this.createAcc_button = new System.Windows.Forms.Button();
            this.updateContact_Info = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // main_Menu
            // 
            this.main_Menu.Location = new System.Drawing.Point(73, 44);
            this.main_Menu.Name = "main_Menu";
            this.main_Menu.Size = new System.Drawing.Size(76, 23);
            this.main_Menu.TabIndex = 4;
            this.main_Menu.Text = "Main Menu";
            this.main_Menu.UseVisualStyleBackColor = true;
            this.main_Menu.Click += new System.EventHandler(this.main_Menu_Click);
            // 
            // product_ScanProgress
            // 
            this.product_ScanProgress.Location = new System.Drawing.Point(288, 44);
            this.product_ScanProgress.Name = "product_ScanProgress";
            this.product_ScanProgress.Size = new System.Drawing.Size(139, 23);
            this.product_ScanProgress.TabIndex = 5;
            this.product_ScanProgress.Text = "Product Scan Progress";
            this.product_ScanProgress.UseVisualStyleBackColor = true;
            this.product_ScanProgress.Click += new System.EventHandler(this.product_ScanProgress_Click);
            // 
            // contacts
            // 
            this.contacts.Location = new System.Drawing.Point(433, 44);
            this.contacts.Name = "contacts";
            this.contacts.Size = new System.Drawing.Size(76, 23);
            this.contacts.TabIndex = 6;
            this.contacts.Text = "Contacts";
            this.contacts.UseMnemonic = false;
            this.contacts.UseVisualStyleBackColor = true;
            this.contacts.Click += new System.EventHandler(this.contacts_Click);
            // 
            // label_Top
            // 
            this.label_Top.AutoSize = true;
            this.label_Top.Location = new System.Drawing.Point(74, 112);
            this.label_Top.Name = "label_Top";
            this.label_Top.Size = new System.Drawing.Size(35, 13);
            this.label_Top.TabIndex = 0;
            this.label_Top.Text = "label1";
            // 
            // label_TopMid
            // 
            this.label_TopMid.AutoSize = true;
            this.label_TopMid.Location = new System.Drawing.Point(74, 160);
            this.label_TopMid.Name = "label_TopMid";
            this.label_TopMid.Size = new System.Drawing.Size(35, 13);
            this.label_TopMid.TabIndex = 1;
            this.label_TopMid.Text = "label1";
            // 
            // label_BotMid
            // 
            this.label_BotMid.AutoSize = true;
            this.label_BotMid.Location = new System.Drawing.Point(74, 212);
            this.label_BotMid.Name = "label_BotMid";
            this.label_BotMid.Size = new System.Drawing.Size(35, 13);
            this.label_BotMid.TabIndex = 2;
            this.label_BotMid.Text = "label1";
            // 
            // label_Bottom
            // 
            this.label_Bottom.AutoSize = true;
            this.label_Bottom.Location = new System.Drawing.Point(74, 261);
            this.label_Bottom.Name = "label_Bottom";
            this.label_Bottom.Size = new System.Drawing.Size(35, 13);
            this.label_Bottom.TabIndex = 3;
            this.label_Bottom.Text = "label1";
            // 
            // scan_Progress
            // 
            this.scan_Progress.Location = new System.Drawing.Point(208, 102);
            this.scan_Progress.Name = "scan_Progress";
            this.scan_Progress.Size = new System.Drawing.Size(139, 23);
            this.scan_Progress.TabIndex = 7;
            this.scan_Progress.Click += new System.EventHandler(this.scan_Progress_Click);
            // 
            // scanProduct
            // 
            this.scanProduct.Location = new System.Drawing.Point(77, 303);
            this.scanProduct.Name = "scanProduct";
            this.scanProduct.Size = new System.Drawing.Size(99, 23);
            this.scanProduct.TabIndex = 8;
            this.scanProduct.Text = "Scan Product";
            this.scanProduct.UseMnemonic = false;
            this.scanProduct.UseVisualStyleBackColor = true;
            this.scanProduct.Click += new System.EventHandler(this.scanProduct_Click);
            // 
            // infoBox_Top
            // 
            this.infoBox_Top.Enabled = false;
            this.infoBox_Top.Location = new System.Drawing.Point(247, 105);
            this.infoBox_Top.Name = "infoBox_Top";
            this.infoBox_Top.Size = new System.Drawing.Size(100, 20);
            this.infoBox_Top.TabIndex = 10;
            // 
            // infoBox_TopMid
            // 
            this.infoBox_TopMid.Enabled = false;
            this.infoBox_TopMid.Location = new System.Drawing.Point(247, 153);
            this.infoBox_TopMid.Name = "infoBox_TopMid";
            this.infoBox_TopMid.Size = new System.Drawing.Size(100, 20);
            this.infoBox_TopMid.TabIndex = 11;
            // 
            // infoBox_BotMid
            // 
            this.infoBox_BotMid.BackColor = System.Drawing.SystemColors.Window;
            this.infoBox_BotMid.Enabled = false;
            this.infoBox_BotMid.ForeColor = System.Drawing.SystemColors.Window;
            this.infoBox_BotMid.Location = new System.Drawing.Point(247, 209);
            this.infoBox_BotMid.Name = "infoBox_BotMid";
            this.infoBox_BotMid.Size = new System.Drawing.Size(100, 20);
            this.infoBox_BotMid.TabIndex = 12;
            // 
            // infoBox_Bottom
            // 
            this.infoBox_Bottom.Location = new System.Drawing.Point(247, 261);
            this.infoBox_Bottom.Name = "infoBox_Bottom";
            this.infoBox_Bottom.Size = new System.Drawing.Size(100, 20);
            this.infoBox_Bottom.TabIndex = 13;
            // 
            // arrowRight
            // 
            this.arrowRight.Location = new System.Drawing.Point(353, 207);
            this.arrowRight.Name = "arrowRight";
            this.arrowRight.Size = new System.Drawing.Size(27, 23);
            this.arrowRight.TabIndex = 0;
            this.arrowRight.Text = ">>";
            this.arrowRight.UseVisualStyleBackColor = true;
            this.arrowRight.Click += new System.EventHandler(this.arrowRight_Click);
            // 
            // arrowLeft
            // 
            this.arrowLeft.Location = new System.Drawing.Point(214, 207);
            this.arrowLeft.Name = "arrowLeft";
            this.arrowLeft.Size = new System.Drawing.Size(27, 23);
            this.arrowLeft.TabIndex = 14;
            this.arrowLeft.Text = "<<";
            this.arrowLeft.UseVisualStyleBackColor = true;
            this.arrowLeft.Click += new System.EventHandler(this.arrowLeft_Click);
            // 
            // productInfo_Button
            // 
            this.productInfo_Button.Location = new System.Drawing.Point(155, 44);
            this.productInfo_Button.Name = "productInfo_Button";
            this.productInfo_Button.Size = new System.Drawing.Size(127, 23);
            this.productInfo_Button.TabIndex = 15;
            this.productInfo_Button.Text = "Update Products";
            this.productInfo_Button.UseMnemonic = false;
            this.productInfo_Button.UseVisualStyleBackColor = true;
            this.productInfo_Button.Click += new System.EventHandler(this.productInfo_Button_Click);
            // 
            // selectionBox_Menu
            // 
            this.selectionBox_Menu.FormattingEnabled = true;
            this.selectionBox_Menu.Location = new System.Drawing.Point(247, 261);
            this.selectionBox_Menu.Name = "selectionBox_Menu";
            this.selectionBox_Menu.Size = new System.Drawing.Size(121, 21);
            this.selectionBox_Menu.TabIndex = 16;
            this.selectionBox_Menu.SelectedIndexChanged += new System.EventHandler(this.selectionBox_Menu_SelectedIndexChanged);
            // 
            // menu_Title
            // 
            this.menu_Title.AutoSize = true;
            this.menu_Title.Location = new System.Drawing.Point(267, 9);
            this.menu_Title.Name = "menu_Title";
            this.menu_Title.Size = new System.Drawing.Size(35, 13);
            this.menu_Title.TabIndex = 17;
            this.menu_Title.Text = "label1";
            // 
            // add_ProductButton
            // 
            this.add_ProductButton.Location = new System.Drawing.Point(77, 202);
            this.add_ProductButton.Name = "add_ProductButton";
            this.add_ProductButton.Size = new System.Drawing.Size(89, 23);
            this.add_ProductButton.TabIndex = 18;
            this.add_ProductButton.Text = "Add Product";
            this.add_ProductButton.UseMnemonic = false;
            this.add_ProductButton.UseVisualStyleBackColor = true;
            this.add_ProductButton.Click += new System.EventHandler(this.add_ProductButton_Click);
            // 
            // product_TxtBoxList
            // 
            this.product_TxtBoxList.Location = new System.Drawing.Point(208, 243);
            this.product_TxtBoxList.Name = "product_TxtBoxList";
            this.product_TxtBoxList.Size = new System.Drawing.Size(252, 96);
            this.product_TxtBoxList.TabIndex = 19;
            this.product_TxtBoxList.Text = "";
            this.product_TxtBoxList.TextChanged += new System.EventHandler(this.product_TxtBoxList_TextChanged);
            // 
            // save_Button
            // 
            this.save_Button.Location = new System.Drawing.Point(195, 202);
            this.save_Button.Name = "save_Button";
            this.save_Button.Size = new System.Drawing.Size(89, 23);
            this.save_Button.TabIndex = 20;
            this.save_Button.Text = "Save List";
            this.save_Button.UseMnemonic = false;
            this.save_Button.UseVisualStyleBackColor = true;
            this.save_Button.Click += new System.EventHandler(this.save_Button_Click);
            // 
            // load_Button
            // 
            this.load_Button.Location = new System.Drawing.Point(308, 202);
            this.load_Button.Name = "load_Button";
            this.load_Button.Size = new System.Drawing.Size(89, 23);
            this.load_Button.TabIndex = 21;
            this.load_Button.Text = "Load List";
            this.load_Button.UseMnemonic = false;
            this.load_Button.UseVisualStyleBackColor = true;
            this.load_Button.Click += new System.EventHandler(this.load_Button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(420, 202);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(89, 23);
            this.delete_button.TabIndex = 22;
            this.delete_button.Text = "Delete List";
            this.delete_button.UseMnemonic = false;
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(152, 202);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(89, 23);
            this.login_button.TabIndex = 23;
            this.login_button.Text = "Login";
            this.login_button.UseMnemonic = false;
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // register_button
            // 
            this.register_button.Location = new System.Drawing.Point(270, 202);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(89, 23);
            this.register_button.TabIndex = 24;
            this.register_button.Text = "Sign Up";
            this.register_button.UseMnemonic = false;
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // log_button2
            // 
            this.log_button2.Location = new System.Drawing.Point(270, 202);
            this.log_button2.Name = "log_button2";
            this.log_button2.Size = new System.Drawing.Size(89, 23);
            this.log_button2.TabIndex = 25;
            this.log_button2.Text = "Login";
            this.log_button2.UseMnemonic = false;
            this.log_button2.UseVisualStyleBackColor = true;
            this.log_button2.Click += new System.EventHandler(this.log_button2_Click);
            // 
            // createAcc_button
            // 
            this.createAcc_button.Location = new System.Drawing.Point(129, 202);
            this.createAcc_button.Name = "createAcc_button";
            this.createAcc_button.Size = new System.Drawing.Size(112, 23);
            this.createAcc_button.TabIndex = 26;
            this.createAcc_button.Text = "Create Account";
            this.createAcc_button.UseMnemonic = false;
            this.createAcc_button.UseVisualStyleBackColor = true;
            this.createAcc_button.Click += new System.EventHandler(this.createAcc_button_Click);
            // 
            // updateContact_Info
            // 
            this.updateContact_Info.Location = new System.Drawing.Point(77, 259);
            this.updateContact_Info.Name = "updateContact_Info";
            this.updateContact_Info.Size = new System.Drawing.Size(154, 23);
            this.updateContact_Info.TabIndex = 9;
            this.updateContact_Info.Text = "Update Contact Info";
            this.updateContact_Info.UseMnemonic = false;
            this.updateContact_Info.UseVisualStyleBackColor = true;
            this.updateContact_Info.Click += new System.EventHandler(this.updateContact_Info_Click);
            // 
            // body
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 351);
            this.Controls.Add(this.createAcc_button);
            this.Controls.Add(this.log_button2);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.load_Button);
            this.Controls.Add(this.save_Button);
            this.Controls.Add(this.product_TxtBoxList);
            this.Controls.Add(this.add_ProductButton);
            this.Controls.Add(this.menu_Title);
            this.Controls.Add(this.selectionBox_Menu);
            this.Controls.Add(this.productInfo_Button);
            this.Controls.Add(this.arrowLeft);
            this.Controls.Add(this.arrowRight);
            this.Controls.Add(this.infoBox_Bottom);
            this.Controls.Add(this.infoBox_BotMid);
            this.Controls.Add(this.infoBox_TopMid);
            this.Controls.Add(this.infoBox_Top);
            this.Controls.Add(this.updateContact_Info);
            this.Controls.Add(this.scanProduct);
            this.Controls.Add(this.scan_Progress);
            this.Controls.Add(this.contacts);
            this.Controls.Add(this.product_ScanProgress);
            this.Controls.Add(this.main_Menu);
            this.Controls.Add(this.label_Bottom);
            this.Controls.Add(this.label_BotMid);
            this.Controls.Add(this.label_TopMid);
            this.Controls.Add(this.label_Top);
            this.Name = "body";
            this.Text = "Walmart Sanitation System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button main_Menu;
        private System.Windows.Forms.Button product_ScanProgress;
        private System.Windows.Forms.Button contacts;
        private System.Windows.Forms.Label label_Top;
        private System.Windows.Forms.Label label_TopMid;
        private System.Windows.Forms.Label label_BotMid;
        private System.Windows.Forms.Label label_Bottom;
        private System.Windows.Forms.ProgressBar scan_Progress;
        private System.Windows.Forms.Button scanProduct;
        private System.Windows.Forms.TextBox infoBox_Top;
        private System.Windows.Forms.TextBox infoBox_TopMid;
        private System.Windows.Forms.TextBox infoBox_BotMid;
        private System.Windows.Forms.TextBox infoBox_Bottom;
        private System.Windows.Forms.Button arrowRight;
        private System.Windows.Forms.Button arrowLeft;
        private System.Windows.Forms.Button productInfo_Button;
        private System.Windows.Forms.ComboBox selectionBox_Menu;
        private System.Windows.Forms.Label menu_Title;
        private System.Windows.Forms.Button add_ProductButton;
        private System.Windows.Forms.RichTextBox product_TxtBoxList;
        private System.Windows.Forms.Button save_Button;
        private System.Windows.Forms.Button load_Button;
        private System.Windows.Forms.SaveFileDialog saveFile_ProductList;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Button log_button2;
        private System.Windows.Forms.Button createAcc_button;
        private System.Windows.Forms.Button updateContact_Info;
    }
}

