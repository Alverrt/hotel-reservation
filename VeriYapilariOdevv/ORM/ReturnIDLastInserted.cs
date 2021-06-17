using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariOdevv.ORM
{
    class ReturnIDLastInserted
    {
        public object GetIDOfLastInserted(SQLiteConnection conn, string column)
        {


            string query = "SELECT last_insert_rowid();";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            try
            {
                object hey = cmd.ExecuteScalar();
                conn.Close();
                return hey;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
        }
    }
}
