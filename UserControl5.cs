using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace PMS
{
    public partial class Marks_UC : UserControl
    {
        private static Marks_UC _instance;

        public static Marks_UC Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Marks_UC();
                }
                return _instance;
            }
        }
        public Marks_UC()
        {
            InitializeComponent();
        }
        public void refresh_DataGridView()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("MarkViewValueProcedure", con);
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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("MarkAddValueProcedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@USN", usn_tb.Text);
            cmd.Parameters.AddWithValue("@semester", sem_tb.Text);
            cmd.Parameters.AddWithValue("@sub3", sub3_tb.Text);
            cmd.Parameters.AddWithValue("@sub2", sub2_tb.Text);
            cmd.Parameters.AddWithValue("@sub1", sub1_tb.Text);

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



        private void Marks_UC_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("MarkDeleteValueProcedure", con);
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

        private void Clear_Click(object sender, EventArgs e)
        {
            usn_tb.Text = "";
            sem_tb.Text = "";
            sub3_tb.Text = "";
            sub1_tb.Text = "";
            sub2_tb.Text = "";
            marks_search.Text = "";
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("MarkSearchValueProcedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@USN", marks_search.Text);

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
    }
}
