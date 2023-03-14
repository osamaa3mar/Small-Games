using System;
using System.Windows.Forms;

namespace TicTacToeGame
{
    public partial class Form1 : Form
    {
        private Char _Choice = 'X';
        private string _PlayerOne = "";
        private string _PlayerTwo = "";
        private string _PlayerTurn = "";
        private byte NumberOfRounds = 0;
        private byte X = 0;
        private byte O = 0;
        bool _solo = false;
        bool _easy = false;
        Random random = new Random();


        public Form1()
        {
            InitializeComponent();
            button1.Text = " ";
            button2.Text = "  ";
            button3.Text = "   ";
            button4.Text = "    ";
            button5.Text = "     ";
            button6.Text = "      ";
            button7.Text = "       ";
            button8.Text = "        ";
            button9.Text = "         ";
        }
        public Form1(string Playerone, string Playertwo)
        {
            InitializeComponent();
            button1.Text = " ";
            button2.Text = "  ";
            button3.Text = "   ";
            button4.Text = "    ";
            button5.Text = "     ";
            button6.Text = "      ";
            button7.Text = "       ";
            button8.Text = "        ";
            button9.Text = "         ";
            _PlayerOne = Playerone;
            _PlayerTwo = Playertwo;
            _PlayerTurn = Playerone;
            label2.Text = _PlayerTurn;
        }
        public Form1(string Playerone, string Playertwo, string numberOfRounds, bool solo, bool easy)
        {
            InitializeComponent();
            button1.Text = " ";
            button2.Text = "  ";
            button3.Text = "   ";
            button4.Text = "    ";
            button5.Text = "     ";
            button6.Text = "      ";
            button7.Text = "       ";
            button8.Text = "        ";
            button9.Text = "         ";
            _PlayerOne = Playerone;
            _PlayerTwo = (Playertwo == "") ? "Computer" : Playertwo;
            _PlayerTurn = Playerone;
            label2.Text = _PlayerTurn;
            NumberOfRounds = Convert.ToByte(numberOfRounds);
            lblRound.Text = numberOfRounds;
            _solo = solo;
            _easy = easy;
        }

