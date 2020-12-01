using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualCommenter
{
    public static class Utility
    {
        private static object syncObject = new object();
        private static Bitmap surface = new Bitmap(1, 1);
        private static Graphics graphics = Graphics.FromImage(surface);

        /// <summary>
        /// 描画する文字の大きさを取得します。
        /// </summary>
        /// <param name="text">描画するテキスト</param>
        /// <param name="font">描画に使用するフォント</param>
        /// <returns>System.Drawing.SizeF</returns>
        public static SizeF MeasureString(string text, Font font)
        {
            lock (syncObject)
            {
                return graphics.MeasureString(text, font, int.MaxValue);
            }
        }
    }
}
