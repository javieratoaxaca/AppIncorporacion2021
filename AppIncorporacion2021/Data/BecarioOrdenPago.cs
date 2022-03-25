using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppIncorporacion2021.Data
{
    class BecarioOrdenPago
    {
        int idOrdenPago;
        string codResultado;
        string becarioId;
        string folioFormato;
        string folioEncuesta;
        string folioVerificador;

        public int IdOrdenPago
        {
            get
            {
                return idOrdenPago;
            }

            set
            {
                idOrdenPago = value;
            }
        }

        public string CodResultado
        {
            get
            {
                return codResultado;
            }

            set
            {
                codResultado = value;
            }
        }

        public string BecarioId
        {
            get
            {
                return becarioId;
            }

            set
            {
                becarioId = value;
            }
        }

        public string FolioFormato
        {
            get
            {
                return folioFormato;
            }

            set
            {
                folioFormato = value;
            }
        }

        public string FolioEncuesta
        {
            get
            {
                return folioEncuesta;
            }

            set
            {
                folioEncuesta = value;
            }
        }

        public string FolioVerificador
        {
            get
            {
                return folioVerificador;
            }

            set
            {
                folioVerificador = value;
            }
        }
    }
}
