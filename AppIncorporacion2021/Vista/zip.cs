﻿using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using SpreadsheetLight;
using AppIncorporacion2021.Modelo;
using AppIncorporacion2021.Data;
using DocumentFormat.OpenXml.Spreadsheet;
using Ionic.Zip;



namespace AppIncorporacion2021.Vista
{
    public partial class zip : Form
    {
        ModeloApdmCapturaOdp smUniversoApdmCapturaOdp;
        ModeloApdmCapturaBitacora smUniversoApdmCapturaBitacora;
        ModeloApdmCapturaCerm smUniversoApdmCapturaCerm;
        ModeloApdmCapturaCubesma smUniversoApdmCapturaCubesma;
        ModeloApdmCapturaCedUni smUniversoApdmCapturaCedUni;

        int contador = 0; //me va servir para contar el numero de archivos txt que encuentra dentro de la ruta
        int indice = 0; //me va servir como contador de los procesos Operativos en el ComboBox
        public zip()
        {
            InitializeComponent();
            smUniversoApdmCapturaOdp = new ModeloApdmCapturaOdp();
            smUniversoApdmCapturaBitacora = new ModeloApdmCapturaBitacora();
            smUniversoApdmCapturaCerm = new ModeloApdmCapturaCerm();
            smUniversoApdmCapturaCubesma = new ModeloApdmCapturaCubesma();
            smUniversoApdmCapturaCedUni = new ModeloApdmCapturaCedUni();
        }

