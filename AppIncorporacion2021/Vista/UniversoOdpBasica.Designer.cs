namespace AppIncorporacion2021.Vista
{
    partial class UniversoOdpBasica
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gBtnCloseForm = new Guna.UI.WinForms.GunaButton();
            this.gcmbRegion = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gdtgUniversoOdpBasica = new Guna.UI.WinForms.GunaDataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdtgUniversoOdpBasica)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.gcmbRegion);
            this.panel3.Controls.Add(this.gunaLabel2);
            this.panel3.Controls.Add(this.gunaLabel1);
            this.panel3.Controls.Add(this.gBtnCloseForm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1264, 143);
            this.panel3.TabIndex = 4;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gunaLabel1.Location = new System.Drawing.Point(405, 19);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(288, 25);
            this.gunaLabel1.TabIndex = 12;
            this.gunaLabel1.Text = "Universo de ODP\'s Básica";
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
            // 
            // gcmbRegion
            // 
            this.gcmbRegion.AutoCompleteCustomSource.AddRange(new string[] {
            "Seleccione una Opcion"});
            this.gcmbRegion.BackColor = System.Drawing.Color.Transparent;
            this.gcmbRegion.BaseColor = System.Drawing.Color.White;
            this.gcmbRegion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gcmbRegion.BorderSize = 1;
            this.gcmbRegion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gcmbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gcmbRegion.FocusedColor = System.Drawing.Color.Empty;
            this.gcmbRegion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gcmbRegion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gcmbRegion.FormattingEnabled = true;
            this.gcmbRegion.Items.AddRange(new object[] {
            "Selecciona una Region:"});
            this.gcmbRegion.Location = new System.Drawing.Point(349, 60);
            this.gcmbRegion.Name = "gcmbRegion";
            this.gcmbRegion.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gcmbRegion.OnHoverItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gcmbRegion.Radius = 15;
            this.gcmbRegion.Size = new System.Drawing.Size(455, 30);
            this.gcmbRegion.TabIndex = 25;
            this.gcmbRegion.SelectedIndexChanged += new System.EventHandler(this.gcmbRegion_SelectedIndexChanged);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gunaLabel2.Location = new System.Drawing.Point(229, 60);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(99, 25);
            this.gunaLabel2.TabIndex = 24;
            this.gunaLabel2.Text = "FILTRO:";
            // 
            // gdtgUniversoOdpBasica
            // 
            this.gdtgUniversoOdpBasica.AllowUserToAddRows = false;
            this.gdtgUniversoOdpBasica.AllowUserToDeleteRows = false;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            this.gdtgUniversoOdpBasica.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.gdtgUniversoOdpBasica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdtgUniversoOdpBasica.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdtgUniversoOdpBasica.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            this.gdtgUniversoOdpBasica.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdtgUniversoOdpBasica.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.gdtgUniversoOdpBasica.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdtgUniversoOdpBasica.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.gdtgUniversoOdpBasica.ColumnHeadersHeight = 45;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdtgUniversoOdpBasica.DefaultCellStyle = dataGridViewCellStyle24;
            this.gdtgUniversoOdpBasica.EnableHeadersVisualStyles = false;
            this.gdtgUniversoOdpBasica.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdtgUniversoOdpBasica.Location = new System.Drawing.Point(21, 40);
            this.gdtgUniversoOdpBasica.Name = "gdtgUniversoOdpBasica";
            this.gdtgUniversoOdpBasica.ReadOnly = true;
            this.gdtgUniversoOdpBasica.RowHeadersVisible = false;
            this.gdtgUniversoOdpBasica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdtgUniversoOdpBasica.Size = new System.Drawing.Size(1243, 439);
            this.gdtgUniversoOdpBasica.TabIndex = 1;
            this.gdtgUniversoOdpBasica.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gdtgUniversoOdpBasica.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gdtgUniversoOdpBasica.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gdtgUniversoOdpBasica.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gdtgUniversoOdpBasica.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gdtgUniversoOdpBasica.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gdtgUniversoOdpBasica.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            this.gdtgUniversoOdpBasica.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdtgUniversoOdpBasica.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gdtgUniversoOdpBasica.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.gdtgUniversoOdpBasica.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdtgUniversoOdpBasica.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gdtgUniversoOdpBasica.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gdtgUniversoOdpBasica.ThemeStyle.HeaderStyle.Height = 45;
            this.gdtgUniversoOdpBasica.ThemeStyle.ReadOnly = true;
            this.gdtgUniversoOdpBasica.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            this.gdtgUniversoOdpBasica.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.gdtgUniversoOdpBasica.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdtgUniversoOdpBasica.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gdtgUniversoOdpBasica.ThemeStyle.RowsStyle.Height = 22;
            this.gdtgUniversoOdpBasica.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            this.gdtgUniversoOdpBasica.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gdtgUniversoOdpBasica);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 496);
            this.panel1.TabIndex = 5;
            // 
            // UniversoOdpBasica
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1264, 662);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UniversoOdpBasica";
            this.Text = "OrdenPago";
            this.Load += new System.EventHandler(this.UniversoOdpBasica_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdtgUniversoOdpBasica)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaButton gBtnCloseForm;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaComboBox gcmbRegion;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaDataGridView gdtgUniversoOdpBasica;
        private System.Windows.Forms.Panel panel1;
    }
}