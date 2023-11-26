using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_management
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }
        Point DragCursor;
        Point DragForm;
        bool Dragging;

        private void button8_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            eC_Employee2.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            salario1.BringToFront();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            beneficios1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            office1.BringToFront();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            departamento1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            relatorio1.BringToFront();
        }

        private void office1_Load(object sender, EventArgs e)
        {

        }

        private void DashBoard_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            DragCursor = Cursor.Position;
            DragForm = this.Location;
        }

        private void DashBoard_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void DashBoard_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging == true)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(DragCursor));
                this.Location = Point.Add(DragForm, new Size(dif));
            }
        }

        private void beneficios1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            home1.BringToFront();
        }
    }
}
