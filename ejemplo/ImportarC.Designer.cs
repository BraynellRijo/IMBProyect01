namespace ejemplo
{
    partial class ImportarC
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
            this.btnSubirDispo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSubirDrive = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.DialogDispositivo = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnSubirDispo
            // 
            this.btnSubirDispo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubirDispo.Location = new System.Drawing.Point(19, 92);
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
            this.btnSubirDispo.TabIndex = 9;
            this.btnSubirDispo.Values.Text = "Importar archivo desde el dispositivo";
            this.btnSubirDispo.Click += new System.EventHandler(this.btnSubirDispo_Click);
            // 
            // btnSubirDrive
            // 
            this.btnSubirDrive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubirDrive.Location = new System.Drawing.Point(19, 201);
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
            this.btnSubirDrive.TabIndex = 10;
            this.btnSubirDrive.Values.Text = "Importar archivo desde Google Drive";
            this.btnSubirDrive.Click += new System.EventHandler(this.btnSubirDrive_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 42);
            this.label1.TabIndex = 23;
            this.label1.Text = "Importar canciones";
            // 
            // DialogDispositivo
            // 
            this.DialogDispositivo.FileName = "Archivos del Dispositivo";
            // 
            // ImportarC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(641, 347);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubirDrive);
            this.Controls.Add(this.btnSubirDispo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ImportarC";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 5;
            this.Text = "ImportarC";
            this.Load += new System.EventHandler(this.ImportarC_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImportC_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSubirDispo;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSubirDrive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog DialogDispositivo;
    }
}