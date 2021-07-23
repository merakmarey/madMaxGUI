using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace madFurry
{
    public static class LaberHelper
    {
        public static void SafeSetText(this Label lb, string value)
        {
            CrossThreadHelper.InvokeAction<Label>(lb, l => { l.Text = value; l.Refresh(); });
        }

    }
}
