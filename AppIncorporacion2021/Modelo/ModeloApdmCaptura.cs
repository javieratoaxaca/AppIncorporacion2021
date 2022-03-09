using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using AppIncorporacion2021.Data;

namespace AppIncorporacion2021.Modelo
{
    class ModeloApdmCaptura:Config.ConexionBD
    {
        public ModeloApdmCaptura() { }

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
        public bool setApdmCaptura(apdmCaptura dtApdmCaptura)
        {

            string Query = string.Format("INSERT INTO apdm_captura (id_pregunta,id_pregunta_anterior,id_codigo_respuesta,codigo_respuesta,respuesta,iteracion,iteracion_anidada,iteracion_anterior,iteracion_anidada_anterior,folio_encuesta,indice)" +
                                         "VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",
                                        dtApdmCaptura.Id_pregunta,dtApdmCaptura.Id_pregunta_anterior,dtApdmCaptura.Id_codigo_respuesta,dtApdmCaptura.Codigo_respuesta,dtApdmCaptura.Respuesta,dtApdmCaptura.Iteracion,dtApdmCaptura.Iteracion_anidada,dtApdmCaptura.Iteracion_anterior,dtApdmCaptura.Iteracion_anidada_anterior,dtApdmCaptura.Folio_encuesta,dtApdmCaptura.Indice);
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

