using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGFontTool.Logic
{
    public static class GlyphExtensions
    {
        /// <summary>
        /// Turns acquired GlyphName to capitalized SpecialCharacter-Free string
        /// </summary>
        /// <param name="glyphname"></param>
        /// <returns></returns>
        public static string PrepareGlyphName(this string glyphname)
        {
            StringBuilder result = new StringBuilder(glyphname.Length);
            for (int i = 0;i < glyphname.Length ;i++)
            {
                if (i > 0)
                {
                    if (glyphname[i - 1] == '-')
                    {
                        result.Append(Char.ToUpper(glyphname[i]));
                    }
                    else
                    {
                        result.Append(glyphname[i]);

                    }
                }
                else
                {
                    result.Append(Char.ToUpper(glyphname[i]));
                }
            }
            glyphname = result.ToString();
            glyphname = String.Join("",glyphname.Split('-'));
            return glyphname;
        }
    }
}
