namespace AppIncorporacion2021
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gTxtBuscar = new Guna.UI.WinForms.GunaTextBox();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gBtnCloseForm = new Guna.UI.WinForms.GunaButton();
            this.gbtnBuscar = new Guna.UI.WinForms.GunaButton();
            this.gdtgvDetalles = new Guna.UI.WinForms.GunaDataGridView();
            this.gBtnEnd = new Guna.UI.WinForms.GunaButton();
            this.gBtnSkipNext = new Guna.UI.WinForms.GunaButton();
            this.gBtnSkipBegin = new Guna.UI.WinForms.GunaButton();
            this.gbtnBegin = new Guna.UI.WinForms.GunaButton();
            this.panel3.SuspendLayout();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdtgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.gBtnCloseForm);
            this.panel3.Controls.Add(this.gBtnEnd);
            this.panel3.Controls.Add(this.gBtnSkipNext);
            this.panel3.Controls.Add(this.gbtnBegin);
            this.panel3.Controls.Add(this.gBtnSkipBegin);
            this.panel3.Controls.Add(this.gbtnBuscar);
            this.panel3.Controls.Add(this.gunaLabel2);
            this.panel3.Controls.Add(this.gTxtBuscar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1003, 130);
            this.panel3.TabIndex = 2;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Semi Rounded Sans Serif 7", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gunaLabel2.Location = new System.Drawing.Point(118, 33);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(101, 23);
            this.gunaLabel2.TabIndex = 5;
            this.gunaLabel2.Text = "Buscar :";
            // 
            // gTxtBuscar
            // 
            this.gTxtBuscar.BackColor = System.Drawing.Color.Transparent;
            this.gTxtBuscar.BaseColor = System.Drawing.Color.White;
            this.gTxtBuscar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gTxtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gTxtBuscar.FocusedBaseColor = System.Drawing.Color.White;
            this.gTxtBuscar.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gTxtBuscar.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gTxtBuscar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.gTxtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gTxtBuscar.Location = new System.Drawing.Point(237, 21);
            this.gTxtBuscar.Name = "gTxtBuscar";
            this.gTxtBuscar.PasswordChar = '\0';
            this.gTxtBuscar.Radius = 15;
            this.gTxtBuscar.SelectedText = "";
            this.gTxtBuscar.Size = new System.Drawing.Size(573, 46);
            this.gTxtBuscar.TabIndex = 0;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Controls.Add(this.gdtgvDetalles);
            this.gunaElipsePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(0, 130);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(1003, 477);
            this.gunaElipsePanel1.TabIndex = 3;
            // 
            // gBtnCloseForm
            // 
            this.gBtnCloseForm.AnimationHoverSpeed = 0.07F;
            this.gBtnCloseForm.AnimationSpeed = 0.03F;
            this.gBtnCloseForm.BackColor = System.Drawing.Color.Transparent;
            this.gBtnCloseForm.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            this.gBtnCloseForm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gBtnCloseForm.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gBtnCloseForm.FocusedColor = System.Drawing.Color.Empty;
            this.gBtnCloseForm.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBtnCloseForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gBtnCloseForm.Image = global::AppIncorporacion2021.Properties.Resources.icons8_cancel_64px;
            this.gBtnCloseForm.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gBtnCloseForm.ImageSize = new System.Drawing.Size(30, 30);
            this.gBtnCloseForm.Location = new System.Drawing.Point(1, 3);
            this.gBtnCloseForm.Name = "gBtnCloseForm";
            this.gBtnCloseForm.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gBtnCloseForm.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gBtnCloseForm.OnHoverForeColor = System.Drawing.Color.White;
            this.gBtnCloseForm.OnHoverImage = null;
            this.gBtnCloseForm.OnPressedColor = System.Drawing.Color.Black;
            this.gBtnCloseForm.Radius = 20;
            this.gBtnCloseForm.Size = new System.Drawing.Size(37, 32);
            this.gBtnCloseForm.TabIndex = 11;
            this.gBtnCloseForm.Click += new System.EventHandler(this.gBtnCloseForm_Click);
            // 
            // gbtnBuscar
            // 
            this.gbtnBuscar.AnimationHoverSpeed = 0.07F;
            this.gbtnBuscar.AnimationSpeed = 0.03F;
            this.gbtnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.gbtnBuscar.BaseColor = System.Drawing.Color.White;
            this.gbtnBuscar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gbtnBuscar.BorderSize = 2;
            this.gbtnBuscar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtnBuscar.FocusedColor = System.Drawing.Color.Empty;
            this.gbtnBuscar.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gbtnBuscar.Image = global::AppIncorporacion2021.Properties.Resources.icons8_google_web_search_60px;
            this.gbtnBuscar.ImageSize = new System.Drawing.Size(40, 40);
            this.gbtnBuscar.Location = new System.Drawing.Point(827, 21);
            this.gbtnBuscar.Name = "gbtnBuscar";
            this.gbtnBuscar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gbtnBuscar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gbtnBuscar.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtnBuscar.OnHoverImage = null;
            this.gbtnBuscar.OnPressedColor = System.Drawing.Color.Black;
            this.gbtnBuscar.Radius = 10;
            this.gbtnBuscar.Size = new System.Drawing.Size(159, 46);
            this.gbtnBuscar.TabIndex = 6;
            this.gbtnBuscar.Text = "Buscar";
            this.gbtnBuscar.Click += new System.EventHandler(this.gbtnBuscar_Click);
            // 
            // gdtgvDetalles
            // 
            this.gdtgvDetalles.AllowUserToAddRows = false;
            this.gdtgvDetalles.AllowUserToDeleteRows = false;
            this.gdtgvDetalles.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gdtgvDetalles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gdtgvDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdtgvDetalles.BackgroundColor = System.Drawing.Color.Black;
            this.gdtgvDetalles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdtgvDetalles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.gdtgvDetalles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdtgvDetalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gdtgvDetalles.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Semi Rounded Sans Serif 7", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdtgvDetalles.DefaultCellStyle = dataGridViewCellStyle3;
            this.gdtgvDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdtgvDetalles.EnableHeadersVisualStyles = false;
            this.gdtgvDetalles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdtgvDetalles.Location = new System.Drawing.Point(0, 0);
            this.gdtgvDetalles.Name = "gdtgvDetalles";
            this.gdtgvDetalles.ReadOnly = true;
            this.gdtgvDetalles.RowHeadersVisible = false;
            this.gdtgvDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdtgvDetalles.Size = new System.Drawing.Size(1003, 477);
            this.gdtgvDetalles.TabIndex = 0;
            this.gdtgvDetalles.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gdtgvDetalles.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gdtgvDetalles.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gdtgvDetalles.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gdtgvDetalles.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gdtgvDetalles.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gdtgvDetalles.ThemeStyle.BackColor = System.Drawing.Color.Black;
            this.gdtgvDetalles.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdtgvDetalles.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gdtgvDetalles.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.gdtgvDetalles.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdtgvDetalles.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gdtgvDetalles.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gdtgvDetalles.ThemeStyle.HeaderStyle.Height = 45;
            this.gdtgvDetalles.ThemeStyle.ReadOnly = true;
            this.gdtgvDetalles.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            this.gdtgvDetalles.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.gdtgvDetalles.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Semi Rounded Sans Serif 7", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdtgvDetalles.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gdtgvDetalles.ThemeStyle.RowsStyle.Height = 22;
            this.gdtgvDetalles.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            this.gdtgvDetalles.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gdtgvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdtgvDetalles_CellContentClick);
            // 
            // gBtnEnd
            // 
            this.gBtnEnd.AnimationHoverSpeed = 0.07F;
            this.gBtnEnd.AnimationSpeed = 0.03F;
            this.gBtnEnd.BackColor = System.Drawing.Color.Transparent;
            this.gBtnEnd.BaseColor = System.Drawing.Color.White;
            this.gBtnEnd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gBtnEnd.BorderSize = 2;
            this.gBtnEnd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gBtnEnd.FocusedColor = System.Drawing.Color.Empty;
            this.gBtnEnd.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBtnEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gBtnEnd.Image = global::AppIncorporacion2021.Properties.Resources.icons8_sort_left_48px___copia;
            this.gBtnEnd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gBtnEnd.ImageSize = new System.Drawing.Size(50, 50);
            this.gBtnEnd.Location = new System.Drawing.Point(646, 77);
            this.gBtnEnd.Name = "gBtnEnd";
            this.gBtnEnd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gBtnEnd.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gBtnEnd.OnHoverForeColor = System.Drawing.Color.White;
            this.gBtnEnd.OnHoverImage = null;
            this.gBtnEnd.OnPressedColor = System.Drawing.Color.Black;
            this.gBtnEnd.Radius = 20;
            this.gBtnEnd.Size = new System.Drawing.Size(95, 46);
            this.gBtnEnd.TabIndex = 10;
            // 
            // gBtnSkipNext
            // 
            this.gBtnSkipNext.AnimationHoverSpeed = 0.07F;
            this.gBtnSkipNext.AnimationSpeed = 0.03F;
            this.gBtnSkipNext.BackColor = System.Drawing.Color.Transparent;
            this.gBtnSkipNext.BaseColor = System.Drawing.Color.White;
            this.gBtnSkipNext.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gBtnSkipNext.BorderSize = 2;
            this.gBtnSkipNext.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gBtnSkipNext.FocusedColor = System.Drawing.Color.Empty;
            this.gBtnSkipNext.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBtnSkipNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gBtnSkipNext.Image = global::AppIncorporacion2021.Properties.Resources.icons8_skip_to_start_48px___copia;
            this.gBtnSkipNext.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gBtnSkipNext.ImageSize = new System.Drawing.Size(50, 50);
            this.gBtnSkipNext.Location = new System.Drawing.Point(533, 77);
            this.gBtnSkipNext.Name = "gBtnSkipNext";
            this.gBtnSkipNext.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gBtnSkipNext.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gBtnSkipNext.OnHoverForeColor = System.Drawing.Color.White;
            this.gBtnSkipNext.OnHoverImage = null;
            this.gBtnSkipNext.OnPressedColor = System.Drawing.Color.Black;
            this.gBtnSkipNext.Radius = 20;
            this.gBtnSkipNext.Size = new System.Drawing.Size(95, 46);
            this.gBtnSkipNext.TabIndex = 9;
            // 
            // gBtnSkipBegin
            // 
            this.gBtnSkipBegin.AnimationHoverSpeed = 0.07F;
            this.gBtnSkipBegin.AnimationSpeed = 0.03F;
            this.gBtnSkipBegin.BackColor = System.Drawing.Color.Transparent;
            this.gBtnSkipBegin.BaseColor = System.Drawing.Color.White;
            this.gBtnSkipBegin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gBtnSkipBegin.BorderSize = 2;
            this.gBtnSkipBegin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gBtnSkipBegin.FocusedColor = System.Drawing.Color.Empty;
            this.gBtnSkipBegin.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBtnSkipBegin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gBtnSkipBegin.Image = global::AppIncorporacion2021.Properties.Resources.icons8_skip_to_start_48px;
            this.gBtnSkipBegin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gBtnSkipBegin.ImageSize = new System.Drawing.Size(50, 50);
            this.gBtnSkipBegin.Location = new System.Drawing.Point(422, 77);
            this.gBtnSkipBegin.Name = "gBtnSkipBegin";
            this.gBtnSkipBegin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gBtnSkipBegin.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gBtnSkipBegin.OnHoverForeColor = System.Drawing.Color.White;
            this.gBtnSkipBegin.OnHoverImage = null;
            this.gBtnSkipBegin.OnPressedColor = System.Drawing.Color.Black;
            this.gBtnSkipBegin.Radius = 20;
            this.gBtnSkipBegin.Size = new System.Drawing.Size(95, 46);
            this.gBtnSkipBegin.TabIndex = 7;
            // 
            // gbtnBegin
            // 
            this.gbtnBegin.AnimationHoverSpeed = 0.07F;
            this.gbtnBegin.AnimationSpeed = 0.03F;
            this.gbtnBegin.BackColor = System.Drawing.Color.Transparent;
            this.gbtnBegin.BaseColor = System.Drawing.Color.White;
            this.gbtnBegin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gbtnBegin.BorderSize = 2;
            this.gbtnBegin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtnBegin.FocusedColor = System.Drawing.Color.Empty;
            this.gbtnBegin.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtnBegin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gbtnBegin.Image = global::AppIncorporacion2021.Properties.Resources.icons8_sort_left_48px;
            this.gbtnBegin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbtnBegin.ImageSize = new System.Drawing.Size(50, 50);
            this.gbtnBegin.Location = new System.Drawing.Point(305, 77);
            this.gbtnBegin.Name = "gbtnBegin";
            this.gbtnBegin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gbtnBegin.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gbtnBegin.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtnBegin.OnHoverImage = null;
            this.gbtnBegin.OnPressedColor = System.Drawing.Color.Black;
            this.gbtnBegin.Radius = 20;
            this.gbtnBegin.Size = new System.Drawing.Size(95, 46);
            this.gbtnBegin.TabIndex = 8;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1003, 607);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.gunaElipsePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdtgvDetalles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaButton gbtnBuscar;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox gTxtBuscar;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaButton gBtnCloseForm;
        private Guna.UI.WinForms.GunaDataGridView gdtgvDetalles;
        private Guna.UI.WinForms.GunaButton gBtnEnd;
        private Guna.UI.WinForms.GunaButton gBtnSkipNext;
        private Guna.UI.WinForms.GunaButton gbtnBegin;
        private Guna.UI.WinForms.GunaButton gBtnSkipBegin;
    }
}