        #region Busqueda de Zip por Directorio
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
                string targetDirectory = @"E:\RESPALDO_DMS_2022\zip\open";
                
               
                    foreach (var item in di.GetFiles(gTxtFiltro.Text))
                    {
                        ltbArchivos.Items.Add(item.Name);
                        rutaarchivo = rutaDirectorio + "\\" + item.Name;
                        contador++;
                    try
                    {
                        using (ZipFile zip = ZipFile.Read(rutaarchivo)) // lee el archivo de la ruta donde se encuentra el archivo zip
                        {

                            for (int i = 1; i <= rutaarchivo.Length; i++)
                            {
                                zip.Password = "Op3r4t1v0zoi4--"; // Contraseña que tiene cada ZIP                  
                                zip.ExtractAll(targetDirectory + "\\" + item.Name, ExtractExistingFileAction.DoNotOverwrite);
                                zip.Dispose();
                                // zip.ExtractAll(targetDirectory + "\\" + item.Name, ExtractExistingFileAction.DoNotOverwrite);
                                //Aqui guarda la extraccion en conjunto con el nombre del zip, para que asi no sobre escriba el contenido en la misma carpeta


                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Ocurrió un error al descomprimir el archivo " + targetDirectory + "\\" + item.Name + ": " + ex.Message);
                        //throw;
                    }
                        //El ZipFile lo obtengo de la Libreria de Ionic.zip 
                        
                    }
                
            
                lblTotalArchivos.Text += contador + " Se extragieron:" + contador + " ZIP's";
            }
        }
        #endregion
        #region Rellenando ComboBox con los Procesos Operativos
        private void zip_Load(object sender, EventArgs e)
        {
            gcmbProceso.Items.Add("Seleccione un Producto");
            gcmbProceso.Items.Add("BITACORA");
            gcmbProceso.Items.Add("ENTREGA_MEDIOS");
            gcmbProceso.Items.Add("ODP_MAT");
            gcmbProceso.Items.Add("CUBESMA");
            gcmbProceso.Items.Add("CEDULA UNICA");
            gcmbProceso.SelectedIndex = 0;
            btnVisibleFalseBitacora();
            btnVisibleFalseCerm();
            btnVisibleFalseOdp();
            btnVisibleFalseCubesma();
            btnVisibleFalseCedUni();
        }
        #endregion
        #region Envio de la APDM_CAPTURA por Proceso a la BDD Central
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
        /*Metodo para enviar los datos del archivo txt de APDM_CAPTURA en la tabla de apdm_captura_odp*/
        private void EnviarMysqlBDOdp()
        {
            apdmCapturaOdp dtadpmCapturaOdp = new apdmCapturaOdp();
            ModeloApdmCapturaOdp smApdmCapturaOdp = new ModeloApdmCapturaOdp();
            //ModeloOrdenPago smOrdenPago = new ModeloOrdenPago();

            try
            {
                for (int i = 0; i <= dtgvArchivos.RowCount; i++)
                {

                    dtadpmCapturaOdp.Id_pregunta = dtgvArchivos.Rows[i].Cells[0].Value.ToString();
                    dtadpmCapturaOdp.Id_pregunta_anterior = dtgvArchivos.Rows[i].Cells[1].Value.ToString();
                    dtadpmCapturaOdp.Id_codigo_respuesta = dtgvArchivos.Rows[i].Cells[2].Value.ToString();
                    dtadpmCapturaOdp.Codigo_respuesta = dtgvArchivos.Rows[i].Cells[3].Value.ToString();
                    dtadpmCapturaOdp.Respuesta = dtgvArchivos.Rows[i].Cells[4].Value.ToString();
                    dtadpmCapturaOdp.Iteracion = dtgvArchivos.Rows[i].Cells[5].Value.ToString();
                    dtadpmCapturaOdp.Iteracion_anidada = dtgvArchivos.Rows[i].Cells[6].Value.ToString();
                    dtadpmCapturaOdp.Iteracion_anterior = dtgvArchivos.Rows[i].Cells[7].Value.ToString();
                    dtadpmCapturaOdp.Iteracion_anidada_anterior = dtgvArchivos.Rows[i].Cells[8].Value.ToString();
                    dtadpmCapturaOdp.Folio_encuesta = dtgvArchivos.Rows[i].Cells[9].Value.ToString();
                    dtadpmCapturaOdp.Indice = dtgvArchivos.Rows[i].Cells[10].Value.ToString();

                    smApdmCapturaOdp.setApdmCapturaOdp(dtadpmCapturaOdp);
                }
                bool resultado = smApdmCapturaOdp.Procesar();
                MessageBox.Show(resultado ? "Se guardaron exitosamente" : "Error al guardar los datos");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*Metodo para enviar los datos del archivo txt de APDM_CAPTURA en la tabla de apdm_captura_cubesma*/
        private void EnviarMysqlBDCubesma()
        {
            apdmCapturaCubesma dtadpmCapturaCubesma = new apdmCapturaCubesma();
            ModeloApdmCapturaCubesma smApdmCapturaCubesma = new ModeloApdmCapturaCubesma();
            //ModeloOrdenPago smOrdenPago = new ModeloOrdenPago();

            try
            {
                for (int i = 0; i <= dtgvArchivos.RowCount; i++)
                {

                    dtadpmCapturaCubesma.Id_pregunta = dtgvArchivos.Rows[i].Cells[0].Value.ToString();
                    dtadpmCapturaCubesma.Id_pregunta_anterior = dtgvArchivos.Rows[i].Cells[1].Value.ToString();
                    dtadpmCapturaCubesma.Id_codigo_respuesta = dtgvArchivos.Rows[i].Cells[2].Value.ToString();
                    dtadpmCapturaCubesma.Codigo_respuesta = dtgvArchivos.Rows[i].Cells[3].Value.ToString();
                    dtadpmCapturaCubesma.Respuesta = dtgvArchivos.Rows[i].Cells[4].Value.ToString();
                    dtadpmCapturaCubesma.Iteracion = dtgvArchivos.Rows[i].Cells[5].Value.ToString();
                    dtadpmCapturaCubesma.Iteracion_anidada = dtgvArchivos.Rows[i].Cells[6].Value.ToString();
                    dtadpmCapturaCubesma.Iteracion_anterior = dtgvArchivos.Rows[i].Cells[7].Value.ToString();
                    dtadpmCapturaCubesma.Iteracion_anidada_anterior = dtgvArchivos.Rows[i].Cells[8].Value.ToString();
                    dtadpmCapturaCubesma.Folio_encuesta = dtgvArchivos.Rows[i].Cells[9].Value.ToString();
                    dtadpmCapturaCubesma.Indice = dtgvArchivos.Rows[i].Cells[10].Value.ToString();

                    smApdmCapturaCubesma.setApdmCapturaCubesma(dtadpmCapturaCubesma);
                }
                bool resultado = smApdmCapturaCubesma.Procesar();
                MessageBox.Show(resultado ? "Se guardaron exitosamente" : "Error al guardar los datos");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*Metodo para enviar los datos del archivo txt de APDM_CAPTURA en la tabla de apdm_captura_Ced_Uni*/
        private void EnviarMysqlBDCedUni()
        {
            apdmCapturaCedUni dtadpmCapturaCedUni = new apdmCapturaCedUni();
            ModeloApdmCapturaCedUni smApdmCapturaCedUni = new ModeloApdmCapturaCedUni();
            //ModeloOrdenPago smOrdenPago = new ModeloOrdenPago();

            try
            {
                for (int i = 0; i <= dtgvArchivos.RowCount; i++)
                {

                    dtadpmCapturaCedUni.Id_pregunta = dtgvArchivos.Rows[i].Cells[0].Value.ToString();
                    dtadpmCapturaCedUni.Id_pregunta_anterior = dtgvArchivos.Rows[i].Cells[1].Value.ToString();
                    dtadpmCapturaCedUni.Id_codigo_respuesta = dtgvArchivos.Rows[i].Cells[2].Value.ToString();
                    dtadpmCapturaCedUni.Codigo_respuesta = dtgvArchivos.Rows[i].Cells[3].Value.ToString();
                    dtadpmCapturaCedUni.Respuesta = dtgvArchivos.Rows[i].Cells[4].Value.ToString();
                    dtadpmCapturaCedUni.Iteracion = dtgvArchivos.Rows[i].Cells[5].Value.ToString();
                    dtadpmCapturaCedUni.Iteracion_anidada = dtgvArchivos.Rows[i].Cells[6].Value.ToString();
                    dtadpmCapturaCedUni.Iteracion_anterior = dtgvArchivos.Rows[i].Cells[7].Value.ToString();
                    dtadpmCapturaCedUni.Iteracion_anidada_anterior = dtgvArchivos.Rows[i].Cells[8].Value.ToString();
                    dtadpmCapturaCedUni.Folio_encuesta = dtgvArchivos.Rows[i].Cells[9].Value.ToString();
                    dtadpmCapturaCedUni.Indice = dtgvArchivos.Rows[i].Cells[10].Value.ToString();

                    smApdmCapturaCedUni.setApdmCapturaCedUni(dtadpmCapturaCedUni);
                }
                bool resultado = smApdmCapturaCedUni.Procesar();
                MessageBox.Show(resultado ? "Se guardaron exitosamente" : "Error al guardar los datos");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Envio de la APDM_RESUMEN_ENCUESTA por Proceso a la BDD Central
        /* *Metodo para enviar los datos del archivo txt de APDM_RESUMEN_ENCUESTA en la tabla de apdm_resumen_encuesta_bitacora*/
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
        /* *Metodo para enviar los datos del archivo txt de APDM_RESUMEN_ENCUESTA en la tabla de apdm_resumen_encuesta_cerm*/
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
        /* *Metodo para enviar los datos del archivo txt de APDM_RESUMEN_ENCUESTA en la tabla de apdm_resumen_encuesta_odp*/
        private void EnviarBdApdmResumenOdp()
        {
            apdmResumenCapturaOdp dtadpmResCapturaOdp = new apdmResumenCapturaOdp();
            ModeloApdmResumenCapturaOdp smApdmResCapturaOdp = new ModeloApdmResumenCapturaOdp();
            //ModeloOrdenPago smOrdenPago = new ModeloOrdenPago();

            try
            {
                for (int i = 0; i <= dtgvArchivos.RowCount; i++)
                {
                    dtadpmResCapturaOdp.Folio_encuesta = dtgvArchivos.Rows[i].Cells[0].Value.ToString();
                    dtadpmResCapturaOdp.IdEncuesta = dtgvArchivos.Rows[i].Cells[1].Value.ToString();
                    dtadpmResCapturaOdp.IdProceso = dtgvArchivos.Rows[i].Cells[2].Value.ToString();
                    dtadpmResCapturaOdp.Cupo = dtgvArchivos.Rows[i].Cells[6].Value.ToString();
                    dtadpmResCapturaOdp.UsuarioCapturaDm = dtgvArchivos.Rows[i].Cells[7].Value.ToString();
                    dtadpmResCapturaOdp.HoraInicio = dtgvArchivos.Rows[i].Cells[8].Value.ToString();
                    dtadpmResCapturaOdp.HoraFin = dtgvArchivos.Rows[i].Cells[9].Value.ToString();
                    dtadpmResCapturaOdp.FechaCaptura = dtgvArchivos.Rows[i].Cells[10].Value.ToString();
                    dtadpmResCapturaOdp.IdEstado = dtgvArchivos.Rows[i].Cells[11].Value.ToString();
                    dtadpmResCapturaOdp.IdMunicipio = dtgvArchivos.Rows[i].Cells[12].Value.ToString();
                    dtadpmResCapturaOdp.CveLocalidad = dtgvArchivos.Rows[i].Cells[13].Value.ToString();
                    dtadpmResCapturaOdp.CveAgeb = dtgvArchivos.Rows[i].Cells[15].Value.ToString();
                    dtadpmResCapturaOdp.IdAgeb = dtgvArchivos.Rows[i].Cells[16].Value.ToString();
                    dtadpmResCapturaOdp.GpsLongitud = dtgvArchivos.Rows[i].Cells[25].Value.ToString();
                    dtadpmResCapturaOdp.GpsLatitud = dtgvArchivos.Rows[i].Cells[26].Value.ToString();


                    smApdmResCapturaOdp.setApdmResCapturaOdp(dtadpmResCapturaOdp);
                }
                bool resultado = smApdmResCapturaOdp.Procesar();
                MessageBox.Show(resultado ? "Se guardaron exitosamente" : "Error al guardar los datos");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*Metodo para enviar los datos del archivo txt de APDM_RESUMEN_ENCUESTA en la tabla de apdm_resumen_encuesta_cubesma*/
        private void EnviarBdApdmResumenCubesma()
        {
            apdmResumenCapturaCubesma dtadpmResCapturaCubesma = new apdmResumenCapturaCubesma();
            ModeloApdmResumenCapturaCubesma smApdmResCapturaCubesma = new ModeloApdmResumenCapturaCubesma();
            //ModeloOrdenPago smOrdenPago = new ModeloOrdenPago();

            try
            {
                for (int i = 0; i <= dtgvArchivos.RowCount; i++)
                {
                    dtadpmResCapturaCubesma.FolioEncuesta = dtgvArchivos.Rows[i].Cells[0].Value.ToString();
                    dtadpmResCapturaCubesma.IdEncuesta = dtgvArchivos.Rows[i].Cells[1].Value.ToString();
                    dtadpmResCapturaCubesma.IdProceso = dtgvArchivos.Rows[i].Cells[2].Value.ToString();
                    dtadpmResCapturaCubesma.Cupo = dtgvArchivos.Rows[i].Cells[6].Value.ToString();
                    dtadpmResCapturaCubesma.UsuarioCapturaDm = dtgvArchivos.Rows[i].Cells[7].Value.ToString();
                    dtadpmResCapturaCubesma.HoraInicio = dtgvArchivos.Rows[i].Cells[8].Value.ToString();
                    dtadpmResCapturaCubesma.HoraFin = dtgvArchivos.Rows[i].Cells[9].Value.ToString();
                    dtadpmResCapturaCubesma.FechaCaptura = dtgvArchivos.Rows[i].Cells[10].Value.ToString();
                    dtadpmResCapturaCubesma.IdEstado = dtgvArchivos.Rows[i].Cells[11].Value.ToString();
                    dtadpmResCapturaCubesma.IdMunicipio = dtgvArchivos.Rows[i].Cells[12].Value.ToString();
                    dtadpmResCapturaCubesma.CveLocalidad = dtgvArchivos.Rows[i].Cells[13].Value.ToString();
                    dtadpmResCapturaCubesma.CveAgeb = dtgvArchivos.Rows[i].Cells[15].Value.ToString();
                    dtadpmResCapturaCubesma.IdAgeb = dtgvArchivos.Rows[i].Cells[16].Value.ToString();
                    dtadpmResCapturaCubesma.GpsLongitud = dtgvArchivos.Rows[i].Cells[25].Value.ToString();
                    dtadpmResCapturaCubesma.GpsLatitud = dtgvArchivos.Rows[i].Cells[26].Value.ToString();


                    smApdmResCapturaCubesma.setApdmResCapturCubesma(dtadpmResCapturaCubesma);
                }
                bool resultado = smApdmResCapturaCubesma.Procesar();
                MessageBox.Show(resultado ? "Se guardaron exitosamente" : "Error al guardar los datos");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void EnviarBdApdmResumenCedUni()
        {
            apdmResumenCapturaCedUni dtadpmResCapturaCedUni = new apdmResumenCapturaCedUni();
            ModeloApdmResumenCapturaCedUni smApdmResCapturaCedUni = new ModeloApdmResumenCapturaCedUni();
            //ModeloOrdenPago smOrdenPago = new ModeloOrdenPago();

            try
            {
                for (int i = 0; i <= dtgvArchivos.RowCount; i++)
                {
                    dtadpmResCapturaCedUni.Folio_encuesta = dtgvArchivos.Rows[i].Cells[0].Value.ToString();
                    dtadpmResCapturaCedUni.IdEncuesta = dtgvArchivos.Rows[i].Cells[1].Value.ToString();
                    dtadpmResCapturaCedUni.IdProceso = dtgvArchivos.Rows[i].Cells[2].Value.ToString();
                    dtadpmResCapturaCedUni.Cupo = dtgvArchivos.Rows[i].Cells[6].Value.ToString();
                    dtadpmResCapturaCedUni.UsuarioCapturaDm = dtgvArchivos.Rows[i].Cells[7].Value.ToString();
                    dtadpmResCapturaCedUni.HoraInicio = dtgvArchivos.Rows[i].Cells[8].Value.ToString();
                    dtadpmResCapturaCedUni.HoraFin = dtgvArchivos.Rows[i].Cells[9].Value.ToString();
                    dtadpmResCapturaCedUni.FechaCaptura = dtgvArchivos.Rows[i].Cells[10].Value.ToString();
                    dtadpmResCapturaCedUni.IdEstado = dtgvArchivos.Rows[i].Cells[11].Value.ToString();
                    dtadpmResCapturaCedUni.IdMunicipio = dtgvArchivos.Rows[i].Cells[12].Value.ToString();
                    dtadpmResCapturaCedUni.CveLocalidad = dtgvArchivos.Rows[i].Cells[13].Value.ToString();
                    dtadpmResCapturaCedUni.CveAgeb = dtgvArchivos.Rows[i].Cells[15].Value.ToString();
                    dtadpmResCapturaCedUni.IdAgeb = dtgvArchivos.Rows[i].Cells[16].Value.ToString();
                    dtadpmResCapturaCedUni.GpsLongitud = dtgvArchivos.Rows[i].Cells[25].Value.ToString();
                    dtadpmResCapturaCedUni.GpsLatitud = dtgvArchivos.Rows[i].Cells[26].Value.ToString();


                    smApdmResCapturaCedUni.setApdmResCapturaCedUni(dtadpmResCapturaCedUni);
                }
                bool resultado = smApdmResCapturaCedUni.Procesar();
                MessageBox.Show(resultado ? "Se guardaron exitosamente" : "Error al guardar los datos");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Exportar Informacion de Excel por Proceso
        //Metodo para exportar el archivo de excel generado de la consulta y mostrado en el DataGrigView -> dtgvODP
        private void ExportarExcelODP()
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

                sl.SetCellValue("B1", "FOLIO_ENCUESTA");
                sl.SetCellStyle("B1", style);
                sl.SetCellValue("C1", "FOLIO_FORMATO");
                sl.SetCellStyle("C1", style);
                sl.SetCellValue("D1", "FECHA_CAPTURA");
                sl.SetCellStyle("D1", style);
                sl.SetCellValue("E1", "CUPO");
                sl.SetCellStyle("E1", style);
                sl.SetCellValue("F1", "CVELOCALIDAD");
                sl.SetCellStyle("F1", style);
                sl.SetCellValue("G1", "LOCALIDAD");
                sl.SetCellStyle("G1", style);
                sl.SetCellValue("H1", "MUNICIPIO");
                sl.SetCellStyle("H1", style);

                int iR = 2;

                foreach (DataGridViewRow row in dtgvODPS.Rows)
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
                    sl.SetCellValue(iR, 6, row.Cells[4].Value.ToString());
                    sl.SetCellStyle(iR, 6, style2);
                    sl.SetCellValue(iR, 7, row.Cells[5].Value.ToString());
                    sl.SetCellStyle(iR, 7, style2);
                    sl.SetCellValue(iR, 8, row.Cells[6].Value.ToString());
                    sl.SetCellStyle(iR, 8, style2);

                    iR++;
                }
                sl.SaveAs(@"D:\CORTE_ODP" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + "_" + DateTime.Now.Hour.ToString() + "_" + DateTime.Now.Minute.ToString() + "_" + DateTime.Now.Second.ToString() + ".xlsx");
                MessageBox.Show("Se Guardo Archivo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ExportarExcelBitacora()
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

                sl.SetCellValue("B1", "FOLIO_ENCUESTA");
                sl.SetCellStyle("B1", style);
                sl.SetCellValue("C1", "CVE_SEDE_LOCALIDAD");
                sl.SetCellStyle("C1", style);
                sl.SetCellValue("D1", "SEDE");
                sl.SetCellStyle("D1", style);
                sl.SetCellValue("E1", "FECHA_CAPTURA");
                sl.SetCellStyle("E1", style);
                sl.SetCellValue("F1", "CUPO");
                sl.SetCellStyle("F1", style);
                sl.SetCellValue("G1", "MUNICIPIO");
                sl.SetCellStyle("G1", style);
                sl.SetCellValue("H1", "LOCALIDAD");
                sl.SetCellStyle("H1", style);
                sl.SetCellValue("I1", "TITULARES_COBRARON");
                sl.SetCellStyle("I1", style);
                sl.SetCellValue("J1", "BIMESTRE_OPERATIVO");
                sl.SetCellStyle("J1", style);


                int iR = 2;

                foreach (DataGridViewRow row in dtgvODPS.Rows)
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
                    sl.SetCellValue(iR, 6, row.Cells[4].Value.ToString());
                    sl.SetCellStyle(iR, 6, style2);
                    sl.SetCellValue(iR, 7, row.Cells[5].Value.ToString());
                    sl.SetCellStyle(iR, 7, style2);
                    sl.SetCellValue(iR, 8, row.Cells[6].Value.ToString());
                    sl.SetCellStyle(iR, 8, style2);
                    sl.SetCellValue(iR, 9, row.Cells[7].Value.ToString());
                    sl.SetCellStyle(iR, 9, style2);
                    sl.SetCellValue(iR, 10, row.Cells[8].Value.ToString());
                    sl.SetCellStyle(iR, 10, style2);

                    iR++;
                }
                sl.SaveAs(@"D:\CORTE_BITACORA" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + "_" + DateTime.Now.Hour.ToString() + "_" + DateTime.Now.Minute.ToString() + "_" + DateTime.Now.Second.ToString() + ".xlsx");
                MessageBox.Show("Se Guardo Archivo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ExportarExcelCerm()
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

                sl.SetCellValue("B1", "FOLIO_ENCUESTA");
                sl.SetCellStyle("B1", style);
                sl.SetCellValue("C1", "FOLIO_FORMATO");
                sl.SetCellStyle("C1", style);
                sl.SetCellValue("D1", "FECHA_CAPTURA");
                sl.SetCellStyle("D1", style);
                sl.SetCellValue("E1", "CUPO");
                sl.SetCellStyle("E1", style);
                sl.SetCellValue("F1", "MUNICIPIO");
                sl.SetCellStyle("F1", style);
                sl.SetCellValue("G1", "LOCALIDAD");
                sl.SetCellStyle("G1", style);



                int iR = 2;

                foreach (DataGridViewRow row in dtgvODPS.Rows)
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
                    sl.SetCellValue(iR, 6, row.Cells[4].Value.ToString());
                    sl.SetCellStyle(iR, 6, style2);
                    sl.SetCellValue(iR, 7, row.Cells[5].Value.ToString());
                    sl.SetCellStyle(iR, 7, style2);


                    iR++;
                }
                sl.SaveAs(@"D:\CORTE_CERM" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + "_" + DateTime.Now.Hour.ToString() + "_" + DateTime.Now.Minute.ToString() + "_" + DateTime.Now.Second.ToString() + ".xlsx");
                MessageBox.Show("Se Guardo Archivo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExportarExcelCedUni()
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

                sl.SetCellValue("B1", "FOLIO_ENCUESTA");
                sl.SetCellStyle("B1", style);
                sl.SetCellValue("C1", "CCT");
                sl.SetCellStyle("C1", style);
                sl.SetCellValue("D1", "FECHA_CAPTURA");
                sl.SetCellStyle("D1", style);
                sl.SetCellValue("E1", "CUPO");
                sl.SetCellStyle("E1", style);
                sl.SetCellValue("F1", "MUNICIPIO");
                sl.SetCellStyle("F1", style);
                sl.SetCellValue("G1", "LOCALIDAD");
                sl.SetCellStyle("G1", style);



                int iR = 2;

                foreach (DataGridViewRow row in dtgvODPS.Rows)
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
                    sl.SetCellValue(iR, 6, row.Cells[4].Value.ToString());
                    sl.SetCellStyle(iR, 6, style2);
                    sl.SetCellValue(iR, 7, row.Cells[5].Value.ToString());
                    sl.SetCellStyle(iR, 7, style2);


                    iR++;
                }
                sl.SaveAs(@"D:\CORTE_CEDUNICA" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + "_" + DateTime.Now.Hour.ToString() + "_" + DateTime.Now.Minute.ToString() + "_" + DateTime.Now.Second.ToString() + ".xlsx");
                MessageBox.Show("Se Guardo Archivo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Exportar por Proceso Operativo a Excel
        private void gBtnExcel_Click(object sender, EventArgs e)
        {
            indice = gcmbProceso.SelectedIndex;
            if (indice == 1)
            {
                ExportarExcelBitacora();
            }
            if (indice == 2)
            {
                ExportarExcelCerm();
            }
            if (indice == 3)
            {
                ExportarExcelODP();
            }
            if (indice == 4)
            {
                //ExportarExcelBitacora();
            }
            if (indice == 5)
            {
                ExportarExcelCedUni();
            }

        }
        #endregion
        #region Botonos de los Procesos para Visible/Invisble (BITACORA,CERM,CUBESMA,ODPS, CEDULA UNICA)
        private void btnVisibleFalseBitacora()
        {
            gBtnExaminarTxts.Visible = false;
            gBtnTxtResumenBitacora.Visible = false;
            gBtnImportarBD.Visible = false;
            gBtnBDResumen.Visible = false;
        }
        private void btnVisibleTrueBitacora()
        {
            gBtnExaminarTxts.Visible = true;
            gBtnTxtResumenBitacora.Visible = true;
            gBtnImportarBD.Visible = true;
            gBtnBDResumen.Visible = true;
        }
        private void btnVisibleFalseCerm()
        {
            gBtnExaminarCermTxt.Visible = false;
            gBtnImportarBDCerm.Visible = false;
            gBtnTxtResumenCerm.Visible = false;
            gBtnBDResumenCerm.Visible = false;
        }
        private void btnVisibleTrueCerm()
        {
            gBtnExaminarCermTxt.Visible = true;
            gBtnImportarBDCerm.Visible = true;
            gBtnTxtResumenCerm.Visible = true;
            gBtnBDResumenCerm.Visible = true;
        }
        private void btnVisibleFalseOdp()
        {
            gbtnExaminarCapturaOPD.Visible = false;
            gbtnImportarCapturaOPD.Visible = false;
            gBtnTxtResumenOdp.Visible = false;
            gbtnImportarResumenCapturaOPD.Visible = false;
        }
        private void btnVisibleTrueOdp()
        {
            gbtnExaminarCapturaOPD.Visible = true;
            gbtnImportarCapturaOPD.Visible = true;
            gBtnTxtResumenOdp.Visible = true;
            gbtnImportarResumenCapturaOPD.Visible = true;
        }
        private void btnVisibleFalseCubesma()
        {
            gbtnExaminarResumenCapturaCubesma.Visible = false;
            gbtnImportarCapturaCubesma.Visible = false;

            gBtnTxtResumenCubesma.Visible = false;
            //gbtnExaminarResumenCapturaCubesma.Visible = false;
            gbtnImportarResumenCapturaCubesma.Visible = false;
        }
        private void btnVisibleTrueCubesma()
        {
            gbtnExaminarResumenCapturaCubesma.Visible = true;
            gbtnImportarCapturaCubesma.Visible = true;
            gBtnTxtResumenCubesma.Visible = true;
            gbtnImportarResumenCapturaCubesma.Visible = true;
        }
        private void btnVisibleFalseCedUni()
        {
            /* gbtnExaminarResumenCapturaCedUni.Visible = false;
             gbtnImportarCapturaCedUni.Visible = false;
             gBtnTxtResumenCedUni.Visible = false;
             gbtnImportarResumenCapturaCedUni.Visible = false;*/
        }
        private void btnVisibleTrueCedUni()
        {
            /*   gbtnExaminarResumenCapturaCedUni.Visible = true;
               gbtnImportarCapturaCedUni.Visible = true;
               gBtnTxtResumenCedUni.Visible = true;
               gbtnImportarResumenCapturaCedUni.Visible = true;*/
        }
        #endregion
        #region Agregar Elementos al ComboBox
        private void gcmbProceso_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            indice = gcmbProceso.SelectedIndex;
            switch (indice)
            {
                case 1:
                    btnVisibleTrueBitacora();
                    btnVisibleFalseCerm();
                    btnVisibleFalseOdp();
                    btnVisibleFalseCubesma();
                    btnVisibleFalseCedUni();
                    break;
                case 2:
                    btnVisibleFalseBitacora();
                    btnVisibleTrueCerm();
                    btnVisibleFalseOdp();
                    btnVisibleFalseCubesma();
                    btnVisibleFalseCedUni();
                    break;
                case 3:
                    btnVisibleFalseBitacora();
                    btnVisibleFalseCerm();
                    btnVisibleTrueOdp();
                    btnVisibleFalseCubesma();
                    btnVisibleFalseCedUni();

                    break;
                case 4:
                    btnVisibleFalseBitacora();
                    btnVisibleFalseCerm();
                    btnVisibleFalseOdp();
                    btnVisibleTrueCubesma();
                    btnVisibleFalseCedUni();
                    break;
                case 5:
                    btnVisibleFalseBitacora();
                    btnVisibleFalseCerm();
                    btnVisibleFalseOdp();
                    btnVisibleFalseCubesma();
                    btnVisibleTrueCedUni();
                    break;
                default:
                    break;
            }
        }
        #endregion
        #region Cargar DatagridView despues de la consulta a la BD Central 
        private void gBtnCargarGridBitacora_Click(object sender, EventArgs e)
        {
            rTxtboxMostrarArchivos.Visible = false;
            dtgvArchivos.Visible = false;
            dtgvODPS.Visible = true;
            indice = gcmbProceso.SelectedIndex;
            if (indice == 1)
            {
                smUniversoApdmCapturaBitacora.CargarGridBitacora(dtgvODPS);
            }
            if (indice == 2)
            {
                smUniversoApdmCapturaCerm.CargarGridCerm(dtgvODPS);
            }
            if (indice == 3)
            {
                smUniversoApdmCapturaOdp.CargarGridODP(dtgvODPS);
            }
            if (indice == 4)
            {
                //smUniversoApdmCapturaOdp.CargarGridODP(dtgvODPS);
            }
            if (indice == 5)
            {
                smUniversoApdmCapturaCedUni.CargarGridCedUni(dtgvODPS);
            }

        }
        #endregion
        #region Botonos para Importar la Info despues de Examinar cada Proceso Operativo
        /*Para Enviar a la Tabla Apdm_Captura_Bitacora*/
        private void gBtnImportarBD_Click(object sender, EventArgs e)
        {
            EnviarMysqlBDBitacora();
        }
        /*Para Enviar a la Tabla Apdm_Resumen_Encuesta_Bitacora*/
        private void gBtnBDResumen_Click(object sender, EventArgs e)
        {
            EnviarBdApdmResumenBitacora();
        }
        /*Para Enviar a la Tabla Apdm_Captura_Cerm*/
        private void gBtnImportarBDCerm_Click(object sender, EventArgs e)
        {
            EnviarMysqlBDCerm();
        }
        /*Para Enviar a la Tabla Apdm_Resumen_Encuesta_Cerm*/
        private void gBtnBDResumenCerm_Click(object sender, EventArgs e)
        {
            EnviarBdApdmResumenCerm();
        }
        /*Para Enviar a la Tabla Apdm_Captura_Odp*/
        private void gbtnImportarCapturaOPD_Click(object sender, EventArgs e)
        {
            EnviarMysqlBDOdp();
        }
        /*Para Enviar a la Tabla Apdm_Resumen_Encuesta_Odp*/
        private void gbtnImportarResumenCapturaOPD_Click(object sender, EventArgs e)
        {
            EnviarBdApdmResumenOdp();
            smUniversoApdmCapturaOdp.CargarGridODP(dtgvODPS);
        }
        /*Para Enviar a la Tabla Apdm_Captura_Cubesma*/
        private void gbtnImportarCapturaCubesma_Click(object sender, EventArgs e)
        {
            EnviarMysqlBDCubesma();
        }
        /*Para Enviar a la Tabla Apdm_Resumen_Encuesta_Cubesma*/
        private void gbtnImportarResumenCapturaCubesma_Click(object sender, EventArgs e)
        {
            EnviarBdApdmResumenCubesma();
            //smUniversoApdmCapturaOdp.CargarGridODP(dtgvODPS);
        }
        /*Para Enviar a la Tabla Apdm_Captura_Ced_Uni*/
        private void gbtnImportarCapturaCedUni_Click(object sender, EventArgs e)
        {
            EnviarMysqlBDCedUni();
        }
        /*Para Enviar a la Tabla Apdm_Resumen_Encuesta_Ced_Uni*/
        private void gbtnImportarResumenCapturaCedUni_Click(object sender, EventArgs e)
        {
            EnviarBdApdmResumenCedUni();
        }
        #endregion
        #region Examinar los archivos txt de los archivos de APDM_CAPTURA y APDM_RESUMEN_ENCUESTA por cada Proceso Operativo
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
        private void gbtnExaminarCapturaOPD_Click(object sender, EventArgs e)
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
            string saveArchivo = @"D:\APDM_CAPTURA_ODP" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + "_" + DateTime.Now.Hour.ToString() + "_" + DateTime.Now.Minute.ToString() + "_" + DateTime.Now.Second.ToString() + ".txt";

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
        private void gbtnExaminarResumenCapturaOPD_Click(object sender, EventArgs e)
        {
            ltbText.Text = "";
            //dtgvArchivos.Rows.Clear();
            string rutaDirectorio = string.Empty;
            string rutaarchivo = string.Empty;
            string linea;
            int lineatxt = 0;
            string saveArchivo = @"D:\APDM_RESUMEN_CAPTURA_ODP" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + "_" + DateTime.Now.Hour.ToString() + "_" + DateTime.Now.Minute.ToString() + "_" + DateTime.Now.Second.ToString() + ".txt";

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
        private void gbtnExaminarCapturaCubesma_Click(object sender, EventArgs e)
        {
            string rutaDirectorio = string.Empty;
            string rutaarchivo = string.Empty;
            string linea;
            int lineatxt = 0;
            string saveArchivo = @"D:\APDM_CAPTURA_CUBESMA" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + "_" + DateTime.Now.Hour.ToString() + "_" + DateTime.Now.Minute.ToString() + "_" + DateTime.Now.Second.ToString() + ".txt";

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
        private void gBtnTxtResumenCubesma_Click(object sender, EventArgs e)
        {
            string rutaDirectorio = string.Empty;
            string rutaarchivo = string.Empty;
            string linea;
            int lineatxt = 0;
            string saveArchivo = @"D:\APDM_RESUMEN_CAPTURA_CUBESMA" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + "_" + DateTime.Now.Hour.ToString() + "_" + DateTime.Now.Minute.ToString() + "_" + DateTime.Now.Second.ToString() + ".txt";

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
        private void gbtnExaminarCapturaCedUni_Click(object sender, EventArgs e)
        {
            ltbText.Text = "";
            //dtgvArchivos.Rows.Clear();
            string rutaDirectorio = string.Empty;
            string rutaarchivo = string.Empty;
            string linea;
            int lineatxt = 0;
            string saveArchivo = @"D:\APDM_CAPTURA_CED_UNI" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + "_" + DateTime.Now.Hour.ToString() + "_" + DateTime.Now.Minute.ToString() + "_" + DateTime.Now.Second.ToString() + ".txt";

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
        private void gBtnTxtResumenCedUni_Click(object sender, EventArgs e)
        {
            string rutaDirectorio = string.Empty;
            string rutaarchivo = string.Empty;
            string linea;
            int lineatxt = 0;
            string saveArchivo = @"D:\APDM_RESUMEN_CAPTURA_CED_UNI" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + "_" + DateTime.Now.Hour.ToString() + "_" + DateTime.Now.Minute.ToString() + "_" + DateTime.Now.Second.ToString() + ".txt";

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


        #endregion
        #region Metodo para Convertir en uno solo todos los txt por proceso
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
 #endregion       
    }
}   