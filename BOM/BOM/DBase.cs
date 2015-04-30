using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;

namespace BOM
{
    public class DBase
    {
        OleDbConnection con { get; set; }
        OleDbCommand cmd { get; set; }

        public DBase()
        {
            con = new OleDbConnection(Properties.Settings.Default.dbConnectionString);
        }

        public void select(string query)
        {
            cmd = new OleDbCommand(query, con);

            con.Open();

            OleDbDataReader reader;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.Write(reader.GetString(0).ToString());
            }

            reader.Close();
            con.Close();
        }
    }
}
