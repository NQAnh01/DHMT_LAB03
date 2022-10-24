using SharpGL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19120450_BT3
{
    public partial class Form1 : Form
    {
        
        OpenGL gl;
        List<Object> shapes = new List<Object>(); //Các hình đã vẽ
        int n_shapes = 0; //Số lượng hình đã vẽ       
        Object currentShape; //Hình đang được vẽ
        private int Selected = -1;  // có được chọn hay k
        int objectId = -1;  //Hình đang được chọn
        int chosenControlPointId = -1;  // điểm điều khiển được chọn

        enum Mode { Line, Circle, Rectangle, Ellipse, Triangle, Pentagon, Hexagon, Polygon, Select, Clear }; 
        Mode currentMode = Mode.Line;   //Chế độ hiện tại
        Color currentLineColor = new Color();   //Màu viền hiện tại
        Color currentFillColor = new Color(1, 1, 1);   //Màu nền hiện tại

        bool isDrawing = false; //Đang nhấn chuột để vẽ hình mới   

        Point pStart = new Point(); //Điểm chăn khởi đầu lúc nhấn chuột
        Point pEnd = new Point(); //Điểm chạn đích khi di chuyển chuột và khi thả chuột       

        int timeDrawing = 0;    //Thời gian vẽ hình
        //***********************************
        OpenGLControl openGLControl;

        private void renderShapes()
        {
            //Reset lại khung vẽ
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            foreach (Object s in shapes)
            {
                s.Draw(gl);
                s.Fill(gl, false);
                s.Draw(gl);
            }
            gl.Flush();
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            List<Object> shape = new List<Object>();
            shapes = shape;
            foreach (Object s in shapes)
            {
                s.Draw(gl);
                s.Fill(gl, false);
                s.Draw(gl);
            }
            n_shapes = 0;
            Selected = -1;
            objectId = -1;
            chosenControlPointId = -1;
            isDrawing = false;
            timeDrawing = 0;
            gl.Flush();
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            btnLine.Enabled = false;
            btnCircle.Enabled = true;
            btnRectangle.Enabled = true;
            btnEllipse.Enabled = true;
            btnTriangle.Enabled = true;
            btnPentagon.Enabled = true;
            BtnHexagon.Enabled = true;
            btnPolygon.Enabled = true;
            btnSelect.Enabled = true;
            currentMode = Mode.Line;
            btnFill.Enabled = false;
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            btnLine.Enabled = true;
            btnCircle.Enabled = false;
            btnRectangle.Enabled = true;
            btnEllipse.Enabled = true;
            btnTriangle.Enabled = true;
            btnPentagon.Enabled = true;
            BtnHexagon.Enabled = true;
            btnPolygon.Enabled = true;
            btnSelect.Enabled = true;
            currentMode = Mode.Circle;
            btnFill.Enabled = false;
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            btnLine.Enabled = true;
            btnCircle.Enabled = true;
            btnRectangle.Enabled = false;
            btnEllipse.Enabled = true;
            btnTriangle.Enabled = true;
            btnPentagon.Enabled = true;
            BtnHexagon.Enabled = true;
            btnPolygon.Enabled = true;
            btnSelect.Enabled = true;
            currentMode = Mode.Rectangle;
            btnFill.Enabled = false;
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            btnLine.Enabled = true;
            btnCircle.Enabled = true;
            btnRectangle.Enabled = true;
            btnEllipse.Enabled = false;
            btnTriangle.Enabled = true;
            btnPentagon.Enabled = true;
            BtnHexagon.Enabled = true;
            btnPolygon.Enabled = true;
            btnSelect.Enabled = true;
            currentMode = Mode.Ellipse;
            btnFill.Enabled = false;
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            btnLine.Enabled = true;
            btnCircle.Enabled = true;
            btnRectangle.Enabled = true;
            btnEllipse.Enabled = true;
            btnTriangle.Enabled = false;
            btnPentagon.Enabled = true;
            BtnHexagon.Enabled = true;
            btnPolygon.Enabled = true;
            btnSelect.Enabled = true;
            currentMode = Mode.Triangle;
            btnFill.Enabled = false;
        }

        private void btnPentagon_Click(object sender, EventArgs e)
        {
            btnLine.Enabled = true;
            btnCircle.Enabled = true;
            btnRectangle.Enabled = true;
            btnEllipse.Enabled = true;
            btnTriangle.Enabled = true;
            btnPentagon.Enabled = false;
            BtnHexagon.Enabled = true;
            btnPolygon.Enabled = true;
            btnSelect.Enabled = true;
            currentMode = Mode.Pentagon;
            btnFill.Enabled = false;
        }

        private void BtnHexagon_Click(object sender, EventArgs e)
        {
            btnLine.Enabled = true;
            btnCircle.Enabled = true;
            btnRectangle.Enabled = true;
            btnEllipse.Enabled = true;
            btnTriangle.Enabled = true;
            btnPentagon.Enabled = true;
            BtnHexagon.Enabled = false;
            btnPolygon.Enabled = true;
            btnSelect.Enabled = true;
            currentMode = Mode.Hexagon;
            btnFill.Enabled = false;
        }

        private void btnPolygon_Click(object sender, EventArgs e)
        {
            btnLine.Enabled = true;
            btnCircle.Enabled = true;
            btnRectangle.Enabled = true;
            btnEllipse.Enabled = true;
            btnTriangle.Enabled = true;
            btnPentagon.Enabled = true;
            BtnHexagon.Enabled = true;
            btnPolygon.Enabled = false;
            btnSelect.Enabled = true;
            currentMode = Mode.Polygon;
            btnFill.Enabled = false;
        }
        

        private void btnSelect_Click(object sender, EventArgs e)
        {
            btnLine.Enabled = true;
            btnCircle.Enabled = true;
            btnRectangle.Enabled = true;
            btnEllipse.Enabled = true;
            btnTriangle.Enabled = true;
            btnPentagon.Enabled = true;
            BtnHexagon.Enabled = true;
            btnPolygon.Enabled = true;
            btnSelect.Enabled = false;
            currentMode = Mode.Select;
            btnFill.Enabled = true;
        }

        private void openGLControl_MouseDown(object sender, MouseEventArgs e)
        {

            pStart.setPoint(e.Location.X, openGLControl.Height - e.Location.Y);
            // vẽ đa giác
            if (currentMode == Mode.Polygon)
            {
                if (!isDrawing)
                {
                    Selected = -1;
                    renderShapes();
                    currentShape = new MultiP_Poly();
                    currentShape.LineColor = currentLineColor;
                    currentShape.FillColor = currentFillColor;
                    currentShape.LineWidth = (int)lst_Width.Value;
                    currentShape.FillColor = currentFillColor;
                    isDrawing = true;
                    timer_Drawing.Start();
                    timeDrawing = 0;

                }
                return;
            }

            isDrawing = true;

            if (currentMode == Mode.Select)
            {
                int x = pStart.X, y = pStart.Y;

                if (objectId >= 0)
                {
                    chosenControlPointId = shapes[objectId].getControlPointId(x, y);
                    if (chosenControlPointId >= 0)
                    {
                        return;
                    }
                }

                objectId = -1;
                for (int i = n_shapes - 1; i >= 0; i--)
                    if (shapes[i].isInsideBox(x, y))
                    {
                        objectId = i;
                        break;
                    }

                renderShapes();

                if (objectId >= 0)
                {
                    shapes[objectId].drawControlBox(gl);
                }

                return;
            }
            timer_Drawing.Start();
            timeDrawing = 0;
            switch (currentMode)
            {
                case Mode.Line:
                    currentShape = new Line();
                    break;
                case Mode.Triangle:
                    currentShape = new Triangle();
                    break;
                case Mode.Rectangle:
                    currentShape = new Rectangle();
                    break;
                case Mode.Circle:
                    currentShape = new Circle();
                    break;
                case Mode.Ellipse:
                    currentShape = new Ellipse();
                    break;
                case Mode.Pentagon:
                    currentShape = new Pentagon();
                    break;
                case Mode.Hexagon:
                    currentShape = new Hexagon();
                    break;
            }
            currentShape.LineColor = currentLineColor;
            currentShape.LineWidth = (int)lst_Width.Value;
            currentShape.FillColor = currentFillColor;
        }

        private void openGLControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return;
            pEnd.setPoint(e.Location.X, openGLControl.Height - e.Location.Y); //Cập nhật điểm chặn cuối khi di chuyển chuột
            if (currentMode == Mode.Polygon)
            {
                ((MultiP_Poly)currentShape).moveVertex(pEnd);
                renderShapes();
                currentShape.Draw(gl);
            }

            else if (currentMode == Mode.Select)
            {
                if (objectId >= 0)
                {
                    if (chosenControlPointId >= 0)
                        shapes[objectId].dragControlPoint(chosenControlPointId, pStart, pEnd); //Co giãn hình qua điểm điều khiển
                    else shapes[objectId].translate(pStart, pEnd); 

                    if (chosenControlPointId != 8)
                        pStart.setPoint(pEnd);
                    renderShapes();
                    shapes[objectId].drawControlBox(gl);
                }
            }
            else
            {
                currentShape.set(pStart, pEnd);    
                renderShapes();
                
                currentShape.Draw(gl);
                gl.Flush();
            }
        }

        private void openGLControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (currentMode == Mode.Polygon)
            {
                if (isDrawing)
                {
                    if (e.Button == System.Windows.Forms.MouseButtons.Right) 
                    {
                        shapes.Add(((MultiP_Poly)currentShape).getPolygon());
                        n_shapes++;
                        isDrawing = false;
                        timer_Drawing.Stop();
                        renderShapes();
                    }
                    else
                    {
                        if (((MultiP_Poly)currentShape).nPoly == 0)
                        {
                            ((MultiP_Poly)currentShape).addVertex(new Point(e.Location.X, openGLControl.Height - e.Location.Y));
                        }
                        ((MultiP_Poly)currentShape).addVertex(new Point(e.Location.X, openGLControl.Height - e.Location.Y));
                        currentShape.Draw(gl);
                    }
                }
                return;
            }

            isDrawing = false;

            if (currentMode == Mode.Select)
            {
                if (chosenControlPointId >= 0)
                {
                    renderShapes();
                    shapes[objectId].drawControlBox(gl);
                    chosenControlPointId = -1;
                }
            }
            else
            {
                
                timer_Drawing.Stop();
                
                shapes.Add(currentShape);
                n_shapes++;
            }
        }

        private void timer_Drawing_Tick(object sender, EventArgs e)
        {
            timeDrawing++;
            int min, sec, mil;
            mil = timeDrawing % 10;
            sec = (timeDrawing / 10) % 60;
            min = timeDrawing / 600;
            lb_Time.Text = min.ToString() + ":" + (sec < 10 ? "0" : "") + sec.ToString() + "." + mil.ToString();
        }

        private void bt_LineColor_Click(object sender, EventArgs e)
        {
            
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                currentLineColor = new Color(colorDialog.Color.R / 255.0f, colorDialog.Color.G / 255.0f, colorDialog.Color.B / 255.0f);
                bt_LineColor.BackColor = colorDialog.Color;
            }
        }

        private void openGLControl_OpenGLInitialized(object sender, EventArgs e)
        {
            gl = openGLControl.OpenGL;
            gl.MatrixMode(OpenGL.GL_PROJECTION);
            gl.LoadIdentity();
        }
        private void openGLControl_Resized(object sender, EventArgs e)
        {
            
            gl.MatrixMode(OpenGL.GL_PROJECTION);
            
            gl.LoadIdentity();
            
            gl.Viewport(0, 0, openGLControl.Width, openGLControl.Height);
            gl.Ortho2D(0, openGLControl.Width, 0, openGLControl.Height);
        }

        private void lst_Width_ValueChanged(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void openGLControl_Load(object sender, EventArgs e)
        {
            gl.ClearColor(1f, 1f, 1f, 1f);
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
        }
    }
}
