using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using AppIncorporacion2021.Data;

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

