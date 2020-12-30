namespace PMS
{
    partial class Meetings_UC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usn_tb = new System.Windows.Forms.TextBox();
            this.pnum_tb = new System.Windows.Forms.TextBox();
            this.time_tb = new System.Windows.Forms.TextBox();
            this.venue_tb = new System.Windows.Forms.TextBox();
            this.issue_tb = new System.Windows.Forms.TextBox();
            this.usn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.date_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.remedy_tb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // usn_tb
            // 
            this.usn_tb.Location = new System.Drawing.Point(42, 298);
            this.usn_tb.Name = "usn_tb";
            this.usn_tb.Size = new System.Drawing.Size(100, 20);
            this.usn_tb.TabIndex = 0;
            // 
            // pnum_tb
            // 
            this.pnum_tb.Location = new System.Drawing.Point(207, 298);
            this.pnum_tb.Name = "pnum_tb";
            this.pnum_tb.Size = new System.Drawing.Size(100, 20);
            this.pnum_tb.TabIndex = 1;
            // 
            // time_tb
            // 
            this.time_tb.Location = new System.Drawing.Point(366, 298);
            this.time_tb.Name = "time_tb";
            this.time_tb.Size = new System.Drawing.Size(52, 20);
            this.time_tb.TabIndex = 2;
            // 
            // venue_tb
            // 
            this.venue_tb.Location = new System.Drawing.Point(50, 371);
            this.venue_tb.Name = "venue_tb";
            this.venue_tb.Size = new System.Drawing.Size(100, 20);
            this.venue_tb.TabIndex = 3;
            // 
            // issue_tb
            // 
            this.issue_tb.Location = new System.Drawing.Point(271, 371);
            this.issue_tb.Name = "issue_tb";
            this.issue_tb.Size = new System.Drawing.Size(138, 20);
            this.issue_tb.TabIndex = 4;
            // 
            // usn
            // 
            this.usn.AutoSize = true;
            this.usn.Location = new System.Drawing.Point(3, 305);
            this.usn.Name = "usn";
            this.usn.Size = new System.Drawing.Size(33, 13);
            this.usn.TabIndex = 5;
            this.usn.Text = "USN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Venue:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Issue:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "pNUM:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(652, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(271, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(477, 240);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Date:";
            // 
            // date_tb
            // 
            this.date_tb.Location = new System.Drawing.Point(494, 298);
            this.date_tb.Name = "date_tb";
            this.date_tb.Size = new System.Drawing.Size(100, 20);
            this.date_tb.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(439, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Remedy:";
            // 
            // remedy_tb
            // 
            this.remedy_tb.Location = new System.Drawing.Point(494, 371);
            this.remedy_tb.Name = "remedy_tb";
            this.remedy_tb.Size = new System.Drawing.Size(100, 20);
            this.remedy_tb.TabIndex = 18;
            // 
            // Meetings_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.remedy_tb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.date_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usn);
            this.Controls.Add(this.issue_tb);
            this.Controls.Add(this.venue_tb);
            this.Controls.Add(this.time_tb);
            this.Controls.Add(this.pnum_tb);
            this.Controls.Add(this.usn_tb);
            this.Name = "Meetings_UC";
            this.Size = new System.Drawing.Size(652, 450);
            this.Load += new System.EventHandler(this.Meetings_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usn_tb;
        private System.Windows.Forms.TextBox pnum_tb;
        private System.Windows.Forms.TextBox time_tb;
        private System.Windows.Forms.TextBox venue_tb;
        private System.Windows.Forms.TextBox issue_tb;
        private System.Windows.Forms.Label usn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox date_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox remedy_tb;
    }
}
