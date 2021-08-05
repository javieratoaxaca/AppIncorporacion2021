using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;
using MySql.Data.MySqlClient;
using AppIncorporacion2021.Data;

namespace AppIncorporacion2021.Modelo
{
    class ModeloBecarios:Config.ConexionBD
    {
        public ModeloBecarios() {}

        #region METODOERROR

        //Metodo para cargar los datos del S3db en el DatagridView

        //public void CargarGrid(DataGridView grid)
        //{

        //    try
        //    {

        //        string query = string.Format("SELECT * FROM BECARIOS  ");//creamos la consulta a la base 
        //        //creamos el cmd para que se lleve el query y cargue la conexion con la DB
        //       SQLiteCommand cmd = new SQLiteCommand(query, GetConnection());

        //        SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);

        //        grid.DataSource = dt;

        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message);
        //    }


        //}
        #endregion

        #region INSERTARDATOS
        //Metodo para insertar los datos del Becario
        public bool SetBecarios(Becarios dtBecarios)
        {

            string Query = string.Format("INSERT INTO becarios (ID_PROGRAMA,NOMBRE,PRIMER_APELLIDO,SEGUNDO_APELLIDO," +
                                         "CURP,TELEFONO,EMAIL,GRADO_ESCOLAR,REGION_ID,SEDE,CVE_CCT,NOMBRE_CCT,CCT," +
                                         "MUNICIPIO_ID,CVE_LOCALIDAD,LOCALIDAD_ID,FOLIO_FORMATO,BIMESTRE,REMESA,ANIO) " +
                                         "VALUES({0},'{1}','{2}','{3}','{4}','{5}','{6}',{7},'{8}','{9}','{10}','{11}'," +
                                         "'{12}',{13},{14},{15},'{16}',{17},'{18}','{19}')",
                                        dtBecarios.Id_programa, dtBecarios.Nombre, dtBecarios.Primer_apellido, dtBecarios.Segundo_apellido,
                                        dtBecarios.Curp, dtBecarios.Telefono, dtBecarios.Email, dtBecarios.Grado_escolar,
                                        dtBecarios.Region_id, dtBecarios.Sede, dtBecarios.Cve_cct, dtBecarios.Nombre_cct,
                                        dtBecarios.Cct, dtBecarios.Municipio_id, dtBecarios.Cve_localidad, dtBecarios.Localidad_id,
                                        dtBecarios.Folio_formato, dtBecarios.Bimestre, dtBecarios.Remesa, dtBecarios.Anio);
            try
            {
                int result = ExecuteQuery(Query);
                     if (result > 0)
                        return true;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


            return false;
        }
        #endregion
        #region ExistenciaBecario
        //Metodo para saber si el becario ya Existe en la DB
        public bool ExisteBecario(int idPrograma)
        {

            Becarios dtBecario = new Becarios();
            try
            {
                string Query = string.Format("SELECT ID_PROGRAMA FROM BECARIOS WHERE ID_PROGRAMA LIKE '{0}'", idPrograma);
                MySqlDataReader dr = GetDataReader(Query);
                return dr.HasRows;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion



    }

    }
