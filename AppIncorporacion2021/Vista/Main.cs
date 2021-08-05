using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppIncorporacion2021.Modelo;
using AppIncorporacion2021.Data;

namespace AppIncorporacion2021
{
    public partial class Main : Form
    {
        Modelo.ModeloIncorporacion smIncorporacion;
        int m, mx, my; //Variables Globales para la manipulacion de las ventana

        public Main()
        {
            InitializeComponent();
            smIncorporacion = new Modelo.ModeloIncorporacion();
            

        }
        #region Botones(Close,Max,Min)
       
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gdtgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            smIncorporacion.CargarGrid(gdtgvDetalles);
            
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
        }

        private void gBtnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbtnBuscar_Click(object sender, EventArgs e)
        {
            //string dato = gTxtBuscar.Text;
            //smIncorporacion.CargarGrid(gdtgvDetalles, dato);
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Minimized)
                WindowState = FormWindowState.Normal;
        }


        #endregion

        //private void CargarTabla(string dato)
        //{
        //    List<Incorporacion> lista = new List<Incorporacion>();
        //    gdtgvDetalles.DataSource = smIncorporacion.consulta(dato);
        //}

    }
}
