namespace Dll.Windows.Forms
{
   public class TextBoxAge : System.Windows.Forms.TextBox
    {
        public TextBoxAge()
            : base()
        {

        }
     protected override void OnKeyPress(System.Windows.Forms.KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if ((((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == 8)) == false)
            {
                e.Handled = true; // بی خیال شو = شتر دیدی ندیدی
            }
            MaxLength = 2;
        }
       protected override void OnValidating(System.ComponentModel.CancelEventArgs e)
        {
           if (string.IsNullOrWhiteSpace(Text))
            {
                e.Cancel = true; // بی خیال شو
            }
        }
    }
}
