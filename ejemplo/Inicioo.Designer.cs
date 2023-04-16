using System;
using System.Windows.Forms;

namespace ejemplo
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.MenuV = new System.Windows.Forms.Panel();
            this.btnSentting = new System.Windows.Forms.Label();
            this.btmImport = new System.Windows.Forms.Label();
            this.btnAlbum = new System.Windows.Forms.Label();
            this.btnPistas = new System.Windows.Forms.Label();
            this.btnInicio = new System.Windows.Forms.Label();
            this.BarraReproduccion = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnLoop = new System.Windows.Forms.PictureBox();
            this.btnAleatorio = new System.Windows.Forms.PictureBox();
            this.lblArtista = new System.Windows.Forms.Label();
            this.lblTituloCancion = new System.Windows.Forms.Label();
            this.ImgCancion = new System.Windows.Forms.PictureBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnAvanzar = new System.Windows.Forms.PictureBox();
            this.btnRetroceder = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.btnStateNormal = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrarApp = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.Header = new System.Windows.Forms.Panel();
            this.MaxMoveWindows = new Bunifu.UI.WinForms.BunifuFormDock();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTipoUser = new System.Windows.Forms.Label();
            this.Inidicador = new Bunifu.UI.WinForms.BunifuShapes();
            this.bunifuShapes2 = new Bunifu.UI.WinForms.BunifuShapes();
            this.MenuV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarraReproduccion)).BeginInit();
            this.BarraReproduccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAleatorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCancion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAvanzar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRetroceder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStateNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarApp)).BeginInit();
            this.panelContenedor.SuspendLayout();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuV
            // 
            this.MenuV.AutoSize = true;
            this.MenuV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuV.Controls.Add(this.Inidicador);
            this.MenuV.Controls.Add(this.lblTipoUser);
            this.MenuV.Controls.Add(this.label1);
            this.MenuV.Controls.Add(this.bunifuPictureBox1);
            this.MenuV.Controls.Add(this.btnSentting);
            this.MenuV.Controls.Add(this.btmImport);
            this.MenuV.Controls.Add(this.btnAlbum);
            this.MenuV.Controls.Add(this.btnPistas);
            this.MenuV.Controls.Add(this.btnInicio);
            this.MenuV.Controls.Add(this.bunifuShapes2);
            this.MenuV.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuV.Location = new System.Drawing.Point(0, 0);
            this.MenuV.Name = "MenuV";
            this.MenuV.Size = new System.Drawing.Size(277, 353);
            this.MenuV.TabIndex = 6;
            // 
            // btnSentting
            // 
            this.btnSentting.AutoSize = true;
            this.btnSentting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSentting.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSentting.ForeColor = System.Drawing.Color.LightGray;
            this.btnSentting.Location = new System.Drawing.Point(45, 285);
            this.btnSentting.Name = "btnSentting";
            this.btnSentting.Size = new System.Drawing.Size(171, 37);
            this.btnSentting.TabIndex = 5;
            this.btnSentting.Text = "Configuración";
            this.btnSentting.Click += new System.EventHandler(this.btnSentting_Click);
            this.btnSentting.Enter += new System.EventHandler(this.btnInicio_Enter);
            this.btnSentting.Leave += new System.EventHandler(this.btnInicio_Leave);
            // 
            // btmImport
            // 
            this.btmImport.AutoSize = true;
            this.btmImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmImport.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmImport.ForeColor = System.Drawing.Color.LightGray;
            this.btmImport.Location = new System.Drawing.Point(45, 248);
            this.btmImport.Name = "btmImport";
            this.btmImport.Size = new System.Drawing.Size(229, 37);
            this.btmImport.TabIndex = 4;
            this.btmImport.Text = "Importar canciones";
            this.btmImport.Click += new System.EventHandler(this.btmImport_Click);
            this.btmImport.Enter += new System.EventHandler(this.btnInicio_Enter);
            this.btmImport.Leave += new System.EventHandler(this.btnInicio_Leave);
            // 
            // btnAlbum
            // 
            this.btnAlbum.AutoSize = true;
            this.btnAlbum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlbum.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlbum.ForeColor = System.Drawing.Color.LightGray;
            this.btnAlbum.Location = new System.Drawing.Point(45, 172);
            this.btnAlbum.Name = "btnAlbum";
            this.btnAlbum.Size = new System.Drawing.Size(113, 37);
            this.btnAlbum.TabIndex = 3;
            this.btnAlbum.Text = "Álbumes";
            this.btnAlbum.Click += new System.EventHandler(this.btnAlbum_Click);
            this.btnAlbum.Enter += new System.EventHandler(this.btnInicio_Enter);
            this.btnAlbum.Leave += new System.EventHandler(this.btnInicio_Leave);
            // 
            // btnPistas
            // 
            this.btnPistas.AutoSize = true;
            this.btnPistas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPistas.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPistas.ForeColor = System.Drawing.Color.LightGray;
            this.btnPistas.Location = new System.Drawing.Point(45, 135);
            this.btnPistas.Name = "btnPistas";
            this.btnPistas.Size = new System.Drawing.Size(83, 37);
            this.btnPistas.TabIndex = 2;
            this.btnPistas.Text = "Pistas";
            this.btnPistas.Click += new System.EventHandler(this.btnPistas_Click);
            this.btnPistas.Enter += new System.EventHandler(this.btnInicio_Enter);
            this.btnPistas.Leave += new System.EventHandler(this.btnInicio_Leave);
            // 
            // btnInicio
            // 
            this.btnInicio.AutoSize = true;
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.LightGray;
            this.btnInicio.Location = new System.Drawing.Point(45, 98);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(75, 37);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            this.btnInicio.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnInicio_MouseMove);
            // 
            // BarraReproduccion
            // 
            this.BarraReproduccion.AutoSize = true;
            this.BarraReproduccion.Controls.Add(this.btnLoop);
            this.BarraReproduccion.Controls.Add(this.btnAleatorio);
            this.BarraReproduccion.Controls.Add(this.lblArtista);
            this.BarraReproduccion.Controls.Add(this.lblTituloCancion);
            this.BarraReproduccion.Controls.Add(this.ImgCancion);
            this.BarraReproduccion.Controls.Add(this.progressBar);
            this.BarraReproduccion.Controls.Add(this.btnAvanzar);
            this.BarraReproduccion.Controls.Add(this.btnRetroceder);
            this.BarraReproduccion.Controls.Add(this.btnPlay);
            this.BarraReproduccion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BarraReproduccion.Location = new System.Drawing.Point(0, 353);
            this.BarraReproduccion.Name = "BarraReproduccion";
            this.BarraReproduccion.Size = new System.Drawing.Size(916, 122);
            this.BarraReproduccion.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.BarraReproduccion.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.BarraReproduccion.StateCommon.ColorAngle = 360F;
            this.BarraReproduccion.StateCommon.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.BarraReproduccion.TabIndex = 5;
            // 
            // btnLoop
            // 
            this.btnLoop.BackColor = System.Drawing.Color.Transparent;
            this.btnLoop.Image = global::ejemplo.Properties.Resources.loop;
            this.btnLoop.Location = new System.Drawing.Point(669, 43);
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.Size = new System.Drawing.Size(41, 36);
            this.btnLoop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLoop.TabIndex = 8;
            this.btnLoop.TabStop = false;
            this.btnLoop.Click += new System.EventHandler(this.btnLoop_Click);
            // 
            // btnAleatorio
            // 
            this.btnAleatorio.BackColor = System.Drawing.Color.Transparent;
            this.btnAleatorio.Image = global::ejemplo.Properties.Resources.aleatorio;
            this.btnAleatorio.Location = new System.Drawing.Point(431, 43);
            this.btnAleatorio.Name = "btnAleatorio";
            this.btnAleatorio.Size = new System.Drawing.Size(40, 36);
            this.btnAleatorio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAleatorio.TabIndex = 7;
            this.btnAleatorio.TabStop = false;
            this.btnAleatorio.Click += new System.EventHandler(this.btnAleatorio_Click);
            // 
            // lblArtista
            // 
            this.lblArtista.AutoSize = true;
            this.lblArtista.BackColor = System.Drawing.Color.Transparent;
            this.lblArtista.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtista.ForeColor = System.Drawing.Color.LightGray;
            this.lblArtista.Location = new System.Drawing.Point(150, 58);
            this.lblArtista.Name = "lblArtista";
            this.lblArtista.Size = new System.Drawing.Size(64, 28);
            this.lblArtista.TabIndex = 6;
            this.lblArtista.Text = "Artista";
            // 
            // lblTituloCancion
            // 
            this.lblTituloCancion.AutoSize = true;
            this.lblTituloCancion.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloCancion.Font = new System.Drawing.Font("Poppins Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCancion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTituloCancion.Location = new System.Drawing.Point(147, 32);
            this.lblTituloCancion.Name = "lblTituloCancion";
            this.lblTituloCancion.Size = new System.Drawing.Size(206, 34);
            this.lblTituloCancion.TabIndex = 5;
            this.lblTituloCancion.Text = "Titulo de la canción";
            // 
            // ImgCancion
            // 
            this.ImgCancion.BackColor = System.Drawing.Color.Transparent;
            this.ImgCancion.Location = new System.Drawing.Point(12, 19);
            this.ImgCancion.Name = "ImgCancion";
            this.ImgCancion.Size = new System.Drawing.Size(130, 100);
            this.ImgCancion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgCancion.TabIndex = 4;
            this.ImgCancion.TabStop = false;
            this.ImgCancion.Click += new System.EventHandler(this.ImgCancion_Click);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.RoyalBlue;
            this.progressBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.progressBar.Location = new System.Drawing.Point(0, 0);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(922, 10);
            this.progressBar.TabIndex = 3;
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.BackColor = System.Drawing.Color.Transparent;
            this.btnAvanzar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAvanzar.Image = global::ejemplo.Properties.Resources.skip;
            this.btnAvanzar.Location = new System.Drawing.Point(608, 43);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(42, 43);
            this.btnAvanzar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAvanzar.TabIndex = 2;
            this.btnAvanzar.TabStop = false;
            this.btnAvanzar.Click += new System.EventHandler(this.btnAvanzar_Click);
            // 
            // btnRetroceder
            // 
            this.btnRetroceder.BackColor = System.Drawing.Color.Transparent;
            this.btnRetroceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetroceder.Image = global::ejemplo.Properties.Resources.rewind_button;
            this.btnRetroceder.Location = new System.Drawing.Point(486, 43);
            this.btnRetroceder.Name = "btnRetroceder";
            this.btnRetroceder.Size = new System.Drawing.Size(42, 43);
            this.btnRetroceder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRetroceder.TabIndex = 1;
            this.btnRetroceder.TabStop = false;
            this.btnRetroceder.Click += new System.EventHandler(this.btnRetoceder_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.Image = global::ejemplo.Properties.Resources.play_button_arrowhead;
            this.btnPlay.Location = new System.Drawing.Point(546, 43);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(42, 43);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPlay.TabIndex = 0;
            this.btnPlay.TabStop = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStateNormal
            // 
            this.btnStateNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStateNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStateNormal.Image = global::ejemplo.Properties.Resources.maximizar;
            this.btnStateNormal.Location = new System.Drawing.Point(1008, 84);
            this.btnStateNormal.Name = "btnStateNormal";
            this.btnStateNormal.Size = new System.Drawing.Size(32, 26);
            this.btnStateNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnStateNormal.TabIndex = 10;
            this.btnStateNormal.TabStop = false;
            this.btnStateNormal.Click += new System.EventHandler(this.btnStateNormal_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = global::ejemplo.Properties.Resources.maximizarN;
            this.btnMaximizar.Location = new System.Drawing.Point(1008, 84);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(32, 26);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 9;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrarApp
            // 
            this.btnCerrarApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrarApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarApp.Image = global::ejemplo.Properties.Resources.eliminar__1_;
            this.btnCerrarApp.Location = new System.Drawing.Point(607, 3);
            this.btnCerrarApp.Name = "btnCerrarApp";
            this.btnCerrarApp.Size = new System.Drawing.Size(22, 19);
            this.btnCerrarApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarApp.TabIndex = 8;
            this.btnCerrarApp.TabStop = false;
            this.btnCerrarApp.Click += new System.EventHandler(this.btnCerrarApp_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.AutoScroll = true;
            this.panelContenedor.Controls.Add(this.Header);
            this.panelContenedor.Controls.Add(this.btnStateNormal);
            this.panelContenedor.Controls.Add(this.btnMaximizar);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(277, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(639, 353);
            this.panelContenedor.TabIndex = 11;
            // 
            // Header
            // 
            this.Header.Controls.Add(this.btnMinimizar);
            this.Header.Controls.Add(this.btnCerrarApp);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(639, 25);
            this.Header.TabIndex = 12;
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
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Image = global::ejemplo.Properties.Resources.minimizar_signo;
            this.btnMinimizar.Location = new System.Drawing.Point(581, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(24, 19);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 9;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 32;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(16, 11);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(64, 64);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 6;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(86, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "Usuario";
            // 
            // lblTipoUser
            // 
            this.lblTipoUser.AutoSize = true;
            this.lblTipoUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTipoUser.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTipoUser.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTipoUser.Location = new System.Drawing.Point(86, 49);
            this.lblTipoUser.Name = "lblTipoUser";
            this.lblTipoUser.Size = new System.Drawing.Size(107, 26);
            this.lblTipoUser.TabIndex = 8;
            this.lblTipoUser.Text = "Propietario";
            // 
            // Inidicador
            // 
            this.Inidicador.Angle = 0F;
            this.Inidicador.BackColor = System.Drawing.Color.Transparent;
            this.Inidicador.BorderColor = System.Drawing.Color.Silver;
            this.Inidicador.BorderThickness = 2;
            this.Inidicador.FillColor = System.Drawing.Color.Silver;
            this.Inidicador.FillShape = true;
            this.Inidicador.Location = new System.Drawing.Point(29, 108);
            this.Inidicador.Name = "Inidicador";
            this.Inidicador.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Polygon;
            this.Inidicador.Sides = 3;
            this.Inidicador.Size = new System.Drawing.Size(10, 11);
            this.Inidicador.TabIndex = 9;
            // 
            // bunifuShapes2
            // 
            this.bunifuShapes2.Angle = 90F;
            this.bunifuShapes2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShapes2.BorderColor = System.Drawing.Color.Silver;
            this.bunifuShapes2.BorderThickness = 3;
            this.bunifuShapes2.FillColor = System.Drawing.Color.Transparent;
            this.bunifuShapes2.FillShape = true;
            this.bunifuShapes2.Location = new System.Drawing.Point(25, 101);
            this.bunifuShapes2.Name = "bunifuShapes2";
            this.bunifuShapes2.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Line;
            this.bunifuShapes2.Sides = 5;
            this.bunifuShapes2.Size = new System.Drawing.Size(18, 99);
            this.bunifuShapes2.TabIndex = 10;
            this.bunifuShapes2.Text = "bunifuShapes2";
            // 
            // Inicio
            // 
            this.AllowStatusStripMerge = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(916, 475);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.MenuV);
            this.Controls.Add(this.BarraReproduccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 0;
            this.Text = "Inicioo";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Inicio_MouseDown);
            this.MenuV.ResumeLayout(false);
            this.MenuV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarraReproduccion)).EndInit();
            this.BarraReproduccion.ResumeLayout(false);
            this.BarraReproduccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAleatorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCancion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAvanzar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRetroceder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStateNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarApp)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnCerrarApp;
        private System.Windows.Forms.Panel MenuV;
        private System.Windows.Forms.Label btnSentting;
        private System.Windows.Forms.Label btmImport;
        private System.Windows.Forms.Label btnAlbum;
        private System.Windows.Forms.Label btnPistas;
        private System.Windows.Forms.Label btnInicio;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel BarraReproduccion;
        private System.Windows.Forms.PictureBox ImgCancion;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.PictureBox btnAvanzar;
        private System.Windows.Forms.PictureBox btnRetroceder;
        private System.Windows.Forms.PictureBox btnPlay;
        private System.Windows.Forms.PictureBox btnStateNormal;
        private System.Windows.Forms.Label lblArtista;
        private System.Windows.Forms.Label lblTituloCancion;
        private System.Windows.Forms.PictureBox btnLoop;
        private System.Windows.Forms.PictureBox btnAleatorio;
        private Panel panelContenedor;
        private Panel Header;
        private Bunifu.UI.WinForms.BunifuFormDock MaxMoveWindows;
        private PictureBox btnMinimizar;
        private Bunifu.UI.WinForms.BunifuShapes Inidicador;
        private Label lblTipoUser;
        private Label label1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuShapes bunifuShapes2;
    }
}