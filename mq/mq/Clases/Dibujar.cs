using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace mq.Clases
{
    public class Dibujar
    {
        public void DrawData(PaintEventArgs e, PictureBox pbData)
        {
            Pen thickPen = new Pen(Color.Cyan, 3);

            Rectangle originalRect = new Rectangle(5, 5, 170, 320);

            int sectionHeight = originalRect.Height / 3;

            e.Graphics.DrawRectangle(thickPen, new Rectangle(originalRect.X, originalRect.Y, originalRect.Width, sectionHeight)); // Parte superior
            e.Graphics.DrawRectangle(thickPen, new Rectangle(originalRect.X, originalRect.Y + sectionHeight, originalRect.Width, sectionHeight)); // Parte central
            e.Graphics.DrawRectangle(thickPen, new Rectangle(originalRect.X, originalRect.Y + 2 * sectionHeight, originalRect.Width, sectionHeight)); // Parte inferior
        }

    }
}
