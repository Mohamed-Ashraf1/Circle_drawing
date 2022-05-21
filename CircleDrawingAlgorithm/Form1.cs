using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleDrawingAlgorithm
{
    public partial class Form1 : Form
    {
        int xCenter, yCenter, radius = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void drawBtn_Click(object sender, EventArgs e)
        {
            xCenter = Int32.Parse(centerXText.Text.Trim());
            yCenter = Int32.Parse(centerYText.Text.Trim());
            radius = Int32.Parse(radiusText.Text.Trim());

            circleMidPoint(xCenter, yCenter, radius);
        }

        private void circleMidPoint(int xCenter, int yCenter, int radius)
        {
            int x = 0;
            int y = radius;
            int p = 1 - radius;

            circlePlotPoints(xCenter, yCenter, x, y);

            while(x < y)
            {
                x++;
                if (p < 0)
                {
                    p += 2 * (x + 1);
                } else
                {
                    y--;
                    p += 2 * (x - y) + 1;
                }
                circlePlotPoints(xCenter, yCenter, x, y);
            }
        }

        private void circlePlotPoints(int xCenter, int yCenter, int x, int y)
        {
            var brush = Brushes.Black;
            var g = drawingPanel.CreateGraphics();

            g.FillRectangle(brush, xCenter + x, yCenter + y, 1, 1);
            g.FillRectangle(brush, xCenter - x, yCenter + y, 1, 1);
            g.FillRectangle(brush, xCenter + x, yCenter - y, 1, 1);
            g.FillRectangle(brush, xCenter - x, yCenter - y, 1, 1);
            g.FillRectangle(brush, xCenter + y, yCenter + x, 1, 1);
            g.FillRectangle(brush, xCenter - y, yCenter + x, 1, 1);
            g.FillRectangle(brush, xCenter + y, yCenter - x, 1, 1);
            g.FillRectangle(brush, xCenter - y, yCenter - x, 1, 1);
        }
    }
}
