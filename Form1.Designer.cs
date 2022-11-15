namespace MyMilestoneProject
{
    partial class Form1
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
            this.pictureBoxImg = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCsz = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelCsz = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.label1Hours = new System.Windows.Forms.Label();
            this.labelWeekend = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImg)).BeginInit();
            this.groupBoxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxImg
            // 
            this.pictureBoxImg.Image = global::MyMilestoneProject.Properties.Resources.OIP;
            this.pictureBoxImg.Location = new System.Drawing.Point(59, 86);
            this.pictureBoxImg.Name = "pictureBoxImg";
            this.pictureBoxImg.Size = new System.Drawing.Size(473, 353);
            this.pictureBoxImg.TabIndex = 0;
            this.pictureBoxImg.TabStop = false;
            this.pictureBoxImg.Click += new System.EventHandler(this.pictureBoxImg_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(242, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(570, 58);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Amour Bakery";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.Location = new System.Drawing.Point(59, 445);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(159, 88);
            this.btnInventory.TabIndex = 2;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(373, 445);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(159, 88);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(6, 41);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(85, 25);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Address";
            this.lblAddress.Click += new System.EventHandler(this.lblAddress_Click);
            // 
            // lblCsz
            // 
            this.lblCsz.AutoSize = true;
            this.lblCsz.Location = new System.Drawing.Point(6, 84);
            this.lblCsz.Name = "lblCsz";
            this.lblCsz.Size = new System.Drawing.Size(139, 25);
            this.lblCsz.TabIndex = 0;
            this.lblCsz.Text = "City, State, Zip";
            this.lblCsz.Click += new System.EventHandler(this.lblCsz_Click);
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(6, 223);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(149, 25);
            this.lblHours.TabIndex = 0;
            this.lblHours.Text = "Business Hours";
            this.lblHours.Click += new System.EventHandler(this.lblHours_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 174);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 25);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(6, 132);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(143, 25);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Phone Number";
            this.lblPhone.Click += new System.EventHandler(this.lblPhone_Click);
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.labelWeekend);
            this.groupBoxInfo.Controls.Add(this.label1Hours);
            this.groupBoxInfo.Controls.Add(this.labelEmail);
            this.groupBoxInfo.Controls.Add(this.labelPhone);
            this.groupBoxInfo.Controls.Add(this.labelCsz);
            this.groupBoxInfo.Controls.Add(this.labelAddress);
            this.groupBoxInfo.Controls.Add(this.lblPhone);
            this.groupBoxInfo.Controls.Add(this.lblEmail);
            this.groupBoxInfo.Controls.Add(this.lblHours);
            this.groupBoxInfo.Controls.Add(this.lblCsz);
            this.groupBoxInfo.Controls.Add(this.lblAddress);
            this.groupBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfo.Location = new System.Drawing.Point(550, 86);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(474, 353);
            this.groupBoxInfo.TabIndex = 3;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Contact Information";
            this.groupBoxInfo.Enter += new System.EventHandler(this.groupBoxInfo_Enter);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(97, 41);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(161, 25);
            this.labelAddress.TabIndex = 1;
            this.labelAddress.Text = "1234 Main Street";
            this.labelAddress.Click += new System.EventHandler(this.labelAddress_Click);
            // 
            // labelCsz
            // 
            this.labelCsz.AutoSize = true;
            this.labelCsz.Location = new System.Drawing.Point(151, 84);
            this.labelCsz.Name = "labelCsz";
            this.labelCsz.Size = new System.Drawing.Size(204, 25);
            this.labelCsz.TabIndex = 1;
            this.labelCsz.Text = "Maronville, AA. 12345";
            this.labelCsz.Click += new System.EventHandler(this.labelCsz_Click);
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(155, 132);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(143, 25);
            this.labelPhone.TabIndex = 1;
            this.labelPhone.Text = "(222)121-1122";
            this.labelPhone.Click += new System.EventHandler(this.labelPhone_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(72, 174);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(246, 25);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "AmourBakery@mynet.com";
            this.labelEmail.Click += new System.EventHandler(this.labelEmail_Click);
            // 
            // label1Hours
            // 
            this.label1Hours.AutoSize = true;
            this.label1Hours.Location = new System.Drawing.Point(161, 223);
            this.label1Hours.Name = "label1Hours";
            this.label1Hours.Size = new System.Drawing.Size(288, 25);
            this.label1Hours.TabIndex = 1;
            this.label1Hours.Text = "Monday-Friday 6:00am-3:00pm";
            this.label1Hours.Click += new System.EventHandler(this.label1Hours_Click);
            // 
            // labelWeekend
            // 
            this.labelWeekend.AutoSize = true;
            this.labelWeekend.Location = new System.Drawing.Point(161, 264);
            this.labelWeekend.Name = "labelWeekend";
            this.labelWeekend.Size = new System.Drawing.Size(269, 25);
            this.labelWeekend.TabIndex = 1;
            this.labelWeekend.Text = "Saturday and Sunday Closed";
            this.labelWeekend.Click += new System.EventHandler(this.labelWeekend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1057, 545);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBoxImg);
            this.Name = "Form1";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImg)).EndInit();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxImg;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCsz;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label labelWeekend;
        private System.Windows.Forms.Label label1Hours;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelCsz;
        private System.Windows.Forms.Label labelAddress;
    }
}

