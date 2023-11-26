namespace Payroll_management
{
    partial class beneficios
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            button7 = new Button();
            button6 = new Button();
            dataGridView1 = new DataGridView();
            textBox11 = new TextBox();
            label17 = new Label();
            button3 = new Button();
            button2 = new Button();
            label3 = new Label();
            label1 = new Label();
            comboBox3 = new ComboBox();
            label4 = new Label();
            dateTimePicker2 = new DateTimePicker();
            textBox1 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button7
            // 
            button7.BackColor = Color.Black;
            button7.FlatAppearance.BorderColor = Color.Black;
            button7.FlatAppearance.BorderSize = 2;
            button7.FlatAppearance.MouseDownBackColor = Color.DimGray;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.White;
            button7.Location = new Point(359, 327);
            button7.Name = "button7";
            button7.Size = new Size(158, 38);
            button7.TabIndex = 82;
            button7.Text = "Atualizar";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Red;
            button6.FlatAppearance.BorderSize = 2;
            button6.FlatAppearance.MouseDownBackColor = Color.Firebrick;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.Black;
            button6.Location = new Point(523, 327);
            button6.Name = "button6";
            button6.Size = new Size(158, 38);
            button6.TabIndex = 83;
            button6.Text = "Remover";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(49, 223);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(623, 98);
            dataGridView1.TabIndex = 80;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(164, 53);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(208, 23);
            textBox11.TabIndex = 79;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(385, 15);
            label17.Name = "label17";
            label17.Size = new Size(95, 19);
            label17.TabIndex = 78;
            label17.Text = "BENEFICIOS";
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.FlatAppearance.BorderColor = Color.Black;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatAppearance.MouseDownBackColor = Color.DimGray;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Transparent;
            button3.Location = new Point(535, 185);
            button3.Name = "button3";
            button3.Size = new Size(137, 32);
            button3.TabIndex = 77;
            button3.Text = "Limprar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Chartreuse;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatAppearance.MouseDownBackColor = Color.LawnGreen;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(410, 185);
            button2.Name = "button2";
            button2.Size = new Size(119, 32);
            button2.TabIndex = 76;
            button2.Text = "Salvar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(70, 95);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 75;
            label3.Text = "Beneficios:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(129, 53);
            label1.Name = "label1";
            label1.Size = new Size(29, 20);
            label1.TabIndex = 71;
            label1.Text = "ID:";
            label1.Click += label1_Click;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Vale alimentação", "Vale Refeição", "Transporte", "Convêncio", "Odonotologia", "PLR" });
            comboBox3.Location = new Point(164, 92);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(208, 23);
            comboBox3.TabIndex = 84;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(398, 56);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 86;
            label4.Text = "Data:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(453, 56);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(189, 23);
            dateTimePicker2.TabIndex = 87;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(459, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(183, 23);
            textBox1.TabIndex = 88;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(398, 95);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 89;
            label5.Text = "Custo:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(518, 134);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(124, 23);
            textBox3.TabIndex = 90;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(398, 134);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 91;
            label6.Text = "Porcentagem:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(92, 134);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 92;
            label7.Text = "Acesso:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ATIVO", "INATIVO", "BLOQUEAR" });
            comboBox1.Location = new Point(164, 134);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(208, 23);
            comboBox1.TabIndex = 93;
            // 
            // beneficios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(dateTimePicker2);
            Controls.Add(label4);
            Controls.Add(comboBox3);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(dataGridView1);
            Controls.Add(textBox11);
            Controls.Add(label17);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "beneficios";
            Size = new Size(959, 489);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button7;
        private Button button6;
        private DataGridView dataGridView1;
        private TextBox textBox11;
        private Label label17;
        private Button button3;
        private Button button2;
        private Label label3;
        private Label label1;
        private ComboBox comboBox3;
        private Label label4;
        private DateTimePicker dateTimePicker2;
        private TextBox textBox1;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
        private Label label7;
        private ComboBox comboBox1;
    }
}
