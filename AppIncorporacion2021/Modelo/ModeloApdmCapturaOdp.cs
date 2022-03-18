using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using AppIncorporacion2021.Data;

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

           string Query = string.Format("INSERT INTO apdm_captura_odp(idPregunta,idPreguntaAnterior,idCodigoRespuesta,codigoRespuesta,respuesta,iteracion,iteracionAnidada,iteracionAnterior,iteracionAnidadaAnterior,folioEncuesta,indice)" +
                                         "VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",
                                        dtApdmCapturaOdp.Id_pregunta,
                                        dtApdmCapturaOdp.Id_pregunta_anterior,
                                        dtApdmCapturaOdp.Id_codigo_respuesta,
                                        dtApdmCapturaOdp.Codigo_respuesta,
                                        dtApdmCapturaOdp.Respuesta,
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
  

    }
}

