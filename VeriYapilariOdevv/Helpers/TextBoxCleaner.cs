using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace VeriYapilariOdevv.Helpers
{
    class TextBoxCleaner
    {
        public void ClearTextBoxes(ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                TextBox text = control as TextBox;
                if (text != null)
                {
                    text.Text = "";
                }
            }
        }
    }
}
