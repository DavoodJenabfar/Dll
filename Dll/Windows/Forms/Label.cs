

namespace Dll.Windows.Forms
{
   public class Label : System.Windows.Forms.Label
    {
        public Label()
            : base()
        {

        }
        protected override void OnMouseEnter(System.EventArgs e)
        {
            base.OnMouseEnter(e);
            BackColor = System.Drawing.Color.Yellow;
        }
        protected override void OnMouseLeave(System.EventArgs e)
        {
            base.OnMouseLeave(e);
            BackColor = System.Drawing.SystemColors.Control;
        }
    }
}
