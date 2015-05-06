using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace BOM
{
    static class DbManager
    {   
        static OleDbConnection con;
        static OleDbCommand cmd;
        static string query;
        
        public static OleDbConnection Connection{
            get{
                return con;
            }
            set{
                con = value;    
            }
        }
        
        public static OleDbCommand Command{
            get{
                return cmd;
            }
            set{
                cmd = value;
            }
        }
        
        public static string SQLQuery{
            get{
                return query;
            }
            set{
                query = value;
            }
        }
        
        public static void setSQLQuery(string q){
            query = q;
        }

        public static void executeQuery(out object dbo)
        {
            dbo = null;
        }
    }
}
