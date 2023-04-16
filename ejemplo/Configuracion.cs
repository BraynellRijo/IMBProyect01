using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ComponentFactory.Krypton;
using ComponentFactory.Krypton.Toolkit;
using System.Reflection.Emit;
using ejemplo.Properties;

namespace ejemplo
{
    public partial class Configuracion : KryptonForm
    {
        public Configuracion()
        {
            InitializeComponent();
        }
        private void btnCerrarApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
        private void Configuracion_Load(object sender, EventArgs e)
        {

        }

        private void ModeLight_CheckedChanged(object sender, EventArgs e)
        {
            if (ModeLight.Checked == true)
            {
                //Configuracion.DefaultBackColor = Color.LightCoral;
            }
        }
    }
}
