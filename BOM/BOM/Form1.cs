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
            input_nutzerName.KeyDown += new KeyEventHandler(enter_KeyDown);
            input_pwd.KeyDown += new KeyEventHandler(enter_KeyDown);
        }

        public void enter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                button_Anmelden.PerformClick();
            }
        }

        private void button_Anmelden_Click(object sender, EventArgs e)
        {
            if (input_nutzerName.Text.Length >= 3 && input_pwd.Text.Length >= 6)
            {
                if (true /*if username exists and if password is correct*/)
                {
                    this.Hide();
                    var main = new Main();
                    main.ShowDialog();
                    this.Close();
                }
                else // vorerst unerreichbar
                {
                    MessageBox.Show("Der Nutzername oder das Passwort ist falsch.");
                }
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
