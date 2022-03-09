using System;
using MySql.Data.MySqlClient;
using System.Data;


namespace AppIncorporacion2021.Config
{
    class ConexionBD
    {
        string cad_cnx;
        MySqlConnection mysqlcnn;

        public ConexionBD()
        {
            cad_cnx = "Database=sidm; Data Source=localhost;User id=root;password=oportunidades;";
        }
        public MySqlConnection GetConnection()
        {
            try
            {
                mysqlcnn = new MySqlConnection(cad_cnx);
                mysqlcnn.Open();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error: Al conectarse a la Base de datos." + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Error: Al realizar la conexion la Base de datos." + ex.Message);
            }
            
            return mysqlcnn;
        }
        public int ExecuteQuery(string SQL)
        {
            int result = 0;
            try
            {
               
                MySqlCommand MySqlCommand = new MySqlCommand(SQL, GetConnection());

                result = MySqlCommand.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error: Al ejecutar las sentencias SQL." + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }
        public MySqlDataReader GetDataReader(string SQL)
        {
            MySqlDataReader MySqlDr = null;
            try
            {
                MySqlCommand MySqlCommand = new MySqlCommand(SQL, GetConnection());
                MySqlDataAdapter MySqlDap = new MySqlDataAdapter(MySqlCommand);
                MySqlDr = MySqlCommand.ExecuteReader();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error: Al ejecutar las sentencias SQL." + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return MySqlDr;
        }
        public DataTable GetDataTabla(string SQL)
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            MySqlCommand MySqlCommand = new MySqlCommand(SQL, GetConnection());
            MySqlDataAdapter MySqlDap = new MySqlDataAdapter(MySqlCommand);
            MySqlDap.SelectCommand = MySqlCommand;
            MySqlDap.Fill(ds);
            dt = ds.Tables[0];
            return dt;


        }
    }
}
