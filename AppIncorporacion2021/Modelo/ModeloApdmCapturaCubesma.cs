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
    class ModeloApdmCapturaCubesma : Config.ConexionBD
    {
        public ModeloApdmCapturaCubesma() { }

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

        public bool setApdmCapturaCubesma(apdmCapturaCubesma dtApdmCapturaCubesma)
        {

            string Query = string.Format("INSERT INTO apdm_captura_cubesma(idPregunta,idPreguntaAnterior,idCodigoRespuesta,codigoRespuesta,respuesta,iteracion,iteracionAnidada,iteracionAnterior,iteracionAnidadaAnterior,folioEncuesta,indice)" +
                                          "VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",
                                         dtApdmCapturaCubesma.Id_pregunta, dtApdmCapturaCubesma.Id_pregunta_anterior, dtApdmCapturaCubesma.Id_codigo_respuesta, dtApdmCapturaCubesma.Codigo_respuesta, dtApdmCapturaCubesma.Respuesta, dtApdmCapturaCubesma.Iteracion, dtApdmCapturaCubesma.Iteracion_anidada, dtApdmCapturaCubesma.Iteracion_anterior, dtApdmCapturaCubesma.Iteracion_anidada_anterior, dtApdmCapturaCubesma.Folio_encuesta, dtApdmCapturaCubesma.Indice);
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
