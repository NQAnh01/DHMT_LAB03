using SharpGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19120450_BT3
{
    class Circle : Ellipse
    {
        private void DrawPoint(OpenGL gl, int u, int v)
        {
            for (int i = 0; i < LineWidth; i++)
                for (int j = 0; j < LineWidth; j++)
                    gl.Vertex2sv(new short[] { (short)(u + i), (short)(v + j) });

        }

        public override void Draw(OpenGL gl)
        {
            gl.Color(LineColor.R, LineColor.G, LineColor.B);
            gl.Begin(OpenGL.GL_POINTS);

            int u, v;

            int[][] quarter = { 
                                new int[] { 1, 1 },
                                new int[] { -1, 1 },
                                new int[] { 1, -1 },
                                new int[] { -1, -1 }
                               };

            // Tính các thông số cơ bản
            int cx = (p1.X + p2.X) / 2,
                cy = (p1.Y + p2.Y) / 2, 
                rx = p2.X - cx,
                ry = rx,           
                x = 0, y = ry,             
                rx2 = rx * rx,
                ry2 = ry * ry,              
                x2 = 2 * ry2 * x,           
                y2 = 2 * rx2 * y;           
            double P = (ry2 - rx2 * ry) + rx2 / 4.0;

            //vùng 1
            while (x2 < y2)
            {
                foreach (int[] i in quarter)
                {
                    u = x * i[0] + cx;
                    v = y * i[1] + cy;
                    DrawPoint(gl, u, v);
                }

                x++;
                x2 += (ry2 * 2);
                if (P < 0)
                {
                    P += (x2 + ry2);
                }
                else
                {
                    y--;
                    y2 -= (rx2 * 2);
                    P += (x2 - y2 + ry2);
                }
            }

            // vùng 2
            // tính lại p từ xlast, ylast
            P = (double)ry2 * (x + 0.5) * (x + 0.5) + (double)rx2 * (y - 1) * (y - 1) - (double)rx2 * ry2;
            while (y > 0)
            {
                foreach (int[] i in quarter)
                {
                    u = x * i[0] + cx;
                    v = y * i[1] + cy;
                    DrawPoint(gl, u, v);
                }

                y--;
                y2 -= (rx2 * 2);
                if (P > 0)
                {
                    P += (rx2 - y2);
                }
                else
                {
                    x++;
                    x2 += (ry2 * 2);
                    P += (x2 - y2 + rx2);
                }
            }
            gl.End();
        }
    }
}
