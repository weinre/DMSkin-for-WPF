using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMSkin.Core.Common
{
    public class UINT
    {
        /// <summary>
        /// 将大小转换为KB
        /// </summary>
        public string UINTFormat(double size)
        {
            string[] units = new String[] { "B", "KB", "MB", "GB", "TB", "PB" };
            double mod = 1024.0;
            int i = 0;
            while (size >= mod)
            {
                size /= mod;
                i++;
            }
            return Math.Round(size, 2) + units[i];
        }
    }
}
