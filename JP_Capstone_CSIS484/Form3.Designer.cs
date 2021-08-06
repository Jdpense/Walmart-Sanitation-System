
namespace JP_Capstone_CSIS484
{
    partial class scan_Results
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
            this.arrowLeft = new System.Windows.Forms.Button();
            this.arrowRight = new System.Windows.Forms.Button();
            this.infoBox_BotMid = new System.Windows.Forms.TextBox();
            this.infoBox_TopMid = new System.Windows.Forms.TextBox();
            this.label_BotMid = new System.Windows.Forms.Label();
            this.label_TopMid = new System.Windows.Forms.Label();
            this.ok_Button = new System.Windows.Forms.Button();
            this.virusStrain_List = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // arrowLeft
            // 
            this.arrowLeft.Location = new System.Drawing.Point(199, 121);
            this.arrowLeft.Name = "arrowLeft";
            this.arrowLeft.Size = new System.Drawing.Size(27, 23);
            this.arrowLeft.TabIndex = 20;
            this.arrowLeft.Text = "<<";
            this.arrowLeft.UseVisualStyleBackColor = true;
            this.arrowLeft.Click += new System.EventHandler(this.arrowLeft_Click);
            // 
            // arrowRight
            // 
            this.arrowRight.Location = new System.Drawing.Point(338, 121);
            this.arrowRight.Name = "arrowRight";
            this.arrowRight.Size = new System.Drawing.Size(27, 23);
            this.arrowRight.TabIndex = 15;
            this.arrowRight.Text = ">>";
            this.arrowRight.UseVisualStyleBackColor = true;
            this.arrowRight.Click += new System.EventHandler(this.arrowRight_Click);
            // 
            // infoBox_BotMid
            // 
            this.infoBox_BotMid.Enabled = false;
            this.infoBox_BotMid.Location = new System.Drawing.Point(232, 123);
            this.infoBox_BotMid.Name = "infoBox_BotMid";
            this.infoBox_BotMid.Size = new System.Drawing.Size(100, 20);
            this.infoBox_BotMid.TabIndex = 19;
            // 
            // infoBox_TopMid
            // 
            this.infoBox_TopMid.Enabled = false;
            this.infoBox_TopMid.Location = new System.Drawing.Point(232, 67);
            this.infoBox_TopMid.Name = "infoBox_TopMid";
            this.infoBox_TopMid.Size = new System.Drawing.Size(100, 20);
            this.infoBox_TopMid.TabIndex = 18;
            // 
            // label_BotMid
            // 
            this.label_BotMid.AutoSize = true;
            this.label_BotMid.Location = new System.Drawing.Point(59, 126);
            this.label_BotMid.Name = "label_BotMid";
            this.label_BotMid.Size = new System.Drawing.Size(35, 13);
            this.label_BotMid.TabIndex = 17;
            this.label_BotMid.Text = "label1";
            // 
            // label_TopMid
            // 
            this.label_TopMid.AutoSize = true;
            this.label_TopMid.Location = new System.Drawing.Point(59, 74);
            this.label_TopMid.Name = "label_TopMid";
            this.label_TopMid.Size = new System.Drawing.Size(35, 13);
            this.label_TopMid.TabIndex = 16;
            this.label_TopMid.Text = "label1";
            // 
            // ok_Button
            // 
            this.ok_Button.Location = new System.Drawing.Point(172, 192);
            this.ok_Button.Name = "ok_Button";
            this.ok_Button.Size = new System.Drawing.Size(75, 23);
            this.ok_Button.TabIndex = 21;
            this.ok_Button.Text = "OK";
            this.ok_Button.UseVisualStyleBackColor = true;
            this.ok_Button.Click += new System.EventHandler(this.ok_Button_Click);
            // 
            // virusStrain_List
            // 
            this.virusStrain_List.AutoSize = true;
            this.virusStrain_List.Location = new System.Drawing.Point(229, 160);
            this.virusStrain_List.Name = "virusStrain_List";
            this.virusStrain_List.Size = new System.Drawing.Size(35, 13);
            this.virusStrain_List.TabIndex = 22;
            this.virusStrain_List.Text = "label1";
            // 
            // scan_Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 255);
            this.Controls.Add(this.virusStrain_List);
            this.Controls.Add(this.ok_Button);
            this.Controls.Add(this.arrowLeft);
            this.Controls.Add(this.arrowRight);
            this.Controls.Add(this.infoBox_BotMid);
            this.Controls.Add(this.infoBox_TopMid);
            this.Controls.Add(this.label_BotMid);
            this.Controls.Add(this.label_TopMid);
            this.Name = "scan_Results";
            this.Text = "Scan Results";
            this.Load += new System.EventHandler(this.scan_Results_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button arrowLeft;
        private System.Windows.Forms.Button arrowRight;
        private System.Windows.Forms.TextBox infoBox_BotMid;
        private System.Windows.Forms.TextBox infoBox_TopMid;
        private System.Windows.Forms.Label label_BotMid;
        private System.Windows.Forms.Label label_TopMid;
        private System.Windows.Forms.Button ok_Button;
        private System.Windows.Forms.Label virusStrain_List;
    }
}