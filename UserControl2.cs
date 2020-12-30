using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace PMS
{
    public partial class Student_UC : UserControl
    {
        
        private static Student_UC _instance;

        public static Student_UC Instance
        {

            get
            {
                if (_instance == null)
                {
                    _instance = new Student_UC();
                }
                return _instance;
            }
        }
        public Student_UC()
        {
            InitializeComponent();
        }


        public void refresh_DataGridView()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("StudentViewValueProcedure", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                da.Fill(ds);

                con.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show("" + e);
                }
                con.Close();

                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void Student_UC_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("StudentAddValueProcedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@USN", usn_tb.Text);
            cmd.Parameters.AddWithValue("@student_name", name_tb.Text);
            cmd.Parameters.AddWithValue("@Programme", programme_tb.Text);
            cmd.Parameters.AddWithValue("@Department", dept_tb.Text);
            cmd.Parameters.AddWithValue("@admission_year", adyear_tb.Text);

            con.Open();

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception exe)
            {
                MessageBox.Show("" + exe);
            }

            con.Close();

            refresh_DataGridView();
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("StudentDeleteValueProcedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@USN", usn_tb.Text);
            
            con.Open();

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception exe)
            {
                MessageBox.Show("" + exe);
            }

            con.Close();



            refresh_DataGridView();
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("StudentSearchValueProcedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usn", Student_search.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds);

            con.Open();

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception exe)
            {
                MessageBox.Show("" + exe);
            }

            con.Close();
            dataGridView1.DataSource = ds.Tables[0];
           
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Student_search.Text = "";
            name_tb.Text = "";
            programme_tb.Text = "";
            dept_tb.Text = "";
            adyear_tb.Text = "";
            usn_tb.Text = "";
        }
    }
}
