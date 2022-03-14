using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame2
{
    public partial class GameOver : Form
    {
        public GameOver(int score)
        {
            InitializeComponent();
            lblScore.Text = "JOUW SCORE: " + score.ToString();
        }
    }
}
