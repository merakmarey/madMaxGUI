using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text;

namespace madFurry
{
    public static class ImageHelper
    {
        public static Image WebBrowserImage(this WebBrowser webBrowser, Rectangle cellBounds, string formattedValue)
        {
            Bitmap tmp = new Bitmap(cellBounds.Width, cellBounds.Height);
            
            try
            {
                CrossThreadHelper.InvokeAction<WebBrowser>(webBrowser, wb =>
                {
                    using (var webBrowser = new WebBrowser())
                    {
                        wb.Navigate("about:blank");
                        wb.ScrollBarsEnabled = false;
                        wb.Size = new Size(cellBounds.Width, cellBounds.Height);
                        wb.Document.Write(String.Empty);
                        wb.Document.Write(String.Format("<html><head><style>*{{margin:0;}}<style></head><body>{0}</body></html>", formattedValue));
                        while ((wb.ReadyState != WebBrowserReadyState.Complete) && (wb.ReadyState != WebBrowserReadyState.Interactive))
                        {
                            System.Windows.Forms.Application.DoEvents();
                        };
                        using (var bitmap = new Bitmap(wb.Width, wb.Height))
                        {
                            wb.DrawToBitmap(bitmap, new Rectangle(1, 1, cellBounds.Width, cellBounds.Height));
                            tmp = bitmap;
                        }
                    }

                });
            }
            catch (Exception ex) 
            { 
            }
          
            return tmp;
        }
    }
}
