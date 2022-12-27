namespace AppIncorporacion2021.Vista
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.btnMin = new Guna.UI.WinForms.GunaButton();
            this.btnMax = new Guna.UI.WinForms.GunaButton();
            this.btnClose = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.pnlPiePagina = new System.Windows.Forms.Panel();
            this.pnlCentral = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlMenuLateral = new System.Windows.Forms.Panel();
            this.pnlSubMenuAdmin = new System.Windows.Forms.Panel();
            this.gBtnSiDm = new Guna.UI.WinForms.GunaButton();
            this.gBtnSubMenuAdminJef = new Guna.UI.WinForms.GunaButton();
            this.gBtnSubMenuAdminEms = new Guna.UI.WinForms.GunaButton();
            this.gBtnSubMenuAdminBasica = new Guna.UI.WinForms.GunaButton();
            this.gBtnAdmin = new Guna.UI.WinForms.GunaButton();
            this.pnlSubMenuMetas = new System.Windows.Forms.Panel();
            this.gbtnSubMenuMetaJef = new Guna.UI.WinForms.GunaButton();
            this.gbtnSubMenuMetaEms = new Guna.UI.WinForms.GunaButton();
            this.gbtnSubMenuMetaBasica = new Guna.UI.WinForms.GunaButton();
            this.gBtnDataGrid = new Guna.UI.WinForms.GunaButton();
            this.pnlSubmenuUniversos = new System.Windows.Forms.Panel();
            this.gBtnSubMenuJef = new Guna.UI.WinForms.GunaButton();
            this.gBtnSubMenuEms = new Guna.UI.WinForms.GunaButton();
            this.gBtnSubMenuBasica = new Guna.UI.WinForms.GunaButton();
            this.gBtnUniversos = new Guna.UI.WinForms.GunaButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlEncabezado.SuspendLayout();
            this.pnlCentral.SuspendLayout();
            this.pnlMenuLateral.SuspendLayout();
            this.pnlSubMenuAdmin.SuspendLayout();
            this.pnlSubMenuMetas.SuspendLayout();
            this.pnlSubmenuUniversos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 25;
            this.gunaElipse1.TargetControl = this;
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(89)))), ((int)(((byte)(70)))));
            this.pnlEncabezado.Controls.Add(this.btnMin);
            this.pnlEncabezado.Controls.Add(this.btnMax);
            this.pnlEncabezado.Controls.Add(this.btnClose);
            this.pnlEncabezado.Controls.Add(this.gunaLabel1);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1402, 42);
            this.pnlEncabezado.TabIndex = 0;
            this.pnlEncabezado.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlEncabezado_MouseDown);
            this.pnlEncabezado.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlEncabezado_MouseMove);
            this.pnlEncabezado.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlEncabezado_MouseUp);
            // 
            // btnMin
            // 
            this.btnMin.AnimationHoverSpeed = 0.07F;
            this.btnMin.AnimationSpeed = 0.03F;
            this.btnMin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            this.btnMin.BorderColor = System.Drawing.Color.Black;
            this.btnMin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FocusedColor = System.Drawing.Color.Empty;
            this.btnMin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Image = global::AppIncorporacion2021.Properties.Resources.min_64px;
            this.btnMin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMin.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMin.Location = new System.Drawing.Point(1262, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnMin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMin.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMin.OnHoverImage = null;
            this.btnMin.OnPressedColor = System.Drawing.Color.Black;
            this.btnMin.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.btnMin.Size = new System.Drawing.Size(40, 42);
            this.btnMin.TabIndex = 7;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.AnimationHoverSpeed = 0.07F;
            this.btnMax.AnimationSpeed = 0.03F;
            this.btnMax.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(188)))), ((int)(((byte)(154)))));
            this.btnMax.BorderColor = System.Drawing.Color.Black;
            this.btnMax.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMax.FocusedColor = System.Drawing.Color.Empty;
            this.btnMax.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMax.ForeColor = System.Drawing.Color.White;
            this.btnMax.Image = global::AppIncorporacion2021.Properties.Resources.max_64px;
            this.btnMax.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMax.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMax.Location = new System.Drawing.Point(1302, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnMax.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMax.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMax.OnHoverImage = null;
            this.btnMax.OnPressedColor = System.Drawing.Color.Black;
            this.btnMax.Size = new System.Drawing.Size(50, 42);
            this.btnMax.TabIndex = 8;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnClose
            // 
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.btnClose.BorderColor = System.Drawing.Color.Black;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FocusedColor = System.Drawing.Color.Empty;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::AppIncorporacion2021.Properties.Resources.icons8_cancel_64px;
            this.btnClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClose.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.Location = new System.Drawing.Point(1352, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Size = new System.Drawing.Size(50, 42);
            this.btnClose.TabIndex = 6;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Semi Rounded Sans Serif 7", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(22, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(120, 23);
            this.gunaLabel1.TabIndex = 5;
            this.gunaLabel1.Text = "DashBoard";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // pnlPiePagina
            // 
            this.pnlPiePagina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.pnlPiePagina.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPiePagina.Location = new System.Drawing.Point(0, 840);
            this.pnlPiePagina.Name = "pnlPiePagina";
            this.pnlPiePagina.Size = new System.Drawing.Size(1402, 13);
            this.pnlPiePagina.TabIndex = 1;
            // 
            // pnlCentral
            // 
            this.pnlCentral.Controls.Add(this.pnlMenu);
            this.pnlCentral.Controls.Add(this.pnlMenuLateral);
            this.pnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentral.Location = new System.Drawing.Point(0, 42);
            this.pnlCentral.Name = "pnlCentral";
            this.pnlCentral.Size = new System.Drawing.Size(1402, 798);
            this.pnlCentral.TabIndex = 2;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Location = new System.Drawing.Point(240, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1162, 798);
            this.pnlMenu.TabIndex = 1;
            // 
            // pnlMenuLateral
            // 
            this.pnlMenuLateral.AutoScroll = true;
            this.pnlMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(89)))), ((int)(((byte)(70)))));
            this.pnlMenuLateral.Controls.Add(this.pnlSubMenuAdmin);
            this.pnlMenuLateral.Controls.Add(this.gBtnAdmin);
            this.pnlMenuLateral.Controls.Add(this.pnlSubMenuMetas);
            this.pnlMenuLateral.Controls.Add(this.gBtnDataGrid);
            this.pnlMenuLateral.Controls.Add(this.pnlSubmenuUniversos);
            this.pnlMenuLateral.Controls.Add(this.gBtnUniversos);
            this.pnlMenuLateral.Controls.Add(this.pnlLogo);
            this.pnlMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuLateral.Name = "pnlMenuLateral";
            this.pnlMenuLateral.Size = new System.Drawing.Size(240, 798);
            this.pnlMenuLateral.TabIndex = 0;
            // 
            // pnlSubMenuAdmin
            // 
            this.pnlSubMenuAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            this.pnlSubMenuAdmin.Controls.Add(this.gBtnSiDm);
            this.pnlSubMenuAdmin.Controls.Add(this.gBtnSubMenuAdminJef);
            this.pnlSubMenuAdmin.Controls.Add(this.gBtnSubMenuAdminEms);
            this.pnlSubMenuAdmin.Controls.Add(this.gBtnSubMenuAdminBasica);
            this.pnlSubMenuAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuAdmin.Location = new System.Drawing.Point(0, 388);
            this.pnlSubMenuAdmin.Name = "pnlSubMenuAdmin";
            this.pnlSubMenuAdmin.Size = new System.Drawing.Size(240, 194);
            this.pnlSubMenuAdmin.TabIndex = 7;
            // 
            // gBtnSiDm
            // 
            this.gBtnSiDm.AnimationHoverSpeed = 0.07F;
            this.gBtnSiDm.AnimationSpeed = 0.03F;
            this.gBtnSiDm.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            this.gBtnSiDm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gBtnSiDm.BorderSize = 1;
            this.gBtnSiDm.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gBtnSiDm.Dock = System.Windows.Forms.DockStyle.Top;
            this.gBtnSiDm.FocusedColor = System.Drawing.Color.Empty;
            this.gBtnSiDm.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gBtnSiDm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gBtnSiDm.Image = global::AppIncorporacion2021.Properties.Resources.icons8_university_100px_1;
            this.gBtnSiDm.ImageSize = new System.Drawing.Size(30, 30);
            this.gBtnSiDm.Location = new System.Drawing.Point(0, 130);
            this.gBtnSiDm.Name = "gBtnSiDm";
            this.gBtnSiDm.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gBtnSiDm.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gBtnSiDm.OnHoverForeColor = System.Drawing.Color.White;
            this.gBtnSiDm.OnHoverImage = null;
            this.gBtnSiDm.OnPressedColor = System.Drawing.Color.Black;
            this.gBtnSiDm.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.gBtnSiDm.Size = new System.Drawing.Size(240, 35);
            this.gBtnSiDm.TabIndex = 3;
            this.gBtnSiDm.Text = "Sis. Info. Dm";
            this.gBtnSiDm.Click += new System.EventHandler(this.gBtnSiDm_Click);
            // 
            // gBtnSubMenuAdminJef
            // 
            this.gBtnSubMenuAdminJef.AnimationHoverSpeed = 0.07F;
            this.gBtnSubMenuAdminJef.AnimationSpeed = 0.03F;
            this.gBtnSubMenuAdminJef.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            this.gBtnSubMenuAdminJef.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gBtnSubMenuAdminJef.BorderSize = 1;
            this.gBtnSubMenuAdminJef.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gBtnSubMenuAdminJef.Dock = System.Windows.Forms.DockStyle.Top;
            this.gBtnSubMenuAdminJef.FocusedColor = System.Drawing.Color.Empty;
            this.gBtnSubMenuAdminJef.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gBtnSubMenuAdminJef.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gBtnSubMenuAdminJef.Image = global::AppIncorporacion2021.Properties.Resources.icons8_university_100px_1;
            this.gBtnSubMenuAdminJef.ImageSize = new System.Drawing.Size(30, 30);
            this.gBtnSubMenuAdminJef.Location = new System.Drawing.Point(0, 84);
            this.gBtnSubMenuAdminJef.Name = "gBtnSubMenuAdminJef";
            this.gBtnSubMenuAdminJef.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gBtnSubMenuAdminJef.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gBtnSubMenuAdminJef.OnHoverForeColor = System.Drawing.Color.White;
            this.gBtnSubMenuAdminJef.OnHoverImage = null;
            this.gBtnSubMenuAdminJef.OnPressedColor = System.Drawing.Color.Black;
            this.gBtnSubMenuAdminJef.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.gBtnSubMenuAdminJef.Size = new System.Drawing.Size(240, 46);
            this.gBtnSubMenuAdminJef.TabIndex = 2;
            this.gBtnSubMenuAdminJef.Text = "Educación Superior";
            this.gBtnSubMenuAdminJef.Click += new System.EventHandler(this.gBtnSubMenuAdminJef_Click);
            // 
            // gBtnSubMenuAdminEms
            // 
            this.gBtnSubMenuAdminEms.AnimationHoverSpeed = 0.07F;
            this.gBtnSubMenuAdminEms.AnimationSpeed = 0.03F;
            this.gBtnSubMenuAdminEms.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            this.gBtnSubMenuAdminEms.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gBtnSubMenuAdminEms.BorderSize = 1;
            this.gBtnSubMenuAdminEms.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gBtnSubMenuAdminEms.Dock = System.Windows.Forms.DockStyle.Top;
            this.gBtnSubMenuAdminEms.FocusedColor = System.Drawing.Color.Empty;
            this.gBtnSubMenuAdminEms.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gBtnSubMenuAdminEms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gBtnSubMenuAdminEms.Image = global::AppIncorporacion2021.Properties.Resources.icons8_classroom_52px_1;
            this.gBtnSubMenuAdminEms.ImageSize = new System.Drawing.Size(30, 30);
            this.gBtnSubMenuAdminEms.Location = new System.Drawing.Point(0, 42);
            this.gBtnSubMenuAdminEms.Name = "gBtnSubMenuAdminEms";
            this.gBtnSubMenuAdminEms.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gBtnSubMenuAdminEms.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gBtnSubMenuAdminEms.OnHoverForeColor = System.Drawing.Color.White;
            this.gBtnSubMenuAdminEms.OnHoverImage = null;
            this.gBtnSubMenuAdminEms.OnPressedColor = System.Drawing.Color.Black;
            this.gBtnSubMenuAdminEms.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.gBtnSubMenuAdminEms.Size = new System.Drawing.Size(240, 42);
            this.gBtnSubMenuAdminEms.TabIndex = 1;
            this.gBtnSubMenuAdminEms.Text = "Educación Media Superior";
            this.gBtnSubMenuAdminEms.Click += new System.EventHandler(this.gBtnSubMenuAdminEms_Click);
            // 
            // gBtnSubMenuAdminBasica
            // 
            this.gBtnSubMenuAdminBasica.AnimationHoverSpeed = 0.07F;
            this.gBtnSubMenuAdminBasica.AnimationSpeed = 0.03F;
            this.gBtnSubMenuAdminBasica.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            this.gBtnSubMenuAdminBasica.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gBtnSubMenuAdminBasica.BorderSize = 1;
            this.gBtnSubMenuAdminBasica.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gBtnSubMenuAdminBasica.Dock = System.Windows.Forms.DockStyle.Top;
            this.gBtnSubMenuAdminBasica.FocusedColor = System.Drawing.Color.Empty;
            this.gBtnSubMenuAdminBasica.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gBtnSubMenuAdminBasica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gBtnSubMenuAdminBasica.Image = global::AppIncorporacion2021.Properties.Resources.icons8_brick_60px_1;
            this.gBtnSubMenuAdminBasica.ImageSize = new System.Drawing.Size(30, 30);
            this.gBtnSubMenuAdminBasica.Location = new System.Drawing.Point(0, 0);
            this.gBtnSubMenuAdminBasica.Name = "gBtnSubMenuAdminBasica";
            this.gBtnSubMenuAdminBasica.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gBtnSubMenuAdminBasica.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gBtnSubMenuAdminBasica.OnHoverForeColor = System.Drawing.Color.White;
            this.gBtnSubMenuAdminBasica.OnHoverImage = null;
            this.gBtnSubMenuAdminBasica.OnPressedColor = System.Drawing.Color.Black;
            this.gBtnSubMenuAdminBasica.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.gBtnSubMenuAdminBasica.Size = new System.Drawing.Size(240, 42);
            this.gBtnSubMenuAdminBasica.TabIndex = 0;
            this.gBtnSubMenuAdminBasica.Text = "Educación Básica";
            this.gBtnSubMenuAdminBasica.Click += new System.EventHandler(this.gBtnSubMenuAdminBasica_Click);
            // 
            // gBtnAdmin
            // 
            this.gBtnAdmin.AnimationHoverSpeed = 0.07F;
            this.gBtnAdmin.AnimationSpeed = 0.03F;
            this.gBtnAdmin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gBtnAdmin.BorderColor = System.Drawing.Color.Black;
            this.gBtnAdmin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gBtnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.gBtnAdmin.FocusedColor = System.Drawing.Color.Empty;
            this.gBtnAdmin.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.gBtnAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gBtnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("gBtnAdmin.Image")));
            this.gBtnAdmin.ImageSize = new System.Drawing.Size(20, 20);
            this.gBtnAdmin.Location = new System.Drawing.Point(0, 365);
            this.gBtnAdmin.Name = "gBtnAdmin";
            this.gBtnAdmin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gBtnAdmin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gBtnAdmin.OnHoverForeColor = System.Drawing.Color.White;
            this.gBtnAdmin.OnHoverImage = null;
            this.gBtnAdmin.OnPressedColor = System.Drawing.Color.Black;
            this.gBtnAdmin.Size = new System.Drawing.Size(240, 23);
            this.gBtnAdmin.TabIndex = 6;
            this.gBtnAdmin.Text = "Herramientas";
            this.gBtnAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gBtnAdmin.Click += new System.EventHandler(this.gBtnAdmin_Click);
            // 
            // pnlSubMenuMetas
            // 
            this.pnlSubMenuMetas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            this.pnlSubMenuMetas.Controls.Add(this.gbtnSubMenuMetaJef);
            this.pnlSubMenuMetas.Controls.Add(this.gbtnSubMenuMetaEms);
            this.pnlSubMenuMetas.Controls.Add(this.gbtnSubMenuMetaBasica);
            this.pnlSubMenuMetas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuMetas.Location = new System.Drawing.Point(0, 235);
            this.pnlSubMenuMetas.Name = "pnlSubMenuMetas";
            this.pnlSubMenuMetas.Size = new System.Drawing.Size(240, 130);
            this.pnlSubMenuMetas.TabIndex = 5;
            // 
            // gbtnSubMenuMetaJef
            // 
            this.gbtnSubMenuMetaJef.AnimationHoverSpeed = 0.07F;
            this.gbtnSubMenuMetaJef.AnimationSpeed = 0.03F;
            this.gbtnSubMenuMetaJef.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            this.gbtnSubMenuMetaJef.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gbtnSubMenuMetaJef.BorderSize = 1;
            this.gbtnSubMenuMetaJef.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtnSubMenuMetaJef.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbtnSubMenuMetaJef.FocusedColor = System.Drawing.Color.Empty;
            this.gbtnSubMenuMetaJef.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gbtnSubMenuMetaJef.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gbtnSubMenuMetaJef.Image = global::AppIncorporacion2021.Properties.Resources.icons8_university_100px_1;
            this.gbtnSubMenuMetaJef.ImageSize = new System.Drawing.Size(30, 30);
            this.gbtnSubMenuMetaJef.Location = new System.Drawing.Point(0, 84);
            this.gbtnSubMenuMetaJef.Name = "gbtnSubMenuMetaJef";
            this.gbtnSubMenuMetaJef.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gbtnSubMenuMetaJef.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtnSubMenuMetaJef.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtnSubMenuMetaJef.OnHoverImage = null;
            this.gbtnSubMenuMetaJef.OnPressedColor = System.Drawing.Color.Black;
            this.gbtnSubMenuMetaJef.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.gbtnSubMenuMetaJef.Size = new System.Drawing.Size(240, 42);
            this.gbtnSubMenuMetaJef.TabIndex = 2;
            this.gbtnSubMenuMetaJef.Text = "Cargar DB Educación Superior";
            this.gbtnSubMenuMetaJef.Click += new System.EventHandler(this.gbtnSubMenuMetaJef_Click);
            // 
            // gbtnSubMenuMetaEms
            // 
            this.gbtnSubMenuMetaEms.AnimationHoverSpeed = 0.07F;
            this.gbtnSubMenuMetaEms.AnimationSpeed = 0.03F;
            this.gbtnSubMenuMetaEms.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            this.gbtnSubMenuMetaEms.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gbtnSubMenuMetaEms.BorderSize = 1;
            this.gbtnSubMenuMetaEms.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtnSubMenuMetaEms.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbtnSubMenuMetaEms.FocusedColor = System.Drawing.Color.Empty;
            this.gbtnSubMenuMetaEms.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gbtnSubMenuMetaEms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gbtnSubMenuMetaEms.Image = global::AppIncorporacion2021.Properties.Resources.icons8_classroom_52px_1;
            this.gbtnSubMenuMetaEms.ImageSize = new System.Drawing.Size(30, 30);
            this.gbtnSubMenuMetaEms.Location = new System.Drawing.Point(0, 42);
            this.gbtnSubMenuMetaEms.Name = "gbtnSubMenuMetaEms";
            this.gbtnSubMenuMetaEms.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gbtnSubMenuMetaEms.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtnSubMenuMetaEms.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtnSubMenuMetaEms.OnHoverImage = null;
            this.gbtnSubMenuMetaEms.OnPressedColor = System.Drawing.Color.Black;
            this.gbtnSubMenuMetaEms.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.gbtnSubMenuMetaEms.Size = new System.Drawing.Size(240, 42);
            this.gbtnSubMenuMetaEms.TabIndex = 1;
            this.gbtnSubMenuMetaEms.Text = "Cargar DB E. Media Superior";
            this.gbtnSubMenuMetaEms.Click += new System.EventHandler(this.gbtnSubMenuMetaEms_Click);
            // 
            // gbtnSubMenuMetaBasica
            // 
            this.gbtnSubMenuMetaBasica.AnimationHoverSpeed = 0.07F;
            this.gbtnSubMenuMetaBasica.AnimationSpeed = 0.03F;
            this.gbtnSubMenuMetaBasica.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            this.gbtnSubMenuMetaBasica.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gbtnSubMenuMetaBasica.BorderSize = 1;
            this.gbtnSubMenuMetaBasica.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtnSubMenuMetaBasica.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbtnSubMenuMetaBasica.FocusedColor = System.Drawing.Color.Empty;
            this.gbtnSubMenuMetaBasica.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gbtnSubMenuMetaBasica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gbtnSubMenuMetaBasica.Image = global::AppIncorporacion2021.Properties.Resources.icons8_brick_60px_1;
            this.gbtnSubMenuMetaBasica.ImageSize = new System.Drawing.Size(30, 30);
            this.gbtnSubMenuMetaBasica.Location = new System.Drawing.Point(0, 0);
            this.gbtnSubMenuMetaBasica.Name = "gbtnSubMenuMetaBasica";
            this.gbtnSubMenuMetaBasica.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gbtnSubMenuMetaBasica.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtnSubMenuMetaBasica.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtnSubMenuMetaBasica.OnHoverImage = null;
            this.gbtnSubMenuMetaBasica.OnPressedColor = System.Drawing.Color.Black;
            this.gbtnSubMenuMetaBasica.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.gbtnSubMenuMetaBasica.Size = new System.Drawing.Size(240, 42);
            this.gbtnSubMenuMetaBasica.TabIndex = 0;
            this.gbtnSubMenuMetaBasica.Text = "Cargar DB Educación Básica";
            this.gbtnSubMenuMetaBasica.Click += new System.EventHandler(this.gbtnSubMenuMetaBasica_Click);
            // 
            // gBtnDataGrid
            // 
            this.gBtnDataGrid.AnimationHoverSpeed = 0.07F;
            this.gBtnDataGrid.AnimationSpeed = 0.03F;
            this.gBtnDataGrid.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gBtnDataGrid.BorderColor = System.Drawing.Color.Black;
            this.gBtnDataGrid.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gBtnDataGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.gBtnDataGrid.FocusedColor = System.Drawing.Color.Empty;
            this.gBtnDataGrid.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.gBtnDataGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gBtnDataGrid.Image = ((System.Drawing.Image)(resources.GetObject("gBtnDataGrid.Image")));
            this.gBtnDataGrid.ImageSize = new System.Drawing.Size(20, 20);
            this.gBtnDataGrid.Location = new System.Drawing.Point(0, 193);
            this.gBtnDataGrid.Name = "gBtnDataGrid";
            this.gBtnDataGrid.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gBtnDataGrid.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gBtnDataGrid.OnHoverForeColor = System.Drawing.Color.White;
            this.gBtnDataGrid.OnHoverImage = null;
            this.gBtnDataGrid.OnPressedColor = System.Drawing.Color.Black;
            this.gBtnDataGrid.Size = new System.Drawing.Size(240, 42);
            this.gBtnDataGrid.TabIndex = 4;
            this.gBtnDataGrid.Text = "Metas";
            this.gBtnDataGrid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gBtnDataGrid.Click += new System.EventHandler(this.gBtnDataGrid_Click);
            // 
            // pnlSubmenuUniversos
            // 
            this.pnlSubmenuUniversos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            this.pnlSubmenuUniversos.Controls.Add(this.gBtnSubMenuJef);
            this.pnlSubmenuUniversos.Controls.Add(this.gBtnSubMenuEms);
            this.pnlSubmenuUniversos.Controls.Add(this.gBtnSubMenuBasica);
            this.pnlSubmenuUniversos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubmenuUniversos.Location = new System.Drawing.Point(0, 63);
            this.pnlSubmenuUniversos.Name = "pnlSubmenuUniversos";
            this.pnlSubmenuUniversos.Size = new System.Drawing.Size(240, 130);
            this.pnlSubmenuUniversos.TabIndex = 3;
            // 
            // gBtnSubMenuJef
            // 
            this.gBtnSubMenuJef.AnimationHoverSpeed = 0.07F;
            this.gBtnSubMenuJef.AnimationSpeed = 0.03F;
            this.gBtnSubMenuJef.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            this.gBtnSubMenuJef.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gBtnSubMenuJef.BorderSize = 1;
            this.gBtnSubMenuJef.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gBtnSubMenuJef.Dock = System.Windows.Forms.DockStyle.Top;
            this.gBtnSubMenuJef.FocusedColor = System.Drawing.Color.Empty;
            this.gBtnSubMenuJef.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gBtnSubMenuJef.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gBtnSubMenuJef.Image = global::AppIncorporacion2021.Properties.Resources.icons8_university_100px_1;
            this.gBtnSubMenuJef.ImageSize = new System.Drawing.Size(30, 30);
            this.gBtnSubMenuJef.Location = new System.Drawing.Point(0, 83);
            this.gBtnSubMenuJef.Name = "gBtnSubMenuJef";
            this.gBtnSubMenuJef.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gBtnSubMenuJef.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gBtnSubMenuJef.OnHoverForeColor = System.Drawing.Color.White;
            this.gBtnSubMenuJef.OnHoverImage = null;
            this.gBtnSubMenuJef.OnPressedColor = System.Drawing.Color.Black;
            this.gBtnSubMenuJef.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.gBtnSubMenuJef.Size = new System.Drawing.Size(240, 35);
            this.gBtnSubMenuJef.TabIndex = 2;
            this.gBtnSubMenuJef.Text = "Educación Superior";
            this.gBtnSubMenuJef.Click += new System.EventHandler(this.gBtnSubMenuJef_Click);
            // 
            // gBtnSubMenuEms
            // 
            this.gBtnSubMenuEms.AnimationHoverSpeed = 0.07F;
            this.gBtnSubMenuEms.AnimationSpeed = 0.03F;
            this.gBtnSubMenuEms.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            this.gBtnSubMenuEms.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gBtnSubMenuEms.BorderSize = 1;
            this.gBtnSubMenuEms.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gBtnSubMenuEms.Dock = System.Windows.Forms.DockStyle.Top;
            this.gBtnSubMenuEms.FocusedColor = System.Drawing.Color.Empty;
            this.gBtnSubMenuEms.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gBtnSubMenuEms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gBtnSubMenuEms.Image = global::AppIncorporacion2021.Properties.Resources.icons8_classroom_52px_1;
            this.gBtnSubMenuEms.ImageSize = new System.Drawing.Size(30, 30);
            this.gBtnSubMenuEms.Location = new System.Drawing.Point(0, 29);
            this.gBtnSubMenuEms.Name = "gBtnSubMenuEms";
            this.gBtnSubMenuEms.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gBtnSubMenuEms.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gBtnSubMenuEms.OnHoverForeColor = System.Drawing.Color.White;
            this.gBtnSubMenuEms.OnHoverImage = null;
            this.gBtnSubMenuEms.OnPressedColor = System.Drawing.Color.Black;
            this.gBtnSubMenuEms.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.gBtnSubMenuEms.Size = new System.Drawing.Size(240, 54);
            this.gBtnSubMenuEms.TabIndex = 1;
            this.gBtnSubMenuEms.Text = "Educación Media Superior";
            this.gBtnSubMenuEms.Click += new System.EventHandler(this.gBtnSubMenuEms_Click);
            // 
            // gBtnSubMenuBasica
            // 
            this.gBtnSubMenuBasica.AnimationHoverSpeed = 0.07F;
            this.gBtnSubMenuBasica.AnimationSpeed = 0.03F;
            this.gBtnSubMenuBasica.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            this.gBtnSubMenuBasica.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gBtnSubMenuBasica.BorderSize = 1;
            this.gBtnSubMenuBasica.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gBtnSubMenuBasica.Dock = System.Windows.Forms.DockStyle.Top;
            this.gBtnSubMenuBasica.FocusedColor = System.Drawing.Color.Empty;
            this.gBtnSubMenuBasica.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gBtnSubMenuBasica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gBtnSubMenuBasica.Image = global::AppIncorporacion2021.Properties.Resources.icons8_brick_60px_1;
            this.gBtnSubMenuBasica.ImageSize = new System.Drawing.Size(30, 30);
            this.gBtnSubMenuBasica.Location = new System.Drawing.Point(0, 0);
            this.gBtnSubMenuBasica.Name = "gBtnSubMenuBasica";
            this.gBtnSubMenuBasica.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gBtnSubMenuBasica.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gBtnSubMenuBasica.OnHoverForeColor = System.Drawing.Color.White;
            this.gBtnSubMenuBasica.OnHoverImage = null;
            this.gBtnSubMenuBasica.OnPressedColor = System.Drawing.Color.Black;
            this.gBtnSubMenuBasica.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.gBtnSubMenuBasica.Size = new System.Drawing.Size(240, 29);
            this.gBtnSubMenuBasica.TabIndex = 0;
            this.gBtnSubMenuBasica.Text = "Educación Básica";
            this.gBtnSubMenuBasica.Click += new System.EventHandler(this.gBtnSubMenuBasica_Click);
            // 
            // gBtnUniversos
            // 
            this.gBtnUniversos.AnimationHoverSpeed = 0.07F;
            this.gBtnUniversos.AnimationSpeed = 0.03F;
            this.gBtnUniversos.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gBtnUniversos.BorderColor = System.Drawing.Color.Black;
            this.gBtnUniversos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gBtnUniversos.Dock = System.Windows.Forms.DockStyle.Top;
            this.gBtnUniversos.FocusedColor = System.Drawing.Color.Empty;
            this.gBtnUniversos.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.gBtnUniversos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gBtnUniversos.Image = global::AppIncorporacion2021.Properties.Resources.icons8_data_grid_60px;
            this.gBtnUniversos.ImageSize = new System.Drawing.Size(50, 50);
            this.gBtnUniversos.Location = new System.Drawing.Point(0, 17);
            this.gBtnUniversos.Name = "gBtnUniversos";
            this.gBtnUniversos.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gBtnUniversos.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gBtnUniversos.OnHoverForeColor = System.Drawing.Color.White;
            this.gBtnUniversos.OnHoverImage = null;
            this.gBtnUniversos.OnPressedColor = System.Drawing.Color.Black;
            this.gBtnUniversos.Size = new System.Drawing.Size(240, 46);
            this.gBtnUniversos.TabIndex = 1;
            this.gBtnUniversos.Text = "Universos";
            this.gBtnUniversos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gBtnUniversos.Click += new System.EventHandler(this.gBtnUniversos_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(240, 17);
            this.pnlLogo.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 853);
            this.Controls.Add(this.pnlCentral);
            this.Controls.Add(this.pnlPiePagina);
            this.Controls.Add(this.pnlEncabezado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.pnlCentral.ResumeLayout(false);
            this.pnlMenuLateral.ResumeLayout(false);
            this.pnlSubMenuAdmin.ResumeLayout(false);
            this.pnlSubMenuMetas.ResumeLayout(false);
            this.pnlSubmenuUniversos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Panel pnlPiePagina;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Panel pnlCentral;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Panel pnlMenuLateral;
        private System.Windows.Forms.Panel pnlLogo;
        private Guna.UI.WinForms.GunaButton gBtnDataGrid;
        private System.Windows.Forms.Panel pnlSubmenuUniversos;
        private Guna.UI.WinForms.GunaButton gBtnSubMenuJef;
        private Guna.UI.WinForms.GunaButton gBtnSubMenuEms;
        private Guna.UI.WinForms.GunaButton gBtnSubMenuBasica;
        private Guna.UI.WinForms.GunaButton gBtnUniversos;
        private System.Windows.Forms.Panel pnlSubMenuAdmin;
        private Guna.UI.WinForms.GunaButton gBtnSubMenuAdminJef;
        private Guna.UI.WinForms.GunaButton gBtnSubMenuAdminEms;
        private Guna.UI.WinForms.GunaButton gBtnSubMenuAdminBasica;
        private Guna.UI.WinForms.GunaButton gBtnAdmin;
        private System.Windows.Forms.Panel pnlSubMenuMetas;
        private Guna.UI.WinForms.GunaButton gbtnSubMenuMetaJef;
        private Guna.UI.WinForms.GunaButton gbtnSubMenuMetaEms;
        private Guna.UI.WinForms.GunaButton gbtnSubMenuMetaBasica;
        private System.Windows.Forms.Panel pnlMenu;
        private Guna.UI.WinForms.GunaButton btnMin;
        private Guna.UI.WinForms.GunaButton btnMax;
        private Guna.UI.WinForms.GunaButton btnClose;
        private Guna.UI.WinForms.GunaButton gBtnSiDm;
    }
}