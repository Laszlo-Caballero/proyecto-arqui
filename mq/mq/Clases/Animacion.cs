using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
using ThreadingTimer = System.Threading.Timer;

namespace mq.Clases
{
    public class Animacion
    {
        private Timer animacionTimer;
        private int offset = 0;      
        private readonly int espacio = 100;  

        public event EventHandler OnInvalidate;
        public Animacion()
        {
            animacionTimer = new Timer();
            animacionTimer.Interval = 30; 
            animacionTimer.Tick += AnimarCardiaco;
        }

        public void Start()
        {
            animacionTimer.Start();
        }

        public void Stop()
        {
            animacionTimer.Stop();
        }

        public void SetOffset(int offset)
        {
            offset = offset;
        }

        private void AnimarCardiaco(object sender, EventArgs e)
        {
            offset -= 5;  

            if (offset < -espacio)
                offset = 0;

            OnInvalidate?.Invoke(this, EventArgs.Empty);
        }

        public void DrawECG(PaintEventArgs e, PictureBox pbECG)
        {
            Pen pen = new Pen(Color.LimeGreen, 2);

            Point[] points = new Point[]
            {
                new Point(2, 70),
                new Point(20, 70),
                new Point(26, 60),
                new Point(32, 80),
                new Point(45, 30),
                new Point(52, 85),
                new Point(60, 52),
                new Point(65, 70),
                new Point(68, 63),
                new Point(72, 70),
                new Point(110, 70),
            };

            int width = pbECG.Width;
            int numberOfRepetitions = width / espacio + 2;

            for (int i = 0; i < numberOfRepetitions; i++)
            {
                Point[] shiftedPoints = points.Select(p => new Point(p.X + i * espacio - offset, p.Y)).ToArray();

                e.Graphics.DrawLines(pen, shiftedPoints);
            }
        }
        public void DrawPressure(PaintEventArgs e, PictureBox pbECG)
        {
            Pen pen = new Pen(Color.LimeGreen, 2);

            Point[] points = new Point[]
            {
                new Point(2, 170),
                new Point(20, 170),
                new Point(26, 180),
                new Point(32, 160),
                new Point(45, 200),
                new Point(52, 165),
                new Point(60, 190),
                new Point(65, 170),
                new Point(110, 170),
            };

            int width = pbECG.Width;
            int numberOfRepetitions = width / espacio + 2;

            for (int i = 0; i < numberOfRepetitions; i++)
            {
                Point[] shiftedPoints = points.Select(p => new Point(p.X + i * espacio - offset, p.Y)).ToArray();

                e.Graphics.DrawLines(pen, shiftedPoints);
            }

        }

        public void DrawOxigeno(PaintEventArgs e, PictureBox pbECG)
        {
            Pen pen = new Pen(Color.Cyan, 2);
            int amplitude = 20;
            int frequency = 15;

            List<Point> points = new List<Point>();
            for (int x = 0; x < pbECG.Width; x++)
            {
                int y = (int)(Math.Sin((x + offset) / (double)frequency) * amplitude + pbECG.Height / 1.2);
                points.Add(new Point(x, y));
            }

            e.Graphics.DrawLines(pen, points.ToArray());
        }

        public void Animar(PaintEventArgs e, PictureBox pbECG)
        {
            DrawECG(e, pbECG);
            DrawPressure(e, pbECG);
            DrawOxigeno(e, pbECG);
        }


    }
}
