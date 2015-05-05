using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Windows.Forms;

namespace BOM
{
    public class DBase
    {
        public OleDbConnection con { get; set; }
        public OleDbCommand cmd { get; set; }
        public OleDbDataReader reader { get; set; }

        public DBase()
        {
            con = new OleDbConnection(Properties.Settings.Default.dbConnectionString);
        }

        public OleDbDataReader select(string query)
        {
            cmd = new OleDbCommand(query, con);

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();

                // just return the reader as the data source
                return reader;
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
            finally
            {
                reader.Close();
                con.Close();
            }
        }

        public void insert(string query)
        {
            con.Open();
            cmd = new OleDbCommand(query, con);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        public void update(string query)
        {
            con.Open();
            cmd = new OleDbCommand(query, con);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
    }
}
