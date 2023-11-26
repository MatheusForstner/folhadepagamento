using System.Data;
using System.Data.SqlClient;


namespace Payroll_management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textUserName.Text == "")
            {
                MessageBox.Show("Digitar em usuário!");
            }
            else if (textpassword.Text == "")
            {
                MessageBox.Show("Digitar em senha!");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-56DDE3C\\SQLEXPRESS;Initial Catalog=loginform;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("select * from tbl_login where username = @username and password = @password", con);
                    cmd.Parameters.AddWithValue("@username", textUserName.Text);
                    cmd.Parameters.AddWithValue("@password", textpassword.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Sucesso no usuário!");
                        DashBoard form2 = new DashBoard();
                        form2.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error a senha ou usuário!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textUserName.Clear();
            textpassword.Clear();

            textUserName.Focus();
        }
    }
}