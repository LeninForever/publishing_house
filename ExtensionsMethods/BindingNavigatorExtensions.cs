using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach_1.ExtensionsMethods
{
    public static class BindingNavigatorExtensions
    {
        public static void MakeDisabledDMLButtons(this System.Windows.Forms.BindingNavigator bindingNavigator, bool enabled)
        {
            if (bindingNavigator.Items.Count < 5)
                return;

                int lastIndex = bindingNavigator.Items.Count - 2;
            int firstDMLIndex = bindingNavigator.Items.Count - 5;
            for (int i = lastIndex; i >= firstDMLIndex; i--)
            {
                bindingNavigator.Items[i].Enabled = enabled;
            }
        }
    }
}
