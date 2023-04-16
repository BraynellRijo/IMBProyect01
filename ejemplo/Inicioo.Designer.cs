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
            this.MenuV = new System.Windows.Forms.Panel();
            this.BusquedaBar = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
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
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
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
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuV
            // 
            this.MenuV.AutoSize = true;
            this.MenuV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuV.Controls.Add(this.BusquedaBar);
            this.MenuV.Controls.Add(this.btnSentting);
            this.MenuV.Controls.Add(this.btmImport);
            this.MenuV.Controls.Add(this.btnAlbum);
            this.MenuV.Controls.Add(this.btnPistas);
            this.MenuV.Controls.Add(this.btnInicio);
            this.MenuV.Location = new System.Drawing.Point(0, -2);
            this.MenuV.Name = "MenuV";
            this.MenuV.Size = new System.Drawing.Size(273, 355);
            this.MenuV.TabIndex = 6;
            // 
            // BusquedaBar
            // 
            this.BusquedaBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BusquedaBar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BusquedaBar.Location = new System.Drawing.Point(19, 14);
            this.BusquedaBar.Multiline = true;
            this.BusquedaBar.Name = "BusquedaBar";
            this.BusquedaBar.Size = new System.Drawing.Size(232, 46);
            this.BusquedaBar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BusquedaBar.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.BusquedaBar.StateCommon.Border.Rounding = 25;
            this.BusquedaBar.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusquedaBar.TabIndex = 18;
            this.BusquedaBar.Text = "Buscar...";
            this.BusquedaBar.Enter += new System.EventHandler(this.BusquedaBar_Enter);
            this.BusquedaBar.Leave += new System.EventHandler(this.BusquedaBar_Leave);
            // 
            // btnSentting
            // 
            this.btnSentting.AutoSize = true;
            this.btnSentting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSentting.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSentting.ForeColor = System.Drawing.Color.LightGray;
            this.btnSentting.Location = new System.Drawing.Point(29, 285);
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
            this.btmImport.Location = new System.Drawing.Point(29, 248);
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
            this.btnAlbum.Location = new System.Drawing.Point(29, 172);
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
            this.btnPistas.Location = new System.Drawing.Point(29, 135);
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
            this.btnInicio.Location = new System.Drawing.Point(29, 98);
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
            this.BarraReproduccion.StateCommon.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
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
            this.btnStateNormal.Location = new System.Drawing.Point(570, 84);
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
            this.btnMaximizar.Location = new System.Drawing.Point(570, 84);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(32, 26);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 9;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrarApp
            // 
            this.btnCerrarApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrarApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarApp.Image = global::ejemplo.Properties.Resources.eliminar__1_;
            this.btnCerrarApp.Location = new System.Drawing.Point(604, 84);
            this.btnCerrarApp.Name = "btnCerrarApp";
            this.btnCerrarApp.Size = new System.Drawing.Size(31, 26);
            this.btnCerrarApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarApp.TabIndex = 8;
            this.btnCerrarApp.TabStop = false;
            this.btnCerrarApp.Click += new System.EventHandler(this.btnCerrarApp_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::ejemplo.Properties.Resources.minimizar_signo;
            this.btnMinimizar.Location = new System.Drawing.Point(540, 84);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(32, 26);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 7;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.AutoScroll = true;
            this.panelContenedor.Controls.Add(this.btnStateNormal);
            this.panelContenedor.Controls.Add(this.btnMaximizar);
            this.panelContenedor.Controls.Add(this.btnCerrarApp);
            this.panelContenedor.Controls.Add(this.btnMinimizar);
            this.panelContenedor.Location = new System.Drawing.Point(274, 2);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(641, 350);
            this.panelContenedor.TabIndex = 11;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
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
            this.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.StateCommon.Border.Rounding = 17;
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
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnCerrarApp;
        private System.Windows.Forms.PictureBox btnMinimizar;
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
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox BusquedaBar;
        private Panel panelContenedor;
    }
}