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

namespace BOM
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "dbDataSet.Log". Sie können sie bei Bedarf verschieben oder entfernen.
            this.logTableAdapter.Fill(this.dbDataSet.Log);
            comboBox_USt.Items.Add("0%");
            comboBox_USt.Items.Add("10%");
            comboBox_USt.Items.Add("20%");
            comboBox_USt.SelectedIndex = 2;

            fillActivityList();   
        }

        private void button_Book_Click(object sender, EventArgs e)
        {
            Thread bookThread = new Thread(new ThreadStart(book));
            bookThread.Start();
        }

        private void book()
        {
            string rechnungsDatum = string.Empty;
            string buchungsDatum = string.Empty;
            double betriebsAnteil = 0;
            int USt = 0;
            string beschreibung = string.Empty;

            /*
             * need invoking because the method will be called in a new thread
             * and the GUI elements are only accessible by invoking and calling
             * them in the GUI thread
             */
            if (dateTime_Rechnungsdatum.InvokeRequired)
            {
                dateTime_Rechnungsdatum.Invoke(new MethodInvoker(delegate { rechnungsDatum = dateTime_Rechnungsdatum.Text; }));
            }

            if (dateTime_Buchungsdatum.InvokeRequired)
            {
                dateTime_Buchungsdatum.Invoke(new MethodInvoker(delegate { buchungsDatum = dateTime_Buchungsdatum.Text; }));
            }

            if (input_Betriebsanteil.InvokeRequired)
            {
                input_Betriebsanteil.Invoke(new MethodInvoker(delegate { betriebsAnteil = double.Parse(input_Betriebsanteil.Text); }));
            }

            if (comboBox_USt.InvokeRequired)
            {
                comboBox_USt.Invoke(new MethodInvoker(delegate { USt = int.Parse(comboBox_USt.SelectedItem.ToString().Remove(comboBox_USt.SelectedItem.ToString().IndexOf('%'))); }));
            }

            if (input_Beschreibung.InvokeRequired)
            {
                input_Beschreibung.Invoke(new MethodInvoker(delegate { beschreibung = input_Beschreibung.Text; }));
            }

            DbManager.SQLQuery = "INSERT INTO BUCHUNG (Rechnungsdatum, Buchungsdatum, Betriebsanteil, UST, ErstellerID, Beschreibung) VALUES (@RD, @BD, @BA, @UST, @EID, @BES);";
            DbManager.Command.CommandText = DbManager.SQLQuery;
            DbManager.Command.Parameters.AddWithValue("@RD", rechnungsDatum);
            DbManager.Command.Parameters.AddWithValue("@BD", buchungsDatum);
            DbManager.Command.Parameters.AddWithValue("@BA", betriebsAnteil);
            DbManager.Command.Parameters.AddWithValue("@UST", USt);
            DbManager.Command.Parameters.AddWithValue("@EID", UData.UID);
            DbManager.Command.Parameters.AddWithValue("@BES", beschreibung);

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
                while(reader.Read()){
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
            ListBox_ActivityList.Items.Clear();
            DbManager.SQLQuery = "SELECT * FROM LOG;";
            DbManager.Command.CommandText = DbManager.SQLQuery;
            try
            {
                DbManager.Connection.Open();
                var reader = DbManager.Command.ExecuteReader();
                while (reader.Read())
                {
                    ListBox_ActivityList.Items.Add(
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

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            fillActivityList();
        }
    }
}