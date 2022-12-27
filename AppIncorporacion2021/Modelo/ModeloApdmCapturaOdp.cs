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
    class ModeloApdmCapturaOdp:Config.ConexionBD
    {
        public ModeloApdmCapturaOdp() { }

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
        public bool setApdmCapturaOdp(apdmCapturaOdp dtApdmCapturaOdp)
        {
           // string respuesta = dtApdmCapturaOdp.Respuesta.Replace("'","");
           string Query = string.Format("INSERT INTO apdm_captura_odp(idPregunta,idPreguntaAnterior,idCodigoRespuesta,codigoRespuesta,respuesta,iteracion,iteracionAnidada,iteracionAnterior,iteracionAnidadaAnterior,folioEncuesta,indice)" +
                                         "VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",
                                        dtApdmCapturaOdp.Id_pregunta,
                                        dtApdmCapturaOdp.Id_pregunta_anterior,
                                        dtApdmCapturaOdp.Id_codigo_respuesta,
                                        dtApdmCapturaOdp.Codigo_respuesta,
                                        dtApdmCapturaOdp.Respuesta.Replace("'", " "),
                                        dtApdmCapturaOdp.Iteracion,
                                        dtApdmCapturaOdp.Iteracion_anidada,
                                        dtApdmCapturaOdp.Iteracion_anterior,
                                        dtApdmCapturaOdp.Iteracion_anidada_anterior,
                                        dtApdmCapturaOdp.Folio_encuesta,
                                        dtApdmCapturaOdp.Indice);
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



        public void CargarGridODP(DataGridView grid)
        {

            try
            {

                string query = string.Format("SELECT A.folioEncuesta, A.RESPUESTA FOLIO_FORMATO, B.FECHA_CAPTURA,B.CUPO, CONCAT('20',SUBSTR(MUN.RESPUESTA,1,3),SUBSTR(LOC.RESPUESTA,1,4)) as CVELOCALIDAD, MUN.RESPUESTA AS MUNICIPIO,LOC.RESPUESTA AS LOCALIDAD FROM apdm_captura_odp as A INNER JOIN apdm_resumen_encuesta_odp AS B  ON A.folioEncuesta = B.FOLIO_ENCUESTA INNER JOIN apdm_codigos_respuesta AS C ON A.idCodigoRespuesta = C.idCodigoRespuesta INNER JOIN(SELECT A1.folioEncuesta, A1.RESPUESTA FROM apdm_captura_odp A1 INNER JOIN apdm_codigos_respuesta B1 ON B1.idCodigoRespuesta = A1.idCodigoRespuesta WHERE B1.TEXTO_RESPUESTA = 'Localidad' GROUP BY A1.folioEncuesta, A1.RESPUESTA) AS LOC ON LOC.folioEncuesta = A.folioEncuesta INNER JOIN(SELECT A1.folioEncuesta, A1.RESPUESTA FROM apdm_captura_odp A1 INNER JOIN apdm_codigos_respuesta B1 ON B1.idCodigoRespuesta = A1.idCodigoRespuesta WHERE B1.TEXTO_RESPUESTA = 'Municipio' GROUP BY A1.folioEncuesta, A1.RESPUESTA) AS MUN ON MUN.folioEncuesta = A.folioEncuesta WHERE C.TEXTO_RESPUESTA = 'folioFormato'; ");//creamos la consulta a la base 
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
    }
}

