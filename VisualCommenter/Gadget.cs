using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualCommenter.Hook;

namespace VisualCommenter
{
    public class Gadget : LayeredWindow
    {
        private Setting setting = Setting.GetInstance();
        private MouseHook mouseHook = MouseHook.GetInstance();

        /// <summary>
        /// 描画データ
        /// </summary>
        public List<CommentData> Data;

        // マウスキャプチャ
        private GridForm grid;


        // 描画タイマー
        private System.Timers.Timer timer;

        // --------------描画用変数------------
        // 描画サーフェイス
        private Bitmap surface;
        private Rectangle window;
        private PointF pos1;
        private PointF pos2;
        private Region reg;
        private Graphics g;
        private Font font;
        private Color background, backgroundLine;
        private SolidBrush sb1;
        private SolidBrush sb2;
        private SolidBrush sb_bg;
        private Pen p_bgl;
        private GraphicsPath gp;

        public Gadget()
        {
            Data = new List<CommentData>();
            grid = new GridForm();
            grid.Width = 11;
            grid.Height = 11;

            // その他初期化            
            surface = new Bitmap(100, 20);
            window = new Rectangle(0, 0, 0, 0);
            pos1 = new PointF(0, 0);
            pos2 = new PointF(0, 0);
            reg = new Region();
            sb1 = new SolidBrush(Color.White);
            sb2 = new SolidBrush(Color.White);
            sb_bg = new SolidBrush(Color.White);
            p_bgl = new Pen(Color.White);
            gp = new GraphicsPath();

            // 描画タイム
            timer = new System.Timers.Timer();
            timer.SynchronizingObject = this;
            timer.AutoReset = true;
            timer.Interval = (int)(1000f / 60f);
            timer.Elapsed += Timer_Elapsed;
            timer.Start();

            // Hook
            mouseHook.MouseHooked += MouseHooked;
        }

        private void MouseHooked(object sender, MouseHookedEventArgs e)
        {
            if (e.Point.X > this.Left - 5 && this.Left + 5 > e.Point.X && e.Point.Y > this.Top - 5 && this.Top + 5 > e.Point.Y)
            {
                if (!grid.Visible)
                {
                    grid.Left = this.Left - 5;
                    grid.Top = this.Top - 5;
                    grid.Show(this);
                }
            }

            if (e.Point.X > this.Left - 3 && this.Left + 3 > e.Point.X && e.Point.Y > this.Top && this.Top + this.Height > e.Point.Y)
            {
                this.Cursor = Cursors.Hand;
            }
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            // 変更されたらサーフェイスに適応
            if (this.Width != setting.Gadget_Width || font != setting.Comment_Font)
            {
                // 前のビットマップを破棄
                if (surface != null)
                {
                    surface.Dispose();
                }
                if (g != null)
                {
                    g.Dispose();
                }

                // 再設定
                surface = new Bitmap(setting.Gadget_Width, (int)(setting.Gadget_Height + setting.Background_Margin), PixelFormat.Format32bppArgb);
                g = Graphics.FromImage(surface);
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.TextRenderingHint = TextRenderingHint.AntiAlias;

                // フォント変更
                font = setting.Comment_Font;
            }
            if (Data.Count > 5)
            {
                Data.RemoveAt(0);
            }
            if (Data.Last().PostTime.AddSeconds(setting.Comment_LastTime) < DateTime.Now)
            {
                // 空データ挿入
                Data.Add(new CommentData()
                {
                    Visible = false,
                    FadeStringPosition = setting.Gadget_Height,
                    BackgroundColor = setting.Background_Color,
                    FadeR = Data.Last().FadeR,
                    FadeG = Data.Last().FadeG,
                    FadeB = Data.Last().FadeB,
                    PostTime = DateTime.Now,
                });
            }

            if (g != null)
            {
                // 画面消去
                g.Clear(Color.Transparent);

                // 背景サイズ
                window.Width = this.Width - 1;
                window.Height = this.Height - 1;

                int count = Data.Count;

                for (int i = 0; i < count; i++)
                {
                    if (i == count - 1)
                    {
                        // フェード計算（最終コメント）
                        Data[i].FadeStringPosition += ((this.Height / 2 - setting.Gadget_Height / 2) - Data[i].FadeStringPosition) * setting.All_Fade;
                        Data[i].FadeStringColor += (255f - Data[i].FadeStringColor) * setting.All_Fade;
                        Data[i].FadeR += (Data[i].BackgroundColor.R - Data[i].FadeR) * setting.All_Fade;
                        Data[i].FadeG += (Data[i].BackgroundColor.G - Data[i].FadeG) * setting.All_Fade;
                        Data[i].FadeB += (Data[i].BackgroundColor.B - Data[i].FadeB) * setting.All_Fade;

                        // 背景描画
                        if (setting.Background_Selected)
                        {
                            background = Color.FromArgb(setting.Background_Alpha, (int)Data[i].FadeR, (int)Data[i].FadeG, (int)Data[i].FadeB);
                            backgroundLine = Color.FromArgb((int)Data[i].FadeR, (int)Data[i].FadeG, (int)Data[i].FadeB);
                        }
                        else
                        {
                            background = Color.FromArgb(setting.Background_Alpha, setting.Background_Color.R, setting.Background_Color.G, setting.Background_Color.B);
                            backgroundLine = setting.Background_Color;
                        }

                        // ブラシ設定
                        sb_bg.Color = background;
                        p_bgl.Color = backgroundLine;
                        // 枠描画
                        g.FillCurveRectangle(sb_bg, window, setting.Background_Curve);
                        g.DrawCurveRectangle(p_bgl, window, setting.Background_Curve);

                        // ライン描画
                        pos1.X = setting.Background_Separator;
                        pos1.Y = 6;
                        pos2.X = setting.Background_Separator;
                        pos2.Y = this.Height - 7;
                        g.DrawLine(p_bgl, pos1, pos2);

                    }
                    else
                    {
                        // フェード計算（その他コメント）
                        Data[i].FadeStringPosition += (-setting.Gadget_Height - Data[i].FadeStringPosition) * setting.All_Fade;
                        Data[i].FadeStringColor += (0f - Data[i].FadeStringColor) * setting.All_Fade;
                    }

                    if (Data[i].Visible)
                    {
                        // 描画位置の規制
                        reg.MakeEmpty();
                        reg.Complement(DrawPath(window, setting.Background_Curve));
                        g.Clip = reg;

                        // ブラシ設定
                        sb1.Color = Color.FromArgb((int)Data[i].FadeStringColor, Data[i].CommentColor.R, Data[i].CommentColor.G, Data[i].CommentColor.B);
                        sb2.Color = Color.FromArgb((int)Data[i].FadeStringColor, 255, 0, 0);

                        // ニックネーム描画
                        pos1.X = setting.Background_Separator - g.MeasureString(Data[i].Nickname, setting.Comment_Font).Width - setting.Background_Margin;
                        pos1.Y = Data[i].FadeStringPosition;
                        g.DrawString(Data[i].Nickname, setting.Comment_Font, sb1, pos1);

                        // コメント描画
                        pos1.X = setting.Background_Separator + setting.Background_Margin;
                        pos1.Y = Data[i].FadeStringPosition;
                        if (Data[i].IsOwner)
                            g.DrawString(Data[i].Comment, setting.Comment_Font, sb2, pos1);
                        else
                            g.DrawString(Data[i].Comment, setting.Comment_Font, sb1, pos1);

                        // クリップ初期化
                        g.ResetClip();
                    }
                }
            }
            // 画像のセット
            if (!this.IsDisposed)
            {
                SetLayeredWindow(surface);
            }
        }