        private void Rounds()
        {
            if (NumberOfRounds != 0)
            {
                NumberOfRounds--;
                lblRound.Text = NumberOfRounds.ToString();
            }
            if (NumberOfRounds == 0 && X > O)
            {
                if (MessageBox.Show($"Game Ended! \"{_PlayerOne} wins the Game\"", "result", MessageBoxButtons.OK,
                    MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            if (NumberOfRounds == 0 && X < O)
            {
                if (MessageBox.Show($"Game Ended! \"{_PlayerTwo} wins the Game\"", "result", MessageBoxButtons.OK,
                    MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.Close();

                }
            }
            if (NumberOfRounds == 0 && X == O)
            {
                if (MessageBox.Show("Game Ended! \"Draw No One Won!!\"", "result", MessageBoxButtons.OK,
                    MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.Close();

                }
            }
        }
        private char _ChangeChoice(char c)
        {
            if (c == 'X')
            {
                return 'O';
            }
            if (c == 'O')
            {
                return 'X';
            }
            return 'X';
        }
        private string _ChangePlayer()
        {
            if (label2.Text == "")
            {
                return _PlayerOne;
            }
            if (label2.Text == _PlayerOne)
            {
                return _PlayerTwo;
            }
            if (label2.Text == _PlayerTwo)
            {
                return _PlayerOne;
            }
            return _PlayerOne;
        }
        private void _ShowResult()
        {
            if (button1.Text == button2.Text && button1.Text == button3.Text)
            {
                if (MessageBox.Show("\'" + button1.Text + "\'" + " Wins", "Result",
                    MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    if (button1.Text == "X")
                    {
                        X++;
                    }
                    else
                    {
                        O++;
                    }
                    Clear();
                }

                Rounds();
                return;
            }
            if (button4.Text == button5.Text && button4.Text == button6.Text)
            {
                if (MessageBox.Show("\'" + button4.Text + "\'" + " Wins", "Result",
                    MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    if (button4.Text == "X")
                    {
                        X++;
                    }
                    else
                    {
                        O++;
                    }
                    Clear();
                }

                Rounds();
                return;
            }
            if (button7.Text == button8.Text && button7.Text == button9.Text)
            {
                if (MessageBox.Show("\'" + button7.Text + "\'" + " Wins", "Result",
                    MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    if (button7.Text == "X")
                    {
                        X++;
                    }
                    else
                    {
                        O++;
                    }
                    Clear();
                }
                Rounds();
                return;
            }
            if (button1.Text == button4.Text && button1.Text == button7.Text)
            {
                if (MessageBox.Show("\'" + button1.Text + "\'" + " Wins", "Result",
                    MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    if (button1.Text == "X")
                    {
                        X++;
                    }
                    else
                    {
                        O++;
                    }
                    Clear();
                }
                Rounds();
                return;
            }
            if (button2.Text == button5.Text && button2.Text == button8.Text)
            {
                if (MessageBox.Show("\'" + button2.Text + "\'" + " Wins", "Result",
                    MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    if (button2.Text == "X")
                    {
                        X++;
                    }
                    else
                    {
                        O++;
                    }
                    Clear();
                }
                return;
            }
            if (button3.Text == button6.Text && button3.Text == button9.Text)
            {
                if (MessageBox.Show("\'" + button3.Text + "\'" + " Wins", "Result",
                    MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    if (button3.Text == "X")
                    {
                        X++;
                    }
                    else
                    {
                        O++;
                    }
                    Clear();
                }
                Rounds();
                return;
            }
            if (button1.Text == button5.Text && button1.Text == button9.Text)
            {
                if (MessageBox.Show("\'" + button1.Text + "\'" + " Wins", "Result",
                    MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    if (button1.Text == "X")
                    {
                        X++;
                    }
                    else
                    {
                        O++;
                    }
                    Clear();
                }
                Rounds();
                return;
            }
            if (button3.Text == button5.Text && button3.Text == button7.Text)
            {
                if (MessageBox.Show("\'" + button3.Text + "\'" + " Wins", "Result",
                    MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    if (button3.Text == "X")
                    {
                        X++;
                    }
                    else
                    {
                        O++;
                    }
                    Clear();
                }
                Rounds();
                return;
            }
            if (!button1.Enabled && !button2.Enabled && !button3.Enabled && !button4.Enabled && !button5.Enabled && !button6.Enabled && !button7.Enabled && !button8.Enabled && !button9.Enabled)
            {
                if (MessageBox.Show("\'" + "Draw" + "\'", "Result",
                    MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {

                    Clear();
                }
                Rounds();
                return;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            ((Button)sender).Text = _Choice.ToString();
            _Choice = _ChangeChoice(_Choice);
            ((Button)sender).Enabled = false;
            if (_solo)
            {
                if (!_easy)
                {
                    CleverComputer();
                    _Choice = _ChangeChoice(_Choice);
                }
                else if (_easy)
                {
                    ComputerChoice();
                    _Choice = _ChangeChoice(_Choice);
                }
            }
            _ChangePlayerLabel(_ChangePlayer());
            _ShowResult();
        }

        public void Clear()
        {
            _Choice = 'X';
            button1.Text = " ";
            button2.Text = "  ";
            button3.Text = "   ";
            button4.Text = "    ";
            button5.Text = "     ";
            button6.Text = "      ";
            button7.Text = "       ";
            button8.Text = "        ";
            button9.Text = "         ";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void _ChangePlayerLabel(string PlayerTurn)
        {
            label2.Text = PlayerTurn;
        }

        Button[] Bots = new Button[9];
        void IntilazeBouttons()
        {
            Bots[0] = button1;
            Bots[1] = button2;
            Bots[2] = button3;
            Bots[3] = button4;
            Bots[4] = button5;
            Bots[5] = button6;
            Bots[6] = button7;
            Bots[7] = button8;
            Bots[8] = button9;
        }
        void ComputerChoice()
        {
            IntilazeBouttons();

            for (int i = 0; i < 9; i++)
            {
                if (Bots[i].Enabled)
                {
                    Bots[i].Text = _Choice.ToString();
                    Bots[i].Enabled = false;
                    return;
                }

            }
        }

        void CleverComputer()
        {
            IntilazeBouttons();
            if (Bots[0].Text == Bots[1].Text && Bots[2].Enabled)//00
            {
                Bots[2].Text = _Choice.ToString();
                Bots[2].Enabled = false;
            }
            else if (Bots[0].Text == Bots[2].Text && Bots[1].Enabled)//00
            {
                Bots[1].Text = _Choice.ToString();
                Bots[1].Enabled = false;
            }
            else if (Bots[1].Text == Bots[2].Text && Bots[0].Enabled)//00
            {
                Bots[0].Text = _Choice.ToString();
                Bots[0].Enabled = false;
            }
            else if (Bots[3].Text == Bots[4].Text && Bots[5].Enabled)//01
            {
                Bots[5].Text = _Choice.ToString();
                Bots[5].Enabled = false;
            }
            else if (Bots[4].Text == Bots[5].Text && Bots[3].Enabled)//01
            {
                Bots[3].Text = _Choice.ToString();
                Bots[3].Enabled = false;
            }
            else if (Bots[3].Text == Bots[5].Text && Bots[4].Enabled)//01
            {
                Bots[4].Text = _Choice.ToString();
                Bots[4].Enabled = false;
            }
            else if (Bots[6].Text == Bots[7].Text && Bots[8].Enabled)//02
            {
                Bots[8].Text = _Choice.ToString();
                Bots[8].Enabled = false;
            }
            else if (Bots[6].Text == Bots[8].Text && Bots[7].Enabled)//02
            {
                Bots[7].Text = _Choice.ToString();
                Bots[7].Enabled = false;
            }
            else if (Bots[7].Text == Bots[8].Text && Bots[6].Enabled)//02
            {
                Bots[6].Text = _Choice.ToString();
                Bots[6].Enabled = false;
            }
            else if (Bots[0].Text == Bots[3].Text && Bots[6].Enabled)//v1
            {
                Bots[6].Text = _Choice.ToString();
                Bots[6].Enabled = false;
            }
            else if (Bots[0].Text == Bots[6].Text && Bots[3].Enabled)//v1
            {
                Bots[3].Text = _Choice.ToString();
                Bots[3].Enabled = false;
            }
            else if (Bots[3].Text == Bots[6].Text && Bots[0].Enabled)//v1
            {
                Bots[0].Text = _Choice.ToString();
                Bots[0].Enabled = false;
            }
            else if (Bots[1].Text == Bots[4].Text && Bots[7].Enabled)//v2
            {
                Bots[7].Text = _Choice.ToString();
                Bots[7].Enabled = false;
            }
            else if (Bots[1].Text == Bots[7].Text && Bots[4].Enabled)//v2
            {
                Bots[4].Text = _Choice.ToString();
                Bots[4].Enabled = false;
            }
            else if (Bots[4].Text == Bots[7].Text && Bots[1].Enabled)//v2
            {
                Bots[1].Text = _Choice.ToString();
                Bots[1].Enabled = false;
            }
            else if (Bots[2].Text == Bots[5].Text && Bots[8].Enabled)//v3
            {
                Bots[8].Text = _Choice.ToString();
                Bots[8].Enabled = false;
            }
            else if (Bots[5].Text == Bots[8].Text && Bots[2].Enabled)//v3
            {
                Bots[2].Text = _Choice.ToString();
                Bots[2].Enabled = false;
            }
            else if (Bots[2].Text == Bots[8].Text && Bots[5].Enabled)//v3
            {
                Bots[5].Text = _Choice.ToString();
                Bots[5].Enabled = false;
            }
            else if (Bots[0].Text == Bots[4].Text && Bots[8].Enabled)///
            {
                Bots[8].Text = _Choice.ToString();
                Bots[8].Enabled = false;
            }
            else if (Bots[0].Text == Bots[8].Text && Bots[4].Enabled)///
            {
                Bots[4].Text = _Choice.ToString();
                Bots[4].Enabled = false;
            }
            else if (Bots[4].Text == Bots[8].Text && Bots[0].Enabled)///
            {
                Bots[0].Text = _Choice.ToString();
                Bots[0].Enabled = false;
            }
            else if (Bots[2].Text == Bots[4].Text && Bots[6].Enabled)//\
            {
                Bots[6].Text = _Choice.ToString();
                Bots[6].Enabled = false;
            }
            else if (Bots[2].Text == Bots[6].Text && Bots[4].Enabled)//\
            {
                Bots[4].Text = _Choice.ToString();
                Bots[4].Enabled = false;
            }
            else if (Bots[4].Text == Bots[6].Text && Bots[2].Enabled)//\
            {
                Bots[2].Text = _Choice.ToString();
                Bots[2].Enabled = false;
            }
            else
            {
                byte disabled = 0;
                for (int e = 0; e < 9; e++)
                {
                    if (!Bots[e].Enabled)
                    {
                        disabled++;
                    }
                    if (disabled >= 9)
                    {
                        return;
                    }

                }
                int i = 0;
                do
                {
                    i = random.Next(0, 9);
                    if (Bots[i].Enabled)
                    {
                        Bots[i].Text = _Choice.ToString();
                    }

                } while (!Bots[i].Enabled);

                Bots[i].Enabled = false;
            }

        }
        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
