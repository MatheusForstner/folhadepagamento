﻿using System;
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
    public partial class departamento : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-56DDE3C\\SQLEXPRESS;Initial Catalog=funcionario1;Integrated Security=True");

        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from departamento_Tab", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public departamento()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("INSERT INTO departamento_Tab(id, cargo, departamento) values ('" + int.Parse(textBox11.Text) + "', '" + textBox1.Text + "', '" + textBox2.Text + "')", con);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Sucesso salvar!");
            con.Close();
            BindData();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("UPDATE departamento_Tab set cargo = '" + textBox1.Text + "', departamento = '" + textBox2.Text + "' where id= '" + int.Parse(textBox11.Text) + "'", con);
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
                SqlCommand cmd1 = new SqlCommand("Delete departamento_Tab where id= '" + int.Parse(textBox11.Text) + "'", con);
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
            textBox2.Clear();
            textBox11.Focus();
        }
    }
}
