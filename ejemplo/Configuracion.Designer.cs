namespace ejemplo
{
    partial class Configuracion
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
            this.btnContacto = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnWeb = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnModeLight = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnContacto
            // 
            this.btnContacto.AutoSize = true;
            this.btnContacto.Font = new System.Drawing.Font("Poppins", 16F);
            this.btnContacto.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnContacto.Location = new System.Drawing.Point(45, 283);
            this.btnContacto.Name = "btnContacto";
            this.btnContacto.Size = new System.Drawing.Size(159, 39);
            this.btnContacto.TabIndex = 1;
            this.btnContacto.Text = "Contactenos";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Poppins", 16F);
            this.lblVersion.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblVersion.Location = new System.Drawing.Point(48, 382);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(98, 39);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "Versión";
            // 
            // btnWeb
            // 
            this.btnWeb.AutoSize = true;
            this.btnWeb.Font = new System.Drawing.Font("Poppins", 16F);
            this.btnWeb.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnWeb.Location = new System.Drawing.Point(48, 334);
            this.btnWeb.Name = "btnWeb";
            this.btnWeb.Size = new System.Drawing.Size(118, 39);
            this.btnWeb.TabIndex = 3;
            this.btnWeb.Text = "Sitio Web";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(45, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 56);
            this.label5.TabIndex = 4;
            this.label5.Text = "Configuración";
            // 
            // btnModeLight
            // 
            this.btnModeLight.Checked = true;
            this.btnModeLight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnModeLight.Location = new System.Drawing.Point(52, 98);
            this.btnModeLight.Name = "btnModeLight";
            this.btnModeLight.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.btnModeLight.Size = new System.Drawing.Size(170, 35);
            this.btnModeLight.StateCommon.ShortText.Color1 = System.Drawing.SystemColors.ControlLight;
            this.btnModeLight.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins", 16F);
            this.btnModeLight.TabIndex = 6;
            this.btnModeLight.Values.Text = "Modo oscuro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(575, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "1.0";
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(641, 446);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModeLight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnWeb);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnContacto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Configuracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 15;
            this.Text = "Configuracion";
            this.Load += new System.EventHandler(this.Configuracion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnContacto;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label btnWeb;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox btnModeLight;
        private System.Windows.Forms.Label label1;
    }
}