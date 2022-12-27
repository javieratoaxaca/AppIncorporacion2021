using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppIncorporacion2021.Data;

namespace AppIncorporacion2021.Modelo
{
    class ModeloApdmResumenCapturaCubesma : Config.ConexionBD
    {
        public ModeloApdmResumenCapturaCubesma() { }

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
        public bool setApdmResCapturCubesma(apdmResumenCapturaCubesma dtApdmResCapturaCubesma)
        {

            string Query = string.Format("INSERT INTO apdm_resumen_encuesta_cubesma(FOLIO_ENCUESTA,ID_ENCUESTA,ID_PROCESO,CUPO,USUARIO_CAPTURA_DM,HORA_INICIO,HORA_FIN,FECHA_CAPTURA,ESTADO_ID,MUNICIPIO_ID,CLAVE_LOCALIDAD,CLAVE_AGEB,AGEB_ID,GPS_LONGITUD,GPS_LATITUD)" +
                                          "VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}')",
                                             dtApdmResCapturaCubesma.FolioEncuesta,
                                             dtApdmResCapturaCubesma.IdEncuesta,
                                             dtApdmResCapturaCubesma.IdProceso,
                                             dtApdmResCapturaCubesma.Cupo,
                                             dtApdmResCapturaCubesma.UsuarioCapturaDm,
                                             dtApdmResCapturaCubesma.HoraInicio,
                                             dtApdmResCapturaCubesma.HoraFin,
                                             dtApdmResCapturaCubesma.FechaCaptura,
                                             dtApdmResCapturaCubesma.IdEstado,
                                             dtApdmResCapturaCubesma.IdMunicipio,
                                             dtApdmResCapturaCubesma.CveLocalidad,
                                             dtApdmResCapturaCubesma.CveAgeb,
                                             dtApdmResCapturaCubesma.IdAgeb,
                                             dtApdmResCapturaCubesma.GpsLongitud,
                                             dtApdmResCapturaCubesma.GpsLatitud
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

