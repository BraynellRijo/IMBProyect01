namespace ejemplo.Resources
{
    partial class Albumes
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
            this.Album1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddAlbum = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Header = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrarApp = new System.Windows.Forms.PictureBox();
            this.MaxMoveWindows = new Bunifu.UI.WinForms.BunifuFormDock();
            ((System.ComponentModel.ISupportInitialize)(this.Album1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarApp)).BeginInit();
            this.SuspendLayout();
            // 
            // Album1
            // 
            this.Album1.Location = new System.Drawing.Point(10, 43);
            this.Album1.Name = "Album1";
            this.Album1.Size = new System.Drawing.Size(158, 158);
            this.Album1.TabIndex = 0;
            this.Album1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(232, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(158, 158);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(461, 43);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(158, 158);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Titulo del Album";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(484, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Titulo del Album";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(255, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Titulo del Album";
            // 
            // btnAddAlbum
            // 
            this.btnAddAlbum.Location = new System.Drawing.Point(10, 212);
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
            this.btnAddAlbum.TabIndex = 7;
            this.btnAddAlbum.Values.Text = "             +\r\nAñadir Álbum";
            // 
            // Header
            // 
            this.Header.Controls.Add(this.btnMinimizar);
            this.Header.Controls.Add(this.btnCerrarApp);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(639, 25);
            this.Header.TabIndex = 29;
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
            // Albumes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(639, 385);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.btnAddAlbum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Album1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Albumes";
            this.Text = "Albumes";
            ((System.ComponentModel.ISupportInitialize)(this.Album1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Album1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddAlbum;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrarApp;
        private Bunifu.UI.WinForms.BunifuFormDock MaxMoveWindows;
    }
}