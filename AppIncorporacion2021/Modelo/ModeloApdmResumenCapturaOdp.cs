using System;
using AppIncorporacion2021.Data;

namespace AppIncorporacion2021.Modelo
{
    class ModeloApdmResumenCapturaOdp:Config.ConexionBD
    {
        public ModeloApdmResumenCapturaOdp() { }

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
        public bool setApdmResCapturaOdp(apdmResumenCapturaOdp dtApdmResCapturaOdp)
        {

           string Query = string.Format("INSERT INTO apdm_resumen_encuesta_odp(FOLIO_ENCUESTA,ID_ENCUESTA,ID_PROCESO,CUPO,USUARIO_CAPTURA_DM,HORA_INICIO,HORA_FIN,FECHA_CAPTURA,ESTADO_ID,MUNICIPIO_ID,CLAVE_LOCALIDAD,CLAVE_AGEB,AGEB_ID,GPS_LONGITUD,GPS_LATITUD)" +
                                         "VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}')",
                                            dtApdmResCapturaOdp.Folio_encuesta,
                                            dtApdmResCapturaOdp.IdEncuesta,
                                            dtApdmResCapturaOdp.IdProceso,
                                            dtApdmResCapturaOdp.Cupo,
                                            dtApdmResCapturaOdp.UsuarioCapturaDm,
                                            dtApdmResCapturaOdp.HoraInicio,
                                            dtApdmResCapturaOdp.HoraFin,
                                            dtApdmResCapturaOdp.FechaCaptura,
                                            dtApdmResCapturaOdp.IdEstado,
                                            dtApdmResCapturaOdp.IdMunicipio,
                                            dtApdmResCapturaOdp.CveLocalidad,
                                            dtApdmResCapturaOdp.CveAgeb,
                                            dtApdmResCapturaOdp.IdAgeb,
                                            dtApdmResCapturaOdp.GpsLongitud,
                                            dtApdmResCapturaOdp.GpsLatitud
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

