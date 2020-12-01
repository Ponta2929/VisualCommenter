using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace VisualCommenter
{
    public class Setting : Serializer<Setting>
    {
        #region Singleton

        /// <summary>
        /// インスタンス
        /// </summary>
        private static Setting instance;

        /// <summary>
        /// インスタンスを取得します。
        /// </summary>
        /// <returns></returns>
        public static Setting GetInstance() => instance ?? (instance = new Setting());

        #endregion

        private static FontConverter fontConverter = new FontConverter();

        /// <summary>
        /// ガジェット X座標
        /// </summary>
        public int Gadget_X { get; set; } = 0;

        /// <summary>
        /// ガジェット Y座標
        /// </summary>
        public int Gadget_Y { get; set; } = 0;

        /// <summary>
        /// ガジェット 横幅
        /// </summary>
        public int Gadget_Width { get; set; } = 720;

        /// <summary>
        /// ガジェット 横幅
        /// </summary>
        [XmlIgnore]
        public int Gadget_Height => (int)Utility.MeasureString("012ABCabcあいう", Comment_Font).Height;

        /// <summary>
        /// ガジェット 高さ
        /// </summary>
        public int Background_Margin { get; set; } = 10;

        /// <summary>
        /// 背景透明度
        /// </summary>
        public int Background_Alpha { get; set; } = 64;

        /// <summary>
        /// 丸み
        /// </summary>
        public int Background_Curve { get; set; } = 10;

        /// <summary>
        /// 区切り位置
        /// </summary>
        public int Background_Separator { get; set; } = 200;

        /// <summary>
        /// 
        /// </summary>
        public bool Background_Selected { get; set; } = true;

        /// <summary>
        /// 背景色
        /// </summary>
        public ColorEx Background_Color { get; set; } = Color.White;

        /// <summary>
        /// 描画フォント
        /// </summary>
        [XmlIgnore]
        public Font Comment_Font { get; set; } = new Font("MS UI Gothic", 20);

        /// <summary>
        /// 描画フォントの文字情報
        /// </summary>
        public string Comment_Font_String { get => fontConverter.ConvertToString(Comment_Font); set => Comment_Font = (Font)fontConverter.ConvertFromString(value); }

        /// <summary>
        /// 最終コメント表示時間
        /// </summary>
        public int Comment_LastTime { get; set; } = 10;

        /// <summary>
        /// フェード値
        /// </summary>
        public float All_Fade { get; set; } = 0.075f;
    }
}
