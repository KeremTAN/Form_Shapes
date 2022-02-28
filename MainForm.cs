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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private static bool isRectangel = false;
        private static int circleRadius, edge1, edge2;
        public static int getRadius() => circleRadius;
        public static int getEdge1() => edge1;
        public static int getEdge2() => edge2;
        private void MainForm_Load(object sender, EventArgs e)
        {
            cmbOptions.Text = cmbOptions.Items[0].ToString();
            rectangleUNvisible();
            circleUNvisible();
            lblErrorMessage.Text = "";
        }

        private void cmbOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblErrorMessage.Text = "";
            if (cmbOptions.Text == cmbOptions.Items[1].ToString())
            {
                rectangleUNvisible();
                circleVisible();
            }
            else if (cmbOptions.Text == cmbOptions.Items[2].ToString())
            {
                rectangleVisible();
                circleUNvisible();
            }
            else {
                rectangleUNvisible();
                circleUNvisible();
            }
        }
        private void btnRedirect_Click(object sender, EventArgs e)
        {
            lblErrorMessage.Text = "";
            if (cmbOptions.Items[0].ToString()==cmbOptions.Text) {
                circleUNvisible();
                rectangleUNvisible();
                return;        
            }
            if (isRectangel)
                if (isNumber(txtEdge1.Text) && isNumber(txtEdge1.Text))
                {
                    RectangleForm rf = new RectangleForm();
                    edge1 = Convert.ToInt32(txtEdge1.Text);
                    edge2 = Convert.ToInt32(txtEdge2.Text);
                    rf.ShowDialog();
                }
                else
                    lblErrorMessage.Text = "Wrong edges values !";
            else
            {
                if (isNumber(txtRadius.Text))
                {
                    CircleForm cf = new CircleForm();
                    circleRadius = Convert.ToInt32(txtRadius.Text);
                    cf.ShowDialog();
                
                }
                else
                   lblErrorMessage.Text = "Wrong radius values !";
            }


        }
        private bool isNumber(string text) {
            if (!String.IsNullOrEmpty(text))
            {
                foreach (char chr in text)
                    if (!Char.IsNumber(chr)) return false;
            }
            else
                return false;
            return true;
        }
        private void rectangleUNvisible()
        {
            isRectangel = false;
            lblEgde1.Visible = false;
            lblEdge2.Visible = false;
            txtEdge1.Visible = false;
            txtEdge2.Visible = false;
        }
        private void rectangleVisible()
        {
            isRectangel = true;
            lblEgde1.Visible = true;
            lblEdge2.Visible = true;
            txtEdge1.Visible = true;
            txtEdge2.Visible = true;
            txtRadius.Text = "";
        }
        private void circleUNvisible()
        {
            lblRadius.Visible = false;
            txtRadius.Visible = false;
        }
        private void circleVisible()
        {
            lblRadius.Visible = true;
            txtRadius.Visible = true;
            txtEdge1.Text = "";
            txtEdge2.Text = "";
        }
        private void btnRedirect_MouseHover(object sender, EventArgs e)
        {
            btnRedirect.BackColor = Color.WhiteSmoke;
        }
        private void btnRedirect_MouseLeave(object sender, EventArgs e)
        {
            btnRedirect.BackColor = Color.White;
        }
    }
}
