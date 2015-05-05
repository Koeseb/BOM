using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data.OleDb;
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
            var loginSuccessful = false;

            if (input_nutzerName.Text.Length >= 3 && input_pwd.Text.Length >= 6 && input_nutzerName.Text.Contains('.'))
            {
                loginSuccessful = login(input_nutzerName.Text, input_pwd.Text);   
            } else if (input_nutzerName.Text == string.Empty && input_pwd.Text == string.Empty) {
                MessageBox.Show("Bitte fuellen Sie alle Felder mit Daten.");
            } else if(input_nutzerName.Text.Length < 3){
                MessageBox.Show("Bitte geben Sie einen gueltigen Nutzernamen mit mindestens 3 Zeichen ein.");
            } else if(input_pwd.Text.Length < 6){
                MessageBox.Show("Bitte geben Sie ein gueltiges Passwort mit mindestens 6 Zeichen ein.");
            } else if (!input_nutzerName.Text.Contains('.')){
                MessageBox.Show("Das ist kein korrekter Nutzername.");
            }

            if (loginSuccessful)
            {
                this.Hide();
                var main = new Main();
                main.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Falsche Eingaben.");
                input_nutzerName.Text = string.Empty;
                input_pwd.Text = string.Empty;
            }
        }

        bool login(string nn, string pwd)
        {
            var con = new OleDbConnection(Properties.Settings.Default.dbConnectionString);
            var cmd = new OleDbCommand(("SELECT Pwd FROM NUTZER WHERE LCASE(VName) = '" + nn.Split('.')[0] + "' AND LCASE(NName) = '" + nn.Split('.')[1] + "';"), con);
            con.Open();
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (reader.GetValue(0).ToString() == pwd.ToString())
                {
                    reader.Close();
                    con.Close();
                    return true;
                }
                else
                {
                    MessageBox.Show("Das eingegebene Passwort ist nicht korrekt.");
                }
            }

            reader.Close();
            con.Close();
            return false;
        }
    }
}
