using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIN_QuiEstCe
{
    public partial class RestartModal: Form
    {
        public RestartModal(int score)
        {
            InitializeComponent();
            lblScore.Text += score;
        }
    }
}
