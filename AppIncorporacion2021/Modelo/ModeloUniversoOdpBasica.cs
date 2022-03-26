using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;


namespace AppIncorporacion2021.Modelo
{
    class ModeloUniversoOdpBasica : Config.ConexionBD
    {
        //creamos el constructor
        public ModeloUniversoOdpBasica() { }
        #region CargarGridMain 
        public void CargarGrid(DataGridView grid)
        {

            try
            {

                string query = string.Format("SELECT idRegion AS IDREGION,nomRegion as REGION,cveOfiLocalidad as CLAVE_OFICIAL,cveMunicipio as CLAVE_MUN,nomMunicipio as MUNICIPIO,cveLocalidad as CLAVE_LOC,"+ "nomLocalidad as LOCALIDAD,idIntegrante as ID_INTEGRANTE,idFamilia as ID_FAMILIA,nomTutora as TUTORA,apPatTutora as PATERNO_TUTORA,apMatTutora as MATERNO_TUTORA,nomLiquidadora as LIQUIDADORA,modalidad as MODALIDAD,bimPago as BIMESTRE_PAGO,folioFormato as FORMATO,remesa as REMESA FROM universo_odps_basica ORDER BY idRegion ");//creamos la consulta a la base 
                //creamos el cmd para que se lleve el query y cargue la conexion con la DB
                MySqlCommand cmd = new MySqlCommand(query, GetConnection());

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                grid.DataSource = dt;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


        }
        #endregion
        public DataTable CargarCmbRegion()
        {


            try
            {

                string query = string.Format("SELECT idRegion,nomRegion FROM regiones");//creamos la consulta a la base 
                //creamos el cmd para que se lleve el query y cargue la conexion con la DB
                MySqlCommand cmd = new MySqlCommand(query, GetConnection());

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
           
        }
        public void CargarGridRegion(DataGridView grid, int idRegion)
        {
            

            try
            {

                string query = string.Format("SELECT idRegion AS IDREGION,nomRegion as REGION,cveOfiLocalidad as CLAVE_OFICIAL,cveMunicipio as CLAVE_MUN,nomMunicipio as MUNICIPIO,cveLocalidad as CLAVE_LOC," + "nomLocalidad as LOCALIDAD,idIntegrante as ID_INTEGRANTE,idFamilia as ID_FAMILIA,nomTutora as TUTORA,apPatTutora as PATERNO_TUTORA,apMatTutora as MATERNO_TUTORA,nomLiquidadora as LIQUIDADORA,modalidad as MODALIDAD,bimPago as BIMESTRE_PAGO,folioFormato as FORMATO,remesa as REMESA FROM universo_odps_basica where idRegion='{0}'",idRegion);//creamos la consulta a la base 
                //creamos el cmd para que se lleve el query y cargue la conexion con la DB
                MySqlCommand cmd = new MySqlCommand(query, GetConnection());

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

              grid.DataSource = dt;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


        }
        public void CargarGridBuscar(DataGridView grid, string txtBuscar)
        {


            try
            {

                string query = string.Format("SELECT idRegion AS IDREGION,nomRegion as REGION,cveOfiLocalidad as CLAVE_OFICIAL,cveMunicipio as CLAVE_MUN,nomMunicipio as MUNICIPIO,cveLocalidad as CLAVE_LOC," + "nomLocalidad as LOCALIDAD,idIntegrante as ID_INTEGRANTE,idFamilia as ID_FAMILIA,nomTutora as TUTORA,apPatTutora as PATERNO_TUTORA,apMatTutora as MATERNO_TUTORA,nomLiquidadora as LIQUIDADORA,modalidad as MODALIDAD,bimPago as BIMESTRE_PAGO,folioFormato as FORMATO,remesa as REMESA FROM universo_odps_basica WHERE nomTutora LIKE '%{0}%' OR apPatTutora LIKE '%{0}%' OR apMatTutora LIKE '%{0}%' OR folioFormato LIKE '%{0}%' OR idFamilia LIKE '%{0}%' ", txtBuscar);//creamos la consulta a la base 
                //creamos el cmd para que se lleve el query y cargue la conexion con la DB
                MySqlCommand cmd = new MySqlCommand(query, GetConnection());

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                grid.DataSource = dt;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


        }
        #region CargarGridBuscar
        //public List<Object> consulta(string dato)
        //{
        //    MySqlDataReader rd;
        //    List<Object> lista = new List<object>();
        //    string query;
        //    if (dato==null)
        //    {
        //        query = "SELECT IdIncorporacion,REGION,NOM_REG,CLAVEOFI,MUN,MUNICIPIO,LOC,LOCALIDAD,FAMILIA_ID,FOLIO_ENCUESTA,TUTORA,PATERNO_TUTOR,MATERNO_TUTOR,AVISO_COBRO,CR_CRIS,CR_NOTIFICACION,CR_AVISO_COBRO,ESCOLAR FROM nominainco ORDER BY REGION ";
        //    }
        //    else
        //    {
        //        query = "SELECT IdIncorporacion,REGION,NOM_REG,CLAVEOFI,MUN,MUNICIPIO,LOC,LOCALIDAD,FAMILIA_ID,FOLIO_ENCUESTA,TUTORA,PATERNO_TUTOR,MATERNO_TUTOR,AVISO_COBRO,CR_CRIS,CR_NOTIFICACION,CR_AVISO_COBRO,ESCOLAR" +
        //            " FROM nominainco"+
        //            " WHERE IdIncorporacion LIKE'%" + dato
        //            + "%' OR REGION LIKE'%" + dato
        //            + "%' OR NOM_REG LIKE'%"+dato
        //            + "%' OR CLAVEOFI LIKE'%" + dato
        //            + "%' OR MUN LIKE'%" + dato
        //            + "%' OR MUNICIPIO LIKE'%" + dato
        //            + "%' OR LOC LIKE'%" + dato
        //            + "%' OR LOCALIDAD LIKE'%" + dato
        //            + "%' OR FAMILIA_ID LIKE'%" + dato
        //            + "%' OR FOLIO_ENCUESTA LIKE'%" + dato
        //            + "%' OR TUTORA LIKE'%" + dato
        //            + "%' OR PATERNO_TUTOR LIKE'%" + dato
        //            + "%' OR MATERNO_TUTOR LIKE'%" + dato
        //            + "%' OR AVISO_COBRO LIKE'%" + dato
        //            + "%' OR CR_CRIS LIKE'%" + dato
        //            + "%' OR CR_NOTIFICACION LIKE'%" + dato
        //            + "%' OR CR_AVISO_COBRO LIKE'%" + dato
        //            + "%' OR ESCOLAR LIKE'%" + dato
        //            + "%' ORDER BY REGION DESC";
        //    }
        //    try
        //    {
        //        MySqlCommand cmd = new MySqlCommand(query, GetConnection());
        //        rd = cmd.ExecuteReader();

        //        while (rd.Read())
        //        {
        //            Incorporacion dtIncorporacion = new Incorporacion();
        //            dtIncorporacion.Idincorporacion = rd.GetInt32(0).ToString();
        //            dtIncorporacion.Region = rd.GetString(1).ToString();
        //            dtIncorporacion.Nom_Reg = rd.GetString(2).ToString();
        //            dtIncorporacion.Claveofi = rd.GetString(3).ToString();
        //            dtIncorporacion.Mun = rd.GetString(4).ToString();
        //            dtIncorporacion.Municipio = rd.GetString(5).ToString();
        //            dtIncorporacion.Loc = rd.GetString(6).ToString();
        //            dtIncorporacion.Localidad = rd.GetString(7).ToString();
        //            dtIncorporacion.Familia_Id = rd.GetString(8).ToString();
        //            dtIncorporacion.Folio_Encuesta = rd.GetString(9).ToString();
        //            dtIncorporacion.Tutora = rd.GetString(10).ToString();
        //            dtIncorporacion.Paterno_Tutor = rd[11].ToString();
        //            dtIncorporacion.Materno_Tutor = rd[12].ToString();
        //            dtIncorporacion.Aviso_Cobro = rd.GetString(13).ToString();
        //            dtIncorporacion.Cr_Cris = rd.GetString(14).ToString();
        //            dtIncorporacion.Cr_Notificacion = rd.GetString(15).ToString();
        //            dtIncorporacion.Cr_Aviso_Cobro = rd.GetString(16).ToString();
        //            dtIncorporacion.Escolar = rd.GetString(17).ToString();
        //            lista.Add(dtIncorporacion);

        //        }
        //    }
        //    catch (MySqlException ex)
        //    {
        //        throw new Exception("Error: Al ejecutar las sentencias SQL." + ex.Message);
        //    }
        //    return lista;
        //}
        #endregion

        //Metodo para saber el total de CRIS
        private void tutorasBecas()
        {

            try
            {

                string query = string.Format("SELECT COUNT(FAMILIA_ID) FROM NOMINAINCO WHERE CR_CRIS='SE APLICO LA ENCUESTA'");
                //creamos el cmd para que se lleve el query y cargue la conexion con la DB
                MySqlCommand cmd = new MySqlCommand(query, GetConnection());
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
