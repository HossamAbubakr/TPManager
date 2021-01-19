using System.Drawing;
using System.Windows.Forms;

namespace TPManager
{
    internal static class Theme
    {
        private static Color _formBackColor = ColorTranslator.FromHtml("#FFFFFF");
        private static Color _controlBackColor = ColorTranslator.FromHtml("#FAFAFA");
        private static Color _controlForeColor = ColorTranslator.FromHtml("#DADADA");
        public static string CurrTheme;
        private static Form _form;
        private static FlatStyle _flatStyle;
        private static bool _forceStyle = false;
        public static void DarkTheme()
        {
            CurrTheme = "Dark";
            _formBackColor = ColorTranslator.FromHtml("#1E1E1E");
            _controlBackColor = ColorTranslator.FromHtml("#2D2D2D");
            _controlForeColor = ColorTranslator.FromHtml("#DADADA");
        }
        public static void LightTheme()
        {
            CurrTheme = "Light";
            _formBackColor = ColorTranslator.FromHtml("#FFFFFF");
            _controlBackColor = ColorTranslator.FromHtml("#FAFAFA");
            _controlForeColor = ColorTranslator.FromHtml("#000000");
        }
        public static void CustomTheme(Color? formBack = null, Color? controlBack = null, Color? controlFore = null)
        {
            _formBackColor = formBack ?? _formBackColor;
            _controlBackColor = controlBack ?? _controlBackColor;
            _controlForeColor = controlFore ?? _controlForeColor;
        }
        public static void UpdateTheme(Form form, FlatStyle? flatStyle = null)
        {
            _form = form;
            if (flatStyle != null)
            {
                _flatStyle = flatStyle ?? _flatStyle;
                _forceStyle = true;
            }
            InvokeColor(_form, "BackColor", _formBackColor);
            foreach (Control control in form.Controls)
            {
                ThemeControl(control);
            }
        }
        private static void ThemeControl(Control control)
        {
            var controlType = control.GetType();
            if (controlType != typeof(GroupBox))
            {
                if (controlType == typeof(Button) || controlType == typeof(CheckedListBox) || controlType == typeof(TabPage) || controlType == typeof(RichTextBox) || controlType == typeof(TextBox) || controlType == typeof(ComboBox) || controlType == typeof(ListView) || controlType == typeof(ListBox))
                {
                    InvokeColor(control, "ForeColor", _controlForeColor);
                    InvokeColor(control, "BackColor", _controlBackColor);
                }
                else if (controlType == typeof(TrackBar))
                {
                    InvokeColor(control, "BackColor", _formBackColor);
                }
                else
                {
                    InvokeColor(control, "ForeColor", _controlForeColor);
                }
            }
            else
            {
                InvokeColor(control, "ForeColor", _controlForeColor);
                foreach (Control c in control.Controls)
                {
                    ThemeControl(c);
                }
            }
            if (_forceStyle)
            {
                InvokeProperty(control, "FlatStyle", _flatStyle);
            }
        }
        private static void InvokeColor(Control control, string property, Color color)
        {
            MethodInvoker controlproperty = () => control.GetType().GetProperty(property)?.SetValue(control, color);
            _form.BeginInvoke(controlproperty);
        }
        private static void InvokeProperty(Control control, string property, dynamic value)
        {
            if (control.GetType().GetProperty(property) == null) return;
            MethodInvoker controlproperty = () => control.GetType().GetProperty(property)?.SetValue(control, value);
            _form.BeginInvoke(controlproperty);
        }
    }
}
