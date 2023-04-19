namespace ejemplo
{
    partial class List
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAleatorioList = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Header = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrarApp = new System.Windows.Forms.PictureBox();
            this.MaxMoveWindows = new Bunifu.UI.WinForms.BunifuFormDock();
            this.ListMs = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.NumberCanc = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.NombreCanc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtistCanc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DuracionCanc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnSubir = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BusquedaBar = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListMs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAleatorioList
            // 
            this.btnAleatorioList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAleatorioList.Location = new System.Drawing.Point(19, 28);
            this.btnAleatorioList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAleatorioList.Name = "btnAleatorioList";
            this.btnAleatorioList.Size = new System.Drawing.Size(65, 62);
            this.btnAleatorioList.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.btnAleatorioList.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.btnAleatorioList.StateCommon.Back.ColorAngle = 180F;
            this.btnAleatorioList.StateCommon.Back.Image = global::ejemplo.Properties.Resources.aleatorioNegro;
            this.btnAleatorioList.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnAleatorioList.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.btnAleatorioList.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(58)))));
            this.btnAleatorioList.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAleatorioList.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TileFlipXY;
            this.btnAleatorioList.StateCommon.Border.Rounding = 75;
            this.btnAleatorioList.TabIndex = 17;
            this.btnAleatorioList.Values.Text = "";
            this.btnAleatorioList.Click += new System.EventHandler(this.btnAleatorioList_Click);
            this.btnAleatorioList.DoubleClick += new System.EventHandler(this.btnAleatorioList_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(90, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 42);
            this.label1.TabIndex = 18;
            this.label1.Text = "Lista de Reproducción";
            // 
            // Header
            // 
            this.Header.Controls.Add(this.btnMinimizar);
            this.Header.Controls.Add(this.btnCerrarApp);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(625, 25);
            this.Header.TabIndex = 28;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Image = global::ejemplo.Properties.Resources.minimizar_signo;
            this.btnMinimizar.Location = new System.Drawing.Point(567, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(24, 19);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 9;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrarApp
            // 
            this.btnCerrarApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrarApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarApp.Image = global::ejemplo.Properties.Resources.eliminar__1_;
            this.btnCerrarApp.Location = new System.Drawing.Point(593, 3);
            this.btnCerrarApp.Name = "btnCerrarApp";
            this.btnCerrarApp.Size = new System.Drawing.Size(22, 19);
            this.btnCerrarApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarApp.TabIndex = 8;
            this.btnCerrarApp.TabStop = false;
            this.btnCerrarApp.Click += new System.EventHandler(this.btnCerrarApp_Click);
            // 
            // MaxMoveWindows
            // 
            this.MaxMoveWindows.AllowFormDragging = true;
            this.MaxMoveWindows.AllowFormDropShadow = true;
            this.MaxMoveWindows.AllowFormResizing = true;
            this.MaxMoveWindows.AllowHidingBottomRegion = true;
            this.MaxMoveWindows.AllowOpacityChangesWhileDragging = false;
            this.MaxMoveWindows.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.MaxMoveWindows.BorderOptions.BottomBorder.BorderThickness = 1;
            this.MaxMoveWindows.BorderOptions.BottomBorder.ShowBorder = true;
            this.MaxMoveWindows.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.MaxMoveWindows.BorderOptions.LeftBorder.BorderThickness = 1;
            this.MaxMoveWindows.BorderOptions.LeftBorder.ShowBorder = true;
            this.MaxMoveWindows.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.MaxMoveWindows.BorderOptions.RightBorder.BorderThickness = 1;
            this.MaxMoveWindows.BorderOptions.RightBorder.ShowBorder = true;
            this.MaxMoveWindows.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.MaxMoveWindows.BorderOptions.TopBorder.BorderThickness = 1;
            this.MaxMoveWindows.BorderOptions.TopBorder.ShowBorder = true;
            this.MaxMoveWindows.ContainerControl = this;
            this.MaxMoveWindows.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.MaxMoveWindows.DockingIndicatorsOpacity = 0.5D;
            this.MaxMoveWindows.DockingOptions.DockAll = true;
            this.MaxMoveWindows.DockingOptions.DockBottomLeft = true;
            this.MaxMoveWindows.DockingOptions.DockBottomRight = true;
            this.MaxMoveWindows.DockingOptions.DockFullScreen = true;
            this.MaxMoveWindows.DockingOptions.DockLeft = true;
            this.MaxMoveWindows.DockingOptions.DockRight = true;
            this.MaxMoveWindows.DockingOptions.DockTopLeft = true;
            this.MaxMoveWindows.DockingOptions.DockTopRight = true;
            this.MaxMoveWindows.FormDraggingOpacity = 0.9D;
            this.MaxMoveWindows.ParentForm = this;
            this.MaxMoveWindows.ShowCursorChanges = true;
            this.MaxMoveWindows.ShowDockingIndicators = true;
            this.MaxMoveWindows.TitleBarOptions.AllowFormDragging = true;
            this.MaxMoveWindows.TitleBarOptions.BunifuFormDock = this.MaxMoveWindows;
            this.MaxMoveWindows.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.MaxMoveWindows.TitleBarOptions.TitleBarControl = this.Header;
            this.MaxMoveWindows.TitleBarOptions.UseBackColorOnDockingIndicators = true;
            // 
            // ListMs
            // 
            this.ListMs.AllowCustomTheming = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.ListMs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ListMs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListMs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ListMs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListMs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ListMs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListMs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ListMs.ColumnHeadersHeight = 40;
            this.ListMs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberCanc,
            this.NombreCanc,
            this.ArtistCanc,
            this.DuracionCanc});
            this.ListMs.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.ListMs.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ListMs.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.ListMs.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.ListMs.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.ListMs.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.ListMs.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.ListMs.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.ListMs.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.ListMs.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ListMs.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ListMs.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.ListMs.CurrentTheme.Name = null;
            this.ListMs.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ListMs.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ListMs.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.ListMs.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.ListMs.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListMs.DefaultCellStyle = dataGridViewCellStyle6;
            this.ListMs.EnableHeadersVisualStyles = false;
            this.ListMs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.ListMs.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.ListMs.HeaderBgColor = System.Drawing.Color.Empty;
            this.ListMs.HeaderForeColor = System.Drawing.Color.White;
            this.ListMs.Location = new System.Drawing.Point(21, 97);
            this.ListMs.Name = "ListMs";
            this.ListMs.RowHeadersVisible = false;
            this.ListMs.RowTemplate.Height = 40;
            this.ListMs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListMs.Size = new System.Drawing.Size(594, 209);
            this.ListMs.TabIndex = 29;
            this.ListMs.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // NumberCanc
            // 
            this.NumberCanc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NumberCanc.HeaderText = "No.";
            this.NumberCanc.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.NumberCanc.Name = "NumberCanc";
            this.NumberCanc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NumberCanc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.NumberCanc.Width = 59;
            // 
            // NombreCanc
            // 
            this.NombreCanc.HeaderText = "Nombre";
            this.NombreCanc.Name = "NombreCanc";
            // 
            // ArtistCanc
            // 
            this.ArtistCanc.HeaderText = "Artista";
            this.ArtistCanc.Name = "ArtistCanc";
            // 
            // DuracionCanc
            // 
            this.DuracionCanc.HeaderText = "Duración";
            this.DuracionCanc.Name = "DuracionCanc";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // btnSubir
            // 
            this.btnSubir.Location = new System.Drawing.Point(557, 365);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(58, 42);
            this.btnSubir.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.btnSubir.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(173)))), ((int)(((byte)(110)))));
            this.btnSubir.StateCommon.Back.ColorAngle = 180F;
            this.btnSubir.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnSubir.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnSubir.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSubir.StateCommon.Border.Rounding = 10;
            this.btnSubir.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnSubir.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubir.TabIndex = 30;
            this.btnSubir.Values.Text = "Add";
            // 
            // BusquedaBar
            // 
            this.BusquedaBar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BusquedaBar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BusquedaBar.Location = new System.Drawing.Point(447, 37);
            this.BusquedaBar.Multiline = true;
            this.BusquedaBar.Name = "BusquedaBar";
            this.BusquedaBar.Size = new System.Drawing.Size(166, 46);
            this.BusquedaBar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BusquedaBar.StateCommon.Border.Rounding = 20;
            this.BusquedaBar.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusquedaBar.TabIndex = 31;
            this.BusquedaBar.Text = "Buscar...";
            this.BusquedaBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(625, 419);
            this.Controls.Add(this.BusquedaBar);
            this.Controls.Add(this.btnSubir);
            this.Controls.Add(this.ListMs);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAleatorioList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Text = "List";
            this.Load += new System.EventHandler(this.List_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.List_MouseDown);
            this.Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListMs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAleatorioList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrarApp;
        private Bunifu.UI.WinForms.BunifuFormDock MaxMoveWindows;
        private Bunifu.UI.WinForms.BunifuDataGridView ListMs;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSubir;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox BusquedaBar;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn NumberCanc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCanc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtistCanc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DuracionCanc;
    }
}