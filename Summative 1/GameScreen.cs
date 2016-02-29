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
    public partial class GameScreen : UserControl
    {
        int patternNumber = 3;
        int colour;
        Random randomNumberGen = new Random();
        Color[] normalColours = new Color[4];



        public GameScreen()
        {
            InitializeComponent();

            // Adding Transparency
            labelMessage.BackColor = Color.FromArgb(200, 0, 0, 0);
            labelMessage.ForeColor = Color.FromArgb(10, 150, 150, 150);

            BlankForm.buttons[0] = buttonY;
            BlankForm.buttons[1] = buttonG;
            BlankForm.buttons[2] = buttonR;
            BlankForm.buttons[3] = buttonB;

            normalColours[0] = Color.FromArgb(80, 255, 255, 5);
            normalColours[1] = Color.FromArgb(80, 80, 255, 5);
            normalColours[2] = Color.FromArgb(80, 255, 5, 5);
            normalColours[3] = Color.FromArgb(80, 58, 71, 222);

            for (int i = 0; i <= 3; i++) { BlankForm.buttons[i].BackColor = normalColours[i]; }


            // Program
            Setup();
            
            Thread.Sleep(1000);

            


        }

        void Setup()
        {
            BlankForm.pattern.Clear();
            Refresh(); // why?
        }


        void ComputerTurn()
        {
            buttonB.Refresh();
            buttonR.Refresh();
            buttonG.Refresh();
            buttonY.Refresh();

            patternNumber += 1; //Increasing difficulty

            for (int i = 0; i <= patternNumber; i++)
            {
                colour = randomNumberGen.Next(0, 4);
                BlankForm.pattern.Add(colour);
                labelMessage.Text += " " + BlankForm.pattern[i];

                switch (BlankForm.pattern[i])
                {
                    case 3:
                        BlankForm.buttons[i].BackColor = Color.FromArgb(255, 58, 71, 222);
                        buttonB.Refresh();
                        Thread.Sleep(250);

                        break;
                    case 2:
                        buttonR.BackColor = Color.FromArgb(255, 255, 5, 5);
                        buttonR.Refresh();
                        Thread.Sleep(250);

                        break;
                    case 1:
                        buttonG.BackColor = Color.FromArgb(255, 80, 255, 5);
                        buttonG.Refresh();
                        Thread.Sleep(250);

                        break;
                    case 0:
                        buttonY.BackColor = Color.FromArgb(255, 255, 255, 5);
                        buttonY.Refresh();
                        Thread.Sleep(250);

                        break;
                    default:
                        break;
                }

                // ResetColour();

                for (int x = 0; x <= 3; x++) { BlankForm.buttons[x].BackColor = normalColours[x]; }

                buttonB.Refresh();
                buttonR.Refresh();
                buttonG.Refresh();
                buttonY.Refresh();
                Thread.Sleep(250);
            }

            
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            ComputerTurn();
        }
    }
}
