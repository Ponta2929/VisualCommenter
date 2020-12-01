
namespace VisualCommenter
{
    partial class SettingForm
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
            this.TabControl_Main = new System.Windows.Forms.TabControl();
            this.TabPage_Comment = new System.Windows.Forms.TabPage();
            this.NumericUpDown_LastComment = new System.Windows.Forms.NumericUpDown();
            this.Label_LastComment = new System.Windows.Forms.Label();
            this.Label_ViewFont = new System.Windows.Forms.Label();
            this.Label_Font = new System.Windows.Forms.Label();
            this.TabPage_Background = new System.Windows.Forms.TabPage();
            this.NumericUpDown_Fade = new System.Windows.Forms.NumericUpDown();
            this.Label_Fade = new System.Windows.Forms.Label();
            this.Label_DefaultColorSelect = new System.Windows.Forms.Label();
            this.Label_DefaultColor = new System.Windows.Forms.Label();
            this.CheckBox_SelectBackground = new System.Windows.Forms.CheckBox();
            this.NumericUpDown_Separator = new System.Windows.Forms.NumericUpDown();
            this.Label_Separator = new System.Windows.Forms.Label();
            this.NumericUpDown_Curve = new System.Windows.Forms.NumericUpDown();
            this.Label_Curve = new System.Windows.Forms.Label();
            this.NumericUpDown_Alpha = new System.Windows.Forms.NumericUpDown();
            this.Label_Alpha = new System.Windows.Forms.Label();
            this.NumericUpDown_Margin = new System.Windows.Forms.NumericUpDown();
            this.Label_Margin = new System.Windows.Forms.Label();
            this.NumericUpDown_Width = new System.Windows.Forms.NumericUpDown();
            this.Label_Width = new System.Windows.Forms.Label();
            this.TabControl_Main.SuspendLayout();
            this.TabPage_Comment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_LastComment)).BeginInit();
            this.TabPage_Background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Fade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Separator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Curve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Alpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Margin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Width)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl_Main
            // 
            this.TabControl_Main.Controls.Add(this.TabPage_Comment);
            this.TabControl_Main.Controls.Add(this.TabPage_Background);
            this.TabControl_Main.Location = new System.Drawing.Point(12, 12);
            this.TabControl_Main.Name = "TabControl_Main";
            this.TabControl_Main.SelectedIndex = 0;
            this.TabControl_Main.Size = new System.Drawing.Size(309, 266);
            this.TabControl_Main.TabIndex = 1;
            // 
            // TabPage_Comment
            // 
            this.TabPage_Comment.Controls.Add(this.NumericUpDown_LastComment);
            this.TabPage_Comment.Controls.Add(this.Label_LastComment);
            this.TabPage_Comment.Controls.Add(this.Label_ViewFont);
            this.TabPage_Comment.Controls.Add(this.Label_Font);
            this.TabPage_Comment.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Comment.Name = "TabPage_Comment";
            this.TabPage_Comment.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Comment.Size = new System.Drawing.Size(301, 211);
            this.TabPage_Comment.TabIndex = 0;
            this.TabPage_Comment.Text = "コメント";
            this.TabPage_Comment.UseVisualStyleBackColor = true;
            // 
            // NumericUpDown_LastComment
            // 
            this.NumericUpDown_LastComment.Location = new System.Drawing.Point(137, 36);
            this.NumericUpDown_LastComment.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.NumericUpDown_LastComment.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumericUpDown_LastComment.Name = "NumericUpDown_LastComment";
            this.NumericUpDown_LastComment.Size = new System.Drawing.Size(158, 19);
            this.NumericUpDown_LastComment.TabIndex = 9;
            this.NumericUpDown_LastComment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumericUpDown_LastComment.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericUpDown_LastComment.ValueChanged += new System.EventHandler(this.NumericUpDown_LastComment_ValueChanged);
            // 
            // Label_LastComment
            // 
            this.Label_LastComment.AutoSize = true;
            this.Label_LastComment.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label_LastComment.Location = new System.Drawing.Point(6, 39);
            this.Label_LastComment.Name = "Label_LastComment";
            this.Label_LastComment.Size = new System.Drawing.Size(125, 13);
            this.Label_LastComment.TabIndex = 8;
            this.Label_LastComment.Text = "最終コメント表示時間:";
            // 
            // Label_ViewFont
            // 
            this.Label_ViewFont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label_ViewFont.Location = new System.Drawing.Point(137, 8);
            this.Label_ViewFont.Name = "Label_ViewFont";
            this.Label_ViewFont.Size = new System.Drawing.Size(158, 20);
            this.Label_ViewFont.TabIndex = 1;
            this.Label_ViewFont.Click += new System.EventHandler(this.Label_ViewFont_Click);
            // 
            // Label_Font
            // 
            this.Label_Font.AutoSize = true;
            this.Label_Font.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label_Font.Location = new System.Drawing.Point(84, 11);
            this.Label_Font.Name = "Label_Font";
            this.Label_Font.Size = new System.Drawing.Size(47, 13);
            this.Label_Font.TabIndex = 0;
            this.Label_Font.Text = "フォント:";
            // 
            // TabPage_Background
            // 
            this.TabPage_Background.Controls.Add(this.NumericUpDown_Width);
            this.TabPage_Background.Controls.Add(this.Label_Width);
            this.TabPage_Background.Controls.Add(this.NumericUpDown_Fade);
            this.TabPage_Background.Controls.Add(this.Label_Fade);
            this.TabPage_Background.Controls.Add(this.Label_DefaultColorSelect);
            this.TabPage_Background.Controls.Add(this.Label_DefaultColor);
            this.TabPage_Background.Controls.Add(this.CheckBox_SelectBackground);
            this.TabPage_Background.Controls.Add(this.NumericUpDown_Separator);
            this.TabPage_Background.Controls.Add(this.Label_Separator);
            this.TabPage_Background.Controls.Add(this.NumericUpDown_Curve);
            this.TabPage_Background.Controls.Add(this.Label_Curve);
            this.TabPage_Background.Controls.Add(this.NumericUpDown_Alpha);
            this.TabPage_Background.Controls.Add(this.Label_Alpha);
            this.TabPage_Background.Controls.Add(this.NumericUpDown_Margin);
            this.TabPage_Background.Controls.Add(this.Label_Margin);
            this.TabPage_Background.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Background.Name = "TabPage_Background";
            this.TabPage_Background.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Background.Size = new System.Drawing.Size(301, 240);
            this.TabPage_Background.TabIndex = 1;
            this.TabPage_Background.Text = "背景その他";
            this.TabPage_Background.UseVisualStyleBackColor = true;
            // 
            // NumericUpDown_Fade
            // 
            this.NumericUpDown_Fade.DecimalPlaces = 3;
            this.NumericUpDown_Fade.Increment = new decimal(new int[] {
            25,
            0,
            0,
            196608});
            this.NumericUpDown_Fade.Location = new System.Drawing.Point(87, 131);
            this.NumericUpDown_Fade.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDown_Fade.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            196608});
            this.NumericUpDown_Fade.Name = "NumericUpDown_Fade";
            this.NumericUpDown_Fade.Size = new System.Drawing.Size(208, 19);
            this.NumericUpDown_Fade.TabIndex = 14;
            this.NumericUpDown_Fade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumericUpDown_Fade.Value = new decimal(new int[] {
            75,
            0,
            0,
            196608});
            this.NumericUpDown_Fade.ValueChanged += new System.EventHandler(this.NumericUpDown_Fade_ValueChanged);
            // 
            // Label_Fade
            // 
            this.Label_Fade.AutoSize = true;
            this.Label_Fade.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label_Fade.Location = new System.Drawing.Point(34, 133);
            this.Label_Fade.Name = "Label_Fade";
            this.Label_Fade.Size = new System.Drawing.Size(47, 13);
            this.Label_Fade.TabIndex = 13;
            this.Label_Fade.Text = "フェード:";
            // 
            // Label_DefaultColorSelect
            // 
            this.Label_DefaultColorSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label_DefaultColorSelect.Location = new System.Drawing.Point(87, 188);
            this.Label_DefaultColorSelect.Name = "Label_DefaultColorSelect";
            this.Label_DefaultColorSelect.Size = new System.Drawing.Size(208, 20);
            this.Label_DefaultColorSelect.TabIndex = 12;
            this.Label_DefaultColorSelect.Click += new System.EventHandler(this.Label_DefaultColorSelect_Click);
            // 
            // Label_DefaultColor
            // 
            this.Label_DefaultColor.AutoSize = true;
            this.Label_DefaultColor.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label_DefaultColor.Location = new System.Drawing.Point(32, 191);
            this.Label_DefaultColor.Name = "Label_DefaultColor";
            this.Label_DefaultColor.Size = new System.Drawing.Size(49, 13);
            this.Label_DefaultColor.TabIndex = 11;
            this.Label_DefaultColor.Text = "背景色:";
            // 
            // CheckBox_SelectBackground
            // 
            this.CheckBox_SelectBackground.AutoSize = true;
            this.CheckBox_SelectBackground.Checked = true;
            this.CheckBox_SelectBackground.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_SelectBackground.Location = new System.Drawing.Point(14, 216);
            this.CheckBox_SelectBackground.Name = "CheckBox_SelectBackground";
            this.CheckBox_SelectBackground.Size = new System.Drawing.Size(208, 16);
            this.CheckBox_SelectBackground.TabIndex = 10;
            this.CheckBox_SelectBackground.Text = "背景設定をコメントビューアから引き継ぐ";
            this.CheckBox_SelectBackground.UseVisualStyleBackColor = true;
            this.CheckBox_SelectBackground.CheckedChanged += new System.EventHandler(this.CheckBox_SelectBackground_CheckedChanged);
            // 
            // NumericUpDown_Separator
            // 
            this.NumericUpDown_Separator.Location = new System.Drawing.Point(87, 41);
            this.NumericUpDown_Separator.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.NumericUpDown_Separator.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NumericUpDown_Separator.Name = "NumericUpDown_Separator";
            this.NumericUpDown_Separator.Size = new System.Drawing.Size(208, 19);
            this.NumericUpDown_Separator.TabIndex = 9;
            this.NumericUpDown_Separator.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumericUpDown_Separator.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.NumericUpDown_Separator.ValueChanged += new System.EventHandler(this.NumericUpDown_Separator_ValueChanged);
            // 
            // Label_Separator
            // 
            this.Label_Separator.AutoSize = true;
            this.Label_Separator.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label_Separator.Location = new System.Drawing.Point(11, 43);
            this.Label_Separator.Name = "Label_Separator";
            this.Label_Separator.Size = new System.Drawing.Size(70, 13);
            this.Label_Separator.TabIndex = 8;
            this.Label_Separator.Text = "区切り位置:";
            // 
            // NumericUpDown_Curve
            // 
            this.NumericUpDown_Curve.Location = new System.Drawing.Point(87, 101);
            this.NumericUpDown_Curve.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.NumericUpDown_Curve.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDown_Curve.Name = "NumericUpDown_Curve";
            this.NumericUpDown_Curve.Size = new System.Drawing.Size(208, 19);
            this.NumericUpDown_Curve.TabIndex = 7;
            this.NumericUpDown_Curve.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumericUpDown_Curve.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericUpDown_Curve.ValueChanged += new System.EventHandler(this.NumericUpDown_Curve_ValueChanged);
            // 
            // Label_Curve
            // 
            this.Label_Curve.AutoSize = true;
            this.Label_Curve.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label_Curve.Location = new System.Drawing.Point(19, 102);
            this.Label_Curve.Name = "Label_Curve";
            this.Label_Curve.Size = new System.Drawing.Size(62, 13);
            this.Label_Curve.TabIndex = 6;
            this.Label_Curve.Text = "丸角具合:";
            // 
            // NumericUpDown_Alpha
            // 
            this.NumericUpDown_Alpha.Location = new System.Drawing.Point(87, 71);
            this.NumericUpDown_Alpha.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumericUpDown_Alpha.Minimum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.NumericUpDown_Alpha.Name = "NumericUpDown_Alpha";
            this.NumericUpDown_Alpha.Size = new System.Drawing.Size(208, 19);
            this.NumericUpDown_Alpha.TabIndex = 5;
            this.NumericUpDown_Alpha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumericUpDown_Alpha.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.NumericUpDown_Alpha.ValueChanged += new System.EventHandler(this.NumericUpDown_Alpha_ValueChanged);
            // 
            // Label_Alpha
            // 
            this.Label_Alpha.AutoSize = true;
            this.Label_Alpha.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label_Alpha.Location = new System.Drawing.Point(13, 73);
            this.Label_Alpha.Name = "Label_Alpha";
            this.Label_Alpha.Size = new System.Drawing.Size(68, 13);
            this.Label_Alpha.TabIndex = 4;
            this.Label_Alpha.Text = "透過レベル:";
            // 
            // NumericUpDown_Margin
            // 
            this.NumericUpDown_Margin.Location = new System.Drawing.Point(87, 11);
            this.NumericUpDown_Margin.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.NumericUpDown_Margin.Name = "NumericUpDown_Margin";
            this.NumericUpDown_Margin.Size = new System.Drawing.Size(208, 19);
            this.NumericUpDown_Margin.TabIndex = 1;
            this.NumericUpDown_Margin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumericUpDown_Margin.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericUpDown_Margin.ValueChanged += new System.EventHandler(this.NumericUpDown_Margin_ValueChanged);
            // 
            // Label_Margin
            // 
            this.Label_Margin.AutoSize = true;
            this.Label_Margin.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label_Margin.Location = new System.Drawing.Point(29, 13);
            this.Label_Margin.Name = "Label_Margin";
            this.Label_Margin.Size = new System.Drawing.Size(52, 13);
            this.Label_Margin.TabIndex = 0;
            this.Label_Margin.Text = "マージン:";
            // 
            // NumericUpDown_Width
            // 
            this.NumericUpDown_Width.Location = new System.Drawing.Point(87, 161);
            this.NumericUpDown_Width.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.NumericUpDown_Width.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NumericUpDown_Width.Name = "NumericUpDown_Width";
            this.NumericUpDown_Width.Size = new System.Drawing.Size(208, 19);
            this.NumericUpDown_Width.TabIndex = 16;
            this.NumericUpDown_Width.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumericUpDown_Width.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NumericUpDown_Width.ValueChanged += new System.EventHandler(this.NumericUpDown_Width_ValueChanged);
            // 
            // Label_Width
            // 
            this.Label_Width.AutoSize = true;
            this.Label_Width.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label_Width.Location = new System.Drawing.Point(12, 162);
            this.Label_Width.Name = "Label_Width";
            this.Label_Width.Size = new System.Drawing.Size(69, 13);
            this.Label_Width.TabIndex = 15;
            this.Label_Width.Text = "ガジェット幅:";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 288);
            this.Controls.Add(this.TabControl_Main);
            this.MaximizeBox = false;
            this.Name = "SettingForm";
            this.Text = "設定";
            this.TabControl_Main.ResumeLayout(false);
            this.TabPage_Comment.ResumeLayout(false);
            this.TabPage_Comment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_LastComment)).EndInit();
            this.TabPage_Background.ResumeLayout(false);
            this.TabPage_Background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Fade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Separator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Curve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Alpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Margin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Width)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl_Main;
        private System.Windows.Forms.TabPage TabPage_Comment;
        private System.Windows.Forms.NumericUpDown NumericUpDown_LastComment;
        private System.Windows.Forms.Label Label_LastComment;
        private System.Windows.Forms.Label Label_ViewFont;
        private System.Windows.Forms.Label Label_Font;
        private System.Windows.Forms.TabPage TabPage_Background;
        private System.Windows.Forms.NumericUpDown NumericUpDown_Fade;
        private System.Windows.Forms.Label Label_Fade;
        private System.Windows.Forms.Label Label_DefaultColorSelect;
        private System.Windows.Forms.Label Label_DefaultColor;
        private System.Windows.Forms.CheckBox CheckBox_SelectBackground;
        private System.Windows.Forms.NumericUpDown NumericUpDown_Separator;
        private System.Windows.Forms.Label Label_Separator;
        private System.Windows.Forms.NumericUpDown NumericUpDown_Curve;
        private System.Windows.Forms.Label Label_Curve;
        private System.Windows.Forms.NumericUpDown NumericUpDown_Alpha;
        private System.Windows.Forms.Label Label_Alpha;
        private System.Windows.Forms.NumericUpDown NumericUpDown_Margin;
        private System.Windows.Forms.Label Label_Margin;
        private System.Windows.Forms.NumericUpDown NumericUpDown_Width;
        private System.Windows.Forms.Label Label_Width;
    }
}