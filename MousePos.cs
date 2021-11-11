using System;
using System.Windows.Forms;

namespace MousePos
{
    public partial class MousePos : Form
    {
        public MousePos()
        {
            InitializeComponent();
        }

        private void MousePos_Load(object sender, EventArgs e)
        
            {
                Timer timer = new Timer();
                timer.Interval = (1 * 10); // .01 secs
                timer.Tick += new EventHandler(timer_Tick);
                timer.Start();
            }

            private void timer_Tick(object sender, EventArgs e)
            {
                xLab.Text = "X Position: " + MousePosition.X.ToString();
                yLab.Text = "Y Position: " + MousePosition.Y.ToString();
            }
        
    }
}
