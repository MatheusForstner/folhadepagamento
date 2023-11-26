namespace Payroll_management
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            button3 = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            button1 = new Button();
            label3 = new Label();
            textpassword = new TextBox();
            label2 = new Label();
            textUserName = new TextBox();
            label1 = new Label();
            label4 = new Label();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textpassword);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textUserName);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(549, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(621, 456);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.FlatAppearance.BorderColor = Color.Gray;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatAppearance.MouseDownBackColor = Color.Gray;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(170, 254);
            button3.Name = "button3";
            button3.Size = new Size(161, 43);
            button3.TabIndex = 8;
            button3.Text = "Limprar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(170, 187);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(26, 27);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(170, 129);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 20);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(296, 57);
            label5.Name = "label5";
            label5.Size = new Size(110, 32);
            label5.TabIndex = 6;
            label5.Text = "Usuário";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderColor = Color.Gray;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseDownBackColor = Color.Gray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(346, 254);
            button1.Name = "button1";
            button1.Size = new Size(161, 43);
            button1.TabIndex = 5;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(196, 222);
            label3.Name = "label3";
            label3.Size = new Size(109, 16);
            label3.TabIndex = 4;
            label3.Text = "Esquecer senha";
            label3.Click += label3_Click;
            // 
            // textpassword
            // 
            textpassword.CharacterCasing = CharacterCasing.Lower;
            textpassword.Location = new Point(196, 187);
            textpassword.Name = "textpassword";
            textpassword.PasswordChar = '*';
            textpassword.Size = new Size(311, 26);
            textpassword.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 164);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 2;
            label2.Text = "Senha:";
            // 
            // textUserName
            // 
            textUserName.Location = new Point(196, 127);
            textUserName.Name = "textUserName";
            textUserName.Size = new Size(311, 26);
            textUserName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(196, 104);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Usuário:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(413, 43);
            label4.Name = "label4";
            label4.Size = new Size(432, 32);
            label4.TabIndex = 1;
            label4.Text = "SISTEMA PAGAMENTO DE FOLHA";
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(224, 224, 224);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(1119, 29);
            button2.Name = "button2";
            button2.Size = new Size(89, 46);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(117, 132);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(392, 341);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1235, 580);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox textpassword;
        private Label label2;
        private TextBox textUserName;
        private Label label3;
        private Button button1;
        private Label label4;
        private Label label5;
        private Button button2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button button3;
    }
}