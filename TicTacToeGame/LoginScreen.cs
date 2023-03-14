using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGame
{
    public partial class LoginScreen : Form
    {
        bool solo = false;
        bool easy = false;
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumberOfRounds.Text))
            {
                txtNumberOfRounds.Text = "3";
            }
            Form1 f1 = new Form1(textBox1.Text,textBox2.Text,txtNumberOfRounds.Text,solo,easy);
            this.Hide();
            f1.ShowDialog();
            this.Show();
        }

        private void btnColorDialog_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();

            ThemeColors(colorDialog1.Color);
            
        }
        void ThemeColors(Color C)
        {
            button1.BackColor = C;
            label2.BackColor = C;
            textBox1.BackColor = C;
            textBox2.BackColor = C;
            txtNumberOfRounds.BackColor = C;
            btnStartGame.BackColor = C;

        }

        void ThemeFonts(Font Font)
        {
            button1.Font = Font;
            label2.Font = Font;
            textBox1.Font = Font;
            textBox2.Font = Font;
            txtNumberOfRounds.Font = Font;
            btnStartGame.Font = Font;
            label1.Font = Font;
            lblFirstPlayerName.Font = Font;
            


        }
        private void button2_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = false;
            fontDialog1.Font = textBox2.Font;
            fontDialog1.ShowDialog();
            ThemeFonts(fontDialog1.Font);
            
        }

        private void rbSolo_CheckedChanged(object sender, EventArgs e)
        {
            solo = true;
            this.Width = 623;
            this.Height = 489;
            panel1.Visible = true;
            Point p = new Point(359, 310);
            btnStartGame.Location = p;
            textBox2.Enabled = false;
            textBox2.Visible= false;
            textBox2.Clear();
            label1.Visible=false;
        }

        private void rbTwoPlayer_CheckedChanged(object sender, EventArgs e)
        {
            solo = false;
            this.Width = 958;
            this.Height = 489;
            panel1.Visible = false;
            Point p = new Point(502, 318);
            btnStartGame.Location = p;
            textBox2.Enabled = true;
            textBox2.Visible = true;
            label1.Visible = true;
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            rbSolo.Checked = true;
        }

        private void rbEasy_CheckedChanged(object sender, EventArgs e)
        {
            
             easy = true;
            
        }

        private void rbHard_CheckedChanged(object sender, EventArgs e)
        {
            easy = false;
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            ThemeFonts(fontDialog1.Font);
        }
    }
}
