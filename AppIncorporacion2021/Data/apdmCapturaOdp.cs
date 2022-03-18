using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppIncorporacion2021.Data
{
    class apdmCapturaOdp
    {
        private int idCapturaOdp;
        private string id_pregunta;
        private string id_pregunta_anterior;
        private string id_codigo_respuesta;
        private string codigo_respuesta;
        private string respuesta;
        private string iteracion;
        private string iteracion_anidada;
        private string iteracion_anterior;
        private string iteracion_anidada_anterior;
        private string folio_encuesta;
        private string indice;

        public int IdCapturaOdp
        {
            get
            {
                return idCapturaOdp;
            }

            set
            {
                idCapturaOdp = value;
            }
        }

        public string Id_pregunta
        {
            get
            {
                return id_pregunta;
            }

            set
            {
                id_pregunta = value;
            }
        }

        public string Id_pregunta_anterior
        {
            get
            {
                return id_pregunta_anterior;
            }

            set
            {
                id_pregunta_anterior = value;
            }
        }

        public string Id_codigo_respuesta
        {
            get
            {
                return id_codigo_respuesta;
            }

            set
            {
                id_codigo_respuesta = value;
            }
        }

        public string Codigo_respuesta
        {
            get
            {
                return codigo_respuesta;
            }

            set
            {
                codigo_respuesta = value;
            }
        }

        public string Respuesta
        {
            get
            {
                return respuesta;
            }

            set
            {
                respuesta = value;
            }
        }

        public string Iteracion
        {
            get
            {
                return iteracion;
            }

            set
            {
                iteracion = value;
            }
        }

        public string Iteracion_anidada
        {
            get
            {
                return iteracion_anidada;
            }

            set
            {
                iteracion_anidada = value;
            }
        }

        public string Iteracion_anterior
        {
            get
            {
                return iteracion_anterior;
            }

            set
            {
                iteracion_anterior = value;
            }
        }

        public string Iteracion_anidada_anterior
        {
            get
            {
                return iteracion_anidada_anterior;
            }

            set
            {
                iteracion_anidada_anterior = value;
            }
        }

        public string Folio_encuesta
        {
            get
            {
                return folio_encuesta;
            }

            set
            {
                folio_encuesta = value;
            }
        }

        public string Indice
        {
            get
            {
                return indice;
            }

            set
            {
                indice = value;
            }
        }
    }
}
