﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class sudokuForm : Form
    {
        TextBox[,] m_vals = new TextBox[9, 9];
        public sudokuForm()
        {
            InitializeComponent();
        }
        public void fillArray()
        {
            int r = 0;
            int c = 0;

            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {

                }
            }
        }

        public void getRowCol(TextBox c, out int row, out int col)
        {
            string n = c.Name;
            string num = n.Substring(n.Length - 2);
            int pos;
            int.TryParse(num, out pos);

            if (pos == 0)
            {
                int.TryParse(num.Substring(0, 1), out pos);
            }
        }
    }
}
