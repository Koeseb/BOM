using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Data.OleDb;
using System.Globalization;

namespace BOM
{
    public partial class Main : Form
    {
        string _rechnungsArt;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            comboBox_USt.Items.Add("0%");
            comboBox_USt.Items.Add("10%");
            comboBox_USt.Items.Add("20%");
            comboBox_USt.SelectedIndex = 2;

            fillActivityList();
            fillGroupComboBox();
        }

        private void button_Book_Click(object sender, EventArgs e)
        {
            Thread bookThread = new Thread(new ThreadStart(book));

            if (radioButton_Ausgangsrechnung.Checked)
            {
                _rechnungsArt = "AR";
            }
            else if (radioButton_Eingangsrechnung.Checked)
            {
                _rechnungsArt = "ER";
            }
            double n;
            bool isNumeric = double.TryParse(input_Betrag.Text, out n);
            if (isNumeric)
            {
                bookThread.Start();
            }
            else
            {
                MessageBox.Show("Der eingegebene Betrag ist keine Zahl!");
            }
        }

        private void book()
        {
            DateTime rechnungsDatum = DateTime.Now;
            DateTime buchungsDatum = DateTime.Now;
            double betriebsAnteil = 0;
            int USt = 0;
            string beschreibung = string.Empty;
            double betrag = 0;
            int gruppe = 0;

            /*
             * need invoking because the method will be called in a new thread
             * and the GUI elements are only accessible by invoking and calling
             * them in the GUI thread
             */
            if (dateTime_Rechnungsdatum.InvokeRequired)
            {
                dateTime_Rechnungsdatum.Invoke(new MethodInvoker(delegate { rechnungsDatum = DateTime.Parse(dateTime_Rechnungsdatum.Text); }));
            }

            if (dateTime_Buchungsdatum.InvokeRequired)
            {
                dateTime_Buchungsdatum.Invoke(new MethodInvoker(delegate { buchungsDatum = DateTime.Parse(dateTime_Buchungsdatum.Text); }));
            }

            if (input_Betriebsanteil.InvokeRequired)
            {
                input_Betriebsanteil.Invoke(new MethodInvoker(delegate { betriebsAnteil = double.Parse(input_Betriebsanteil.Text); }));
            }

            if (comboBox_USt.InvokeRequired)
            {
                comboBox_USt.Invoke(new MethodInvoker(delegate { USt = int.Parse(comboBox_USt.SelectedItem.ToString().Remove(comboBox_USt.SelectedItem.ToString().IndexOf('%'))); }));
            }

            if (comboBox_Beschreibung.InvokeRequired)
            {
                comboBox_Beschreibung.Invoke(new MethodInvoker(delegate { beschreibung = comboBox_Beschreibung.Text; }));
            }

            if (input_Betrag.InvokeRequired)
            {
                input_Betrag.Invoke(new MethodInvoker(delegate { betrag = double.Parse(input_Betrag.Text); }));
            }

            if (comboBox_GruppenWahl.InvokeRequired)
            {
                comboBox_GruppenWahl.Invoke(new MethodInvoker(delegate { gruppe = int.Parse(comboBox_GruppenWahl.Text.Split(' ')[0]); }));
            }

            DbManager.SQLQuery = "INSERT INTO BUCHUNG (Rechnungsdatum, Buchungsdatum, Betriebsanteil, UST, ErstellerID, Beschreibung, RechnungsArt, Betrag, GID) VALUES (@RD, @BD, @BA, @UST, @EID, @BES, @RA, @BT, @GID);";
            DbManager.Command.CommandText = DbManager.SQLQuery;
            DbManager.Command.Parameters.AddWithValue("@RD", rechnungsDatum);
            DbManager.Command.Parameters.AddWithValue("@BD", buchungsDatum);
            DbManager.Command.Parameters.AddWithValue("@BA", betriebsAnteil);
            DbManager.Command.Parameters.AddWithValue("@UST", USt);
            DbManager.Command.Parameters.AddWithValue("@EID", UData.UID);
            DbManager.Command.Parameters.AddWithValue("@BES", beschreibung);
            DbManager.Command.Parameters.AddWithValue("@RA", _rechnungsArt);
            DbManager.Command.Parameters.AddWithValue("@BT", betrag);
            DbManager.Command.Parameters.AddWithValue("@GID", gruppe);

            try
            {
                DbManager.Connection.Open();

                // insert into buchung
                DbManager.Command.ExecuteNonQuery();
                DbManager.Command.Parameters.Clear();

                // get id of buchung
                int id = 0;
                DbManager.SQLQuery = "SELECT BelegNR FROM BUCHUNG WHERE BelegNR = (SELECT MAX(BelegNR) FROM BUCHUNG);";
                DbManager.Command.CommandText = DbManager.SQLQuery;
                var reader = DbManager.Command.ExecuteReader();
                while (reader.Read())
                {
                    id = int.Parse(reader.GetValue(0).ToString());
                }
                reader.Close();

                // insert into log
                DbManager.SQLQuery = "INSERT INTO LOG (Beschreibung, Typ, ID_Vorgang) VALUES(@BES, 'Buchung', @IDV);";
                DbManager.Command.CommandText = DbManager.SQLQuery;
                DbManager.Command.Parameters.AddWithValue("@BES", beschreibung);
                DbManager.Command.Parameters.AddWithValue("@IDV", id);
                DbManager.Command.ExecuteNonQuery();
                DbManager.Command.Parameters.Clear();

                MessageBox.Show("Buchung wurde durchgefuehrt.");
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
                DbManager.Connection.Close();
            }
        }

        private void fillActivityList()
        {
            listBox_ActivityList.Items.Clear();
            DbManager.SQLQuery = "SELECT * FROM LOG;";
            DbManager.Command.CommandText = DbManager.SQLQuery;
            try
            {
                DbManager.Connection.Open();
                var reader = DbManager.Command.ExecuteReader();
                while (reader.Read())
                {
                    listBox_ActivityList.Items.Add(
                        reader.GetValue(2).ToString() +
                        " " +
                        reader.GetValue(3).ToString() +
                        ": " +
                        reader.GetValue(1).ToString());
                }

                reader.Close();
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
                DbManager.Connection.Close();
            }
        }

        private void fillGroupComboBox()
        {
            DbManager.SQLQuery = "SELECT * FROM Gruppe;";
            DbManager.Command.CommandText = DbManager.SQLQuery;

            try
            {
                DbManager.Connection.Open();
                var reader = DbManager.Command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox_GruppenWahl.Items.Add(reader.GetValue(0).ToString() + " " + reader.GetValue(1).ToString());
                }

                comboBox_GruppenWahl.SelectedIndex = 0;

                reader.Close();
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
                DbManager.Connection.Close();
            }
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            fillActivityList();
        }
    }
}