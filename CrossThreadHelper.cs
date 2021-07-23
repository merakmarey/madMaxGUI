using System;
using System.Windows.Forms;

namespace madFurry
{
    public static class CrossThreadHelper
    {
        public static void InvokeAction<T>(T container, Action<T> action) where T: Control
        {
            if (container.InvokeRequired)
            {
                container.Invoke(new MethodInvoker(delegate {
                    action(container);
                 }));
            } else
            {
                action(container);
            }
        }
    }
}
