using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace BOM
{
    static class DbManager
    {
        static OleDbConnection _con;
        static OleDbCommand _cmd;
        static string _query;

        public static OleDbConnection Connection
        {
            get
            {
                return _con;
            }
            set
            {
                _con = value;
            }
        }

        public static OleDbCommand Command
        {
            get
            {
                return _cmd;
            }
            set
            {
                _cmd = value;
            }
        }

        public static string SQLQuery
        {
            get
            {
                return _query;
            }
            set
            {
                _query = value;
            }
        }

        public static void setSQLQuery(string q)
        {
            _query = q;
        }

        public static void executeQuery(out object dbo)
        {
            dbo = null;
        }
    }
}