        /// <summary>
        /// 描画範囲指定用関数
        /// </summary>
        private GraphicsPath DrawPath(Rectangle rect, int curve)
        {
            gp.Reset();
            // パスの追加
            gp.StartFigure();
            gp.AddArc(rect.Right - curve, rect.Top, curve, curve, 270, 90); // 右上
            gp.AddArc(rect.Right - curve, rect.Bottom - curve, curve, curve, 0, 90); // 右上
            gp.AddArc(rect.Left, rect.Bottom - curve, curve, curve, 90, 90); // 右上
            gp.AddArc(rect.Left, rect.Top, curve, curve, 180, 90); // 右上
            gp.CloseFigure();

            // 戻り値
            return gp;
        }

        /// <summary>
        /// 描画範囲指定用関数
        /// </summary>
        private GraphicsPath DrawPath(RectangleF rect, int curve)
        {
            gp.Reset();
            // パスの追加
            gp.StartFigure();
            gp.AddArc(rect.Right - curve, rect.Top, curve, curve, 270, 90); // 右上
            gp.AddArc(rect.Right - curve, rect.Bottom - curve, curve, curve, 0, 90); // 右上
            gp.AddArc(rect.Left, rect.Bottom - curve, curve, curve, 90, 90); // 右上
            gp.AddArc(rect.Left, rect.Top, curve, curve, 180, 90); // 右上
            gp.CloseFigure();

            // 戻り値
            return gp;
        }

        protected override void Dispose(bool disposing)
        {

            // 消去
            if (timer != null)
                timer.Dispose();
            if (g != null)
                g.Dispose();
            if (surface != null)
                surface.Dispose();
            if (sb1 != null)
                sb1.Dispose();
            if (sb2 != null)
                sb2.Dispose();
            if (sb_bg != null)
                sb_bg.Dispose();
            if (p_bgl != null)
                p_bgl.Dispose();
            if (gp != null)
                gp.Dispose();
            if (reg != null)
                reg.Dispose();

            base.Dispose(disposing);
        }
    }
}
