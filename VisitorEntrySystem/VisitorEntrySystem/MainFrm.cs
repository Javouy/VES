using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisitorEntrySystem
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void visitorInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visitor_Info Ivisitor = new Visitor_Info();
            Ivisitor.Show();
            this.Hide();
        }

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrationFrm register = new RegistrationFrm();
            register.Show();
            this.Hide();
        }

        private void newUserToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
