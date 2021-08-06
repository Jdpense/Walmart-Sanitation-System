
namespace JP_Capstone_CSIS484
{
    partial class ErrorMsg_Body
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
            this.errorMsg = new System.Windows.Forms.Label();
            this.ok_ButtonEM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // errorMsg
            // 
            this.errorMsg.AutoSize = true;
            this.errorMsg.Location = new System.Drawing.Point(95, 67);
            this.errorMsg.Name = "errorMsg";
            this.errorMsg.Size = new System.Drawing.Size(35, 13);
            this.errorMsg.TabIndex = 0;
            this.errorMsg.Text = "label1";
            // 
            // ok_ButtonEM
            // 
            this.ok_ButtonEM.Location = new System.Drawing.Point(164, 132);
            this.ok_ButtonEM.Name = "ok_ButtonEM";
            this.ok_ButtonEM.Size = new System.Drawing.Size(75, 23);
            this.ok_ButtonEM.TabIndex = 1;
            this.ok_ButtonEM.Text = "OK";
            this.ok_ButtonEM.UseVisualStyleBackColor = true;
            this.ok_ButtonEM.Click += new System.EventHandler(this.ok_ButtonEM_Click);
            // 
            // ErrorMsg_Body
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 167);
            this.Controls.Add(this.ok_ButtonEM);
            this.Controls.Add(this.errorMsg);
            this.Name = "ErrorMsg_Body";
            this.Text = "Error";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label errorMsg;
        private System.Windows.Forms.Button ok_ButtonEM;
    }
}