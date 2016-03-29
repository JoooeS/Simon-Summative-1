/// 
/// Program: Simon Says Game - Summative 1
/// 
/// Description: The program will repeatedly create a pattern for the player to follow
///              and will continue until the player gets the computer pattern wrong.
///              The program only requires clicking and will display the accomplishment
///              of the player (Score).
/// 
/// Class: ICS4U
/// Date Started: Approximately February 2016
/// Created by: Joe S
/// 


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
using System.Media;

namespace Summative_1
{
    public partial class GameScreen : UserControl
    {
        #region Variables
        // Lists
        List<int> computerPattern = new List<int>();
        List<int> playerPattern = new List<int>();

        // Sound
        SoundPlayer sf = new SoundPlayer(Properties.Resources.Press_SK);

        // Arrays
        Label[] labels = new Label[4];
        Color[] dimmedColours = new Color[4];
        Color[] brightColours = new Color[4];

        // Number generator
        Random randomNumberGen = new Random();

        // Variables
        public static int roundsCleared = 0; // public variable to be used in game over screen
        int patternNumber = 0;
        int colour;
        bool playerTurn = false;
        #endregion


        public GameScreen()
        {
            InitializeComponent();

            // Transparency of Message label
            labelMessage.BackColor = Color.FromArgb(150, 0, 0, 0);
            labelMessage.ForeColor = Color.FromArgb(10, 150, 150, 150);

            // Assigning labels
            labels[0] = labelY; // Yellow
            labels[1] = labelG; // Green
            labels[2] = labelR; // Red
            labels[3] = labelB; // Blue

            // Dimmed colour values
            dimmedColours[0] = Color.FromArgb(80, 255, 255, 0);
            dimmedColours[1] = Color.FromArgb(80, 0, 255, 0);
            dimmedColours[2] = Color.FromArgb(80, 255, 0, 0);
            dimmedColours[3] = Color.FromArgb(80, 0, 0, 255);

            // Bright colour values
            brightColours[0] = Color.FromArgb(255, 255, 255, 0);
            brightColours[1] = Color.FromArgb(255, 0, 255, 0);
            brightColours[2] = Color.FromArgb(255, 255, 0, 0);
            brightColours[3] = Color.FromArgb(255, 0, 0, 255);

            for (int i = 0; i <= 3; i++) // Setting the labels to look "dimmed"
            {
                labels[i].BackColor = dimmedColours[i];
            }
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            Refresh();

            for (int i = 3; i > 0; i--)
            {
                labelMessage.Text = "Computer Turn in " + Convert.ToString(i);
                labelMessage.Refresh();
                Thread.Sleep(1000);
            }

            ComputerTurn();
        }

        /// <summary>
        /// Creates a computer pattern to display to the player while completing various minor changes
        /// </summary>
        void ComputerTurn()
        {
            // Clearing player and computer patterns for the next round
            playerPattern.Clear(); 
            computerPattern.Clear();
            labelMessage.Text = "Computer Turn now :D";
            labelMessage.Refresh();
            Thread.Sleep(500);

            for (int i = 0; i < labels.Count(); i++) // Reset label.backcolors to "dimmed"
            {
                labels[i].Refresh();
            }

            patternNumber += 1; //Increase difficulty by adding one

            // Creation of the pattern using a "for loop"
            for (int i = 0; i < patternNumber; i++)
            {
                colour = randomNumberGen.Next(0, 4);
                computerPattern.Add(colour);

                // Dependent on the colour 
                switch (computerPattern[i])
                {
                    case 3:
                        labels[3].BackColor = brightColours[3]; // Lights up blue label
                        labelB.Refresh();
                        sf.Play();
                        Thread.Sleep(500);

                        break;
                    case 2:
                        labels[2].BackColor = brightColours[2]; // Lights up Red label
                        labelR.Refresh();
                        sf.Play();
                        Thread.Sleep(500);

                        break;
                    case 1:
                        labels[1].BackColor = brightColours[1]; // Lights up Green label
                        labelG.Refresh();
                        sf.Play();
                        Thread.Sleep(500);

                        break;
                    case 0:
                        labels[0].BackColor = brightColours[0]; // Lights up Yellow label
                        labelY.Refresh();
                        sf.Play();
                        Thread.Sleep(500);

                        break;
                    default:
                        break;
                }

                for (int x = 0; x <= 3; x++) // Reset colours back to "dimmed"
                {
                    labels[x].BackColor = dimmedColours[x];
                    labels[x].Refresh();
                }
                Thread.Sleep(250);
            }

            labelMessage.Text = "Player Turn"; // New message
        }

        /// <summary>
        /// Method to compare player pattern to computer pattern
        /// </summary>
        void PlayerCheck()
        {
            // Compares computerPattern to the playerPattern
            for (int x = 0; x < playerPattern.Count(); x++)
            {
                // If RIGHT
                if (computerPattern[x] == playerPattern[x])
                {
                    labelMessage.Text = Convert.ToString(x + 1) + "/" + Convert.ToString(patternNumber) + " correct!";
                    labelMessage.Refresh();

                    if (x == patternNumber - 1)
                    {
                        labels[playerPattern[x]].BackColor = dimmedColours[playerPattern[x]];
                        labels[playerPattern[x]].Refresh();

                        for (int i = 3; i > 0; i--)
                        {
                            labelMessage.Text = "Nice. Computer Turn in " + Convert.ToString(i);
                            labelMessage.Refresh();
                            Thread.Sleep(1000);
                        }
                        playerTurn = false;
                        roundsCleared++;
                        ComputerTurn();
                        break;
                    }
                }

                // If WRONG
                else
                {
                    for (int i = 0; i < labels.Count(); i++)
                    {
                        labels[i].Visible = false;
                    }
                    labelMessage.Text = "...";
                    labelMessage.Refresh();
                    Thread.Sleep(1500);
                    labelMessage.Text += " Loser.";
                    labelMessage.Refresh();
                    Thread.Sleep(1500);

                    Form f = this.FindForm();
                    f.Controls.Remove(this);

                    GameOverScreen gos = new GameOverScreen();
                    f.Controls.Add(gos);
                    break;
                }

                if (playerPattern.Count > 0)
                {
                    labels[playerPattern[x]].BackColor = dimmedColours[playerPattern[x]];
                    labels[playerPattern[x]].Refresh();
                }
                
            }
        }

        /// <summary>
        /// Method to visually indicate to the player that "x" button has been pressed
        /// </summary>
        /// <param name="x">Corresponds to a colour</param>
        void Clicker(int x)
        {
            labels[x].BackColor = brightColours[x];
            labels[x].Refresh();
            sf.Play();
            Thread.Sleep(150);
            labels[x].BackColor = dimmedColours[x];
            labels[x].Refresh();
        }


        private void labelY_Click(object sender, EventArgs e)
        {
            Clicker(0);
            playerPattern.Add(0);
            PlayerCheck();
        }


        private void labelG_Click(object sender, EventArgs e)
        {
            Clicker(1);
            playerPattern.Add(1);
            PlayerCheck();
        }


        private void labelR_Click(object sender, EventArgs e)
        {
            Clicker(2);
            playerPattern.Add(2);
            PlayerCheck();
        }


        private void labelB_Click(object sender, EventArgs e)
        {
            Clicker(3);
            playerPattern.Add(3);
            PlayerCheck();
        }
    }
}
