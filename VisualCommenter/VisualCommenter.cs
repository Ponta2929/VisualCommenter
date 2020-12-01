using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NicoLibrary.NicoLiveData;
using Plugin;

namespace VisualCommenter
{
    public class VisualCommenter : IPlugin, IPluginEx
    {
        // 設定
        private Setting setting = Setting.GetInstance();

        // ガジェットウィンドウ
        private Gadget gadget = null;

        public IPluginHost Host { get; set; }

        public bool IsAutoRun => false;

        public string Description => "コメントを表示するプラグインです。";

        public string Version => "ver 1.0.0";

        public string Name => "コメントビジュアライザー";

        public bool HasSettingForm => true;

        public void AutoRun()
        {

        }

        public void Run()
        {
            try
            {
                // 設定読み込み
                setting.FileDeserialize($"{Application.StartupPath}\\plugins\\VisualCommenter.xml");
            }
            catch
            {

            }

            if (gadget == null)
            {
                // ガジェット初期化
                gadget = new Gadget();
                gadget.TopMost = true;
                gadget.Left = setting.Gadget_X;
                gadget.Top = setting.Gadget_Y;
                gadget.Data.Add(new CommentData() { BackgroundColor = setting.Background_Color, FadeStringPosition = setting.Gadget_Height, FadeR = 0, FadeB = 0, FadeG = 0, PostTime = DateTime.Now });

                // ガジェット表示
                gadget.Show();

                // イベント  
                Host.MainForm.FormClosing += Gadget_FormClosing;
                Host.ReceivedComment += Host_ReceivedComment;
            }
        }

        private void Gadget_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                setting.Gadget_X = gadget.Left;
                setting.Gadget_Y = gadget.Top;

                // 設定保存
                setting.FileSerialize($"{Application.StartupPath}\\plugins\\VisualCommenter.xml");
            }
            catch
            {

            }
        }

        private void Host_ReceivedComment(object sender, ReceivedCommentEventArgs e)
        {
            if (gadget != null && e.CommentDataList.Count > 0)
            {
                // コメントデータ一覧
                var data = e.CommentDataList.Last();

                // ユーザー設定取得
                var userSetting = Host.GetUserSettingInPlugin();

                var userData
                    = userSetting.UserDataList.FindAll(s => { return s.UserId == data.UserId; }).ToArray();

                // 挿入データ
                var info = new CommentData();
                {
                    info.Visible = true;
                    info.IsOwner = data.Premium == 3 ? true : false;
                    info.Nickname = userData.Length > 0 ? userData[0].NickName : "";
                    info.Comment = data.Comment;
                    info.CommentColor = CheckMailToColor(data.Mail);
                    info.BackgroundColor = userData.Length > 0 ? userData[0].BGColor : (Color)setting.Background_Color;
                    info.FadeStringPosition = setting.Gadget_Height;
                    info.FadeR = gadget.Data.Last().FadeR;
                    info.FadeG = gadget.Data.Last().FadeG;
                    info.FadeB = gadget.Data.Last().FadeB;
                    info.PostTime = DateTime.Now;
                }

                // データ追加
                gadget.Data.Add(info);
            }
        }

        public void ShowSettingForm()
        {
            new SettingForm().Show();
        }

        /// <summary>
        /// メール欄から色の判定を行います。
        /// </summary>
        private Color CheckMailToColor(string mail)
        {
            string[] s = mail.Split(' ');

            if (s != null)
            {
                switch (s[0])
                {
                    // 一般会員
                    case "red":
                        return Color.Red;
                    case "pink":
                        return Color.FromArgb(0xff, 0x80, 0x80);
                    case "orange":
                        return Color.FromArgb(0xff, 0xc0, 0x00);
                    case "yellow":
                        return Color.Yellow;
                    case "green":
                        return Color.Green;
                    case "cyan":
                        return Color.Cyan;
                    case "blue":
                        return Color.Blue;
                    case "purple":
                        return Color.FromArgb(0xc0, 0x00, 0xff);
                    case "black":
                        return Color.FromArgb(0xff, 0xff, 0xff);

                    // プレミアム会員
                    case "white2":
                    case "niconicowhite":
                        return Color.FromArgb(0xcc, 0xcc, 0x99);
                    case "red2":
                    case "truered":
                        return Color.FromArgb(0xcc, 0x00, 0x33);
                    case "pink2":
                        return Color.FromArgb(0xff, 0x33, 0xcc);
                    case "orange2":
                    case "passionorange":
                        return Color.FromArgb(0xff, 0x66, 0x00);
                    case "yellow2":
                    case "madyellow":
                        return Color.FromArgb(0x99, 0x99, 0x00);
                    case "green2":
                    case "elementalgreen":
                        return Color.FromArgb(0x00, 0xcc, 0x66);
                    case "cyan2":
                        return Color.FromArgb(0x00, 0xcc, 0xcc);
                    case "blue2":
                    case "marineblue":
                        return Color.FromArgb(0x33, 0x99, 0xff);
                    case "purple2":
                    case "nobleviolet":
                        return Color.FromArgb(0x66, 0x33, 0xcc);
                    case "black2":
                        return Color.FromArgb(0x66, 0x66, 0x66);
                    default:
                        return Color.Black;
                }
            }

            // デフォルト
            return Color.Black;
        }

        ~VisualCommenter()
        {
            // ガジェット破棄
            if (gadget != null)
            {
                gadget.Close();
            }
        }
    }
}
