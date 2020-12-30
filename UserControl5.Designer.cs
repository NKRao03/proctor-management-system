namespace PMS
{
    partial class Marks_UC
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.usn_tb = new System.Windows.Forms.TextBox();
            this.sem_tb = new System.Windows.Forms.TextBox();
            this.sub1_tb = new System.Windows.Forms.TextBox();
            this.sub2_tb = new System.Windows.Forms.TextBox();
            this.sub3_tb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Search_button = new System.Windows.Forms.Button();
            this.marks_search = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "USN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Semester:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Subject2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(426, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Subject1:";
            // 
            // usn_tb
            // 
            this.usn_tb.Location = new System.Drawing.Point(101, 337);
            this.usn_tb.Name = "usn_tb";
            this.usn_tb.Size = new System.Drawing.Size(100, 20);
            this.usn_tb.TabIndex = 6;
            // 
            // sem_tb
            // 
            this.sem_tb.Location = new System.Drawing.Point(308, 337);
            this.sem_tb.Name = "sem_tb";
            this.sem_tb.Size = new System.Drawing.Size(100, 20);
            this.sem_tb.TabIndex = 7;
            // 
            // sub1_tb
            // 
            this.sub1_tb.Location = new System.Drawing.Point(514, 337);
            this.sub1_tb.Name = "sub1_tb";
            this.sub1_tb.Size = new System.Drawing.Size(100, 20);
            this.sub1_tb.TabIndex = 8;
            // 
            // sub2_tb
            // 
            this.sub2_tb.Location = new System.Drawing.Point(101, 409);
            this.sub2_tb.Name = "sub2_tb";
            this.sub2_tb.Size = new System.Drawing.Size(100, 20);
            this.sub2_tb.TabIndex = 9;
            // 
            // sub3_tb
            // 
            this.sub3_tb.Location = new System.Drawing.Point(308, 409);
            this.sub3_tb.Name = "sub3_tb";
            this.sub3_tb.Size = new System.Drawing.Size(100, 20);
            this.sub3_tb.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add:";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(223, 254);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(75, 23);
            this.Delete_button.TabIndex = 13;
            this.Delete_button.Text = "Delete:";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(404, 254);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 17;
            this.Clear.Text = "Clear:";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Search_button
            // 
            this.Search_button.Location = new System.Drawing.Point(297, 47);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(148, 23);
            this.Search_button.TabIndex = 18;
            this.Search_button.Text = "SEARCH";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // marks_search
            // 
            this.marks_search.Location = new System.Drawing.Point(158, 21);
            this.marks_search.Name = "marks_search";
            this.marks_search.Size = new System.Drawing.Size(287, 20);
            this.marks_search.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Search Student USN:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(652, 108);
            this.dataGridView1.TabIndex = 21;
            // 
            // Marks_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.marks_search);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sub3_tb);
            this.Controls.Add(this.sub2_tb);
            this.Controls.Add(this.sub1_tb);
            this.Controls.Add(this.sem_tb);
            this.Controls.Add(this.usn_tb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Marks_UC";
            this.Size = new System.Drawing.Size(652, 450);
            this.Load += new System.EventHandler(this.Marks_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox usn_tb;
        private System.Windows.Forms.TextBox sem_tb;
        private System.Windows.Forms.TextBox sub1_tb;
        private System.Windows.Forms.TextBox sub2_tb;
        private System.Windows.Forms.TextBox sub3_tb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.TextBox marks_search;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
