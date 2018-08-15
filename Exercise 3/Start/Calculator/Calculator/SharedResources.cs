// SharedResources.cs

using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Calculator
{
    public static class SharedResources
    {
        public static Color CanvasBkColor
            => Color.Black;

        public static Color DisplayLabelBkColor
            => Color.Black;

        public static Color DisplayLabelForeColor
            => Color.White;

        public static Color NumberButtonBkColor
            => Color.White;

        public static Color NumberButtonForeColor
            => Color.Black;

        public static Color OpButtonBkColor
            => Color.FromRgb(0xff, 0xa5, 0x00);

        public static Color OpButtonForeColor
            => Color.White;

        public static Color ClearButtonBkColor
            => Color.FromRgb(0x80, 0x80, 0x80);

        public static Color ClearButtonForeColor
            => Color.White;
    }
}
