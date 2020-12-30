namespace PMS
{
    partial class Student
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
            this.Add_New = new System.Windows.Forms.Button();
            this.adyear_tb = new System.Windows.Forms.TextBox();
            this.dept_tb = new System.Windows.Forms.TextBox();
            this.programme_tb = new System.Windows.Forms.TextBox();
            this.usn_tb = new System.Windows.Forms.TextBox();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.adyear = new System.Windows.Forms.Label();
            this.dept = new System.Windows.Forms.Label();
            this.programme = new System.Windows.Forms.Label();
            this.USN = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Add_New
            // 
            this.Add_New.Location = new System.Drawing.Point(69, 283);
            this.Add_New.Name = "Add_New";
            this.Add_New.Size = new System.Drawing.Size(75, 23);
            this.Add_New.TabIndex = 22;
            this.Add_New.Text = "Add:";
            this.Add_New.UseVisualStyleBackColor = true;
            // 
            // adyear_tb
            // 
            this.adyear_tb.Location = new System.Drawing.Point(505, 408);
            this.adyear_tb.Name = "adyear_tb";
            this.adyear_tb.Size = new System.Drawing.Size(100, 20);
            this.adyear_tb.TabIndex = 21;
            // 
            // dept_tb
            // 
            this.dept_tb.Location = new System.Drawing.Point(282, 408);
            this.dept_tb.Name = "dept_tb";
            this.dept_tb.Size = new System.Drawing.Size(100, 20);
            this.dept_tb.TabIndex = 20;
            // 
            // programme_tb
            // 
            this.programme_tb.Location = new System.Drawing.Point(106, 408);
            this.programme_tb.Name = "programme_tb";
            this.programme_tb.Size = new System.Drawing.Size(100, 20);
            this.programme_tb.TabIndex = 19;
            // 
            // usn_tb
            // 
            this.usn_tb.Location = new System.Drawing.Point(444, 334);
            this.usn_tb.Name = "usn_tb";
            this.usn_tb.Size = new System.Drawing.Size(161, 20);
            this.usn_tb.TabIndex = 18;
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(106, 334);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(276, 20);
            this.name_tb.TabIndex = 17;
            // 
            // adyear
            // 
            this.adyear.AutoSize = true;
            this.adyear.Location = new System.Drawing.Point(405, 415);
            this.adyear.Name = "adyear";
            this.adyear.Size = new System.Drawing.Size(94, 13);
            this.adyear.TabIndex = 16;
            this.adyear.Text = "Year of Admission:";
            // 
            // dept
            // 
            this.dept.AutoSize = true;
            this.dept.Location = new System.Drawing.Point(211, 415);
            this.dept.Name = "dept";
            this.dept.Size = new System.Drawing.Size(65, 13);
            this.dept.TabIndex = 15;
            this.dept.Text = "Department:";
            // 
            // programme
            // 
            this.programme.AutoSize = true;
            this.programme.Location = new System.Drawing.Point(37, 415);
            this.programme.Name = "programme";
            this.programme.Size = new System.Drawing.Size(63, 13);
            this.programme.TabIndex = 14;
            this.programme.Text = "Programme:";
            // 
            // USN
            // 
            this.USN.AutoSize = true;
            this.USN.Location = new System.Drawing.Point(405, 341);
            this.USN.Name = "USN";
            this.USN.Size = new System.Drawing.Size(33, 13);
            this.USN.TabIndex = 13;
            this.USN.Text = "USN:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(37, 341);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(38, 13);
            this.name.TabIndex = 12;
            this.name.Text = "Name:";
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Add_New);
            this.Controls.Add(this.adyear_tb);
            this.Controls.Add(this.dept_tb);
            this.Controls.Add(this.programme_tb);
            this.Controls.Add(this.usn_tb);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.adyear);
            this.Controls.Add(this.dept);
            this.Controls.Add(this.programme);
            this.Controls.Add(this.USN);
            this.Controls.Add(this.name);
            this.Name = "Student";
            this.Size = new System.Drawing.Size(652, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_New;
        private System.Windows.Forms.TextBox adyear_tb;
        private System.Windows.Forms.TextBox dept_tb;
        private System.Windows.Forms.TextBox programme_tb;
        private System.Windows.Forms.TextBox usn_tb;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.Label adyear;
        private System.Windows.Forms.Label dept;
        private System.Windows.Forms.Label programme;
        private System.Windows.Forms.Label USN;
        private System.Windows.Forms.Label name;
    }
}
