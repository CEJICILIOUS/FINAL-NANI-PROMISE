namespace WANAKOKASABOT
{
    partial class LoanAdd
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.interest = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.loanamnt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clientid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.termcombobox = new System.Windows.Forms.ComboBox();
            this.noofpayment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.deduction = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.totalpayable = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.receivableamnt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.interestedamnt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Artifakt Element Heavy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(389, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 41);
            this.label5.TabIndex = 19;
            this.label5.Text = "LOAN ADD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Artifakt Element", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Term";
            // 
            // interest
            // 
            this.interest.Font = new System.Drawing.Font("Artifakt Element", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interest.Location = new System.Drawing.Point(239, 241);
            this.interest.Name = "interest";
            this.interest.Size = new System.Drawing.Size(170, 28);
            this.interest.TabIndex = 16;
            this.interest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.interest_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Artifakt Element", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Interest";
            // 
            // loanamnt
            // 
            this.loanamnt.Font = new System.Drawing.Font("Artifakt Element", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanamnt.Location = new System.Drawing.Point(239, 180);
            this.loanamnt.Name = "loanamnt";
            this.loanamnt.Size = new System.Drawing.Size(170, 28);
            this.loanamnt.TabIndex = 14;
            this.loanamnt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loanamnt_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Artifakt Element", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Loan Amount";
            // 
            // clientid
            // 
            this.clientid.Font = new System.Drawing.Font("Artifakt Element", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientid.Location = new System.Drawing.Point(239, 123);
            this.clientid.Name = "clientid";
            this.clientid.Size = new System.Drawing.Size(170, 28);
            this.clientid.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Artifakt Element", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "ClientID";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Artifakt Element", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(635, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // termcombobox
            // 
            this.termcombobox.Font = new System.Drawing.Font("Artifakt Element", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termcombobox.FormattingEnabled = true;
            this.termcombobox.Items.AddRange(new object[] {
            "Daily",
            "Weekly ",
            "Bi-Monthly",
            "Monthly "});
            this.termcombobox.Location = new System.Drawing.Point(239, 298);
            this.termcombobox.Name = "termcombobox";
            this.termcombobox.Size = new System.Drawing.Size(170, 29);
            this.termcombobox.TabIndex = 20;
            // 
            // noofpayment
            // 
            this.noofpayment.Font = new System.Drawing.Font("Artifakt Element", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noofpayment.Location = new System.Drawing.Point(239, 354);
            this.noofpayment.Name = "noofpayment";
            this.noofpayment.Size = new System.Drawing.Size(170, 28);
            this.noofpayment.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Artifakt Element", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(86, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "No of Payment";
            // 
            // deduction
            // 
            this.deduction.Font = new System.Drawing.Font("Artifakt Element", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deduction.Location = new System.Drawing.Point(239, 406);
            this.deduction.Name = "deduction";
            this.deduction.Size = new System.Drawing.Size(170, 28);
            this.deduction.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Artifakt Element", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(86, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 21);
            this.label7.TabIndex = 23;
            this.label7.Text = "Deduction";
            // 
            // status
            // 
            this.status.Font = new System.Drawing.Font("Artifakt Element", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(635, 351);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(170, 28);
            this.status.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Artifakt Element", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(482, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 21);
            this.label8.TabIndex = 33;
            this.label8.Text = "Status";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Artifakt Element", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(482, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 21);
            this.label9.TabIndex = 31;
            this.label9.Text = "Due Date";
            // 
            // totalpayable
            // 
            this.totalpayable.Font = new System.Drawing.Font("Artifakt Element", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalpayable.Location = new System.Drawing.Point(635, 237);
            this.totalpayable.Name = "totalpayable";
            this.totalpayable.Size = new System.Drawing.Size(170, 28);
            this.totalpayable.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Artifakt Element", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(481, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 21);
            this.label10.TabIndex = 29;
            this.label10.Text = "Total Payable";
            // 
            // receivableamnt
            // 
            this.receivableamnt.Font = new System.Drawing.Font("Artifakt Element", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receivableamnt.Location = new System.Drawing.Point(635, 178);
            this.receivableamnt.Name = "receivableamnt";
            this.receivableamnt.Size = new System.Drawing.Size(170, 28);
            this.receivableamnt.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Artifakt Element", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(482, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 21);
            this.label11.TabIndex = 27;
            this.label11.Text = "Receivable Amount";
            // 
            // interestedamnt
            // 
            this.interestedamnt.Font = new System.Drawing.Font("Artifakt Element", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestedamnt.Location = new System.Drawing.Point(635, 120);
            this.interestedamnt.Name = "interestedamnt";
            this.interestedamnt.Size = new System.Drawing.Size(170, 28);
            this.interestedamnt.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Artifakt Element", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(482, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 21);
            this.label12.TabIndex = 25;
            this.label12.Text = "Interested Amount";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Artifakt Element", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(635, 305);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(239, 22);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // LoanAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 509);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.totalpayable);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.receivableamnt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.interestedamnt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.deduction);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.noofpayment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.termcombobox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.interest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loanamnt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clientid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "LoanAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoanAdd";
            this.Load += new System.EventHandler(this.LoanAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox interest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox loanamnt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox clientid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox termcombobox;
        private System.Windows.Forms.TextBox noofpayment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox deduction;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox totalpayable;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox receivableamnt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox interestedamnt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}