using System.Windows.Forms;
using static glWinForm1.OpenGL;


namespace glWinForm1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void radioButtonFill_CheckedChanged(object sender, System.EventArgs e)
        {
            if (radioButtonFill.Checked)
            {
                Composite.DrawMode = DrawMode.GL_FILL;
                renderControl1.Invalidate();
            }
        }

        private void radioButtonLine_CheckedChanged(object sender, System.EventArgs e)
        {
            if (radioButtonLine.Checked)
            {
                Composite.DrawMode = DrawMode.GL_LINE;
                renderControl1.Invalidate();
            }
        }

        private void radioButtonPoint_CheckedChanged(object sender, System.EventArgs e)
        {
            if (radioButtonPoint.Checked)
            {
                Composite.DrawMode = DrawMode.GL_POINT;
                renderControl1.Invalidate();
            }
        }

        private void numericUpDownHorizontal_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.horizontalCount = (int)numericUpDownHorizontal.Value;
            renderControl1.Invalidate();
        }

        private void numericUpDownVertical_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.verticalCount = (int)numericUpDownVertical.Value;
            renderControl1.Invalidate();
        }
    }
}
