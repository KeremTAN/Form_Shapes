using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormShapes
{
    public partial class CircleForm : Form
    {
        private int radius = 0, newX_Coor = 0, newY_Coor = 0, newLocX = 0, newLocY=0;
        CircleShape circleShape;
        public CircleForm()
        {
            InitializeComponent();
        }

        private void CircleForm_Load(object sender, EventArgs e) {
            radius = MainForm.getRadius();
            circleShape = new CircleShape(radius,radius);
        }

        private void picCircle_MouseDown(object sender, MouseEventArgs e)
        {
            newLocX = Convert.ToInt32(e.X);
            newLocY = Convert.ToInt32(e.Y);
        }

        private void picCircle_MouseUp(object sender, MouseEventArgs e)
        {
            newX_Coor = Convert.ToInt32(e.X);
            newY_Coor = Convert.ToInt32(e.Y);
            int LocX = newX_Coor < newLocX ? newX_Coor : newLocX;
            int LocY = newY_Coor < newLocY ? newY_Coor : newLocY;

            int areaX = Math.Abs(newX_Coor - newLocX);
            int areaY = Math.Abs(newY_Coor - newLocY);
            DrawCircle(LocX, LocY, areaX, areaY);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            DrawCircle(0,0, radius,radius);
        }
        void DrawCircle(int locX, int locY,int x, int y) {
            Graphics g = picCircle.CreateGraphics();
            g.Clear(picCircle.BackColor);          
            Pen p = new Pen(new SolidBrush(Color.White), 3);
            Rectangle r = new Rectangle(locX, locY, x, y);

            g.DrawEllipse(p, r);
            p.Dispose();
            g.Dispose();
            circleShape = new CircleShape(x, y);
            PrintInfo();
        }
        void PrintInfo() => lblObjectInfo.Text = circleShape.Print(circleShape.CalculateArea(), circleShape.CalculatePerimeter());


    }
}
