using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BOM
{
    public partial class Main : Form
    {
        string[] topicList = { "Aktivitaeten", "Buchungen", "Fahrtenbuch" };

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // examples
            ListBox_ActivityList.Items.Add("Franz Mueller hat 2543 Euro abgebucht (Grund: Kaffeemaschine kaputt).\n");
            ListBox_ActivityList.Items.Add("Ramasan Butaki hat fuer 300 Euro einen Schrank gekauft.\n");
            ListBox_ActivityList.Items.Add("Marus Troester hat 20 Euro abgebucht (Grund: Nach Neuseeland fliegen.)\n");
        }

        private void Label_Rechnungsdatum_Click(object sender, EventArgs e)
        {

        }
    }
}