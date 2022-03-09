using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppIncorporacion2021.Vista
{
    public partial class Dashboard : Form
    {
        int m, mx, my; //Variables Globales para la manipulacion de las ventana
        private Form activoFormulario = null;
        public Dashboard()
        {
            InitializeComponent();
            diseñoPersonalizado();
            abrirFormularioHijo(new Metas());
        }

        #region PersonalizarMenu
        //Metodo para Personalizar Diseño
        private void diseñoPersonalizado()
        {
            pnlSubMenuAdmin.Visible = false;
            pnlSubMenuMetas.Visible = false;
            pnlSubmenuUniversos.Visible = false;
        }

        //metodo para Ocultar el Submenu
        private void ocultarSubMenu()
        {
            if (pnlSubMenuAdmin.Visible == true)
                pnlSubMenuAdmin.Visible = false;
            if (pnlSubMenuMetas.Visible == true)
                pnlSubMenuMetas.Visible = false;
            if (pnlSubmenuUniversos.Visible == true)
                pnlSubmenuUniversos.Visible = false;
        }
        //metodo  vacio para mostrar el submenu
        private void mostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                ocultarSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        #endregion

        #region Menu 
        //Mostrar los SubMenus de los Botos del Menu Principal
        private void gBtnUniversos_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlSubmenuUniversos);
        }
        private void gBtnDataGrid_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlSubMenuMetas);
        }
        private void gBtnAdmin_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlSubMenuAdmin);
        }

        #endregion

        #region SubmenuUniverso
        private void gBtnSubMenuBasica_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new Main());
            
            /*
                    Aqui va el codigo para las demas operaciones
                    */
            ocultarSubMenu();
        }
        private void gBtnSubMenuEms_Click(object sender, EventArgs e)
        {

            /*
                    Aqui va el codigo para las demas operaciones
                    */
            ocultarSubMenu();
        }
        private void gBtnSubMenuJef_Click(object sender, EventArgs e)
        {
            /*
                    Aqui va el codigo para las demas operaciones
                    */
            ocultarSubMenu();
        }
        #endregion

        #region SubMenuMetas
        private void gbtnSubMenuMetaBasica_Click(object sender, EventArgs e)
        {
            /*
                   Aqui va el codigo para las demas operaciones
                   */
            ocultarSubMenu();
        }

        private void gbtnSubMenuMetaEms_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new CargarDB()); 
            /*
                   Aqui va el codigo para las demas operaciones
                   */
            ocultarSubMenu();
        }

        private void gbtnSubMenuMetaJef_Click(object sender, EventArgs e)
        {
            /*
                   Aqui va el codigo para las demas operaciones
                   */
            ocultarSubMenu();
        }
        #endregion

        #region SubMenuAdmin
        private void gBtnSubMenuAdminBasica_Click(object sender, EventArgs e)
        {
            /*
                  Aqui va el codigo para las demas operaciones
                  */
            ocultarSubMenu();
        }

        private void gBtnSubMenuAdminEms_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new OrdenPago());
            /*
                  Aqui va el codigo para las demas operaciones
                  */
            ocultarSubMenu();
        }

        private void gBtnSubMenuAdminJef_Click(object sender, EventArgs e)
        {
            /*
                  Aqui va el codigo para las demas operaciones
                  */
            abrirFormularioHijo(new zip());
            ocultarSubMenu();
        }

        #endregion

        #region ManejoBotonesMINMAXEXIT
        private void btnMin_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Minimized)
                WindowState = FormWindowState.Normal;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region MovimientoFormulario
        private void pnlEncabezado_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
        }

        private void pnlEncabezado_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new Metas());
        }

        private void pnlEncabezado_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }
        #endregion

        #region AbrirFormulario
        //Metodo para Abrir Formularios hijo en el formulario Padre
        private void abrirFormularioHijo(Form formHijo)
        {
            if (activoFormulario != null)
                activoFormulario.Close();

            activoFormulario = formHijo;
            formHijo.TopLevel = false;
            formHijo.Dock = DockStyle.Fill;
            pnlMenu.Controls.Add(formHijo);
            pnlMenu.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }
        #endregion

    }
    
}
