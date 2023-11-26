namespace Payroll_management
{
    partial class relatorio
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
            label17 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(344, 14);
            label17.Name = "label17";
            label17.Size = new Size(91, 19);
            label17.TabIndex = 44;
            label17.Text = "RELATÓRIO";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 120);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(649, 223);
            dataGridView1.TabIndex = 45;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 77);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 47;
            label2.Text = "ID:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(107, 74);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 23);
            textBox1.TabIndex = 46;
            // 
            // button2
            // 
            button2.BackColor = Color.Chartreuse;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatAppearance.MouseDownBackColor = Color.LawnGreen;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(332, 70);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(126, 33);
            button2.TabIndex = 48;
            button2.Text = "Pesquisar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // relatorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label17);
            Margin = new Padding(3, 2, 3, 2);
            Name = "relatorio";
            Size = new Size(959, 489);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label17;
        private DataGridView dataGridView1;
        private Label label2;
        private TextBox textBox1;
        private Button button2;
    }
}
