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
    public partial class RectangleForm : Form
    {
        private int edge1 = 0, edge2=0, newX_Coor = 0, newY_Coor = 0, newLocX = 0, newLocY = 0;
        RectangleShape rectangleShape;
        public RectangleForm()
        {
            InitializeComponent();
        }

        private void picRectangle_MouseDown(object sender, MouseEventArgs e)
        {
            newLocX= Convert.ToInt32(e.X);
            newLocY= Convert.ToInt32(e.Y);
        }

        private void picRectangle_MouseUp(object sender, MouseEventArgs e)
        {
            newX_Coor = Convert.ToInt32(e.X);
            newY_Coor = Convert.ToInt32(e.Y);
            int LocX = newX_Coor < newLocX ? newX_Coor : newLocX;
            int LocY = newY_Coor < newLocY ? newY_Coor : newLocY;

            int areaX = Math.Abs(newX_Coor - newLocX); 
            int areaY = Math.Abs(newY_Coor - newLocY );
            DrawRectangle(LocX, LocY, areaX, areaY);
        }

        private void RectangleForm_Load(object sender, EventArgs e)
        {
            edge1 = MainForm.getEdge1();
            edge2 = MainForm.getEdge2();
            rectangleShape = new RectangleShape(edge1,edge2);
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            DrawRectangle(0,0,edge1,edge2);
        }
        void DrawRectangle(int locX, int locY, int x, int y)
        {
            Graphics g = picRectangle.CreateGraphics();
            g.Clear(picRectangle.BackColor);
            Pen p = new Pen(new SolidBrush(Color.White), 3);
            Rectangle r = new Rectangle(locX, locY, x, y);

            g.DrawRectangle(p, r);
            p.Dispose();
            g.Dispose();
            rectangleShape = new RectangleShape(x,y);
            PrintInfo();
        }
        void PrintInfo() => lblObjectInfo.Text = rectangleShape.Print(rectangleShape.CalculateArea(), rectangleShape.CalculatePerimeter());
    }
}
