using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.Models;

namespace Test
{
    public partial class PositionForm : Form
    {
        public Position Position { get; set; }

        public PositionForm()
        {
            InitializeComponent();
        }

        public PositionForm(Position pos) : this()
        {
            Position = pos ?? new Position();
            position.Text = Position.PositionName;
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            Position = Position ?? new Position();
            Position.PositionName = position.Text;
            Close();
        }
    }
}
