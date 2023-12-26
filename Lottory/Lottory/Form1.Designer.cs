namespace Lottory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSabt = new System.Windows.Forms.Button();
            this.rtxtKol = new System.Windows.Forms.RichTextBox();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnrepeat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rtxtwinners = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSabt);
            this.panel1.Controls.Add(this.rtxtKol);
            this.panel1.Controls.Add(this.txtAddName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 571);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Jalal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(94, 533);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "تعداد شرکت کننده ها : 0";
            // 
            // btnSabt
            // 
            this.btnSabt.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSabt.FlatAppearance.BorderSize = 4;
            this.btnSabt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSabt.Font = new System.Drawing.Font("B Jalal", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSabt.ForeColor = System.Drawing.Color.Black;
            this.btnSabt.Location = new System.Drawing.Point(48, 52);
            this.btnSabt.Name = "btnSabt";
            this.btnSabt.Size = new System.Drawing.Size(183, 54);
            this.btnSabt.TabIndex = 1;
            this.btnSabt.Text = "ثبت";
            this.btnSabt.UseVisualStyleBackColor = false;
            this.btnSabt.Click += new System.EventHandler(this.btnSabt_Click);
            // 
            // rtxtKol
            // 
            this.rtxtKol.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtxtKol.Font = new System.Drawing.Font("Felix Titling", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtKol.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rtxtKol.Location = new System.Drawing.Point(3, 139);
            this.rtxtKol.Name = "rtxtKol";
            this.rtxtKol.ReadOnly = true;
            this.rtxtKol.Size = new System.Drawing.Size(272, 381);
            this.rtxtKol.TabIndex = 4;
            this.rtxtKol.Text = "";
            // 
            // txtAddName
            // 
            this.txtAddName.Font = new System.Drawing.Font("B Jalal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtAddName.Location = new System.Drawing.Point(3, 12);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(272, 34);
            this.txtAddName.TabIndex = 0;
            this.txtAddName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAddName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtAddName_MouseClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.rtxtwinners);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.btnrepeat);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(309, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 571);
            this.panel2.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(3, 535);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(138, 22);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "MehdiPsycho ©";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnrepeat
            // 
            this.btnrepeat.BackColor = System.Drawing.Color.Aquamarine;
            this.btnrepeat.Enabled = false;
            this.btnrepeat.FlatAppearance.BorderSize = 3;
            this.btnrepeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrepeat.Font = new System.Drawing.Font("B Jalal", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnrepeat.Location = new System.Drawing.Point(32, 227);
            this.btnrepeat.Name = "btnrepeat";
            this.btnrepeat.Size = new System.Drawing.Size(204, 62);
            this.btnrepeat.TabIndex = 5;
            this.btnrepeat.Text = "قرعه کشی مجدد";
            this.btnrepeat.UseVisualStyleBackColor = false;
            this.btnrepeat.Visible = false;
            this.btnrepeat.Click += new System.EventHandler(this.btnrepeat_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("B Jalal", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.Location = new System.Drawing.Point(32, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "شروع";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("B Titr", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(32, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 69);
            this.label2.TabIndex = 0;
            this.label2.Text = "مهدی میرزاخانی";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtxtwinners
            // 
            this.rtxtwinners.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtxtwinners.Font = new System.Drawing.Font("Felix Titling", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtwinners.ForeColor = System.Drawing.Color.DimGray;
            this.rtxtwinners.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rtxtwinners.Location = new System.Drawing.Point(3, 328);
            this.rtxtwinners.Name = "rtxtwinners";
            this.rtxtwinners.ReadOnly = true;
            this.rtxtwinners.Size = new System.Drawing.Size(272, 192);
            this.rtxtwinners.TabIndex = 5;
            this.rtxtwinners.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "شرکت کنندگان :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "لیست برنندگان :";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSabt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(601, 595);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قرعه کشی";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSabt;
        private System.Windows.Forms.RichTextBox rtxtKol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnrepeat;
        private System.Windows.Forms.RichTextBox rtxtwinners;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

