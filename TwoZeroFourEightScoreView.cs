using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace twozerofoureight
{
    public partial class ScoreForm : Form, View
    {
        public ScoreForm()
        {
            InitializeComponent();
        }
        public void Notify(Model m)
        {
            UpdateScore(((TwoZeroFourEightModel)m).scoreUpdate());
        }
        private void UpdateScore(int x)
        {
            lblScore2.Text = Convert.ToString(x);
        }
        private void lblScore2_Click(object sender, EventArgs e)
        {

        }

        private void ScoreForm_Load(object sender, EventArgs e)
        {

        }
    }
}
