using System.Windows.Forms;
using static glWinForm1.OpenGL;


namespace glWinForm1
{
    public partial class MainForm : Form
    {
        public static decimal Xmin = -10;
        public static decimal Xmax = 10;

        public static int N = 500;


        public MainForm()
        {
            InitializeComponent();
        }

        // Xmin
        private void numericUpDownMin_ValueChanged(object sender, System.EventArgs e)
        {
            if (numericUpDownMax.Value - numericUpDownMin.Value < 5m)
            {
                numericUpDownMin.Value = numericUpDownMax.Value - 5m;
            }

            Xmin = numericUpDownMin.Value;
            renderControl1.Invalidate();
        }

        //Xmax
        private void numericUpDownMax_ValueChanged(object sender, System.EventArgs e)
        {
            if (numericUpDownMax.Value - numericUpDownMin.Value < 5m)
            {
                numericUpDownMax.Value = numericUpDownMin.Value + 5m;
            }

            Xmax = numericUpDownMax.Value;
            renderControl1.Invalidate();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            Xmin = numericUpDownMin.Value;
            Xmax = numericUpDownMax.Value;
        }

        private void numericUpDownN_ValueChanged(object sender, System.EventArgs e)
        {
            N = (int)numericUpDownN.Value;
            renderControl1.Invalidate();
        }
    }
}
