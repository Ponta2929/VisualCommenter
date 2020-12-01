using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualCommenter
{
    public partial class GridForm : Form
    {
        private int x, y;

        public GridForm()
        {
            InitializeComponent();
        }

        private void Panel_Grid_MouseLeave(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void Panel_Grid_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                x = e.X;
                y = e.Y;
            }
        }

        private void Panel_Grid_MouseMove(object sender, MouseEventArgs e)
        {
            var owner = this.Owner;

            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - x ;
                this.Top += e.Y - y;
                owner.Left = this.Left + 5;
                owner.Top = this.Top + 5;
            }
        }
    }
}
