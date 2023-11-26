using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Payroll_management
{
    public partial class relatorio : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-56DDE3C\\SQLEXPRESS;Initial Catalog=funcionario1;Integrated Security=True");
        public relatorio()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
                SqlCommand command = new SqlCommand("select * from funcionario_1 where id= '" + int.Parse(textBox1.Text) + "'", con);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
        }
    }
}
