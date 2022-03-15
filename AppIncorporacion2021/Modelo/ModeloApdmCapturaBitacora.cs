using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using AppIncorporacion2021.Data;

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
  

    }
}

