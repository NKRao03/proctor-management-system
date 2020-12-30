namespace PMS
{
    partial class Student_UC
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.usn_tb = new System.Windows.Forms.TextBox();
            this.programme_tb = new System.Windows.Forms.TextBox();
            this.dept_tb = new System.Windows.Forms.TextBox();
            this.adyear_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Programme = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Student_search = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Search_button = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(652, 108);
            this.dataGridView1.TabIndex = 0;
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(92, 274);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(100, 20);
            this.name_tb.TabIndex = 1;
            // 
            // usn_tb
            // 
            this.usn_tb.Location = new System.Drawing.Point(378, 271);
            this.usn_tb.Name = "usn_tb";
            this.usn_tb.Size = new System.Drawing.Size(100, 20);
            this.usn_tb.TabIndex = 2;
            // 
            // programme_tb
            // 
            this.programme_tb.Location = new System.Drawing.Point(92, 311);
            this.programme_tb.Name = "programme_tb";
            this.programme_tb.Size = new System.Drawing.Size(100, 20);
            this.programme_tb.TabIndex = 3;
            // 
            // dept_tb
            // 
            this.dept_tb.Location = new System.Drawing.Point(378, 307);
            this.dept_tb.Name = "dept_tb";
            this.dept_tb.Size = new System.Drawing.Size(100, 20);
            this.dept_tb.TabIndex = 4;
            // 
            // adyear_tb
            // 
            this.adyear_tb.Location = new System.Drawing.Point(268, 364);
            this.adyear_tb.Name = "adyear_tb";
            this.adyear_tb.Size = new System.Drawing.Size(100, 20);
            this.adyear_tb.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "USN:";
            // 
            // Programme
            // 
            this.Programme.AutoSize = true;
            this.Programme.Location = new System.Drawing.Point(23, 318);
            this.Programme.Name = "Programme";
            this.Programme.Size = new System.Drawing.Size(63, 13);
            this.Programme.TabIndex = 8;
            this.Programme.Text = "Programme:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Department:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Year Of Admission:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add:";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(190, 226);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(75, 23);
            this.Delete_button.TabIndex = 12;
            this.Delete_button.Text = "Delete:";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Student_search
            // 
            this.Student_search.Location = new System.Drawing.Point(164, 15);
            this.Student_search.Name = "Student_search";
            this.Student_search.Size = new System.Drawing.Size(287, 20);
            this.Student_search.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Search Student USN:";
            // 
            // Search_button
            // 
            this.Search_button.Location = new System.Drawing.Point(303, 41);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(148, 23);
            this.Search_button.TabIndex = 15;
            this.Search_button.Text = "SEARCH";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(467, 226);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 16;
            this.Clear.Text = "Clear:";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Student_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Student_search);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Programme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adyear_tb);
            this.Controls.Add(this.dept_tb);
            this.Controls.Add(this.programme_tb);
            this.Controls.Add(this.usn_tb);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Student_UC";
            this.Size = new System.Drawing.Size(652, 450);
            this.Load += new System.EventHandler(this.Student_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.TextBox usn_tb;
        private System.Windows.Forms.TextBox programme_tb;
        private System.Windows.Forms.TextBox dept_tb;
        private System.Windows.Forms.TextBox adyear_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Programme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.TextBox Student_search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.Button Clear;
    }
}
