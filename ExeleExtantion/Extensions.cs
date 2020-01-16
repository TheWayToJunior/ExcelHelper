using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExcelExtantion
{
    public enum ButtonColor { Default, OnClick }

    public static class ButtonExtensions
    {
        public static void ToChange(this Button button, ButtonColor changes)
        {
            switch (changes)
            {
                case ButtonColor.Default:
                    button.BackColor = Color.FromArgb(47, 148, 94);
                    button.ForeColor = Color.White;

                    break;

                case ButtonColor.OnClick:
                    button.BackColor = Color.White;
                    button.ForeColor = Color.FromArgb(47, 148, 94);

                    break;
            }
        }
    }
}
