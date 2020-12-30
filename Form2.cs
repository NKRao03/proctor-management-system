using System;
using System.Windows.Forms;

namespace PMS
{
    public partial class Body : Form
    {
        public Body()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Contains(Student_UC.Instance))
            {
                ContentPanel.Controls.Add(Student_UC.Instance);
                Student_UC.Instance.Dock = DockStyle.Fill;
                Student_UC.Instance.BringToFront();
            }
            else
            {
                Student_UC.Instance.BringToFront();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Contains(Meetings_UC.Instance))
            {
                ContentPanel.Controls.Add(Meetings_UC.Instance);
                Meetings_UC.Instance.Dock = DockStyle.Fill;
                Meetings_UC.Instance.BringToFront();
            }
            else
            {
                Meetings_UC.Instance.BringToFront();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Contains(About_UC.Instance))
            {
                ContentPanel.Controls.Add(About_UC.Instance);
                About_UC.Instance.Dock = DockStyle.Fill;
                About_UC.Instance.BringToFront();
            }
            else
            {
                About_UC.Instance.BringToFront();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Contains(Marks_UC.Instance))
            {
                ContentPanel.Controls.Add(Marks_UC.Instance);
                Marks_UC.Instance.Dock = DockStyle.Fill;
                Marks_UC.Instance.BringToFront();
            }
            else
            {
                Marks_UC.Instance.BringToFront();
            }
        }
    }
}
