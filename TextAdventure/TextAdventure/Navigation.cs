using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextAdventure
{
    static class Navigation
    {
        public static void navigate(Label lbl, int i)
        {
            
            switch (i)
            {
                case 1:
                    updateDisplay("You pressed button 1.", lbl);
                    break;
                case 2:
                    updateDisplay("You pressed button 2.", lbl);
                    break;
                case 3:
                    updateDisplay("You pressed button 3.", lbl);
                    break;
                case 4:
                    updateDisplay("You pressed button 4", lbl);
                    break;
                default:
                    updateDisplay("Bad things happened.", lbl);
                    break;
            }
        }
        private static void updateDisplay(String s, Label lbl)
        {
            lbl.Text = s;
        }
    }
}
