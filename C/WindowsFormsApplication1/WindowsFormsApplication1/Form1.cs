using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.OpenGl;
using Tao.FreeGlut;
using Tao.Platform.Windows;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FW.InitializeContexts();

        }

        private void simpleOpenGlControl2_Load(object sender, EventArgs e)
        {

        }

        private void FW_Paint(object sender, PaintEventArgs e)
        {
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);
            Gl.glViewport(0, 0, FW.Width, FW.Height);
            Gl.glClearColor(0f, 0f, 1f, 1);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Glut.glutWireSphere(2, 32, 32);
            Gl.glFlush();
            FW.Invalidate();
        }
    }
}
