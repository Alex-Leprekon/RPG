using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            List<Character> command1 = new List<Character>();
            List<Character> command2 = new List<Character>();
            foreach (Character c in this.Controls)
            {
                if (c.Tag == "c1")
                {
                    command1.Add(c);
                }
                if (c.Tag == "c2")
                {
                    command2.Add(c);
                }
            }
        }
    }
}
