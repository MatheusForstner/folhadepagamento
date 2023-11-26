namespace Payroll_management
{
    partial class office
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
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
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
            button7.Location = new Point(372, 333);
            button7.Name = "button7";
            button7.Size = new Size(158, 38);
            button7.TabIndex = 69;
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
            button6.Location = new Point(536, 333);
            button6.Name = "button6";
            button6.Size = new Size(158, 38);
            button6.TabIndex = 70;
            button6.Text = "Remover";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(53, 186);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(641, 141);
            dataGridView1.TabIndex = 67;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(249, 50);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(306, 23);
            textBox11.TabIndex = 66;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(362, 16);
            label17.Name = "label17";
            label17.Size = new Size(62, 19);
            label17.TabIndex = 65;
            label17.Text = "OFFICE";
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
            button3.Location = new Point(418, 148);
            button3.Name = "button3";
            button3.Size = new Size(137, 32);
            button3.TabIndex = 64;
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
            button2.Location = new Point(293, 148);
            button2.Name = "button2";
            button2.Size = new Size(119, 32);
            button2.TabIndex = 63;
            button2.Text = "Salvar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(174, 118);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 62;
            label3.Text = "Acesso:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(183, 89);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 61;
            label2.Text = "Cargo:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(249, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(306, 23);
            textBox1.TabIndex = 59;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(211, 52);
            label1.Name = "label1";
            label1.Size = new Size(29, 20);
            label1.TabIndex = 58;
            label1.Text = "ID:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ATIVO", "INATIVO", "BLOQUEAR" });
            comboBox1.Location = new Point(249, 119);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(306, 23);
            comboBox1.TabIndex = 71;
            // 
            // office
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(comboBox1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(dataGridView1);
            Controls.Add(textBox11);
            Controls.Add(label17);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "office";
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
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private ComboBox comboBox1;
    }
}
