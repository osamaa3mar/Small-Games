﻿using System;
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
    public partial class ResultForm : Form
    {

        public ResultForm()
        {
            InitializeComponent();
        }
        public void ChangeResult(string Result)
        {
            ResultLabel.Text = Result;
        }
        


    }
}
