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
    public partial class OrdenPago : Form
    {
        int contador = 0; //me va servir para contar el numero de archivos txt que encuentra dentro de la ruta
        ModeloOrdenPago smOrdenPago = new ModeloOrdenPago();
        
        public OrdenPago()
        {
            InitializeComponent();
            
        }

        private void gbtnDirectorio_Click(object sender, EventArgs e)
        {
            string rutaDirectorio = string.Empty;
            string rutaarchivo = string.Empty;
            string linea;
            int lineatxt = 0;
            string saveArchivo = @"D:\Respaldo_" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + "_" + DateTime.Now.Hour.ToString() + "_" + DateTime.Now.Minute.ToString() + "_" + DateTime.Now.Second.ToString() + ".txt";

            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                rutaDirectorio = fbd.SelectedPath;
            }
            gTxtDirectorio.Text = rutaDirectorio;

            if (rutaDirectorio.Trim()!=string.Empty)
            {
                DirectoryInfo di = new DirectoryInfo(@rutaDirectorio);
                //rtxtboxMostrarArchivo.AppendText();
                StreamWriter sww = new StreamWriter(saveArchivo, true);
                sww.WriteLine("ID-BECARIO_FOLIO-FORMATO_FOLIO-ENCUESTA_FOLIO-VERIFICADOR\n");
                sww.Close();

                foreach (var item in di.GetFiles(gTxtFiltro.Text))
                {
                    ltbArchivos.Items.Add(item.Name);
                    rutaarchivo = rutaDirectorio + "\\" + item.Name;
                    contador++;
                    using (StreamReader sr = new StreamReader(rutaarchivo))
                    {

                        // rtxtboxMostrarArchivo.AppendText(item.Name + "\n");
                        while ((linea = sr.ReadLine()) != null)
                        {

                            rTxtboxMostrarArchivos.AppendText(linea + "_" + item.Name + "\n");
                            StreamWriter sw = new StreamWriter(saveArchivo, true);
                            sw.WriteLine(linea + "_" + item.Name + "\n");
                            sw.Close();
                            lineatxt++;
                        }

                    }

                }
                //MessageBox.Show("Archivo Creado en ruta"+saveArchivo);
                lblTotalArchivos.Text += contador + " y registros son:" + lineatxt;

                dtgvArchivos.AutoGenerateColumns = true;
                dtgvArchivos.DataSource = ConvertirTxtDataTable(saveArchivo);
            }
        }


        private DataTable ConvertirTxtDataTable(string path)
        {
            var dtDatos = new DataTable();
            int countRow = 0;
            int countColumns = 0;
            try
            {
                FileInfo fiFile = new FileInfo(path);
                StreamReader srReadFile = new StreamReader(path, Encoding.UTF8);
                using (srReadFile = fiFile.OpenText())
                {
                    string lineasnew = string.Empty;
                    while ((lineasnew = srReadFile.ReadLine()) != null)
                    {
                        if (string.IsNullOrEmpty(lineasnew))
                        {
                            continue;
                        }
                        if (countRow == 0)
                        {
                            var obtenerColumns = lineasnew.Split('_');
                            countColumns = obtenerColumns.Length;
                            //dtDatos.Columns.Add()
                            foreach (string itemColumn in obtenerColumns)
                            {

                                dtDatos.Columns.Add(itemColumn.Split('\r')[0].Trim());
                            }
                            countRow++;
                        }
                        else
                        {
                            var obtenerRows = lineasnew.Split('_');
                            if (string.IsNullOrEmpty(obtenerRows[0].Split('\r')[0].Trim()))
                            {
                                continue;
                            }
                            DataRow drRow = dtDatos.NewRow();
                            int colsCount = 0;
                            foreach (var item in obtenerRows)
                            {
                                if (colsCount < countColumns)
                                {
                                    drRow[colsCount] = item.Split('\r')[0].Trim();
                                }
                                colsCount++;
                            }
                            dtDatos.Rows.Add(drRow);
                        }
                    }
                }
                return dtDatos;
            }
            catch (Exception ex)
            {

                throw new ApplicationException(ex.Message, ex);
            }

        }
        private void importarODPBd()
        {
            BecarioOrdenPago dtOrdenPago = new BecarioOrdenPago();
            ModeloOrdenPago smOrdenPago = new ModeloOrdenPago();

            try
            {
             
                    for (int i = 0; i < dtgvArchivos.RowCount; i++)
                    {
                       // dtOrdenPago.CodResultado = "101";//dtgvArchivos.Rows[i].Cells[0].Value.ToString();
                        dtOrdenPago.BecarioId =  dtgvArchivos.Rows[i].Cells[0].Value.ToString();
                        dtOrdenPago.FolioFormato = dtgvArchivos.Rows[i].Cells[1].Value.ToString();
                        dtOrdenPago.FolioEncuesta = dtgvArchivos.Rows[i].Cells[2].Value.ToString();
                        dtOrdenPago.FolioVerificador = dtgvArchivos.Rows[i].Cells[3].Value.ToString();
                        smOrdenPago.setOrdenPago2(dtOrdenPago);

                    }
                    bool resultado = smOrdenPago.Procesar();
                    MessageBox.Show(resultado ? "Se guardaron exitosamente" : "Error al guardar los datos");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void gBtnImportarBD_Click(object sender, EventArgs e)
        {
            importarODPBd();
        }

        private void gBtnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                // string CodBarras;
                //CodBarras = scProducto.llenargrid(dtgvProductos);
                System.Drawing.Color cl = new System.Drawing.Color();
                System.Drawing.Color cl2 = new System.Drawing.Color();

                cl = System.Drawing.Color.FromArgb(158, 207, 185);
                cl2 = System.Drawing.Color.FromArgb(52, 83, 101);
                SLDocument sl = new SLDocument();
                SLStyle style = new SLStyle();
                SLStyle style2 = new SLStyle();
                //Seccion para las celdas de titulo
                style.Font.FontSize = 15;
                style.Font.FontName = "Heltica";
                style.Font.FontColor = cl;
                style.Font.Bold = true;
                style.Fill.SetPattern(PatternValues.Solid, cl2, cl);
                style.Border.LeftBorder.BorderStyle = BorderStyleValues.Thick;
                style.Border.LeftBorder.Color = System.Drawing.Color.BlanchedAlmond;
                style.Border.BottomBorder.BorderStyle = BorderStyleValues.DashDotDot;
                style.Border.BottomBorder.Color = System.Drawing.Color.Brown;
                //style.SetTopBorder(BorderStyleValues.Medium, SLThemeColorIndexValues.Accent6Color);


                //Seccion para las celdas del Grid
                style2.Font.FontSize = 12;
                style2.Font.FontName = "Heltica";
                style2.Border.LeftBorder.BorderStyle = BorderStyleValues.Thick;
                style2.Border.LeftBorder.Color = System.Drawing.Color.BlanchedAlmond;
                style2.Border.BottomBorder.BorderStyle = BorderStyleValues.DashDotDot;
                style2.Border.BottomBorder.Color = System.Drawing.Color.Brown;
                //style2.SetTopBorder(BorderStyleValues.Medium, SLThemeColorIndexValues.Accent6Color);

                sl.SetCellValue("B1", "CODIGO_RESULTADO");
                sl.SetCellStyle("B1", style);
                sl.SetCellValue("C1", "ID_BECARIO");
                sl.SetCellStyle("C1", style);
                sl.SetCellValue("D1", "FOLIO_FORMATO");
                sl.SetCellStyle("D1", style);
                sl.SetCellValue("E1", "FOLIO_VERIFICADOR");
                sl.SetCellStyle("E1", style);

                int iR = 2;

                foreach (DataGridViewRow row in dtgvArchivos.Rows)
                {
                    //sl.SetCellValue("", true);
                    // sl.SetCellValue(iR, 1, "A");
                    // MessageBox.Show(row.Cells[0].Value.ToString());
                    sl.SetCellValue(iR, 2, row.Cells[0].Value.ToString());
                    sl.SetCellStyle(iR, 2, style2);
                    sl.SetCellValue(iR, 3, row.Cells[1].Value.ToString());
                    sl.SetCellStyle(iR, 3, style2);
                    sl.SetCellValue(iR, 4, row.Cells[2].Value.ToString());
                    sl.SetCellStyle(iR, 4, style2);
                    sl.SetCellValue(iR, 5, row.Cells[3].Value.ToString());
                    sl.SetCellStyle(iR, 5, style2);

                    iR++;
                }
                sl.SaveAs(@"D:\Universo_Becarios_ACEMS.xlsx");
                MessageBox.Show("Se Guardo Archivo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OrdenPago_Load(object sender, EventArgs e)
        {
            
        }

        private void gTxtBuscarOdp_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }

}
