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
    public partial class EC_Employee : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-56DDE3C\\SQLEXPRESS;Initial Catalog=funcionario1;Integrated Security=True");

        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from funcionario_1", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public EC_Employee()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd1 = new SqlCommand("INSERT INTO funcionario_1 (id, nome, complementar, genero, celular, telefone, area, empresa, cpf, funcionario, dataemissao, endereco, enderecocomplementar, bairro, datanascimento) values ('" + int.Parse(textBox11.Text) + "', '" + textBox1.Text + "', '" + textBox2.Text + "', '" + comboBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + comboBox3.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "', '" + textBox7.Text + "', '" + this.dateTimePicker2.Text + "', '" + textBox8.Text + "', '" + textBox9.Text + "', '" + textBox10.Text + "', '" + this.dateTimePicker1.Text + "')", con);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Sucesso salvar!");
            con.Close();
            BindData();


        }
        private void button7_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("UPDATE funcionario_1 set nome = '" + textBox1.Text + "', complementar = '" + textBox2.Text + "', genero = '" + comboBox2.Text + "', celular = '" + textBox3.Text + "', telefone = '" + textBox4.Text + "', area = '" + comboBox3.Text + "', empresa =  '" + textBox5.Text + "', cpf = '" + textBox6.Text + "', funcionario = '" + textBox7.Text + "', dataemissao = '" + this.dateTimePicker2.Text + "', endereco = '" + textBox8.Text + "', enderecocomplementar = '" + textBox9.Text + "', bairro = '" + textBox10.Text + "', datanascimento = '" + this.dateTimePicker1.Text + "' where id= '" + int.Parse(textBox11.Text) + "'", con);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Sucesso atualizar!");
            con.Close();
            BindData();

        }

        private void EC_Employee_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox11 != null)
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("Delete funcionario_1 where id= '" + int.Parse(textBox11.Text) + "'", con);
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

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox11.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Focus();
        }
    }
}
