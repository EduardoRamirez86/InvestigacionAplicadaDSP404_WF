namespace InvestigaciónAplicadaDSP404_WF
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTopHeader = new System.Windows.Forms.Panel();
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.pnlRightFavorites = new System.Windows.Forms.Panel();
            this.lblFooterPath = new System.Windows.Forms.Label();
            this.dgvFavoritos = new System.Windows.Forms.DataGridView();
            this.colCiudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLatitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLongitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHumedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colViento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCondicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFavActions = new System.Windows.Forms.Panel();
            this.lblOfflineBadge = new System.Windows.Forms.Label();
            this.btnAbrirCsv = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.lblFavoritesTitle = new System.Windows.Forms.Label();
            this.pnlLeftSearch = new System.Windows.Forms.Panel();
            this.pnlWeatherCard = new System.Windows.Forms.Panel();
            this.btnGuardarFavorito = new System.Windows.Forms.Button();
            this.lblMedicionHora = new System.Windows.Forms.Label();
            this.pnlMetrics = new System.Windows.Forms.Panel();
            this.lblVientoVal = new System.Windows.Forms.Label();
            this.lblHumedadVal = new System.Windows.Forms.Label();
            this.lblCondition = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.pnlCoordinatesBadge = new System.Windows.Forms.Panel();
            this.lblCoordLongitud = new System.Windows.Forms.Label();
            this.lblCoordLatitud = new System.Windows.Forms.Label();
            this.lblCountryName = new System.Windows.Forms.Label();
            this.lblCityName = new System.Windows.Forms.Label();
            this.pnlStatusBanner = new System.Windows.Forms.Panel();
            this.lblStatusMessage = new System.Windows.Forms.Label();
            this.pbLoading = new System.Windows.Forms.ProgressBar();
            this.pnlSearchBox = new System.Windows.Forms.Panel();
            this.lblSugerenciasInfo = new System.Windows.Forms.Label();
            this.cboOpcionesCiudad = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.lblSearchLabel = new System.Windows.Forms.Label();
            this.statusStripBottom = new System.Windows.Forms.StatusStrip();
            this.tsLblApiStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsLblSeparator1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsLblRecordsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsLblSeparator2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsLblRuntimeInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlTopHeader.SuspendLayout();
            this.pnlMainContent.SuspendLayout();
            this.pnlRightFavorites.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFavoritos)).BeginInit();
            this.pnlFavActions.SuspendLayout();
            this.pnlLeftSearch.SuspendLayout();
            this.pnlWeatherCard.SuspendLayout();
            this.pnlMetrics.SuspendLayout();
            this.pnlCoordinatesBadge.SuspendLayout();
            this.pnlStatusBanner.SuspendLayout();
            this.pnlSearchBox.SuspendLayout();
            this.statusStripBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopHeader
            // 
            this.pnlTopHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.pnlTopHeader.Controls.Add(this.lblHeaderSubtitle);
            this.pnlTopHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlTopHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlTopHeader.Name = "pnlTopHeader";
            this.pnlTopHeader.Padding = new System.Windows.Forms.Padding(20, 12, 20, 12);
            this.pnlTopHeader.Size = new System.Drawing.Size(1124, 62);
            this.pnlTopHeader.TabIndex = 0;
            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(180)))));
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(22, 35);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(479, 15);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Investigación Aplicada 2 • DSP404 • Consumo de API REST y Persistencia de Favorit" +
    "os CSV";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.lblHeaderTitle.Location = new System.Drawing.Point(20, 9);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(355, 25);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Weather Desk — Consulta Meteorológica";
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.pnlMainContent.Controls.Add(this.pnlRightFavorites);
            this.pnlMainContent.Controls.Add(this.pnlLeftSearch);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(0, 62);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Padding = new System.Windows.Forms.Padding(16);
            this.pnlMainContent.Size = new System.Drawing.Size(1124, 606);
            this.pnlMainContent.TabIndex = 1;
            // 
            // pnlRightFavorites
            // 
            this.pnlRightFavorites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.pnlRightFavorites.Controls.Add(this.lblFooterPath);
            this.pnlRightFavorites.Controls.Add(this.dgvFavoritos);
            this.pnlRightFavorites.Controls.Add(this.pnlFavActions);
            this.pnlRightFavorites.Controls.Add(this.lblFavoritesTitle);
            this.pnlRightFavorites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightFavorites.Location = new System.Drawing.Point(462, 16);
            this.pnlRightFavorites.Name = "pnlRightFavorites";
            this.pnlRightFavorites.Padding = new System.Windows.Forms.Padding(16);
            this.pnlRightFavorites.Size = new System.Drawing.Size(646, 574);
            this.pnlRightFavorites.TabIndex = 1;
            // 
            // lblFooterPath
            // 
            this.lblFooterPath.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFooterPath.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblFooterPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(125)))), ((int)(((byte)(150)))));
            this.lblFooterPath.Location = new System.Drawing.Point(16, 538);
            this.lblFooterPath.Name = "lblFooterPath";
            this.lblFooterPath.Size = new System.Drawing.Size(614, 20);
            this.lblFooterPath.TabIndex = 3;
            this.lblFooterPath.Text = "Archivo local: Data\\favoritos_clima.csv • Doble clic en una fila para cargar tele" +
    "metría en modo offline";
            this.lblFooterPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvFavoritos
            // 
            this.dgvFavoritos.AllowUserToAddRows = false;
            this.dgvFavoritos.AllowUserToDeleteRows = false;
            this.dgvFavoritos.AllowUserToResizeRows = false;
            this.dgvFavoritos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFavoritos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
            this.dgvFavoritos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFavoritos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFavoritos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 8.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(175)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(175)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFavoritos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvFavoritos.ColumnHeadersHeight = 32;
            this.dgvFavoritos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFavoritos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCiudad,
            this.colPais,
            this.colLatitud,
            this.colLongitud,
            this.colTemp,
            this.colHumedad,
            this.colViento,
            this.colCondicion,
            this.colFecha});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(130)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFavoritos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvFavoritos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFavoritos.EnableHeadersVisualStyles = false;
            this.dgvFavoritos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.dgvFavoritos.Location = new System.Drawing.Point(16, 88);
            this.dgvFavoritos.MultiSelect = false;
            this.dgvFavoritos.Name = "dgvFavoritos";
            this.dgvFavoritos.ReadOnly = true;
            this.dgvFavoritos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFavoritos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvFavoritos.RowHeadersVisible = false;
            this.dgvFavoritos.RowTemplate.Height = 28;
            this.dgvFavoritos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFavoritos.Size = new System.Drawing.Size(614, 470);
            this.dgvFavoritos.TabIndex = 2;
            // 
            // colCiudad
            // 
            this.colCiudad.FillWeight = 105F;
            this.colCiudad.HeaderText = "Ciudad";
            this.colCiudad.Name = "colCiudad";
            this.colCiudad.ReadOnly = true;
            // 
            // colPais
            // 
            this.colPais.FillWeight = 85F;
            this.colPais.HeaderText = "País";
            this.colPais.Name = "colPais";
            this.colPais.ReadOnly = true;
            // 
            // colLatitud
            // 
            this.colLatitud.FillWeight = 75F;
            this.colLatitud.HeaderText = "Latitud";
            this.colLatitud.Name = "colLatitud";
            this.colLatitud.ReadOnly = true;
            // 
            // colLongitud
            // 
            this.colLongitud.FillWeight = 75F;
            this.colLongitud.HeaderText = "Longitud";
            this.colLongitud.Name = "colLongitud";
            this.colLongitud.ReadOnly = true;
            // 
            // colTemp
            // 
            this.colTemp.FillWeight = 65F;
            this.colTemp.HeaderText = "Temp";
            this.colTemp.Name = "colTemp";
            this.colTemp.ReadOnly = true;
            // 
            // colHumedad
            // 
            this.colHumedad.FillWeight = 65F;
            this.colHumedad.HeaderText = "Hum.";
            this.colHumedad.Name = "colHumedad";
            this.colHumedad.ReadOnly = true;
            // 
            // colViento
            // 
            this.colViento.FillWeight = 65F;
            this.colViento.HeaderText = "Viento";
            this.colViento.Name = "colViento";
            this.colViento.ReadOnly = true;
            // 
            // colCondicion
            // 
            this.colCondicion.FillWeight = 95F;
            this.colCondicion.HeaderText = "Condición";
            this.colCondicion.Name = "colCondicion";
            this.colCondicion.ReadOnly = true;
            // 
            // colFecha
            // 
            this.colFecha.FillWeight = 90F;
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            // 
            // pnlFavActions
            // 
            this.pnlFavActions.Controls.Add(this.lblOfflineBadge);
            this.pnlFavActions.Controls.Add(this.btnAbrirCsv);
            this.pnlFavActions.Controls.Add(this.btnEliminar);
            this.pnlFavActions.Controls.Add(this.btnRecargar);
            this.pnlFavActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFavActions.Location = new System.Drawing.Point(16, 44);
            this.pnlFavActions.Name = "pnlFavActions";
            this.pnlFavActions.Size = new System.Drawing.Size(614, 44);
            this.pnlFavActions.TabIndex = 1;
            // 
            // lblOfflineBadge
            // 
            this.lblOfflineBadge.AutoSize = true;
            this.lblOfflineBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(76)))));
            this.lblOfflineBadge.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblOfflineBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(200)))), ((int)(((byte)(245)))));
            this.lblOfflineBadge.Location = new System.Drawing.Point(3, 15);
            this.lblOfflineBadge.Name = "lblOfflineBadge";
            this.lblOfflineBadge.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.lblOfflineBadge.Size = new System.Drawing.Size(144, 19);
            this.lblOfflineBadge.TabIndex = 2;
            this.lblOfflineBadge.Text = "Modo Offline Habilitado";
            // 
            // btnAbrirCsv
            // 
            this.btnAbrirCsv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbrirCsv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(42)))), ((int)(((byte)(65)))));
            this.btnAbrirCsv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirCsv.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            this.btnAbrirCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirCsv.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAbrirCsv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.btnAbrirCsv.Location = new System.Drawing.Point(242, 7);
            this.btnAbrirCsv.Name = "btnAbrirCsv";
            this.btnAbrirCsv.Size = new System.Drawing.Size(115, 30);
            this.btnAbrirCsv.TabIndex = 3;
            this.btnAbrirCsv.Text = "Ver Archivo CSV";
            this.btnAbrirCsv.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(205)))));
            this.btnEliminar.Location = new System.Drawing.Point(494, 7);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 30);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnRecargar
            // 
            this.btnRecargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.btnRecargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecargar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnRecargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecargar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRecargar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(242)))), ((int)(((byte)(250)))));
            this.btnRecargar.Location = new System.Drawing.Point(365, 7);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(123, 30);
            this.btnRecargar.TabIndex = 0;
            this.btnRecargar.Text = "Actualizar Lista";
            this.btnRecargar.UseVisualStyleBackColor = false;
            // 
            // lblFavoritesTitle
            // 
            this.lblFavoritesTitle.AutoSize = true;
            this.lblFavoritesTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFavoritesTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.5F, System.Drawing.FontStyle.Bold);
            this.lblFavoritesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(252)))));
            this.lblFavoritesTitle.Location = new System.Drawing.Point(16, 16);
            this.lblFavoritesTitle.Name = "lblFavoritesTitle";
            this.lblFavoritesTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.lblFavoritesTitle.Size = new System.Drawing.Size(342, 28);
            this.lblFavoritesTitle.TabIndex = 0;
            this.lblFavoritesTitle.Text = "Consultas Guardadas (Persistencia en Archivo)";
            // 
            // pnlLeftSearch
            // 
            this.pnlLeftSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.pnlLeftSearch.Controls.Add(this.pnlWeatherCard);
            this.pnlLeftSearch.Controls.Add(this.pnlStatusBanner);
            this.pnlLeftSearch.Controls.Add(this.pbLoading);
            this.pnlLeftSearch.Controls.Add(this.pnlSearchBox);
            this.pnlLeftSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftSearch.Location = new System.Drawing.Point(16, 16);
            this.pnlLeftSearch.Name = "pnlLeftSearch";
            this.pnlLeftSearch.Padding = new System.Windows.Forms.Padding(16);
            this.pnlLeftSearch.Size = new System.Drawing.Size(446, 574);
            this.pnlLeftSearch.TabIndex = 0;
            // 
            // pnlWeatherCard
            // 
            this.pnlWeatherCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
            this.pnlWeatherCard.Controls.Add(this.btnGuardarFavorito);
            this.pnlWeatherCard.Controls.Add(this.lblMedicionHora);
            this.pnlWeatherCard.Controls.Add(this.pnlMetrics);
            this.pnlWeatherCard.Controls.Add(this.lblCondition);
            this.pnlWeatherCard.Controls.Add(this.lblTemperature);
            this.pnlWeatherCard.Controls.Add(this.pnlCoordinatesBadge);
            this.pnlWeatherCard.Controls.Add(this.lblCountryName);
            this.pnlWeatherCard.Controls.Add(this.lblCityName);
            this.pnlWeatherCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWeatherCard.Location = new System.Drawing.Point(16, 218);
            this.pnlWeatherCard.Name = "pnlWeatherCard";
            this.pnlWeatherCard.Padding = new System.Windows.Forms.Padding(18);
            this.pnlWeatherCard.Size = new System.Drawing.Size(414, 340);
            this.pnlWeatherCard.TabIndex = 3;
            // 
            // btnGuardarFavorito
            // 
            this.btnGuardarFavorito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(130)))), ((int)(((byte)(205)))));
            this.btnGuardarFavorito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarFavorito.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGuardarFavorito.Enabled = false;
            this.btnGuardarFavorito.FlatAppearance.BorderSize = 0;
            this.btnGuardarFavorito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarFavorito.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnGuardarFavorito.ForeColor = System.Drawing.Color.White;
            this.btnGuardarFavorito.Location = new System.Drawing.Point(18, 286);
            this.btnGuardarFavorito.Name = "btnGuardarFavorito";
            this.btnGuardarFavorito.Size = new System.Drawing.Size(378, 36);
            this.btnGuardarFavorito.TabIndex = 7;
            this.btnGuardarFavorito.Text = "Guardar en Favoritos";
            this.btnGuardarFavorito.UseVisualStyleBackColor = false;
            // 
            // lblMedicionHora
            // 
            this.lblMedicionHora.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMedicionHora.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblMedicionHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(145)))), ((int)(((byte)(170)))));
            this.lblMedicionHora.Location = new System.Drawing.Point(18, 237);
            this.lblMedicionHora.Name = "lblMedicionHora";
            this.lblMedicionHora.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblMedicionHora.Size = new System.Drawing.Size(378, 26);
            this.lblMedicionHora.TabIndex = 6;
            this.lblMedicionHora.Text = "Última medición: -";
            // 
            // pnlMetrics
            // 
            this.pnlMetrics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.pnlMetrics.Controls.Add(this.lblVientoVal);
            this.pnlMetrics.Controls.Add(this.lblHumedadVal);
            this.pnlMetrics.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMetrics.Location = new System.Drawing.Point(18, 185);
            this.pnlMetrics.Name = "pnlMetrics";
            this.pnlMetrics.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.pnlMetrics.Size = new System.Drawing.Size(378, 52);
            this.pnlMetrics.TabIndex = 5;
            // 
            // lblVientoVal
            // 
            this.lblVientoVal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblVientoVal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblVientoVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(242)))), ((int)(((byte)(250)))));
            this.lblVientoVal.Location = new System.Drawing.Point(191, 10);
            this.lblVientoVal.Name = "lblVientoVal";
            this.lblVientoVal.Size = new System.Drawing.Size(175, 32);
            this.lblVientoVal.TabIndex = 1;
            this.lblVientoVal.Text = "Viento: -- km/h";
            this.lblVientoVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHumedadVal
            // 
            this.lblHumedadVal.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHumedadVal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblHumedadVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(242)))), ((int)(((byte)(250)))));
            this.lblHumedadVal.Location = new System.Drawing.Point(12, 10);
            this.lblHumedadVal.Name = "lblHumedadVal";
            this.lblHumedadVal.Size = new System.Drawing.Size(173, 32);
            this.lblHumedadVal.TabIndex = 0;
            this.lblHumedadVal.Text = "Humedad: -- %";
            this.lblHumedadVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCondition
            // 
            this.lblCondition.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCondition.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.lblCondition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(225)))), ((int)(((byte)(238)))));
            this.lblCondition.Location = new System.Drawing.Point(18, 157);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(378, 28);
            this.lblCondition.TabIndex = 4;
            this.lblCondition.Text = "Esperando consulta...";
            // 
            // lblTemperature
            // 
            this.lblTemperature.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTemperature.Font = new System.Drawing.Font("Segoe UI", 34F, System.Drawing.FontStyle.Bold);
            this.lblTemperature.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
            this.lblTemperature.Location = new System.Drawing.Point(18, 97);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(378, 60);
            this.lblTemperature.TabIndex = 3;
            this.lblTemperature.Text = "-- °C";
            // 
            // pnlCoordinatesBadge
            // 
            this.pnlCoordinatesBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.pnlCoordinatesBadge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCoordinatesBadge.Controls.Add(this.lblCoordLongitud);
            this.pnlCoordinatesBadge.Controls.Add(this.lblCoordLatitud);
            this.pnlCoordinatesBadge.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCoordinatesBadge.Location = new System.Drawing.Point(18, 67);
            this.pnlCoordinatesBadge.Name = "pnlCoordinatesBadge";
            this.pnlCoordinatesBadge.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.pnlCoordinatesBadge.Size = new System.Drawing.Size(378, 30);
            this.pnlCoordinatesBadge.TabIndex = 2;
            // 
            // lblCoordLongitud
            // 
            this.lblCoordLongitud.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCoordLongitud.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblCoordLongitud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.lblCoordLongitud.Location = new System.Drawing.Point(188, 4);
            this.lblCoordLongitud.Name = "lblCoordLongitud";
            this.lblCoordLongitud.Size = new System.Drawing.Size(180, 20);
            this.lblCoordLongitud.TabIndex = 1;
            this.lblCoordLongitud.Text = "Longitud: --";
            this.lblCoordLongitud.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCoordLatitud
            // 
            this.lblCoordLatitud.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCoordLatitud.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblCoordLatitud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.lblCoordLatitud.Location = new System.Drawing.Point(8, 4);
            this.lblCoordLatitud.Name = "lblCoordLatitud";
            this.lblCoordLatitud.Size = new System.Drawing.Size(180, 20);
            this.lblCoordLatitud.TabIndex = 0;
            this.lblCoordLatitud.Text = "Latitud: --";
            this.lblCoordLatitud.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCountryName
            // 
            this.lblCountryName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCountryName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCountryName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(180)))));
            this.lblCountryName.Location = new System.Drawing.Point(18, 47);
            this.lblCountryName.Name = "lblCountryName";
            this.lblCountryName.Size = new System.Drawing.Size(378, 20);
            this.lblCountryName.TabIndex = 1;
            this.lblCountryName.Text = "País / Región: --";
            // 
            // lblCityName
            // 
            this.lblCityName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCityName.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblCityName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.lblCityName.Location = new System.Drawing.Point(18, 18);
            this.lblCityName.Name = "lblCityName";
            this.lblCityName.Size = new System.Drawing.Size(378, 29);
            this.lblCityName.TabIndex = 0;
            this.lblCityName.Text = "Sin consulta activa";
            // 
            // pnlStatusBanner
            // 
            this.pnlStatusBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.pnlStatusBanner.Controls.Add(this.lblStatusMessage);
            this.pnlStatusBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStatusBanner.Location = new System.Drawing.Point(16, 172);
            this.pnlStatusBanner.Name = "pnlStatusBanner";
            this.pnlStatusBanner.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.pnlStatusBanner.Size = new System.Drawing.Size(414, 46);
            this.pnlStatusBanner.TabIndex = 2;
            // 
            // lblStatusMessage
            // 
            this.lblStatusMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatusMessage.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblStatusMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(180)))));
            this.lblStatusMessage.Location = new System.Drawing.Point(10, 6);
            this.lblStatusMessage.Name = "lblStatusMessage";
            this.lblStatusMessage.Size = new System.Drawing.Size(394, 34);
            this.lblStatusMessage.TabIndex = 0;
            this.lblStatusMessage.Text = "Escribe el nombre de una ciudad o selecciona una opción de la lista.";
            this.lblStatusMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbLoading
            // 
            this.pbLoading.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLoading.Location = new System.Drawing.Point(16, 166);
            this.pbLoading.MarqueeAnimationSpeed = 25;
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(414, 6);
            this.pbLoading.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbLoading.TabIndex = 1;
            this.pbLoading.Visible = false;
            // 
            // pnlSearchBox
            // 
            this.pnlSearchBox.Controls.Add(this.lblSugerenciasInfo);
            this.pnlSearchBox.Controls.Add(this.cboOpcionesCiudad);
            this.pnlSearchBox.Controls.Add(this.btnConsultar);
            this.pnlSearchBox.Controls.Add(this.txtCiudad);
            this.pnlSearchBox.Controls.Add(this.lblSearchLabel);
            this.pnlSearchBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchBox.Location = new System.Drawing.Point(16, 16);
            this.pnlSearchBox.Name = "pnlSearchBox";
            this.pnlSearchBox.Size = new System.Drawing.Size(414, 150);
            this.pnlSearchBox.TabIndex = 0;
            // 
            // lblSugerenciasInfo
            // 
            this.lblSugerenciasInfo.AutoSize = true;
            this.lblSugerenciasInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblSugerenciasInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(180)))));
            this.lblSugerenciasInfo.Location = new System.Drawing.Point(0, 96);
            this.lblSugerenciasInfo.Name = "lblSugerenciasInfo";
            this.lblSugerenciasInfo.Size = new System.Drawing.Size(189, 13);
            this.lblSugerenciasInfo.TabIndex = 4;
            this.lblSugerenciasInfo.Text = "Opciones encontradas con Lat/Lon:";
            // 
            // cboOpcionesCiudad
            // 
            this.cboOpcionesCiudad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.cboOpcionesCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOpcionesCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboOpcionesCiudad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboOpcionesCiudad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(252)))));
            this.cboOpcionesCiudad.FormattingEnabled = true;
            this.cboOpcionesCiudad.Location = new System.Drawing.Point(3, 114);
            this.cboOpcionesCiudad.Name = "cboOpcionesCiudad";
            this.cboOpcionesCiudad.Size = new System.Drawing.Size(408, 23);
            this.cboOpcionesCiudad.TabIndex = 3;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(130)))), ((int)(((byte)(205)))));
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(3, 58);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(408, 32);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Buscar Ubicación";
            this.btnConsultar.UseVisualStyleBackColor = false;
            // 
            // txtCiudad
            // 
            this.txtCiudad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.txtCiudad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCiudad.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtCiudad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.txtCiudad.Location = new System.Drawing.Point(3, 26);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(408, 26);
            this.txtCiudad.TabIndex = 1;
            // 
            // lblSearchLabel
            // 
            this.lblSearchLabel.AutoSize = true;
            this.lblSearchLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblSearchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(242)))));
            this.lblSearchLabel.Location = new System.Drawing.Point(0, 6);
            this.lblSearchLabel.Name = "lblSearchLabel";
            this.lblSearchLabel.Size = new System.Drawing.Size(182, 15);
            this.lblSearchLabel.TabIndex = 0;
            this.lblSearchLabel.Text = "Escribe el nombre de una ciudad:";
            // 
            // statusStripBottom
            // 
            this.statusStripBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.statusStripBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLblApiStatus,
            this.tsLblSeparator1,
            this.tsLblRecordsCount,
            this.tsLblSeparator2,
            this.tsLblRuntimeInfo});
            this.statusStripBottom.Location = new System.Drawing.Point(0, 668);
            this.statusStripBottom.Name = "statusStripBottom";
            this.statusStripBottom.Size = new System.Drawing.Size(1124, 22);
            this.statusStripBottom.TabIndex = 2;
            this.statusStripBottom.Text = "statusStrip1";
            // 
            // tsLblApiStatus
            // 
            this.tsLblApiStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsLblApiStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(190)))), ((int)(((byte)(130)))));
            this.tsLblApiStatus.Name = "tsLblApiStatus";
            this.tsLblApiStatus.Size = new System.Drawing.Size(154, 17);
            this.tsLblApiStatus.Text = "Open-Meteo REST: En Línea";
            // 
            // tsLblSeparator1
            // 
            this.tsLblSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            this.tsLblSeparator1.Name = "tsLblSeparator1";
            this.tsLblSeparator1.Size = new System.Drawing.Size(10, 17);
            this.tsLblSeparator1.Text = "|";
            // 
            // tsLblRecordsCount
            // 
            this.tsLblRecordsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(175)))), ((int)(((byte)(200)))));
            this.tsLblRecordsCount.Name = "tsLblRecordsCount";
            this.tsLblRecordsCount.Size = new System.Drawing.Size(106, 17);
            this.tsLblRecordsCount.Text = "Favoritos locales: 0";
            // 
            // tsLblSeparator2
            // 
            this.tsLblSeparator2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            this.tsLblSeparator2.Name = "tsLblSeparator2";
            this.tsLblSeparator2.Size = new System.Drawing.Size(10, 17);
            this.tsLblSeparator2.Text = "|";
            // 
            // tsLblRuntimeInfo
            // 
            this.tsLblRuntimeInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(125)))), ((int)(((byte)(150)))));
            this.tsLblRuntimeInfo.Name = "tsLblRuntimeInfo";
            this.tsLblRuntimeInfo.Size = new System.Drawing.Size(277, 17);
            this.tsLblRuntimeInfo.Text = ".NET Framework 4.8 • HttpClient • System.Text.Json";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1124, 690);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.statusStripBottom);
            this.Controls.Add(this.pnlTopHeader);
            this.MinimumSize = new System.Drawing.Size(1020, 620);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather Desk — Consulta Meteorológica REST";
            this.pnlTopHeader.ResumeLayout(false);
            this.pnlTopHeader.PerformLayout();
            this.pnlMainContent.ResumeLayout(false);
            this.pnlRightFavorites.ResumeLayout(false);
            this.pnlRightFavorites.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFavoritos)).EndInit();
            this.pnlFavActions.ResumeLayout(false);
            this.pnlFavActions.PerformLayout();
            this.pnlLeftSearch.ResumeLayout(false);
            this.pnlWeatherCard.ResumeLayout(false);
            this.pnlMetrics.ResumeLayout(false);
            this.pnlCoordinatesBadge.ResumeLayout(false);
            this.pnlStatusBanner.ResumeLayout(false);
            this.pnlSearchBox.ResumeLayout(false);
            this.pnlSearchBox.PerformLayout();
            this.statusStripBottom.ResumeLayout(false);
            this.statusStripBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopHeader;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Panel pnlRightFavorites;
        private System.Windows.Forms.Label lblFavoritesTitle;
        private System.Windows.Forms.Panel pnlLeftSearch;
        private System.Windows.Forms.Panel pnlSearchBox;
        private System.Windows.Forms.Label lblSearchLabel;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.ProgressBar pbLoading;
        private System.Windows.Forms.Panel pnlStatusBanner;
        private System.Windows.Forms.Label lblStatusMessage;
        private System.Windows.Forms.Panel pnlWeatherCard;
        private System.Windows.Forms.Label lblCityName;
        private System.Windows.Forms.Label lblCountryName;
        private System.Windows.Forms.Panel pnlCoordinatesBadge;
        private System.Windows.Forms.Label lblCoordLatitud;
        private System.Windows.Forms.Label lblCoordLongitud;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Button btnGuardarFavorito;
        private System.Windows.Forms.Panel pnlMetrics;
        private System.Windows.Forms.Label lblHumedadVal;
        private System.Windows.Forms.Label lblVientoVal;
        private System.Windows.Forms.Label lblMedicionHora;
        private System.Windows.Forms.Panel pnlFavActions;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.Button btnAbrirCsv;
        private System.Windows.Forms.DataGridView dgvFavoritos;
        private System.Windows.Forms.Label lblOfflineBadge;
        private System.Windows.Forms.Label lblFooterPath;
        private System.Windows.Forms.StatusStrip statusStripBottom;
        private System.Windows.Forms.ToolStripStatusLabel tsLblApiStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsLblSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel tsLblRecordsCount;
        private System.Windows.Forms.ToolStripStatusLabel tsLblSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel tsLblRuntimeInfo;
        private System.Windows.Forms.Label lblSugerenciasInfo;
        private System.Windows.Forms.ComboBox cboOpcionesCiudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCiudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPais;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLatitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLongitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHumedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colViento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCondicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
    }
}
