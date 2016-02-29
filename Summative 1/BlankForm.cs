using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Summative_1
{
    public partial class BlankForm : Form
    {
        public static List<int> pattern = new List<int>();
        public static Button[] buttons = new Button[4];

        public static int timesCleared = 0;
        

        public BlankForm()
        {
            InitializeComponent();

            // Load Main Screen
            MainScreen ms = new MainScreen();
            this.Controls.Add(ms);

            
        }
    }
}
