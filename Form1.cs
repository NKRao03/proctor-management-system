using System;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database1.mdf\";Integrated Security=True");
        SqlDataReader dr;
        SqlCommand cmd;

        private String getUsername()
        {
            con.Open();
            String syntax = "SELECT pNUM FROM Credentials where pNUM='123'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            con.Close();
            return temp;
        }
        private String getPassword()
        {
            con.Open();
            String syntax = "SELECT Value FROM Credentials where pNUM='123'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            con.Close();
            return temp;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String Uname = getUsername(), Upass = getPassword(), name, pass;
            name = textBox1.Text;
            pass = textBox2.Text;

            if (name.Equals(Uname) && pass.Equals(Upass))
            {
                Body obj = new Body();
                this.Hide();
                obj.Show();

            }
            else
            {
                MessageBox.Show("Invalid Credentials Entered");

            }
        }
    }
}
