using System;
using System.Data;
using System.Data.SQLite;


namespace AppIncorporacion2021.Config
{
    public class ConexionSQLite
    {
        private string cad_sqlite;
        private SQLiteConnection sqlitecnn;
         public ConexionSQLite()
        {
            
            
        }
        public SQLiteConnection GetConnection(string ruta )
        {
            cad_sqlite = @"Data Source="+ruta;

            try
            {
                 sqlitecnn = new SQLiteConnection(cad_sqlite);
                sqlitecnn.Open();
            }
            catch (SQLiteException ex)
            {
                throw new SQLiteException("Error: Al conectarse a la Base de datos." + ex.Message);
            }
            

            return null;
        }

        public DataTable GetData(string sql)
        {
            SQLiteCommand cmd = new SQLiteCommand(sql, sqlitecnn);
            
            SQLiteDataReader dr= cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
    }
}
