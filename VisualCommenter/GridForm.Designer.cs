
namespace VisualCommenter
{
    partial class GridForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel_Grid = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Panel_Grid
            // 
            this.Panel_Grid.BackgroundImage = global::VisualCommenter.Properties.Resources.Grid;
            this.Panel_Grid.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Panel_Grid.Location = new System.Drawing.Point(0, 0);
            this.Panel_Grid.Name = "Panel_Grid";
            this.Panel_Grid.Size = new System.Drawing.Size(11, 11);
            this.Panel_Grid.TabIndex = 0;
            this.Panel_Grid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Grid_MouseDown);
            this.Panel_Grid.MouseLeave += new System.EventHandler(this.Panel_Grid_MouseLeave);
            this.Panel_Grid.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_Grid_MouseMove);
            // 
            // GridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Magenta;
            this.ClientSize = new System.Drawing.Size(100, 100);
            this.ControlBox = false;
            this.Controls.Add(this.Panel_Grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GridForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GridForm";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Grid;
    }
}