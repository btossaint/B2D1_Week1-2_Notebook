using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B2D1_Week1_2_Notebook
{
    public partial class Form1 : Form
    {
        private Notebook myNotebook;
        public Form1()
        {
            InitializeComponent();
            myNotebook = new Notebook();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myNotebook.storeNote(tbNotitie.Text);
        }

        private void bLees_Click(object sender, EventArgs e)
        {
            myNotebook.showNote(Convert.ToInt32(tbNoteNummer.Text));
        }

        private void bAantal_Click(object sender, EventArgs e)
        {
            lNummer.Text = myNotebook.numberOfNotes().ToString();
        }
    }
}
