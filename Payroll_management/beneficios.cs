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

namespace Payroll_management
{
    public partial class beneficios : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-56DDE3C\\SQLEXPRESS;Initial Catalog=funcionario1;Integrated Security=True");

        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from beneficios_tb", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public beneficios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("INSERT INTO beneficios_tb (id, beneficios, acesso, data_beneficios, custo, porcentagem) values ('" + int.Parse(textBox11.Text) + "', '" + comboBox3.Text + "', '" + comboBox1.Text + "', '" + dateTimePicker2.Text + "', '" + textBox1.Text + "', '" + textBox3.Text + "')", con);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Sucesso salvar!");
            con.Close();
            BindData();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("UPDATE beneficios_tb set beneficios = '" + comboBox3.Text + "', acesso = '" + comboBox1.Text + "', data_beneficios = '" + dateTimePicker2.Text + "', custo = '" + textBox1.Text + "', porcentagem = '" + textBox3.Text + "'  where id= '" + int.Parse(textBox11.Text) + "'", con);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Sucesso atualizar!");
            con.Close();
            BindData();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox11 != null)
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("Delete beneficios_tb where id= '" + int.Parse(textBox11.Text) + "'", con);
                cmd1.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Sucesso excluir!");
                BindData();
            }
            else
            {
                MessageBox.Show("Obrigatorio ID!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox11.Clear();
            textBox1.Clear();
            textBox3.Clear();
            textBox11.Focus();
        }
    }
}
