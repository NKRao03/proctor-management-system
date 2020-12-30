using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace PMS
{
    public partial class Meetings_UC : UserControl
    {
            private static Meetings_UC _instance;

            public static Meetings_UC Instance
            {
                get
                {
                    if (_instance == null)
                    {
                        _instance = new Meetings_UC();
                    }
                    return _instance;
                }
            }
            public Meetings_UC()
        {
            InitializeComponent();
        }
        public void refresh_DataGridView()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("MeetingsViewValueProcedure", con);
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
            SqlCommand cmd = new SqlCommand("MeetingsAddValueProcedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@USN", usn_tb.Text);
            cmd.Parameters.AddWithValue("@pNUM", pnum_tb.Text);
            cmd.Parameters.AddWithValue("@time", time_tb.Text);
            cmd.Parameters.AddWithValue("@date", date_tb.Text);
            cmd.Parameters.AddWithValue("@venue", venue_tb.Text);
            cmd.Parameters.AddWithValue("@issue", issue_tb.Text);
            cmd.Parameters.AddWithValue("@remedy", remedy_tb.Text);

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

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("MeetingsDeleteValueProcedure", con);
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

        private void button3_Click(object sender, EventArgs e)
        {
            usn_tb.Text = "";
            pnum_tb.Text = "";
            time_tb.Text = "";
            date_tb.Text = "";
            venue_tb.Text = "";
            issue_tb.Text = "";
            remedy_tb.Text = "";
        }

        private void Meetings_UC_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }
    }
}
