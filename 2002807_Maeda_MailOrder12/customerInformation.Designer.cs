namespace _2002807_Maeda_MailOrder12
{
    partial class customerInformation
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
            this.orderInfo = new System.Windows.Forms.RichTextBox();
            this.ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orderInfo
            // 
            this.orderInfo.Location = new System.Drawing.Point(13, 13);
            this.orderInfo.Name = "orderInfo";
            this.orderInfo.Size = new System.Drawing.Size(303, 240);
            this.orderInfo.TabIndex = 0;
            this.orderInfo.Text = "";
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(13, 260);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(141, 58);
            this.ok.TabIndex = 1;
            this.ok.Text = "Ok";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // customerInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 337);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.orderInfo);
            this.Name = "customerInformation";
            this.Text = "Customer Information";
            this.Activated += new System.EventHandler(this.customerInformation_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox orderInfo;
        private System.Windows.Forms.Button ok;
    }
}