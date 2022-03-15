using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using SpreadsheetLight;
using AppIncorporacion2021.Modelo;
using AppIncorporacion2021.Data;
using DocumentFormat.OpenXml.Spreadsheet;
using Ionic.Zip;
//using DocumentFormat.OpenXml.Spreadsheet;


namespace AppIncorporacion2021.Vista
{
    public partial class zip : Form
    {
        int contador = 0; //me va servir para contar el numero de archivos txt que encuentra dentro de la ruta

        public zip()
        {
            InitializeComponent();
        }

        private void gbtnDirectorio_Click(object sender, EventArgs e)
        {
            string rutaDirectorio = string.Empty;
            string rutaarchivo = string.Empty;
            string linea;
            int lineatxt = 0;

            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                rutaDirectorio = fbd.SelectedPath;
            }
            gTxtDirectorio.Text = rutaDirectorio;

            if (rutaDirectorio.Trim() != string.Empty)
            {
                DirectoryInfo di = new DirectoryInfo(@rutaDirectorio);
                string targetDirectory = @"D:\RESPALDO_DMS\zip\open\";

                foreach (var item in di.GetFiles(gTxtFiltro.Text))
                {
                    ltbArchivos.Items.Add(item.Name);
                    rutaarchivo = rutaDirectorio + "\\" + item.Name;
                    contador++;
                    //El ZipFile lo obtengo de la Libreria de Ionic.zip 
                    using (ZipFile zip = ZipFile.Read(rutaarchivo)) // lee el archivo de la ruta donde se encuentra el archivo zip
                    {
                        for (int i = 1; i <= rutaarchivo.Length; i++)
                        {
                            zip.Password = "Op3r4t1v0zoi4--"; // Contraseña que tiene cada ZIP                      
                            zip.ExtractAll(targetDirectory + "\\" + item.Name, ExtractExistingFileAction.DoNotOverwrite); //Aqui guarda la extraccion en conjunto con el nombre del zip, para que asi no sobre escriba el contenido en la misma carpeta
                        }
                    }
                }
                lblTotalArchivos.Text += contador + " Se extragieron:" + contador + " ZIP's";
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
                            var obtenerColumns = lineasnew.Split('|');
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
                            var obtenerRows = lineasnew.Split('|');
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

        /*Metodo para enviar los datos del archivo txt de APDM_CAPTURA en la tabla de apdm_captura_bitacora*/
        private void EnviarMysqlBDBitacora()
        {
            apdmCapturaBitacora dtadpmCapturaBitacora = new apdmCapturaBitacora();
            ModeloApdmCapturaBitacora smApdmCapturaBitacora = new ModeloApdmCapturaBitacora();
            //ModeloOrdenPago smOrdenPago = new ModeloOrdenPago();

            try
            {
                for (int i = 0; i <= dtgvArchivos.RowCount; i++)
                {

                    dtadpmCapturaBitacora.Id_pregunta = dtgvArchivos.Rows[i].Cells[0].Value.ToString();
                    dtadpmCapturaBitacora.Id_pregunta_anterior = dtgvArchivos.Rows[i].Cells[1].Value.ToString();
                    dtadpmCapturaBitacora.Id_codigo_respuesta = dtgvArchivos.Rows[i].Cells[2].Value.ToString();
                    dtadpmCapturaBitacora.Codigo_respuesta = dtgvArchivos.Rows[i].Cells[3].Value.ToString();
                    dtadpmCapturaBitacora.Respuesta = dtgvArchivos.Rows[i].Cells[4].Value.ToString();
                    dtadpmCapturaBitacora.Iteracion = dtgvArchivos.Rows[i].Cells[5].Value.ToString();
                    dtadpmCapturaBitacora.Iteracion_anidada = dtgvArchivos.Rows[i].Cells[6].Value.ToString();
                    dtadpmCapturaBitacora.Iteracion_anterior = dtgvArchivos.Rows[i].Cells[7].Value.ToString();
                    dtadpmCapturaBitacora.Iteracion_anidada_anterior = dtgvArchivos.Rows[i].Cells[8].Value.ToString();
                    dtadpmCapturaBitacora.Folio_encuesta = dtgvArchivos.Rows[i].Cells[9].Value.ToString();
                    dtadpmCapturaBitacora.Indice = dtgvArchivos.Rows[i].Cells[10].Value.ToString();

                    smApdmCapturaBitacora.setApdmCapturaBitacora(dtadpmCapturaBitacora);
                }
                bool resultado = smApdmCapturaBitacora.Procesar();
                MessageBox.Show(resultado ? "Se guardaron exitosamente" : "Error al guardar los datos");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*Metodo para enviar los datos del archivo txt de APDM_CAPTURA en la tabla de apdm_captura_cerm*/
        private void EnviarMysqlBDCerm()
        {
            apdmCapturaCerm dtadpmCapturaCerm = new apdmCapturaCerm();
            ModeloApdmCapturaCerm smApdmCapturaCerm = new ModeloApdmCapturaCerm();
            //ModeloOrdenPago smOrdenPago = new ModeloOrdenPago();

            try
            {
                for (int i = 0; i <= dtgvArchivos.RowCount; i++)
                {

                    dtadpmCapturaCerm.Id_pregunta = dtgvArchivos.Rows[i].Cells[0].Value.ToString();
                    dtadpmCapturaCerm.Id_pregunta_anterior = dtgvArchivos.Rows[i].Cells[1].Value.ToString();
                    dtadpmCapturaCerm.Id_codigo_respuesta = dtgvArchivos.Rows[i].Cells[2].Value.ToString();
                    dtadpmCapturaCerm.Codigo_respuesta = dtgvArchivos.Rows[i].Cells[3].Value.ToString();
                    dtadpmCapturaCerm.Respuesta = dtgvArchivos.Rows[i].Cells[4].Value.ToString();
                    dtadpmCapturaCerm.Iteracion = dtgvArchivos.Rows[i].Cells[5].Value.ToString();
                    dtadpmCapturaCerm.Iteracion_anidada = dtgvArchivos.Rows[i].Cells[6].Value.ToString();
                    dtadpmCapturaCerm.Iteracion_anterior = dtgvArchivos.Rows[i].Cells[7].Value.ToString();
                    dtadpmCapturaCerm.Iteracion_anidada_anterior = dtgvArchivos.Rows[i].Cells[8].Value.ToString();
                    dtadpmCapturaCerm.Folio_encuesta = dtgvArchivos.Rows[i].Cells[9].Value.ToString();
                    dtadpmCapturaCerm.Indice = dtgvArchivos.Rows[i].Cells[10].Value.ToString();

                    smApdmCapturaCerm.setApdmCapturaCerm(dtadpmCapturaCerm);
                }
                bool resultado = smApdmCapturaCerm.Procesar();
                MessageBox.Show(resultado ? "Se guardaron exitosamente" : "Error al guardar los datos");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /* *Metodo para enviar los datos del archivo txt de APDM_CAPTURA en la tabla de apdm_resumen_encuesta_bitacora*/
        private void EnviarBdApdmResumenBitacora()
        {
            apdmResumenCapturaBitacora dtadpmResCaptura = new apdmResumenCapturaBitacora();
            ModeloApdmResumenCapturaBitacora smApdmResCaptura = new ModeloApdmResumenCapturaBitacora();
            //ModeloOrdenPago smOrdenPago = new ModeloOrdenPago();

            try
            {
                for (int i = 0; i <= dtgvArchivos.RowCount; i++)
                {
                    dtadpmResCaptura.Folio_encuesta = dtgvArchivos.Rows[i].Cells[0].Value.ToString();
                    dtadpmResCaptura.IdEncuesta = dtgvArchivos.Rows[i].Cells[1].Value.ToString();
                    dtadpmResCaptura.IdProceso = dtgvArchivos.Rows[i].Cells[2].Value.ToString();
                    dtadpmResCaptura.Cupo = dtgvArchivos.Rows[i].Cells[6].Value.ToString();
                    dtadpmResCaptura.UsuarioCapturaDm = dtgvArchivos.Rows[i].Cells[7].Value.ToString();
                    dtadpmResCaptura.HoraInicio = dtgvArchivos.Rows[i].Cells[8].Value.ToString();
                    dtadpmResCaptura.HoraFin = dtgvArchivos.Rows[i].Cells[9].Value.ToString();
                    dtadpmResCaptura.FechaCaptura = dtgvArchivos.Rows[i].Cells[10].Value.ToString();
                    dtadpmResCaptura.IdEstado = dtgvArchivos.Rows[i].Cells[11].Value.ToString();
                    dtadpmResCaptura.IdMunicipio = dtgvArchivos.Rows[i].Cells[12].Value.ToString();
                    dtadpmResCaptura.CveLocalidad = dtgvArchivos.Rows[i].Cells[13].Value.ToString();
                    dtadpmResCaptura.CveAgeb = dtgvArchivos.Rows[i].Cells[15].Value.ToString();
                    dtadpmResCaptura.IdAgeb = dtgvArchivos.Rows[i].Cells[16].Value.ToString();
                    dtadpmResCaptura.GpsLongitud = dtgvArchivos.Rows[i].Cells[25].Value.ToString();
                    dtadpmResCaptura.GpsLatitud = dtgvArchivos.Rows[i].Cells[26].Value.ToString();


                    smApdmResCaptura.setApdmResCaptura(dtadpmResCaptura);
                }
                bool resultado = smApdmResCaptura.Procesar();
                MessageBox.Show(resultado ? "Se guardaron exitosamente" : "Error al guardar los datos");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /* *Metodo para enviar los datos del archivo txt de APDM_CAPTURA en la tabla de apdm_resumen_encuesta_cerm*/
        private void EnviarBdApdmResumenCerm()
        {
            apdmResumenCapturaCerm dtadpmResCapturaCerm = new apdmResumenCapturaCerm();
            ModeloApdmResumenCapturaCerm smApdmResCapturaCerm = new ModeloApdmResumenCapturaCerm();
            //ModeloOrdenPago smOrdenPago = new ModeloOrdenPago();

            try
            {
                for (int i = 0; i <= dtgvArchivos.RowCount; i++)
                {
                    dtadpmResCapturaCerm.Folio_encuesta = dtgvArchivos.Rows[i].Cells[0].Value.ToString();
                    dtadpmResCapturaCerm.IdEncuesta = dtgvArchivos.Rows[i].Cells[1].Value.ToString();
                    dtadpmResCapturaCerm.IdProceso = dtgvArchivos.Rows[i].Cells[2].Value.ToString();
                    dtadpmResCapturaCerm.Cupo = dtgvArchivos.Rows[i].Cells[6].Value.ToString();
                    dtadpmResCapturaCerm.UsuarioCapturaDm = dtgvArchivos.Rows[i].Cells[7].Value.ToString();
                    dtadpmResCapturaCerm.HoraInicio = dtgvArchivos.Rows[i].Cells[8].Value.ToString();
                    dtadpmResCapturaCerm.HoraFin = dtgvArchivos.Rows[i].Cells[9].Value.ToString();
                    dtadpmResCapturaCerm.FechaCaptura = dtgvArchivos.Rows[i].Cells[10].Value.ToString();
                    dtadpmResCapturaCerm.IdEstado = dtgvArchivos.Rows[i].Cells[11].Value.ToString();
                    dtadpmResCapturaCerm.IdMunicipio = dtgvArchivos.Rows[i].Cells[12].Value.ToString();
                    dtadpmResCapturaCerm.CveLocalidad = dtgvArchivos.Rows[i].Cells[13].Value.ToString();
                    dtadpmResCapturaCerm.CveAgeb = dtgvArchivos.Rows[i].Cells[15].Value.ToString();
                    dtadpmResCapturaCerm.IdAgeb = dtgvArchivos.Rows[i].Cells[16].Value.ToString();
                    dtadpmResCapturaCerm.GpsLongitud = dtgvArchivos.Rows[i].Cells[25].Value.ToString();
                    dtadpmResCapturaCerm.GpsLatitud = dtgvArchivos.Rows[i].Cells[26].Value.ToString();


                    smApdmResCapturaCerm.setApdmResCapturaCerm(dtadpmResCapturaCerm);
                }
                bool resultado = smApdmResCapturaCerm.Procesar();
                MessageBox.Show(resultado ? "Se guardaron exitosamente" : "Error al guardar los datos");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gBtnImportarBD_Click(object sender, EventArgs e)
        {
            EnviarMysqlBDBitacora();
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

        private void gBtnExaminarTxts_Click(object sender, EventArgs e)
        {
            /* string itemcmb = cmbProceso.Text;
             Console.Write(itemcmb);
             lblcmbProceso.Text = itemcmb;
             if(cmbProceso.SelectedItem.ToString() == "Bitacora")
             {*/

            string rutaDirectorio = string.Empty;
            string rutaarchivo = string.Empty;
            string linea;
            int lineatxt = 0;
            string saveArchivo = @"D:\APDM_CAPTURA_" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + "_" + DateTime.Now.Hour.ToString() + "_" + DateTime.Now.Minute.ToString() + "_" + DateTime.Now.Second.ToString() + ".txt";

            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                rutaDirectorio = fbd.SelectedPath;
            }
            gTxtDirectorio.Text = rutaDirectorio;

            if (rutaDirectorio.Trim() != string.Empty)
            {
                DirectoryInfo di = new DirectoryInfo(@rutaDirectorio);
                //rtxtboxMostrarArchivo.AppendText();
                StreamWriter sww = new StreamWriter(saveArchivo, true);
                sww.WriteLine("\n");
                sww.Close();
                string filtro = "*.txt";
                foreach (var item in di.GetFiles(filtro))
                {
                    ltbText.Items.Add(item.Name);
                    rutaarchivo = rutaDirectorio + "\\" + item.Name;
                    contador++;
                    using (StreamReader sr = new StreamReader(rutaarchivo))
                    {

                        // rtxtboxMostrarArchivo.AppendText(item.Name + "\n");
                        while ((linea = sr.ReadLine()) != null)
                        {

                            rTxtboxMostrarArchivos.AppendText(linea + "|" + "\n");
                            StreamWriter sw = new StreamWriter(saveArchivo, true);
                            sw.WriteLine(linea + "|" + "\n");
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

        private void gBtnTxtResumen_Click(object sender, EventArgs e)
        {
            ltbText.Text = "";
            //dtgvArchivos.Rows.Clear();
            string rutaDirectorio = string.Empty;
            string rutaarchivo = string.Empty;
            string linea;
            int lineatxt = 0;
            string saveArchivo = @"D:\APDM_RESUMEN_CAPTURA_" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + "_" + DateTime.Now.Hour.ToString() + "_" + DateTime.Now.Minute.ToString() + "_" + DateTime.Now.Second.ToString() + ".txt";

            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                rutaDirectorio = fbd.SelectedPath;
            }
            gTxtDirectorio.Text = rutaDirectorio;

            if (rutaDirectorio.Trim() != string.Empty)
            {
                DirectoryInfo di = new DirectoryInfo(@rutaDirectorio);
                //rtxtboxMostrarArchivo.AppendText();
                StreamWriter sww = new StreamWriter(saveArchivo, true);
                sww.WriteLine("\n");
                sww.Close();
                string filtro = "*.txt";
                foreach (var item in di.GetFiles(filtro))
                {
                    ltbText.Items.Add(item.Name);
                    rutaarchivo = rutaDirectorio + "\\" + item.Name;
                    contador++;
                    using (StreamReader sr = new StreamReader(rutaarchivo))
                    {

                        // rtxtboxMostrarArchivo.AppendText(item.Name + "\n");
                        while ((linea = sr.ReadLine()) != null)
                        {

                            rTxtboxMostrarArchivos.AppendText(linea + "|" + "\n");
                            StreamWriter sw = new StreamWriter(saveArchivo, true);
                            sw.WriteLine(linea + "|" + "\n");
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

        private void gBtnBDResumen_Click(object sender, EventArgs e)
        {
            EnviarBdApdmResumenBitacora();
        }

        private void gBtnExaminarCermTxt_Click(object sender, EventArgs e)
        {
            string rutaDirectorio = string.Empty;
            string rutaarchivo = string.Empty;
            string linea;
            int lineatxt = 0;
            string saveArchivo = @"D:\APDM_CAPTURA_CERM" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + "_" + DateTime.Now.Hour.ToString() + "_" + DateTime.Now.Minute.ToString() + "_" + DateTime.Now.Second.ToString() + ".txt";

            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                rutaDirectorio = fbd.SelectedPath;
            }
            gTxtDirectorio.Text = rutaDirectorio;

            if (rutaDirectorio.Trim() != string.Empty)
            {
                DirectoryInfo di = new DirectoryInfo(@rutaDirectorio);
                //rtxtboxMostrarArchivo.AppendText();
                StreamWriter sww = new StreamWriter(saveArchivo, true);
                sww.WriteLine("\n");
                sww.Close();
                string filtro = "*.txt";
                foreach (var item in di.GetFiles(filtro))
                {
                    ltbText.Items.Add(item.Name);
                    rutaarchivo = rutaDirectorio + "\\" + item.Name;
                    contador++;
                    using (StreamReader sr = new StreamReader(rutaarchivo))
                    {

                        // rtxtboxMostrarArchivo.AppendText(item.Name + "\n");
                        while ((linea = sr.ReadLine()) != null)
                        {

                            rTxtboxMostrarArchivos.AppendText(linea + "|" + "\n");
                            StreamWriter sw = new StreamWriter(saveArchivo, true);
                            sw.WriteLine(linea + "|" + "\n");
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

        private void gBtnTxtResumenCerm_Click(object sender, EventArgs e)
        {
            string rutaDirectorio = string.Empty;
            string rutaarchivo = string.Empty;
            string linea;
            int lineatxt = 0;
            string saveArchivo = @"D:\APDM_RESUMEN_CAPTURA_CERM" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + "_" + DateTime.Now.Hour.ToString() + "_" + DateTime.Now.Minute.ToString() + "_" + DateTime.Now.Second.ToString() + ".txt";

            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                rutaDirectorio = fbd.SelectedPath;
            }
            gTxtDirectorio.Text = rutaDirectorio;

            if (rutaDirectorio.Trim() != string.Empty)
            {
                DirectoryInfo di = new DirectoryInfo(@rutaDirectorio);
                //rtxtboxMostrarArchivo.AppendText();
                StreamWriter sww = new StreamWriter(saveArchivo, true);
                sww.WriteLine("\n");
                sww.Close();
                string filtro = "*.txt";
                foreach (var item in di.GetFiles(filtro))
                {
                    ltbText.Items.Add(item.Name);
                    rutaarchivo = rutaDirectorio + "\\" + item.Name;
                    contador++;
                    using (StreamReader sr = new StreamReader(rutaarchivo))
                    {

                        // rtxtboxMostrarArchivo.AppendText(item.Name + "\n");
                        while ((linea = sr.ReadLine()) != null)
                        {

                            rTxtboxMostrarArchivos.AppendText(linea + "|" + "\n");
                            StreamWriter sw = new StreamWriter(saveArchivo, true);
                            sw.WriteLine(linea + "|" + "\n");
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

        private void gBtnImportarBDCerm_Click(object sender, EventArgs e)
        {
            EnviarMysqlBDCerm();
        }

        private void gBtnBDResumenCerm_Click(object sender, EventArgs e)
        {
            EnviarBdApdmResumenCerm();
        }
    } 
}