using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Summative_1
{
    public partial class GameOverScreen : UserControl
    {
        public GameOverScreen()
        {
            InitializeComponent();
        }

        private void GameOverScreen_Load(object sender, EventArgs e)
        {
            if (GameScreen.roundsCleared == 0)
            {
                labelMessage.Text = "Not even one round?";
            }
            else
            {
                labelMessage.Text = "You cleared " + Convert.ToString(GameScreen.roundsCleared) + " rounds!";
            }
            
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            GameScreen.roundsCleared = 0;

            for (int x = 3; x > 0; x--)
            {
                labelMessage.Text = "Game beginning in " + Convert.ToString(x);
                labelMessage.Refresh();
                Thread.Sleep(1000);
            }

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
