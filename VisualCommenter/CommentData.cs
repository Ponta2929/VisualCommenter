using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualCommenter
{   
    /// <summary>
    /// 管理データ
    /// </summary>
    public class CommentData
    {
        /// <summary>
        /// 表示していいか
        /// </summary>
        public bool Visible { get; set; }
       
        /// <summary>
        /// オーナーコメントか
        /// </summary>
        public bool IsOwner { get; set; }
       
        /// <summary>
        /// ニックネーム
        /// </summary>
        public string Nickname { get; set; }
        
        /// <summary>
        /// コメント
        /// </summary>
        public string Comment { get; set; }
        
        /// <summary>
        /// コメントの色
        /// </summary>
        public Color CommentColor { get; set; }
        
        /// <summary>
        /// 色
        /// </summary>
        public Color BackgroundColor { get; set; }
        
        /// <summary>
        /// テキストの現在位置
        /// </summary>
        public float FadeStringPosition { get; set; }
        
        /// <summary>
        /// テキストの現在色
        /// </summary>
        public float FadeStringColor { get; set; }
       
        /// <summary>
        /// 背景の現在色(R)
        /// </summary>
        public float FadeR { get; set; }
        
        /// <summary>
        /// 背景の現在色(G)
        /// </summary>
        public float FadeG { get; set; }
       
        /// <summary>
        /// 背景の現在色(B)
        /// </summary>
        public float FadeB { get; set; }

        /// <summary>
        /// 追加された時間
        /// </summary>
        public DateTime PostTime { get; set; }
    }
}