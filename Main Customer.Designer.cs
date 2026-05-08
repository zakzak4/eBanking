namespace eBanking
{
    partial class Main_Customer
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
            this.LABEL_WLC = new System.Windows.Forms.Label();
            this.LABEL_BALANCE = new System.Windows.Forms.Label();
            this.LABEL_DOT = new System.Windows.Forms.Label();
            this.LABEL_AVAIL_BAL = new System.Windows.Forms.Label();
            this.LABEL_NEW_TRAN = new System.Windows.Forms.Label();
            this.LABEL_LOG_OUT = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BUTTON_NEW_TRAN = new ePOSOne.btnProduct.Button_WOC();
            this.BUTTON_LOG_OUT = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LABEL_WLC
            // 
            this.LABEL_WLC.AutoSize = true;
            this.LABEL_WLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_WLC.ForeColor = System.Drawing.Color.Teal;
            this.LABEL_WLC.Location = new System.Drawing.Point(31, 51);
            this.LABEL_WLC.Name = "LABEL_WLC";
            this.LABEL_WLC.Size = new System.Drawing.Size(188, 24);
            this.LABEL_WLC.TabIndex = 0;
            this.LABEL_WLC.Text = "Welcome Message";
            this.LABEL_WLC.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LABEL_BALANCE
            // 
            this.LABEL_BALANCE.AutoSize = true;
            this.LABEL_BALANCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_BALANCE.ForeColor = System.Drawing.Color.Teal;
            this.LABEL_BALANCE.Location = new System.Drawing.Point(145, 154);
            this.LABEL_BALANCE.Name = "LABEL_BALANCE";
            this.LABEL_BALANCE.Size = new System.Drawing.Size(74, 20);
            this.LABEL_BALANCE.TabIndex = 2;
            this.LABEL_BALANCE.Text = "Balance";
            // 
            // LABEL_DOT
            // 
            this.LABEL_DOT.AutoSize = true;
            this.LABEL_DOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_DOT.ForeColor = System.Drawing.Color.Teal;
            this.LABEL_DOT.Location = new System.Drawing.Point(16, 55);
            this.LABEL_DOT.Name = "LABEL_DOT";
            this.LABEL_DOT.Size = new System.Drawing.Size(20, 18);
            this.LABEL_DOT.TabIndex = 3;
            this.LABEL_DOT.Text = "➋";
            // 
            // LABEL_AVAIL_BAL
            // 
            this.LABEL_AVAIL_BAL.AutoSize = true;
            this.LABEL_AVAIL_BAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_AVAIL_BAL.ForeColor = System.Drawing.Color.DimGray;
            this.LABEL_AVAIL_BAL.Location = new System.Drawing.Point(118, 124);
            this.LABEL_AVAIL_BAL.Name = "LABEL_AVAIL_BAL";
            this.LABEL_AVAIL_BAL.Size = new System.Drawing.Size(133, 13);
            this.LABEL_AVAIL_BAL.TabIndex = 4;
            this.LABEL_AVAIL_BAL.Text = "AVAILABLE BALANCE";
            this.LABEL_AVAIL_BAL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LABEL_NEW_TRAN
            // 
            this.LABEL_NEW_TRAN.AutoSize = true;
            this.LABEL_NEW_TRAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_NEW_TRAN.ForeColor = System.Drawing.Color.DimGray;
            this.LABEL_NEW_TRAN.Location = new System.Drawing.Point(118, 233);
            this.LABEL_NEW_TRAN.Name = "LABEL_NEW_TRAN";
            this.LABEL_NEW_TRAN.Size = new System.Drawing.Size(128, 13);
            this.LABEL_NEW_TRAN.TabIndex = 18;
            this.LABEL_NEW_TRAN.Text = "NEW TRANSACTION";
            this.LABEL_NEW_TRAN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LABEL_LOG_OUT
            // 
            this.LABEL_LOG_OUT.AutoSize = true;
            this.LABEL_LOG_OUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_LOG_OUT.ForeColor = System.Drawing.Color.DimGray;
            this.LABEL_LOG_OUT.Location = new System.Drawing.Point(159, 460);
            this.LABEL_LOG_OUT.Name = "LABEL_LOG_OUT";
            this.LABEL_LOG_OUT.Size = new System.Drawing.Size(47, 9);
            this.LABEL_LOG_OUT.TabIndex = 20;
            this.LABEL_LOG_OUT.Text = "LOG OUT";
            this.LABEL_LOG_OUT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::eBanking.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(75, 322);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 90);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // BUTTON_NEW_TRAN
            // 
            this.BUTTON_NEW_TRAN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BUTTON_NEW_TRAN.BorderColor = System.Drawing.Color.Teal;
            this.BUTTON_NEW_TRAN.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.BUTTON_NEW_TRAN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.BUTTON_NEW_TRAN.FlatAppearance.BorderSize = 0;
            this.BUTTON_NEW_TRAN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BUTTON_NEW_TRAN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BUTTON_NEW_TRAN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUTTON_NEW_TRAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_NEW_TRAN.ForeColor = System.Drawing.Color.Transparent;
            this.BUTTON_NEW_TRAN.Location = new System.Drawing.Point(145, 258);
            this.BUTTON_NEW_TRAN.Name = "BUTTON_NEW_TRAN";
            this.BUTTON_NEW_TRAN.OnHoverBorderColor = System.Drawing.Color.Teal;
            this.BUTTON_NEW_TRAN.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.BUTTON_NEW_TRAN.OnHoverTextColor = System.Drawing.Color.Lime;
            this.BUTTON_NEW_TRAN.Size = new System.Drawing.Size(75, 25);
            this.BUTTON_NEW_TRAN.TabIndex = 17;
            this.BUTTON_NEW_TRAN.Text = "€";
            this.BUTTON_NEW_TRAN.TextColor = System.Drawing.Color.Teal;
            this.BUTTON_NEW_TRAN.UseVisualStyleBackColor = true;
            this.BUTTON_NEW_TRAN.Click += new System.EventHandler(this.BUTTON_NEW_TRAN_Click);
            // 
            // BUTTON_LOG_OUT
            // 
            this.BUTTON_LOG_OUT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BUTTON_LOG_OUT.BorderColor = System.Drawing.Color.Teal;
            this.BUTTON_LOG_OUT.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.BUTTON_LOG_OUT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.BUTTON_LOG_OUT.FlatAppearance.BorderSize = 0;
            this.BUTTON_LOG_OUT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BUTTON_LOG_OUT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BUTTON_LOG_OUT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUTTON_LOG_OUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_LOG_OUT.ForeColor = System.Drawing.Color.Transparent;
            this.BUTTON_LOG_OUT.Location = new System.Drawing.Point(151, 430);
            this.BUTTON_LOG_OUT.Name = "BUTTON_LOG_OUT";
            this.BUTTON_LOG_OUT.OnHoverBorderColor = System.Drawing.Color.Teal;
            this.BUTTON_LOG_OUT.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.BUTTON_LOG_OUT.OnHoverTextColor = System.Drawing.Color.Red;
            this.BUTTON_LOG_OUT.Size = new System.Drawing.Size(60, 20);
            this.BUTTON_LOG_OUT.TabIndex = 19;
            this.BUTTON_LOG_OUT.Text = "x";
            this.BUTTON_LOG_OUT.TextColor = System.Drawing.Color.Teal;
            this.BUTTON_LOG_OUT.UseVisualStyleBackColor = true;
            this.BUTTON_LOG_OUT.Click += new System.EventHandler(this.BUTTON_LOG_OUT_Click);
            // 
            // Main_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(358, 486);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BUTTON_NEW_TRAN);
            this.Controls.Add(this.BUTTON_LOG_OUT);
            this.Controls.Add(this.LABEL_LOG_OUT);
            this.Controls.Add(this.LABEL_NEW_TRAN);
            this.Controls.Add(this.LABEL_AVAIL_BAL);
            this.Controls.Add(this.LABEL_DOT);
            this.Controls.Add(this.LABEL_BALANCE);
            this.Controls.Add(this.LABEL_WLC);
            this.Name = "Main_Customer";
            this.Text = "Main Page";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LABEL_WLC;
        private System.Windows.Forms.Label LABEL_BALANCE;
        private System.Windows.Forms.Label LABEL_DOT;
        private System.Windows.Forms.Label LABEL_AVAIL_BAL;
        private ePOSOne.btnProduct.Button_WOC BUTTON_NEW_TRAN;
        private System.Windows.Forms.Label LABEL_NEW_TRAN;
        private ePOSOne.btnProduct.Button_WOC BUTTON_LOG_OUT;
        private System.Windows.Forms.Label LABEL_LOG_OUT;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}