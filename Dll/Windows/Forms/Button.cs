﻿namespace Dll.Windows.Forms
{
   public class Button : System.Windows.Forms.Button
    {
        public Button()
            :base()
        {

        }
        protected override void OnMouseEnter(System.EventArgs e)
        {
            base.OnMouseEnter(e);
            BackColor = System.Drawing.Color.OrangeRed;
        }
        protected override void OnMouseLeave(System.EventArgs e)
        {
            base.OnMouseLeave(e);
            BackColor = System.Drawing.SystemColors.Control;
        }
    }
}
