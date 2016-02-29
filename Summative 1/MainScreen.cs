using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Summative_1
{
    public partial class MainScreen : UserControl
    {
        public MainScreen()
        {
            InitializeComponent();

            buttonStart.BackColor = Color.FromArgb(80, 255, 255, 255);
            buttonExit.BackColor = Color.FromArgb(80, 255, 255, 255);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            GameScreen gs = new GameScreen();
            f.Controls.Add(gs);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
