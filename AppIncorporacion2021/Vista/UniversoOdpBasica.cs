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
using Microsoft.Office.Interop.Excel;
//using DocumentFormat.OpenXml.Spreadsheet;


namespace AppIncorporacion2021.Vista
{
    public partial class UniversoOdpBasica : Form
    {
        int indice = 0;
        int idRegion = 0;
        int contador = 0; //me va servir para contar el numero de archivos txt que encuentra dentro de la ruta
        ModeloUniversoOdpBasica smUniversoOdpBasica;
        ModeloOrdenPago smOdpBasica;
        OpenFileDialog openFD = new OpenFileDialog();
        public UniversoOdpBasica()
        {
            InitializeComponent();
            smUniversoOdpBasica = new ModeloUniversoOdpBasica();
            smOdpBasica = new ModeloOrdenPago();
        }

        private void UniversoOdpBasica_Load(object sender, EventArgs e)
        {
            smUniversoOdpBasica.CargarGrid(gdtgUniversoOdpBasica);
            smOdpBasica.CargarGridOdp(gdtgOdpCapturado);
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

        private void gTxtBuscarODP_TextChanged(object sender, EventArgs e)
        {
            if (gTxtBuscarODP.Text != "")
                smUniversoOdpBasica.CargarGridBuscar(gdtgUniversoOdpBasica,gTxtBuscarODP.Text);
            else
                smUniversoOdpBasica.CargarGrid(gdtgUniversoOdpBasica);
        }

        private void gTxtOdpCapturado_TextChanged(object sender, EventArgs e)
        {
            if (gTxtOdpCapturado.Text != "")
                smOdpBasica.CargarGridBuscarOdp(gdtgOdpCapturado,gTxtOdpCapturado.Text);
            else
                smOdpBasica.CargarGridOdp(gdtgOdpCapturado);
        }

        private void gBtnImportarExcelADbRemesa_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlworkSheet;
            Microsoft.Office.Interop.Excel.Range xlRange;

            int xlRow;
            string strFileName;

            openFD.Filter = "Excel Office | *.xls; *.xlsx";
            openFD.ShowDialog();
            strFileName = openFD.FileName;

            //Condicionamos el acceso al archivo de excel
            if (strFileName != "")
            {
                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlWorkBook = xlApp.Workbooks.Open(strFileName);
                xlworkSheet = xlWorkBook.Worksheets["Hoja1"];
                xlRange = xlworkSheet.UsedRange;

                int i = 0;

                for (xlRow = 9; xlRow <= xlRange.Rows.Count; xlRow++)
                {
                    i++;
                    gdtgvRemesasExcel.Rows.Add(i,xlRange.Cells[xlRow,1].Text, xlRange.Cells[xlRow, 2].Text, xlRange.Cells[xlRow, 3].Text, xlRange.Cells[xlRow, 4].Text, xlRange.Cells[xlRow, 5].Text, xlRange.Cells[xlRow, 6].Text, xlRange.Cells[xlRow, 7].Text, xlRange.Cells[xlRow, 8].Text, xlRange.Cells[xlRow, 9].Text, xlRange.Cells[xlRow, 10].Text, xlRange.Cells[xlRow, 11].Text, xlRange.Cells[xlRow, 12].Text);
                }
                xlWorkBook.Close();
                xlApp.Quit();
            }

        }
    }
}
