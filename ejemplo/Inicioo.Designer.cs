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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            this.MenuV = new System.Windows.Forms.Panel();
            this.Indicador = new Bunifu.UI.WinForms.BunifuShapes();
            this.lblTipoUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.btnSentting = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Label();
            this.btnAlbum = new System.Windows.Forms.Label();
            this.btnPistas = new System.Windows.Forms.Label();
            this.btnInicio = new System.Windows.Forms.Label();
            this.bunifuShapes2 = new Bunifu.UI.WinForms.BunifuShapes();
            this.bunifuShapes1 = new Bunifu.UI.WinForms.BunifuShapes();
            this.BarraReproduccion = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnLoop = new System.Windows.Forms.PictureBox();
            this.btnAleatorio = new System.Windows.Forms.PictureBox();
            this.btnSkip = new System.Windows.Forms.PictureBox();
            this.btnRewind = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.DurationCanc = new System.Windows.Forms.Label();
            this.CountMs = new System.Windows.Forms.Label();
            this.Aleatorio = new Bunifu.UI.WinForms.BunifuImageButton();
            this.Loop = new Bunifu.UI.WinForms.BunifuImageButton();
            this.rewind = new Bunifu.UI.WinForms.BunifuImageButton();
            this.Play = new Bunifu.UI.WinForms.BunifuImageButton();
            this.Skip = new Bunifu.UI.WinForms.BunifuImageButton();
            this.BarraProgress = new Bunifu.UI.WinForms.BunifuHSlider();
            this.lblArtista = new System.Windows.Forms.Label();
            this.lblTituloCancion = new System.Windows.Forms.Label();
            this.ImgCancion = new System.Windows.Forms.PictureBox();
            this.Header = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrarApp = new System.Windows.Forms.PictureBox();
            this.MaxMoveWindows = new Bunifu.UI.WinForms.BunifuFormDock();
            this.PagContain = new Bunifu.UI.WinForms.BunifuPages();
            this.PagInicio = new System.Windows.Forms.TabPage();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.PagList = new System.Windows.Forms.TabPage();
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnAleatorioList = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ListMs = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.BusquedaBar = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnSubir = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PagPistas = new System.Windows.Forms.TabPage();
            this.btnAddAlbum = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.Album1 = new System.Windows.Forms.PictureBox();
            this.PagImportC = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSubirDrive = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSubirDispo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.PagSentting = new System.Windows.Forms.TabPage();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnSesion = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ModeLight = new Bunifu.UI.WinForms.BunifuToggleSwitch2();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.SubirMs = new System.Windows.Forms.OpenFileDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.MenuV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarraReproduccion)).BeginInit();
            this.BarraReproduccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAleatorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSkip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRewind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCancion)).BeginInit();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarApp)).BeginInit();
            this.PagContain.SuspendLayout();
            this.PagInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.PagList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.PagPistas.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Album1)).BeginInit();
            this.PagImportC.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.PagSentting.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuV
            // 
            this.MenuV.AutoSize = true;
            this.MenuV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuV.Controls.Add(this.Indicador);
            this.MenuV.Controls.Add(this.lblTipoUser);
            this.MenuV.Controls.Add(this.label1);
            this.MenuV.Controls.Add(this.bunifuPictureBox1);
            this.MenuV.Controls.Add(this.btnSentting);
            this.MenuV.Controls.Add(this.btnImport);
            this.MenuV.Controls.Add(this.btnAlbum);
            this.MenuV.Controls.Add(this.btnPistas);
            this.MenuV.Controls.Add(this.btnInicio);
            this.MenuV.Controls.Add(this.bunifuShapes2);
            this.MenuV.Controls.Add(this.bunifuShapes1);
            this.MenuV.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuV.Location = new System.Drawing.Point(0, 0);
            this.MenuV.Name = "MenuV";
            this.MenuV.Size = new System.Drawing.Size(277, 390);
            this.MenuV.TabIndex = 6;
            // 
            // Indicador
            // 
            this.Indicador.Angle = 0F;
            this.Indicador.BackColor = System.Drawing.Color.Transparent;
            this.Indicador.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(230)))), ((int)(((byte)(154)))));
            this.Indicador.BorderThickness = 2;
            this.Indicador.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(230)))), ((int)(((byte)(154)))));
            this.Indicador.FillShape = true;
            this.Indicador.Location = new System.Drawing.Point(29, 108);
            this.Indicador.Name = "Indicador";
            this.Indicador.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Circle;
            this.Indicador.Sides = 3;
            this.Indicador.Size = new System.Drawing.Size(10, 10);
            this.Indicador.TabIndex = 9;
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
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 32;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(16, 21);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(64, 64);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 6;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
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
            // btnImport
            // 
            this.btnImport.AutoSize = true;
            this.btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImport.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.LightGray;
            this.btnImport.Location = new System.Drawing.Point(45, 248);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(229, 37);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "Importar canciones";
            this.btnImport.Click += new System.EventHandler(this.btmImport_Click);
            this.btnImport.Enter += new System.EventHandler(this.btnInicio_Enter);
            this.btnImport.Leave += new System.EventHandler(this.btnInicio_Leave);
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
            // 
            // bunifuShapes2
            // 
            this.bunifuShapes2.Angle = 90F;
            this.bunifuShapes2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShapes2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(230)))), ((int)(((byte)(154)))));
            this.bunifuShapes2.BorderThickness = 3;
            this.bunifuShapes2.FillColor = System.Drawing.Color.Transparent;
            this.bunifuShapes2.FillShape = true;
            this.bunifuShapes2.Location = new System.Drawing.Point(25, 108);
            this.bunifuShapes2.Name = "bunifuShapes2";
            this.bunifuShapes2.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Line;
            this.bunifuShapes2.Sides = 5;
            this.bunifuShapes2.Size = new System.Drawing.Size(18, 92);
            this.bunifuShapes2.TabIndex = 10;
            this.bunifuShapes2.Text = "bunifuShapes2";
            // 
            // bunifuShapes1
            // 
            this.bunifuShapes1.Angle = 90F;
            this.bunifuShapes1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShapes1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(230)))), ((int)(((byte)(154)))));
            this.bunifuShapes1.BorderThickness = 3;
            this.bunifuShapes1.FillColor = System.Drawing.Color.Transparent;
            this.bunifuShapes1.FillShape = true;
            this.bunifuShapes1.Location = new System.Drawing.Point(25, 254);
            this.bunifuShapes1.Name = "bunifuShapes1";
            this.bunifuShapes1.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Line;
            this.bunifuShapes1.Sides = 5;
            this.bunifuShapes1.Size = new System.Drawing.Size(18, 57);
            this.bunifuShapes1.TabIndex = 11;
            this.bunifuShapes1.Text = "bunifuShapes1";
            // 
            // BarraReproduccion
            // 
            this.BarraReproduccion.AutoSize = true;
            this.BarraReproduccion.Controls.Add(this.btnLoop);
            this.BarraReproduccion.Controls.Add(this.btnAleatorio);
            this.BarraReproduccion.Controls.Add(this.btnSkip);
            this.BarraReproduccion.Controls.Add(this.btnRewind);
            this.BarraReproduccion.Controls.Add(this.btnPlay);
            this.BarraReproduccion.Controls.Add(this.DurationCanc);
            this.BarraReproduccion.Controls.Add(this.CountMs);
            this.BarraReproduccion.Controls.Add(this.Aleatorio);
            this.BarraReproduccion.Controls.Add(this.Loop);
            this.BarraReproduccion.Controls.Add(this.rewind);
            this.BarraReproduccion.Controls.Add(this.Play);
            this.BarraReproduccion.Controls.Add(this.Skip);
            this.BarraReproduccion.Controls.Add(this.BarraProgress);
            this.BarraReproduccion.Controls.Add(this.lblArtista);
            this.BarraReproduccion.Controls.Add(this.lblTituloCancion);
            this.BarraReproduccion.Controls.Add(this.ImgCancion);
            this.BarraReproduccion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BarraReproduccion.Location = new System.Drawing.Point(0, 390);
            this.BarraReproduccion.Name = "BarraReproduccion";
            this.BarraReproduccion.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonStandalone;
            this.BarraReproduccion.Size = new System.Drawing.Size(916, 102);
            this.BarraReproduccion.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.BarraReproduccion.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.BarraReproduccion.StateCommon.ColorAngle = 360F;
            this.BarraReproduccion.StateCommon.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.BarraReproduccion.TabIndex = 5;
            this.BarraReproduccion.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraReproduccion_Paint);
            // 
            // btnLoop
            // 
            this.btnLoop.BackColor = System.Drawing.Color.Transparent;
            this.btnLoop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoop.Image = global::ejemplo.Properties.Resources.loop;
            this.btnLoop.Location = new System.Drawing.Point(671, 14);
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.Size = new System.Drawing.Size(30, 32);
            this.btnLoop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLoop.TabIndex = 21;
            this.btnLoop.TabStop = false;
            this.btnLoop.Visible = false;
            this.btnLoop.WaitOnLoad = true;
            this.btnLoop.Click += new System.EventHandler(this.btnLoop_Click);
            // 
            // btnAleatorio
            // 
            this.btnAleatorio.BackColor = System.Drawing.Color.Transparent;
            this.btnAleatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAleatorio.Image = global::ejemplo.Properties.Resources.aleatorio;
            this.btnAleatorio.Location = new System.Drawing.Point(503, 14);
            this.btnAleatorio.Name = "btnAleatorio";
            this.btnAleatorio.Size = new System.Drawing.Size(30, 32);
            this.btnAleatorio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAleatorio.TabIndex = 20;
            this.btnAleatorio.TabStop = false;
            this.btnAleatorio.Visible = false;
            this.btnAleatorio.Click += new System.EventHandler(this.btnAleatorio_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.BackColor = System.Drawing.Color.Transparent;
            this.btnSkip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSkip.Image = global::ejemplo.Properties.Resources.skip;
            this.btnSkip.Location = new System.Drawing.Point(627, 8);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(38, 38);
            this.btnSkip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSkip.TabIndex = 19;
            this.btnSkip.TabStop = false;
            this.btnSkip.Visible = false;
            this.btnSkip.WaitOnLoad = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnRewind
            // 
            this.btnRewind.BackColor = System.Drawing.Color.Transparent;
            this.btnRewind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRewind.Image = global::ejemplo.Properties.Resources.rewind_button;
            this.btnRewind.Location = new System.Drawing.Point(539, 8);
            this.btnRewind.Name = "btnRewind";
            this.btnRewind.Size = new System.Drawing.Size(38, 38);
            this.btnRewind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRewind.TabIndex = 18;
            this.btnRewind.TabStop = false;
            this.btnRewind.Visible = false;
            this.btnRewind.Click += new System.EventHandler(this.btnRewind_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.Image = global::ejemplo.Properties.Resources.play_button_arrowhead;
            this.btnPlay.Location = new System.Drawing.Point(583, 8);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(38, 38);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPlay.TabIndex = 17;
            this.btnPlay.TabStop = false;
            this.btnPlay.Visible = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // DurationCanc
            // 
            this.DurationCanc.AutoSize = true;
            this.DurationCanc.BackColor = System.Drawing.Color.Transparent;
            this.DurationCanc.Location = new System.Drawing.Point(863, 80);
            this.DurationCanc.Name = "DurationCanc";
            this.DurationCanc.Size = new System.Drawing.Size(34, 13);
            this.DurationCanc.TabIndex = 16;
            this.DurationCanc.Text = "00:00";
            // 
            // CountMs
            // 
            this.CountMs.AutoSize = true;
            this.CountMs.BackColor = System.Drawing.Color.Transparent;
            this.CountMs.Location = new System.Drawing.Point(367, 80);
            this.CountMs.Name = "CountMs";
            this.CountMs.Size = new System.Drawing.Size(34, 13);
            this.CountMs.TabIndex = 15;
            this.CountMs.Text = "00:00";
            this.CountMs.Click += new System.EventHandler(this.CountMs_Click);
            // 
            // Aleatorio
            // 
            this.Aleatorio.ActiveImage = null;
            this.Aleatorio.AllowAnimations = true;
            this.Aleatorio.AllowBuffering = false;
            this.Aleatorio.AllowToggling = false;
            this.Aleatorio.AllowZooming = true;
            this.Aleatorio.AllowZoomingOnFocus = false;
            this.Aleatorio.BackColor = System.Drawing.Color.Transparent;
            this.Aleatorio.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Aleatorio.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Aleatorio.ErrorImage")));
            this.Aleatorio.FadeWhenInactive = false;
            this.Aleatorio.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.Aleatorio.Image = ((System.Drawing.Image)(resources.GetObject("Aleatorio.Image")));
            this.Aleatorio.ImageActive = null;
            this.Aleatorio.ImageLocation = null;
            this.Aleatorio.ImageMargin = 5;
            this.Aleatorio.ImageSize = new System.Drawing.Size(25, 27);
            this.Aleatorio.ImageZoomSize = new System.Drawing.Size(30, 32);
            this.Aleatorio.InitialImage = ((System.Drawing.Image)(resources.GetObject("Aleatorio.InitialImage")));
            this.Aleatorio.Location = new System.Drawing.Point(155, 58);
            this.Aleatorio.Name = "Aleatorio";
            this.Aleatorio.Rotation = 0;
            this.Aleatorio.ShowActiveImage = true;
            this.Aleatorio.ShowCursorChanges = true;
            this.Aleatorio.ShowImageBorders = true;
            this.Aleatorio.ShowSizeMarkers = false;
            this.Aleatorio.Size = new System.Drawing.Size(30, 32);
            this.Aleatorio.TabIndex = 13;
            this.Aleatorio.ToolTipText = "";
            this.Aleatorio.WaitOnLoad = false;
            this.Aleatorio.Zoom = 5;
            this.Aleatorio.ZoomSpeed = 10;
            this.Aleatorio.Click += new System.EventHandler(this.Aleatorio_Click);
            // 
            // Loop
            // 
            this.Loop.ActiveImage = null;
            this.Loop.AllowAnimations = true;
            this.Loop.AllowBuffering = false;
            this.Loop.AllowToggling = false;
            this.Loop.AllowZooming = true;
            this.Loop.AllowZoomingOnFocus = false;
            this.Loop.BackColor = System.Drawing.Color.Transparent;
            this.Loop.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Loop.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Loop.ErrorImage")));
            this.Loop.FadeWhenInactive = false;
            this.Loop.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.Loop.Image = ((System.Drawing.Image)(resources.GetObject("Loop.Image")));
            this.Loop.ImageActive = null;
            this.Loop.ImageLocation = null;
            this.Loop.ImageMargin = 5;
            this.Loop.ImageSize = new System.Drawing.Size(25, 27);
            this.Loop.ImageZoomSize = new System.Drawing.Size(30, 32);
            this.Loop.InitialImage = ((System.Drawing.Image)(resources.GetObject("Loop.InitialImage")));
            this.Loop.Location = new System.Drawing.Point(331, 58);
            this.Loop.Name = "Loop";
            this.Loop.Rotation = 0;
            this.Loop.ShowActiveImage = true;
            this.Loop.ShowCursorChanges = true;
            this.Loop.ShowImageBorders = true;
            this.Loop.ShowSizeMarkers = false;
            this.Loop.Size = new System.Drawing.Size(30, 32);
            this.Loop.TabIndex = 12;
            this.Loop.ToolTipText = "";
            this.Loop.WaitOnLoad = false;
            this.Loop.Zoom = 5;
            this.Loop.ZoomSpeed = 10;
            // 
            // rewind
            // 
            this.rewind.ActiveImage = null;
            this.rewind.AllowAnimations = true;
            this.rewind.AllowBuffering = false;
            this.rewind.AllowToggling = false;
            this.rewind.AllowZooming = true;
            this.rewind.AllowZoomingOnFocus = false;
            this.rewind.BackColor = System.Drawing.Color.Transparent;
            this.rewind.DialogResult = System.Windows.Forms.DialogResult.None;
            this.rewind.ErrorImage = ((System.Drawing.Image)(resources.GetObject("rewind.ErrorImage")));
            this.rewind.FadeWhenInactive = false;
            this.rewind.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.rewind.Image = ((System.Drawing.Image)(resources.GetObject("rewind.Image")));
            this.rewind.ImageActive = null;
            this.rewind.ImageLocation = null;
            this.rewind.ImageMargin = 5;
            this.rewind.ImageSize = new System.Drawing.Size(33, 33);
            this.rewind.ImageZoomSize = new System.Drawing.Size(38, 38);
            this.rewind.InitialImage = ((System.Drawing.Image)(resources.GetObject("rewind.InitialImage")));
            this.rewind.Location = new System.Drawing.Point(191, 52);
            this.rewind.Name = "rewind";
            this.rewind.Rotation = 0;
            this.rewind.ShowActiveImage = true;
            this.rewind.ShowCursorChanges = true;
            this.rewind.ShowImageBorders = true;
            this.rewind.ShowSizeMarkers = false;
            this.rewind.Size = new System.Drawing.Size(38, 38);
            this.rewind.TabIndex = 11;
            this.rewind.ToolTipText = "";
            this.rewind.WaitOnLoad = false;
            this.rewind.Zoom = 5;
            this.rewind.ZoomSpeed = 10;
            this.rewind.Click += new System.EventHandler(this.btnRewind_Click);
            // 
            // Play
            // 
            this.Play.ActiveImage = null;
            this.Play.AllowAnimations = true;
            this.Play.AllowBuffering = false;
            this.Play.AllowToggling = false;
            this.Play.AllowZooming = true;
            this.Play.AllowZoomingOnFocus = false;
            this.Play.BackColor = System.Drawing.Color.Transparent;
            this.Play.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Play.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Play.ErrorImage")));
            this.Play.FadeWhenInactive = false;
            this.Play.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.Play.Image = ((System.Drawing.Image)(resources.GetObject("Play.Image")));
            this.Play.ImageActive = null;
            this.Play.ImageLocation = null;
            this.Play.ImageMargin = 5;
            this.Play.ImageSize = new System.Drawing.Size(33, 33);
            this.Play.ImageZoomSize = new System.Drawing.Size(38, 38);
            this.Play.InitialImage = ((System.Drawing.Image)(resources.GetObject("Play.InitialImage")));
            this.Play.Location = new System.Drawing.Point(239, 52);
            this.Play.Name = "Play";
            this.Play.Rotation = 0;
            this.Play.ShowActiveImage = true;
            this.Play.ShowCursorChanges = true;
            this.Play.ShowImageBorders = true;
            this.Play.ShowSizeMarkers = false;
            this.Play.Size = new System.Drawing.Size(38, 38);
            this.Play.TabIndex = 9;
            this.Play.ToolTipText = "";
            this.Play.WaitOnLoad = false;
            this.Play.Zoom = 5;
            this.Play.ZoomSpeed = 10;
            this.Play.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // Skip
            // 
            this.Skip.ActiveImage = null;
            this.Skip.AllowAnimations = true;
            this.Skip.AllowBuffering = false;
            this.Skip.AllowToggling = false;
            this.Skip.AllowZooming = true;
            this.Skip.AllowZoomingOnFocus = false;
            this.Skip.BackColor = System.Drawing.Color.Transparent;
            this.Skip.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Skip.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Skip.ErrorImage")));
            this.Skip.FadeWhenInactive = false;
            this.Skip.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.Skip.Image = ((System.Drawing.Image)(resources.GetObject("Skip.Image")));
            this.Skip.ImageActive = null;
            this.Skip.ImageLocation = null;
            this.Skip.ImageMargin = 5;
            this.Skip.ImageSize = new System.Drawing.Size(33, 33);
            this.Skip.ImageZoomSize = new System.Drawing.Size(38, 38);
            this.Skip.InitialImage = ((System.Drawing.Image)(resources.GetObject("Skip.InitialImage")));
            this.Skip.Location = new System.Drawing.Point(287, 52);
            this.Skip.Name = "Skip";
            this.Skip.Rotation = 0;
            this.Skip.ShowActiveImage = true;
            this.Skip.ShowCursorChanges = true;
            this.Skip.ShowImageBorders = true;
            this.Skip.ShowSizeMarkers = false;
            this.Skip.Size = new System.Drawing.Size(38, 38);
            this.Skip.TabIndex = 10;
            this.Skip.ToolTipText = "";
            this.Skip.WaitOnLoad = false;
            this.Skip.Zoom = 5;
            this.Skip.ZoomSpeed = 10;
            this.Skip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // BarraProgress
            // 
            this.BarraProgress.AllowCursorChanges = true;
            this.BarraProgress.AllowHomeEndKeysDetection = false;
            this.BarraProgress.AllowIncrementalClickMoves = true;
            this.BarraProgress.AllowMouseDownEffects = false;
            this.BarraProgress.AllowMouseHoverEffects = false;
            this.BarraProgress.AllowScrollingAnimations = true;
            this.BarraProgress.AllowScrollKeysDetection = true;
            this.BarraProgress.AllowScrollOptionsMenu = true;
            this.BarraProgress.AllowShrinkingOnFocusLost = false;
            this.BarraProgress.BackColor = System.Drawing.Color.Transparent;
            this.BarraProgress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BarraProgress.BackgroundImage")));
            this.BarraProgress.BindingContainer = null;
            this.BarraProgress.BorderRadius = 2;
            this.BarraProgress.BorderThickness = 1;
            this.BarraProgress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BarraProgress.DrawThickBorder = true;
            this.BarraProgress.DurationBeforeShrink = 2000;
            this.BarraProgress.ElapsedColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(230)))), ((int)(((byte)(154)))));
            this.BarraProgress.LargeChange = 10;
            this.BarraProgress.Location = new System.Drawing.Point(381, 52);
            this.BarraProgress.Maximum = 100;
            this.BarraProgress.Minimum = 0;
            this.BarraProgress.MinimumSize = new System.Drawing.Size(0, 31);
            this.BarraProgress.MinimumThumbLength = 18;
            this.BarraProgress.Name = "BarraProgress";
            this.BarraProgress.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.BarraProgress.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.BarraProgress.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.BarraProgress.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.BarraProgress.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.BarraProgress.ShrinkSizeLimit = 3;
            this.BarraProgress.Size = new System.Drawing.Size(506, 31);
            this.BarraProgress.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.BarraProgress.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thick;
            this.BarraProgress.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.BarraProgress.SmallChange = 1;
            this.BarraProgress.TabIndex = 14;
            this.BarraProgress.ThumbColor = System.Drawing.Color.MediumSpringGreen;
            this.BarraProgress.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.BarraProgress.ThumbLength = 50;
            this.BarraProgress.ThumbMargin = 1;
            this.BarraProgress.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.BarraProgress.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.BarraProgress.Value = 0;
            this.BarraProgress.Scroll += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs>(this.BarraProgress_Scroll);
            // 
            // lblArtista
            // 
            this.lblArtista.AutoSize = true;
            this.lblArtista.BackColor = System.Drawing.Color.Transparent;
            this.lblArtista.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtista.ForeColor = System.Drawing.Color.LightGray;
            this.lblArtista.Location = new System.Drawing.Point(151, 32);
            this.lblArtista.Name = "lblArtista";
            this.lblArtista.Size = new System.Drawing.Size(55, 25);
            this.lblArtista.TabIndex = 6;
            this.lblArtista.Text = "Artista";
            // 
            // lblTituloCancion
            // 
            this.lblTituloCancion.AutoSize = true;
            this.lblTituloCancion.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloCancion.Font = new System.Drawing.Font("Poppins Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCancion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTituloCancion.Location = new System.Drawing.Point(148, 6);
            this.lblTituloCancion.Name = "lblTituloCancion";
            this.lblTituloCancion.Size = new System.Drawing.Size(174, 28);
            this.lblTituloCancion.TabIndex = 5;
            this.lblTituloCancion.Text = "Titulo de la canción";
            this.lblTituloCancion.Click += new System.EventHandler(this.lblTituloCancion_Click);
            // 
            // ImgCancion
            // 
            this.ImgCancion.BackColor = System.Drawing.Color.Transparent;
            this.ImgCancion.Image = ((System.Drawing.Image)(resources.GetObject("ImgCancion.Image")));
            this.ImgCancion.Location = new System.Drawing.Point(12, 6);
            this.ImgCancion.Name = "ImgCancion";
            this.ImgCancion.Size = new System.Drawing.Size(130, 93);
            this.ImgCancion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgCancion.TabIndex = 4;
            this.ImgCancion.TabStop = false;
            this.ImgCancion.Click += new System.EventHandler(this.ImgCancion_Click);
            // 
            // Header
            // 
            this.Header.Controls.Add(this.btnMinimizar);
            this.Header.Controls.Add(this.btnCerrarApp);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(3, 3);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(625, 25);
            this.Header.TabIndex = 12;
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
            // PagContain
            // 
            this.PagContain.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.PagContain.AllowTransitions = false;
            this.PagContain.Controls.Add(this.PagInicio);
            this.PagContain.Controls.Add(this.PagList);
            this.PagContain.Controls.Add(this.PagPistas);
            this.PagContain.Controls.Add(this.PagImportC);
            this.PagContain.Controls.Add(this.PagSentting);
            this.PagContain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PagContain.Location = new System.Drawing.Point(277, 0);
            this.PagContain.Multiline = true;
            this.PagContain.Name = "PagContain";
            this.PagContain.Page = this.PagInicio;
            this.PagContain.PageIndex = 0;
            this.PagContain.PageName = "PagInicio";
            this.PagContain.PageTitle = "Inicio";
            this.PagContain.SelectedIndex = 0;
            this.PagContain.Size = new System.Drawing.Size(639, 390);
            this.PagContain.TabIndex = 12;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.PagContain.Transition = animation1;
            this.PagContain.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // PagInicio
            // 
            this.PagInicio.AutoScroll = true;
            this.PagInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.PagInicio.Controls.Add(this.pictureBox11);
            this.PagInicio.Controls.Add(this.Header);
            this.PagInicio.Location = new System.Drawing.Point(4, 4);
            this.PagInicio.Name = "PagInicio";
            this.PagInicio.Padding = new System.Windows.Forms.Padding(3);
            this.PagInicio.Size = new System.Drawing.Size(631, 364);
            this.PagInicio.TabIndex = 0;
            this.PagInicio.Text = "Inicio";
            this.PagInicio.Click += new System.EventHandler(this.PagInicio_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(158, 93);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(353, 214);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 13;
            this.pictureBox11.TabStop = false;
            // 
            // PagList
            // 
            this.PagList.AutoScroll = true;
            this.PagList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.PagList.Controls.Add(this.axWindowsMediaPlayer);
            this.PagList.Controls.Add(this.btnAleatorioList);
            this.PagList.Controls.Add(this.ListMs);
            this.PagList.Controls.Add(this.BusquedaBar);
            this.PagList.Controls.Add(this.btnSubir);
            this.PagList.Controls.Add(this.label2);
            this.PagList.Controls.Add(this.panel1);
            this.PagList.Location = new System.Drawing.Point(4, 4);
            this.PagList.Name = "PagList";
            this.PagList.Padding = new System.Windows.Forms.Padding(3);
            this.PagList.Size = new System.Drawing.Size(631, 364);
            this.PagList.TabIndex = 1;
            this.PagList.Text = "Pista";
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(2, 335);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(10, 23);
            this.axWindowsMediaPlayer.TabIndex = 39;
            this.axWindowsMediaPlayer.Visible = false;
            this.axWindowsMediaPlayer.StatusChange += new System.EventHandler(this.axWindowsMediaPlayer1_StatusChange);
            // 
            // btnAleatorioList
            // 
            this.btnAleatorioList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAleatorioList.Location = new System.Drawing.Point(22, 35);
            this.btnAleatorioList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAleatorioList.Name = "btnAleatorioList";
            this.btnAleatorioList.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.btnAleatorioList.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(10)))));
            this.btnAleatorioList.OverrideDefault.Back.ColorAngle = 45F;
            this.btnAleatorioList.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAleatorioList.OverrideDefault.Border.Rounding = 25;
            this.btnAleatorioList.Size = new System.Drawing.Size(65, 62);
            this.btnAleatorioList.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.btnAleatorioList.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.btnAleatorioList.StateCommon.Back.ColorAngle = 180F;
            this.btnAleatorioList.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnAleatorioList.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAleatorioList.StateCommon.Back.Image = global::ejemplo.Properties.Resources.aleatorioNegro;
            this.btnAleatorioList.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnAleatorioList.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.btnAleatorioList.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(58)))));
            this.btnAleatorioList.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAleatorioList.StateCommon.Border.Rounding = 75;
            this.btnAleatorioList.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(173)))), ((int)(((byte)(110)))));
            this.btnAleatorioList.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.btnAleatorioList.StatePressed.Back.ColorAngle = 45F;
            this.btnAleatorioList.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAleatorioList.StatePressed.Border.Rounding = 75;
            this.btnAleatorioList.TabIndex = 38;
            this.btnAleatorioList.Values.Text = "";
            this.btnAleatorioList.Click += new System.EventHandler(this.btnAleatorioList_Click);
            // 
            // ListMs
            // 
            this.ListMs.AllowDrop = true;
            this.ListMs.Location = new System.Drawing.Point(8, 110);
            this.ListMs.Name = "ListMs";
            this.ListMs.Size = new System.Drawing.Size(610, 200);
            this.ListMs.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ListMs.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ListMs.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ListMs.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ListMs.StateCommon.Border.Rounding = 7;
            this.ListMs.StateCommon.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ListMs.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.ListMs.StateCommon.Item.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.ListMs.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListMs.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ListMs.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ListMs.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ListMs.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ListMs.TabIndex = 37;
            this.ListMs.SelectedIndexChanged += new System.EventHandler(this.ListMs_SelectedIndexChanged);
            // 
            // BusquedaBar
            // 
            this.BusquedaBar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BusquedaBar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BusquedaBar.Location = new System.Drawing.Point(450, 54);
            this.BusquedaBar.Multiline = true;
            this.BusquedaBar.Name = "BusquedaBar";
            this.BusquedaBar.Size = new System.Drawing.Size(166, 46);
            this.BusquedaBar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BusquedaBar.StateCommon.Border.Rounding = 20;
            this.BusquedaBar.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusquedaBar.TabIndex = 36;
            this.BusquedaBar.Text = "Buscar...";
            this.BusquedaBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BusquedaBar.Enter += new System.EventHandler(this.BusquedaBar_Enter);
            this.BusquedaBar.Leave += new System.EventHandler(this.BusquedaBar_Leave);
            // 
            // btnSubir
            // 
            this.btnSubir.Location = new System.Drawing.Point(567, 316);
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
            this.btnSubir.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.btnSubir.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(173)))), ((int)(((byte)(110)))));
            this.btnSubir.StateDisabled.Back.ColorAngle = 180F;
            this.btnSubir.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.btnSubir.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(173)))), ((int)(((byte)(110)))));
            this.btnSubir.TabIndex = 35;
            this.btnSubir.Values.Text = "Add";
            this.btnSubir.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSubir_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(93, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 42);
            this.label2.TabIndex = 33;
            this.label2.Text = "Lista de Reproducción";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 25);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::ejemplo.Properties.Resources.minimizar_signo;
            this.pictureBox1.Location = new System.Drawing.Point(567, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::ejemplo.Properties.Resources.eliminar__1_;
            this.pictureBox2.Location = new System.Drawing.Point(593, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.btnCerrarApp_Click);
            // 
            // PagPistas
            // 
            this.PagPistas.AutoScroll = true;
            this.PagPistas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.PagPistas.Controls.Add(this.btnAddAlbum);
            this.PagPistas.Controls.Add(this.label4);
            this.PagPistas.Controls.Add(this.label5);
            this.PagPistas.Controls.Add(this.label6);
            this.PagPistas.Controls.Add(this.panel2);
            this.PagPistas.Controls.Add(this.pictureBox9);
            this.PagPistas.Controls.Add(this.pictureBox10);
            this.PagPistas.Controls.Add(this.Album1);
            this.PagPistas.Location = new System.Drawing.Point(4, 4);
            this.PagPistas.Name = "PagPistas";
            this.PagPistas.Padding = new System.Windows.Forms.Padding(3);
            this.PagPistas.Size = new System.Drawing.Size(631, 364);
            this.PagPistas.TabIndex = 2;
            this.PagPistas.Text = "Albumes";
            // 
            // btnAddAlbum
            // 
            this.btnAddAlbum.Location = new System.Drawing.Point(13, 216);
            this.btnAddAlbum.Name = "btnAddAlbum";
            this.btnAddAlbum.Size = new System.Drawing.Size(156, 158);
            this.btnAddAlbum.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnAddAlbum.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnAddAlbum.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(135)))));
            this.btnAddAlbum.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.btnAddAlbum.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddAlbum.StateCommon.Border.Rounding = 7;
            this.btnAddAlbum.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.btnAddAlbum.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAlbum.TabIndex = 20;
            this.btnAddAlbum.Values.Text = "             +\r\nAñadir Álbum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(258, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 26);
            this.label4.TabIndex = 19;
            this.label4.Text = "Titulo del Album";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(487, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 26);
            this.label5.TabIndex = 18;
            this.label5.Text = "Titulo del Album";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(36, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 26);
            this.label6.TabIndex = 17;
            this.label6.Text = "Titulo del Album";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(616, 25);
            this.panel2.TabIndex = 13;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::ejemplo.Properties.Resources.minimizar_signo;
            this.pictureBox3.Location = new System.Drawing.Point(558, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 19);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::ejemplo.Properties.Resources.eliminar__1_;
            this.pictureBox4.Location = new System.Drawing.Point(584, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 19);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.btnCerrarApp_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(464, 47);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(158, 158);
            this.pictureBox9.TabIndex = 16;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Location = new System.Drawing.Point(235, 47);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(158, 158);
            this.pictureBox10.TabIndex = 15;
            this.pictureBox10.TabStop = false;
            // 
            // Album1
            // 
            this.Album1.Location = new System.Drawing.Point(13, 47);
            this.Album1.Name = "Album1";
            this.Album1.Size = new System.Drawing.Size(158, 158);
            this.Album1.TabIndex = 14;
            this.Album1.TabStop = false;
            // 
            // PagImportC
            // 
            this.PagImportC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.PagImportC.Controls.Add(this.label3);
            this.PagImportC.Controls.Add(this.btnSubirDrive);
            this.PagImportC.Controls.Add(this.btnSubirDispo);
            this.PagImportC.Controls.Add(this.panel3);
            this.PagImportC.Location = new System.Drawing.Point(4, 4);
            this.PagImportC.Name = "PagImportC";
            this.PagImportC.Padding = new System.Windows.Forms.Padding(3);
            this.PagImportC.Size = new System.Drawing.Size(631, 364);
            this.PagImportC.TabIndex = 3;
            this.PagImportC.Text = "Importar canciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(32, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 42);
            this.label3.TabIndex = 26;
            this.label3.Text = "Importar canciones";
            // 
            // btnSubirDrive
            // 
            this.btnSubirDrive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubirDrive.Location = new System.Drawing.Point(21, 217);
            this.btnSubirDrive.Name = "btnSubirDrive";
            this.btnSubirDrive.Size = new System.Drawing.Size(589, 90);
            this.btnSubirDrive.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(83)))));
            this.btnSubirDrive.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.btnSubirDrive.StateCommon.Back.ColorAngle = 1F;
            this.btnSubirDrive.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btnSubirDrive.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnSubirDrive.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnSubirDrive.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSubirDrive.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btnSubirDrive.StateCommon.Border.Rounding = 17;
            this.btnSubirDrive.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSubirDrive.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubirDrive.TabIndex = 25;
            this.btnSubirDrive.Values.Text = "Importar archivo desde Google Drive";
            // 
            // btnSubirDispo
            // 
            this.btnSubirDispo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubirDispo.Location = new System.Drawing.Point(21, 108);
            this.btnSubirDispo.Name = "btnSubirDispo";
            this.btnSubirDispo.Size = new System.Drawing.Size(589, 94);
            this.btnSubirDispo.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.btnSubirDispo.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSubirDispo.StateCommon.Back.ColorAngle = 360F;
            this.btnSubirDispo.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnSubirDispo.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnSubirDispo.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSubirDispo.StateCommon.Border.Rounding = 17;
            this.btnSubirDispo.StateCommon.Content.LongText.Font = new System.Drawing.Font("Poppins Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubirDispo.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSubirDispo.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubirDispo.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.btnSubirDispo.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSubirDispo.StateNormal.Content.LongText.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubirDispo.TabIndex = 24;
            this.btnSubirDispo.Values.Text = "Importar archivo desde el dispositivo";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Controls.Add(this.pictureBox6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(625, 25);
            this.panel3.TabIndex = 13;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.Image = global::ejemplo.Properties.Resources.minimizar_signo;
            this.pictureBox5.Location = new System.Drawing.Point(567, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 19);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = global::ejemplo.Properties.Resources.eliminar__1_;
            this.pictureBox6.Location = new System.Drawing.Point(593, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(22, 19);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.btnCerrarApp_Click);
            // 
            // PagSentting
            // 
            this.PagSentting.AutoScroll = true;
            this.PagSentting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.PagSentting.Controls.Add(this.linkLabel2);
            this.PagSentting.Controls.Add(this.linkLabel1);
            this.PagSentting.Controls.Add(this.btnSesion);
            this.PagSentting.Controls.Add(this.label7);
            this.PagSentting.Controls.Add(this.label8);
            this.PagSentting.Controls.Add(this.ModeLight);
            this.PagSentting.Controls.Add(this.label9);
            this.PagSentting.Controls.Add(this.label10);
            this.PagSentting.Controls.Add(this.lblVersion);
            this.PagSentting.Controls.Add(this.panel4);
            this.PagSentting.Location = new System.Drawing.Point(4, 4);
            this.PagSentting.Name = "PagSentting";
            this.PagSentting.Padding = new System.Windows.Forms.Padding(3);
            this.PagSentting.Size = new System.Drawing.Size(631, 364);
            this.PagSentting.TabIndex = 4;
            this.PagSentting.Text = "Configuracion";
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.GhostWhite;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Poppins", 16F);
            this.linkLabel2.LinkColor = System.Drawing.SystemColors.ControlLight;
            this.linkLabel2.Location = new System.Drawing.Point(29, 356);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(118, 39);
            this.linkLabel2.TabIndex = 45;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Sitio Web";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.GhostWhite;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Poppins", 16F);
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.ControlLight;
            this.linkLabel1.Location = new System.Drawing.Point(29, 317);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(159, 39);
            this.linkLabel1.TabIndex = 44;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Contactenos";
            // 
            // btnSesion
            // 
            this.btnSesion.ActiveLinkColor = System.Drawing.Color.GhostWhite;
            this.btnSesion.AutoSize = true;
            this.btnSesion.Font = new System.Drawing.Font("Poppins", 16F);
            this.btnSesion.LinkColor = System.Drawing.SystemColors.ControlLight;
            this.btnSesion.Location = new System.Drawing.Point(29, 196);
            this.btnSesion.Name = "btnSesion";
            this.btnSesion.Size = new System.Drawing.Size(159, 39);
            this.btnSesion.TabIndex = 43;
            this.btnSesion.TabStop = true;
            this.btnSesion.Text = "Iniciar Sesión";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 16F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(29, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(266, 39);
            this.label7.TabIndex = 42;
            this.label7.Text = "Cambiar Foto del Perfil";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 16F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(29, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 39);
            this.label8.TabIndex = 41;
            this.label8.Text = "Modo oscuro";
            // 
            // ModeLight
            // 
            this.ModeLight.BackColor = System.Drawing.Color.Transparent;
            this.ModeLight.Checked = false;
            this.ModeLight.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ModeLight.CheckedSwitchColor = System.Drawing.Color.White;
            this.ModeLight.CheckedSwitchStyle = Bunifu.UI.WinForms.BunifuToggleSwitch2.SwitchStyles.Fill;
            this.ModeLight.Location = new System.Drawing.Point(545, 118);
            this.ModeLight.Name = "ModeLight";
            this.ModeLight.OutlineThickness = 2;
            this.ModeLight.Size = new System.Drawing.Size(55, 30);
            this.ModeLight.TabIndex = 40;
            this.ModeLight.UncheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.ModeLight.UncheckedSwitchColor = System.Drawing.Color.White;
            this.ModeLight.UncheckedSwitchStyle = Bunifu.UI.WinForms.BunifuToggleSwitch2.SwitchStyles.Fill;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 14F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(556, 397);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 34);
            this.label9.TabIndex = 39;
            this.label9.Text = "1.0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.LightGray;
            this.label10.Location = new System.Drawing.Point(11, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(257, 56);
            this.label10.TabIndex = 38;
            this.label10.Text = "Configuración";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Poppins", 16F);
            this.lblVersion.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblVersion.Location = new System.Drawing.Point(29, 395);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(98, 39);
            this.lblVersion.TabIndex = 37;
            this.lblVersion.Text = "Versión";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox7);
            this.panel4.Controls.Add(this.pictureBox8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(608, 25);
            this.panel4.TabIndex = 13;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox7.Image = global::ejemplo.Properties.Resources.minimizar_signo;
            this.pictureBox7.Location = new System.Drawing.Point(550, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(24, 19);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 9;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox8.Image = global::ejemplo.Properties.Resources.eliminar__1_;
            this.pictureBox8.Location = new System.Drawing.Point(576, 3);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(22, 19);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 8;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.btnCerrarApp_Click);
            // 
            // SubirMs
            // 
            this.SubirMs.FileName = "openFileDialog1";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Inicio
            // 
            this.AllowStatusStripMerge = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(916, 492);
            this.Controls.Add(this.PagContain);
            this.Controls.Add(this.MenuV);
            this.Controls.Add(this.BarraReproduccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 12;
            this.Text = "Inicioo";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Inicio_MouseDown);
            this.MenuV.ResumeLayout(false);
            this.MenuV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarraReproduccion)).EndInit();
            this.BarraReproduccion.ResumeLayout(false);
            this.BarraReproduccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAleatorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSkip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRewind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCancion)).EndInit();
            this.Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarApp)).EndInit();
            this.PagContain.ResumeLayout(false);
            this.PagInicio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.PagList.ResumeLayout(false);
            this.PagList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.PagPistas.ResumeLayout(false);
            this.PagPistas.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Album1)).EndInit();
            this.PagImportC.ResumeLayout(false);
            this.PagImportC.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.PagSentting.ResumeLayout(false);
            this.PagSentting.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.PictureBox btnCerrarApp;
        private System.Windows.Forms.Panel MenuV;
        private System.Windows.Forms.Label btnSentting;
        private System.Windows.Forms.Label btnImport;
        private System.Windows.Forms.Label btnAlbum;
        private System.Windows.Forms.Label btnPistas;
        private System.Windows.Forms.Label btnInicio;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel BarraReproduccion;
        private System.Windows.Forms.PictureBox ImgCancion;
        private System.Windows.Forms.Label lblArtista;
        private System.Windows.Forms.Label lblTituloCancion;
        private Panel Header;
        private Bunifu.UI.WinForms.BunifuFormDock MaxMoveWindows;
        private PictureBox btnMinimizar;
        private Bunifu.UI.WinForms.BunifuShapes Indicador;
        private Label lblTipoUser;
        private Label label1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuShapes bunifuShapes2;
        private Bunifu.UI.WinForms.BunifuShapes bunifuShapes1;
        private Bunifu.UI.WinForms.BunifuImageButton Play;
        private Bunifu.UI.WinForms.BunifuImageButton Aleatorio;
        private Bunifu.UI.WinForms.BunifuImageButton Loop;
        private Bunifu.UI.WinForms.BunifuImageButton rewind;
        private Bunifu.UI.WinForms.BunifuImageButton Skip;
        private Bunifu.UI.WinForms.BunifuPages PagContain;
        private TabPage PagInicio;
        private TabPage PagList;
        private TabPage PagPistas;
        private TabPage PagImportC;
        private TabPage PagSentting;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Panel panel3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Panel panel4;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox BusquedaBar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSubir;
        private Label label2;
        private Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSubirDrive;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSubirDispo;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddAlbum;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox Album1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private LinkLabel btnSesion;
        private Label label7;
        private Label label8;
        private Bunifu.UI.WinForms.BunifuToggleSwitch2 ModeLight;
        private Label label9;
        private Label label10;
        private Label lblVersion;
        private Bunifu.UI.WinForms.BunifuHSlider BarraProgress;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox ListMs;
        private PictureBox pictureBox11;
        private OpenFileDialog SubirMs;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAleatorioList;
        private Label DurationCanc;
        private Label CountMs;
        private PictureBox btnLoop;
        private PictureBox btnAleatorio;
        private PictureBox btnSkip;
        private PictureBox btnRewind;
        private PictureBox btnPlay;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private Timer timer;
    }
}