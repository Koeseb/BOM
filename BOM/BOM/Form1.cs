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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Anmelden_Click(object sender, EventArgs e)
        {
            if (input_nutzerName.Text.Length >= 3 && input_pwd.Text.Length >= 6)
            {
                MessageBox.Show("Uname: " + input_nutzerName.Text + "\tPw: " + input_pwd.Text);
            } else if (input_nutzerName.Text == string.Empty && input_pwd.Text == string.Empty) {
                MessageBox.Show("Bitte fuellen Sie alle Felder mit Daten.");
            } else if(input_nutzerName.Text.Length < 3){
                MessageBox.Show("Bitte geben Sie einen gueltigen Nutzernamen mit mindestens 3 Zeichen ein.");
            } else if(input_pwd.Text.Length < 6){
                MessageBox.Show("Bitte geben Sie ein gueltiges Passwort mit mindestens 6 Zeichen ein.");
            }
        }
    }
}
