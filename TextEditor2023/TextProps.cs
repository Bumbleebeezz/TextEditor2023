using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace TextEditor2023
{
    public class TextProps
    {
        public int FontSize { get; set; } = 10;

        public string FontFamily { get; set; } = new("Consolas");

        public List<int> FontSizes { get; set; } = new List<int>() 
        {
            8,
            10,
            12,
            14,
            16,
            18,
            20,
            22,
            24,
            26,
            28,
            30,
            32,
            34,
            36,
            38,
            40
        };

        public List<FontFamily> FontFamilies { get; set; } = new List<FontFamily>() 
        { 
            new ("Consolas"),
            new ("Yu Gothic Light"),
            new ("Yu Gothic Light"),
            new ("Leelawadee UI"),
            new ("Microsoft Himalaya"),
            new ("Nirmala UI Semilight"),
            new ("SimSun"),
            new ("Sitka Small"),
            new ("Verdana")
        };
    }
}
