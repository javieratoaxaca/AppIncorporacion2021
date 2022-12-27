using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using AppIncorporacion2021.Data;
using System.Windows.Forms;
using System.Data;
namespace AppIncorporacion2021.Modelo
{
    class ModeloApdmCapturaCerm:Config.ConexionBD
    {
        public ModeloApdmCapturaCerm() { }

        private string _addSQL;
        public string AddSQL
        {
            get
            {
                return _addSQL;
            }
            set
            {
                _addSQL = value;

            }
        }

        public void CargarGridCerm(DataGridView grid)
        {

            try
            {

                string query = string.Format("SELECT A.folioEncuesta, A.RESPUESTA FOLIO_FORMATO, B.FECHA_CAPTURA,B.CUPO,MUN.RESPUESTA AS MUNICIPIO,LOC.RESPUESTA AS LOCALIDAD FROM apdm_captura_cerm as A INNER JOIN apdm_resumen_encuesta_cerm AS B  ON A.folioEncuesta = B.FOLIO_ENCUESTA INNER JOIN apdm_codigos_respuesta AS C ON A.idCodigoRespuesta = C.idCodigoRespuesta INNER JOIN(SELECT A1.folioEncuesta, A1.RESPUESTA FROM apdm_captura_cerm A1 INNER JOIN apdm_codigos_respuesta B1 ON B1.idCodigoRespuesta = A1.idCodigoRespuesta WHERE B1.TEXTO_RESPUESTA = 'Localidad' GROUP BY A1.folioEncuesta, A1.RESPUESTA) AS LOC ON LOC.folioEncuesta = A.folioEncuesta INNER JOIN(SELECT A1.folioEncuesta, A1.RESPUESTA FROM apdm_captura_cerm A1 INNER JOIN apdm_codigos_respuesta B1 ON B1.idCodigoRespuesta = A1.idCodigoRespuesta WHERE B1.TEXTO_RESPUESTA = 'Municipio' GROUP BY A1.folioEncuesta, A1.RESPUESTA) AS MUN ON MUN.folioEncuesta = A.folioEncuesta WHERE C.TEXTO_RESPUESTA = 'folioCerm'; ");//creamos la consulta a la base 
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
        public bool setApdmCapturaCerm(apdmCapturaCerm dtApdmCapturaCerm)
        {

           string Query = string.Format("INSERT INTO apdm_captura_cerm(idPregunta,idPreguntaAnterior,idCodigoRespuesta,codigoRespuesta,respuesta,iteracion,iteracionAnidada,iteracionAnterior,iteracionAnidadaAnterior,folioEncuesta,indice)" +
                                         "VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",
                                        dtApdmCapturaCerm.Id_pregunta, dtApdmCapturaCerm.Id_pregunta_anterior, dtApdmCapturaCerm.Id_codigo_respuesta, dtApdmCapturaCerm.Codigo_respuesta, dtApdmCapturaCerm.Respuesta, dtApdmCapturaCerm.Iteracion, dtApdmCapturaCerm.Iteracion_anidada, dtApdmCapturaCerm.Iteracion_anterior, dtApdmCapturaCerm.Iteracion_anidada_anterior, dtApdmCapturaCerm.Folio_encuesta, dtApdmCapturaCerm.Indice);
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
        public bool Procesar()
        {
            try
            {
                var result = ExecuteQuery(AddSQL);
                if (result > 0)
                    return true;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


            return false;
        }
  

    }
}

