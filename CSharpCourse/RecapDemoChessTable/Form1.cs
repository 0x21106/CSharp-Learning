using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemoChessTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initChessTable();
        }

        private void initChessTable()
        {
            Button[,] buttons = new Button[8, 8];
            int top = 0;
            int left = 0;

            for (int a = 0; a < buttons.GetUpperBound(0); a++)
            {
                for (int b = 0; b < buttons.GetUpperBound(1); b++)
                {
                    buttons[a, b] = new Button();
                    buttons[a, b].Width = 50;
                    buttons[a, b].Height = 50;
                    buttons[a, b].Left = left;
                    buttons[a, b].Top = top;
                    left += 50;
                    if ((a + b) % 2 == 0)
                    {
                        buttons[a, b].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[a, b].BackColor = Color.White;
                    }
                    this.Controls.Add(buttons[a, b]);
                }
                left = 0;
                top += 50;
            }
        }
    }
}
