using System;
using AppIncorporacion2021.Data;

namespace AppIncorporacion2021.Modelo
{
    class ModeloApdmResumenCapturaCerm:Config.ConexionBD
    {
        public ModeloApdmResumenCapturaCerm() { }

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
        public bool setApdmResCapturaCerm(apdmResumenCapturaCerm dtApdmResCapturaCerm)
        {

           string Query = string.Format("INSERT INTO apdm_resumen_encuesta_cerm(FOLIO_ENCUESTA,ID_ENCUESTA,ID_PROCESO,CUPO,USUARIO_CAPTURA_DM,HORA_INICIO,HORA_FIN,FECHA_CAPTURA,ESTADO_ID,MUNICIPIO_ID,CLAVE_LOCALIDAD,CLAVE_AGEB,AGEB_ID,GPS_LONGITUD,GPS_LATITUD)" +
                                         "VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}')",
                                            dtApdmResCapturaCerm.Folio_encuesta,
                                            dtApdmResCapturaCerm.IdEncuesta,
                                            dtApdmResCapturaCerm.IdProceso,
                                            dtApdmResCapturaCerm.Cupo,
                                            dtApdmResCapturaCerm.UsuarioCapturaDm,
                                            dtApdmResCapturaCerm.HoraInicio,
                                            dtApdmResCapturaCerm.HoraFin,
                                            dtApdmResCapturaCerm.FechaCaptura,
                                            dtApdmResCapturaCerm.IdEstado,
                                            dtApdmResCapturaCerm.IdMunicipio,
                                            dtApdmResCapturaCerm.CveLocalidad,
                                            dtApdmResCapturaCerm.CveAgeb,
                                            dtApdmResCapturaCerm.IdAgeb,
                                            dtApdmResCapturaCerm.GpsLongitud,
                                            dtApdmResCapturaCerm.GpsLatitud
                                        );
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

