using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SpreadsheetLight;
using AppIncorporacion2021.Modelo;
using AppIncorporacion2021.Data;
using SpreadsheetLight;
using DocumentFormat.OpenXml.Spreadsheet;
//using DocumentFormat.OpenXml.Spreadsheet;


namespace AppIncorporacion2021.Vista
{
    public partial class UniversoOdpBasica : Form
    {
        int indice = 0;
        int idRegion = 0;
        int contador = 0; //me va servir para contar el numero de archivos txt que encuentra dentro de la ruta
        ModeloUniversoOdpBasica smUniversoOdpBasica;
        public UniversoOdpBasica()
        {
            InitializeComponent();
            smUniversoOdpBasica = new ModeloUniversoOdpBasica();
        }

        private void UniversoOdpBasica_Load(object sender, EventArgs e)
        {
            smUniversoOdpBasica.CargarGrid(gdtgUniversoOdpBasica);
            gcmbRegion.DataSource = smUniversoOdpBasica.CargarCmbRegion();
            gcmbRegion.DisplayMember = "nomRegion";
            gcmbRegion.ValueMember = "idRegion";
        }

        private void gcmbRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            indice =  gcmbRegion.SelectedIndex;
            switch (indice)
            {
                case 0:
                    idRegion = 20000;
                    smUniversoOdpBasica.CargarGrid(gdtgUniversoOdpBasica);
                    break;
                case 1:
                     idRegion = 20001;
                    smUniversoOdpBasica.CargarGridRegion(gdtgUniversoOdpBasica, idRegion);
                    break;
                case 2:
                    idRegion = 20002;
                    smUniversoOdpBasica.CargarGridRegion(gdtgUniversoOdpBasica, idRegion);
                    break;
                case 3:
                     idRegion = 20003;
                    smUniversoOdpBasica.CargarGridRegion(gdtgUniversoOdpBasica, idRegion);
                    break;
                case 4:
                    idRegion = 20004;
                    smUniversoOdpBasica.CargarGridRegion(gdtgUniversoOdpBasica, idRegion);
                    break;
                case 5:
                     idRegion = 20005;
                    smUniversoOdpBasica.CargarGridRegion(gdtgUniversoOdpBasica, idRegion);
                    break;
                case 6:
                     idRegion = 20006;
                    smUniversoOdpBasica.CargarGridRegion(gdtgUniversoOdpBasica, idRegion);
                    break;
                case 7:
                    idRegion = 20007;
                    smUniversoOdpBasica.CargarGridRegion(gdtgUniversoOdpBasica, idRegion);
                    break;
                case 8:
                    idRegion = 20008;
                    smUniversoOdpBasica.CargarGridRegion(gdtgUniversoOdpBasica, idRegion);
                    break;
                case 9:
                     idRegion = 20009;
                    smUniversoOdpBasica.CargarGridRegion(gdtgUniversoOdpBasica, idRegion);
                    break;
                case 10:
                    idRegion = 20010;
                    smUniversoOdpBasica.CargarGridRegion(gdtgUniversoOdpBasica, idRegion);
                    break;
                case 11:
                     idRegion = 20011;
                    smUniversoOdpBasica.CargarGridRegion(gdtgUniversoOdpBasica, idRegion);
                    break;
                case 12:
                     idRegion = 20012;
                    smUniversoOdpBasica.CargarGridRegion(gdtgUniversoOdpBasica, idRegion);
                    break;
                case 13:
                     idRegion = 20013;
                    smUniversoOdpBasica.CargarGridRegion(gdtgUniversoOdpBasica, idRegion);
                    break;
                case 14:
                     idRegion = 20014;
                    smUniversoOdpBasica.CargarGridRegion(gdtgUniversoOdpBasica, idRegion);
                    break;
                case 15:
                    idRegion = 20015;
                    smUniversoOdpBasica.CargarGridRegion(gdtgUniversoOdpBasica, idRegion);
                    break;
                default:
                    break;
            }
        }

       
    }
}
