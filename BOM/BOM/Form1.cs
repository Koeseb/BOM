/* 
 * BOM
 * 2014/2015
 * Michael Koeppl, Sebastian, Martina, Bruno (fuegt eure Nachnamen bitte ein, wenn ihr sie wollt)
 * 
 * Changelog:
 *  - 2015/05/13
 *      - Login Methode entfernt, Funktionalitaet direkt in die Button onClick Methode verschoben und Login verbessert
 *      - Boilerplate
 *  - nc
 * Bugs in this file:
 *  - 
 */ 

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
        OleDbDataReader _reader;

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
            if (input_nutzerName.Text.Length >= 3 && input_pwd.Text.Length >= 6 && input_nutzerName.Text.Contains('.'))
            {
                DbManager.Connection = new OleDbConnection(Properties.Settings.Default.dbConnectionString);
                DbManager.SQLQuery = "SELECT Pwd, NutzerID FROM NUTZER WHERE LCASE(VName) = '" + input_nutzerName.Text.Split('.')[0] + "' AND LCASE(NName) = '" + input_nutzerName.Text.Split('.')[1] + "';";
                DbManager.Command = new OleDbCommand(DbManager.SQLQuery, DbManager.Connection);
                try
                {
                    DbManager.Connection.Open();
                    _reader = DbManager.Command.ExecuteReader();

                    // count the runthroughs
                    // if 0 --> no user found with given username
                    int count = 0;

                    while (_reader.Read())
                    {
                        count++;
                        if (_reader.GetValue(0).ToString() == input_pwd.Text.ToString())
                        {
                            // store user data
                            UData.Uname = input_nutzerName.Text;
                            UData.UID = int.Parse(_reader.GetValue(1).ToString());

                            _reader.Close();
                            DbManager.Connection.Close();

                            // open main window
                            this.Hide();
                            var main = new Main();
                            main.ShowDialog();
                            this.Close();

                            // exit the loop in order to avoid
                            // facing an error
                            // "tried to access closed reader"
                            break;
                        }
                        else
                        {
                            input_pwd.Text = string.Empty;
                            MessageBox.Show("Falsches Passwort.");
                            input_pwd.Focus();
                        }
                    }

                    if (count == 0)
                    {
                        MessageBox.Show("Dieser Nutzer existiert nicht.");
                        input_nutzerName.Clear();
                        input_pwd.Clear();
                        input_nutzerName.Focus();
                    }
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    _reader.Close();
                    DbManager.Connection.Close();
                }
            }
            else if (input_nutzerName.Text == string.Empty && input_pwd.Text == string.Empty)
            {
                MessageBox.Show("Bitte fuellen Sie alle Felder mit Daten.");
            }
            else if (input_nutzerName.Text.Length < 3)
            {
                MessageBox.Show("Bitte geben Sie einen gueltigen Nutzernamen mit mindestens 3 Zeichen ein.");
                input_nutzerName.Clear();
                input_pwd.Clear();
                input_nutzerName.Focus();
            }
            else if (input_pwd.Text.Length < 6)
            {
                MessageBox.Show("Bitte geben Sie ein gueltiges Passwort mit mindestens 6 Zeichen ein.");
                input_pwd.Clear();
                input_pwd.Focus();
            }
            else if (!input_nutzerName.Text.Contains('.'))
            {
                MessageBox.Show("Das ist kein korrekter Nutzername.");
                input_nutzerName.Clear();
                input_pwd.Clear();
                input_nutzerName.Focus();
            }
        }
    }
}
