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
    class ModeloApdmCapturaBitacora:Config.ConexionBD
    {
        public ModeloApdmCapturaBitacora() { }

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
        public bool setApdmCapturaBitacora(apdmCapturaBitacora dtadpmCapturaBitacora)
        {

           string Query = string.Format("INSERT INTO apdm_captura_bitacora(id_pregunta,id_pregunta_anterior,id_codigo_respuesta,codigo_respuesta,respuesta,iteracion,iteracion_anidada,iteracion_anterior,iteracion_anidada_anterior,folio_encuesta,indice)" +
                                         "VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",
                                        dtadpmCapturaBitacora.Id_pregunta,
                                        dtadpmCapturaBitacora.Id_pregunta_anterior,
                                        dtadpmCapturaBitacora.Id_codigo_respuesta,
                                        dtadpmCapturaBitacora.Codigo_respuesta,
                                        dtadpmCapturaBitacora.Respuesta,
                                        dtadpmCapturaBitacora.Iteracion,
                                        dtadpmCapturaBitacora.Iteracion_anidada,
                                        dtadpmCapturaBitacora.Iteracion_anterior,
                                        dtadpmCapturaBitacora.Iteracion_anidada_anterior,
                                        dtadpmCapturaBitacora.Folio_encuesta,
                                        dtadpmCapturaBitacora.Indice);
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

        public void CargarGridBitacora(DataGridView grid)
        {

            try
            {

                string query = string.Format("SELECT A.folio_encuesta, SUBSTR(A.RESPUESTA,1,9) as CVE_LOCAL_SEDE, A.RESPUESTA SEDE, B.FECHA_CAPTURA,B.CUPO,MUN.RESPUESTA AS MUNICIPIO,LOC.RESPUESTA AS LOCALIDAD,TIT.RESPUESTA AS TITULARESCOBRO, BIM.RESPUESTA as BIMESTRE FROM apdm_captura_bitacora as A INNER JOIN apdm_resumen_encuesta_bitacora AS B  ON A.folio_encuesta = B.FOLIO_ENCUESTA INNER JOIN apdm_codigos_respuesta AS C ON A.id_codigo_respuesta = C.idCodigoRespuesta INNER JOIN(SELECT A1.folio_encuesta, A1.RESPUESTA FROM apdm_captura_bitacora A1 INNER JOIN apdm_codigos_respuesta B1 ON B1.idCodigoRespuesta = A1.id_codigo_respuesta WHERE B1.TEXTO_RESPUESTA = 'Localidad' GROUP BY A1.folio_encuesta, A1.RESPUESTA) AS LOC ON LOC.FOLIO_ENCUESTA = A.folio_encuesta INNER JOIN(SELECT A1.folio_encuesta, A1.RESPUESTA FROM apdm_captura_bitacora A1 INNER JOIN apdm_codigos_respuesta B1 ON B1.idCodigoRespuesta = A1.id_codigo_respuesta WHERE B1.TEXTO_RESPUESTA = 'Municipio' GROUP BY A1.folio_encuesta, A1.RESPUESTA) AS MUN ON MUN.FOLIO_ENCUESTA = A.folio_encuesta INNER JOIN(SELECT A1.folio_encuesta, A1.RESPUESTA FROM apdm_captura_bitacora A1 INNER JOIN apdm_codigos_respuesta B1 ON B1.idCodigoRespuesta = A1.id_codigo_respuesta WHERE B1.TEXTO_RESPUESTA = 'titularesCobroApoyo' GROUP BY A1.folio_encuesta, A1.RESPUESTA) AS TIT ON TIT.FOLIO_ENCUESTA = A.folio_encuesta INNER JOIN(SELECT A1.folio_encuesta, A1.RESPUESTA FROM apdm_captura_bitacora A1 INNER JOIN apdm_codigos_respuesta B1 ON B1.idCodigoRespuesta = A1.id_codigo_respuesta WHERE B1.TEXTO_RESPUESTA = 'BimOperacion' and A1.respuesta='JULIO-AGOSTO 2022' GROUP BY A1.folio_encuesta, A1.RESPUESTA) AS BIM ON BIM.FOLIO_ENCUESTA = A.folio_encuesta WHERE C.TEXTO_RESPUESTA = 'Sede'; ");//creamos la consulta a la base 
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

