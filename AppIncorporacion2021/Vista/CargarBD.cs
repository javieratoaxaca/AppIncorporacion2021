using System;
using AppIncorporacion2021.Config;
using System.Windows.Forms;
using AppIncorporacion2021.Data;
using AppIncorporacion2021.Modelo;
using MySql.Data.MySqlClient;



namespace AppIncorporacion2021
{
    public partial class CargarDB : Form
    {
        ConexionSQLite cnx=null;

        public CargarDB()
        {
            InitializeComponent();
          //  smBecarios = new Modelo.ModeloBecarios();
        }

        private void gBtnCloseFormDB_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Sirvara para obtener el tipo de base de datos a cargar
        private void gBtnExaminar_Click(object sender, EventArgs e)
        {
            //gTxtFiltro.Text = "*.S3DB";
            OpenFileDialog fBrowDialog = new OpenFileDialog();

            string path = fBrowDialog.ShowDialog() == DialogResult.OK ? fBrowDialog.FileName : "";
            gTxtDitectorio.Text = path;
            cnx = new ConexionSQLite();
            try
            {
                cnx.GetConnection(path);
                string sql = "select ID_PROGRAMA,NOMBRE,PRIMER_APELLIDO,SEGUNDO_APELLIDO,CURP,TELEFONO,EMAIL,GRADO_ESCOLAR,REGION_ID,SEDE,CVE_CCT,NOMBRE_CCT,CCT,MUNICIPIO_ID,CVE_LOCALIDAD,LOCALIDAD_ID,FOLIO_FORMATO,BIMESTRE,REMESA,ANIO  from becarios";
                var data=cnx.GetData(sql);
                gdtgvDetallesS3db.DataSource = data;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void gBtnBuscarDB_Click(object sender, EventArgs e)
        {
            
            Becarios dtBecarios = new Becarios();
            ModeloBecarios smBecarios = new ModeloBecarios();
            try
            {
                //cnxmysql = new ConexionBD();

                for(int i= 0; i < gdtgvDetallesS3db.RowCount; i++)
                {
                    dtBecarios.Id_programa = Convert.ToInt32(gdtgvDetallesS3db.Rows[i].Cells[0].Value.ToString());
                    dtBecarios.Nombre = gdtgvDetallesS3db.Rows[i].Cells[1].Value.ToString();
                    dtBecarios.Primer_apellido = gdtgvDetallesS3db.Rows[i].Cells[2].Value.ToString();
                    dtBecarios.Segundo_apellido = gdtgvDetallesS3db.Rows[i].Cells[3].Value.ToString();
                    dtBecarios.Curp = gdtgvDetallesS3db.Rows[i].Cells[4].Value.ToString();
                    dtBecarios.Telefono = gdtgvDetallesS3db.Rows[i].Cells[5].Value.ToString();
                    dtBecarios.Email = gdtgvDetallesS3db.Rows[i].Cells[6].Value.ToString();
                    dtBecarios.Grado_escolar = Convert.ToInt32(gdtgvDetallesS3db.Rows[i].Cells[7].Value.ToString());
                    dtBecarios.Region_id = gdtgvDetallesS3db.Rows[i].Cells[8].Value.ToString();
                    dtBecarios.Sede = gdtgvDetallesS3db.Rows[i].Cells[9].Value.ToString();
                    dtBecarios.Cve_cct = gdtgvDetallesS3db.Rows[i].Cells[10].Value.ToString();
                    dtBecarios.Nombre_cct = gdtgvDetallesS3db.Rows[i].Cells[11].Value.ToString();
                    dtBecarios.Cct=gdtgvDetallesS3db.Rows[i].Cells[12].Value.ToString();
                    dtBecarios.Municipio_id = Convert.ToInt32(gdtgvDetallesS3db.Rows[i].Cells[13].Value.ToString());
                    dtBecarios.Cve_localidad = Convert.ToInt32(gdtgvDetallesS3db.Rows[i].Cells[14].Value.ToString());
                    dtBecarios.Localidad_id = Convert.ToInt32(gdtgvDetallesS3db.Rows[i].Cells[15].Value.ToString());
                    dtBecarios.Folio_formato = gdtgvDetallesS3db.Rows[i].Cells[16].Value.ToString();
                    dtBecarios.Bimestre = Convert.ToInt32(gdtgvDetallesS3db.Rows[i].Cells[17].Value.ToString());
                    dtBecarios.Remesa = gdtgvDetallesS3db.Rows[i].Cells[18].Value.ToString();
                    dtBecarios.Anio = gdtgvDetallesS3db.Rows[i].Cells[19].Value.ToString();
                    smBecarios.SetBecarios(dtBecarios);
                }                
            }            
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        //Metodo para insertar los Datos del DatagridView a la Base de Datos
        private void insertBecarios()
        {
            
        }
    }
}
