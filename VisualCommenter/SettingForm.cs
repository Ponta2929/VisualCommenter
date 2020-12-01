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
    public partial class SettingForm : Form
    {
        private Setting setting = Setting.GetInstance();

        public SettingForm()
        {
            InitializeComponent();

            // Initialize();
            Initialize();
        }
        public void Initialize()
        {
            SetSettingData();
        }

        private void SetSettingData()
        {
            this.Label_ViewFont.Font = new Font(setting.Comment_Font.FontFamily, 9);
            this.Label_ViewFont.Text = $"{setting.Comment_Font.FontFamily.Name}, {setting.Comment_Font.Size}pt";
            this.NumericUpDown_Margin.Value = setting.Background_Margin;
            this.NumericUpDown_Alpha.Value = setting.Background_Alpha;
            this.NumericUpDown_Curve.Value = setting.Background_Curve;
            this.NumericUpDown_Separator.Value = setting.Background_Separator;
            this.NumericUpDown_LastComment.Value = setting.Comment_LastTime;
            this.CheckBox_SelectBackground.Checked = setting.Background_Selected;
            this.Label_DefaultColorSelect.BackColor = setting.Background_Color;
            this.NumericUpDown_Fade.Value = (decimal)setting.All_Fade;
            this.NumericUpDown_Width.Value = setting.Gadget_Width;
        }

        private void Label_ViewFont_Click(object sender, EventArgs e)
        {
            using (var fd = new FontDialog())
            {
                fd.Font = setting.Comment_Font;

                if (fd.ShowDialog(this) == DialogResult.OK)
                {
                    setting.Comment_Font = fd.Font;
                }
            }

            SetSettingData();
        }

        private void NumericUpDown_LastComment_ValueChanged(object sender, EventArgs e) =>
            setting.Comment_LastTime = (int)NumericUpDown_LastComment.Value;

        private void NumericUpDown_Margin_ValueChanged(object sender, EventArgs e) =>
            setting.Background_Margin = (int)NumericUpDown_Margin.Value;

        private void NumericUpDown_Separator_ValueChanged(object sender, EventArgs e) =>
            setting.Background_Separator = (int)NumericUpDown_Separator.Value;

        private void NumericUpDown_Alpha_ValueChanged(object sender, EventArgs e) =>
            setting.Background_Alpha = (int)NumericUpDown_Alpha.Value;

        private void NumericUpDown_Curve_ValueChanged(object sender, EventArgs e) =>
            setting.Background_Curve = (int)NumericUpDown_Curve.Value;


        private void NumericUpDown_Fade_ValueChanged(object sender, EventArgs e) =>
            setting.All_Fade = (float)NumericUpDown_Fade.Value;

        private void Label_DefaultColorSelect_Click(object sender, EventArgs e)
        {
            using (var cd = new ColorDialog())
            {
                cd.Color = setting.Background_Color;

                if (cd.ShowDialog(this) == DialogResult.OK)
                {
                    setting.Background_Color = cd.Color;
                }
            }

            SetSettingData();
        }

        private void CheckBox_SelectBackground_CheckedChanged(object sender, EventArgs e) =>
            setting.Background_Selected = this.CheckBox_SelectBackground.Checked;

        private void NumericUpDown_Width_ValueChanged(object sender, EventArgs e) =>
            setting.Gadget_Width = (int)NumericUpDown_Width.Value;

    }
}
