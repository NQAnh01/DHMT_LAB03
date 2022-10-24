using System.Windows.Forms;

namespace _19120450_BT3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        //private void InitializeComponent()
        //{
        //    this.components = new System.ComponentModel.Container();
        //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    this.ClientSize = new System.Drawing.Size(800, 450);
        //    this.Text = "Form1";
        //}
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openGLControl = new SharpGL.OpenGLControl();
            this.lb_LineColor = new System.Windows.Forms.Label();
            this.bt_LineColor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lst_Width = new System.Windows.Forms.NumericUpDown();
            this.lb_Time = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.timer_Drawing = new System.Windows.Forms.Timer(this.components);
            this.btnFill = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.BtnHexagon = new System.Windows.Forms.Button();
            this.btnPentagon = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnPolygon = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbShape = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lst_Width)).BeginInit();
            this.SuspendLayout();
            this.gbShape.SuspendLayout();
            // 
            // openGLControl
            // 
            this.openGLControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openGLControl.BackColor = System.Drawing.Color.White;
            this.openGLControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.openGLControl.Cursor = System.Windows.Forms.Cursors.Cross;
            this.openGLControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.openGLControl.DrawFPS = false;
            this.openGLControl.ForeColor = System.Drawing.Color.White;
            this.openGLControl.Location = new System.Drawing.Point(0, 188);
            this.openGLControl.Name = "openGLControl";
            this.openGLControl.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLControl.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl.Size = new System.Drawing.Size(763, 327);
            this.openGLControl.TabIndex = 0;
            this.openGLControl.OpenGLInitialized += new System.EventHandler(this.openGLControl_OpenGLInitialized);
            this.openGLControl.Resized += new System.EventHandler(this.openGLControl_Resized);
            this.openGLControl.Load += new System.EventHandler(this.openGLControl_Load);
            this.openGLControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.openGLControl_MouseDown);
            this.openGLControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.openGLControl_MouseMove);
            this.openGLControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.openGLControl_MouseUp);
            // 
            // gbShape
            // 
            this.gbShape.Controls.Add(this.btnEllipse);
            this.gbShape.Controls.Add(this.btnRectangle);
            this.gbShape.Controls.Add(this.btnCircle);
            this.gbShape.Controls.Add(this.btnLine);
            this.gbShape.Controls.Add(this.btnPentagon);
            this.gbShape.Controls.Add(this.btnPolygon);
            this.gbShape.Controls.Add(this.btnTriangle);
            this.gbShape.Controls.Add(this.BtnHexagon);
            this.gbShape.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbShape.Location = new System.Drawing.Point(3, 10);
            this.gbShape.Name = "gbShape";
            this.gbShape.Size = new System.Drawing.Size(444, 135);
            this.gbShape.TabIndex = 5;
            this.gbShape.TabStop = false;
            this.gbShape.Text = "Shape";
            // 
            // lb_LineColor
            // 
            this.lb_LineColor.AutoSize = true;
            this.lb_LineColor.Location = new System.Drawing.Point(601, 17);
            this.lb_LineColor.Name = "lb_LineColor";
            this.lb_LineColor.Size = new System.Drawing.Size(54, 13);
            this.lb_LineColor.TabIndex = 17;
            this.lb_LineColor.Text = "Color";
            // 
            // bt_LineColor
            // 
            this.bt_LineColor.BackColor = System.Drawing.SystemColors.ControlText;
            this.bt_LineColor.Location = new System.Drawing.Point(599, 29);
            this.bt_LineColor.Name = "bt_LineColor";
            this.bt_LineColor.Size = new System.Drawing.Size(35, 39);
            this.bt_LineColor.TabIndex = 18;
            this.bt_LineColor.UseVisualStyleBackColor = false;
            this.bt_LineColor.Click += new System.EventHandler(this.bt_LineColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(599, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Line Width(px)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lst_Width
            // 
            this.lst_Width.Location = new System.Drawing.Point(599, 105);
            this.lst_Width.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.lst_Width.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lst_Width.Name = "lst_Width";
            this.lst_Width.Size = new System.Drawing.Size(86, 20);
            this.lst_Width.TabIndex = 20;
            this.lst_Width.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lst_Width.ValueChanged += new System.EventHandler(this.lst_Width_ValueChanged);
            // 
            // lb_Time
            // 
            this.lb_Time.AutoSize = true;
            this.lb_Time.Location = new System.Drawing.Point(651, 54);
            this.lb_Time.Name = "lb_Time";
            this.lb_Time.Size = new System.Drawing.Size(37, 13);
            this.lb_Time.TabIndex = 21;
            this.lb_Time.Text = "0:00.0";
            // 
            // timer_Drawing
            // 
            this.timer_Drawing.Tick += new System.EventHandler(this.timer_Drawing_Tick);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.Control;
            this.btnSelect.Location = new System.Drawing.Point(479, 29);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(88, 39);
            this.btnSelect.TabIndex = 16;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(479, 89);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 39);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.BackColor = System.Drawing.SystemColors.Control;
            this.btnEllipse.Location = new System.Drawing.Point(230, 19);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(88, 39);
            this.btnEllipse.TabIndex = 14;
            this.btnEllipse.Text = "Ellipse";
            this.btnEllipse.UseVisualStyleBackColor = false;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.BackColor = System.Drawing.SystemColors.Control;
            this.btnCircle.Location = new System.Drawing.Point(123, 19);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(88, 39);
            this.btnCircle.TabIndex = 13;
            this.btnCircle.Text = "Circle";
            this.btnCircle.UseVisualStyleBackColor = false;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // BtnHexagon
            // 
            this.BtnHexagon.BackColor = System.Drawing.SystemColors.Control;
            this.BtnHexagon.Location = new System.Drawing.Point(230, 79);
            this.BtnHexagon.Name = "BtnHexagon";
            this.BtnHexagon.Size = new System.Drawing.Size(88, 39);
            this.BtnHexagon.TabIndex = 12;
            this.BtnHexagon.Text = "Hexagon";
            this.BtnHexagon.UseVisualStyleBackColor = false;
            this.BtnHexagon.Click += new System.EventHandler(this.BtnHexagon_Click);
            // 
            // btnPentagon
            // 
            this.btnPentagon.BackColor = System.Drawing.SystemColors.Control;
            this.btnPentagon.Location = new System.Drawing.Point(123, 79);
            this.btnPentagon.Name = "btnPentagon";
            this.btnPentagon.Size = new System.Drawing.Size(88, 39);
            this.btnPentagon.TabIndex = 11;
            this.btnPentagon.Text = "Pentagon";
            this.btnPentagon.UseVisualStyleBackColor = false;
            this.btnPentagon.Click += new System.EventHandler(this.btnPentagon_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackColor = System.Drawing.SystemColors.Control;
            this.btnRectangle.Location = new System.Drawing.Point(337, 19);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(88, 39);
            this.btnRectangle.TabIndex = 10;
            this.btnRectangle.Text = "Rectangle";
            this.btnRectangle.UseVisualStyleBackColor = false;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnLine
            // 
            this.btnLine.BackColor = System.Drawing.SystemColors.Control;
            this.btnLine.Enabled = false;
            this.btnLine.Location = new System.Drawing.Point(16, 19);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(88, 39);
            this.btnLine.TabIndex = 9;
            this.btnLine.Text = "Line";
            this.btnLine.UseVisualStyleBackColor = false;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnTriangle
            // 
            this.btnTriangle.BackColor = System.Drawing.SystemColors.Control;
            this.btnTriangle.Location = new System.Drawing.Point(16, 79);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(88, 39);
            this.btnTriangle.TabIndex = 8;
            this.btnTriangle.Text = "Triangle";
            this.btnTriangle.UseVisualStyleBackColor = false;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // btnPolygon
            // 
            this.btnPolygon.BackColor = System.Drawing.SystemColors.Control;
            this.btnPolygon.Location = new System.Drawing.Point(337, 79);
            this.btnPolygon.Name = "btnPolygon";
            this.btnPolygon.Size = new System.Drawing.Size(88, 39);
            this.btnPolygon.TabIndex = 15;
            this.btnPolygon.Text = "Polygon";
            this.btnPolygon.UseVisualStyleBackColor = false;
            this.btnPolygon.Click += new System.EventHandler(this.btnPolygon_Click);
            // 
            // Lab01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 516);
            this.Controls.Add(this.lb_Time);
            this.Controls.Add(this.lst_Width);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_LineColor);
            this.Controls.Add(this.lb_LineColor);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gbShape);
            this.Controls.Add(this.openGLControl);
            this.Name = "_19120450_BT3";
            this.Text = "_19120450_BT3";
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lst_Width)).EndInit();
            this.gbShape.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnPentagon;
        private System.Windows.Forms.Button BtnHexagon;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnPolygon;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lb_LineColor;
        private System.Windows.Forms.Button bt_LineColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown lst_Width;
        private System.Windows.Forms.Label lb_Time;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Timer timer_Drawing;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.GroupBox gbShape;
        private System.Windows.Forms.Button btnClear;
    }
}

