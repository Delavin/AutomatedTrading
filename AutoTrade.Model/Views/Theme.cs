using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTrade.Model.Views
{
    /// <summary>
    /// 皮肤类型
    /// </summary>
    public enum ThemeType
    {
        Red,
        Blue,
        Black,
    }
   public  class Theme
    {
        /// <summary>
        /// 皮肤路径
        /// </summary>
        public Uri ThemeSource { get; set; }
        /// <summary>
        /// 皮肤类型
        /// </summary>
        public ThemeType ThemeType { get; set; }

    }
}
