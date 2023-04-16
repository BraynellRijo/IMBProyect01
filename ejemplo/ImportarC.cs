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

namespace ejemplo
{
    public partial class ImportarC : KryptonForm
    {
        public ImportarC()
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
        private void btnInicio_Click(object sender, EventArgs e)
        {
            Inicio home = new Inicio();
            home.Show();
            this.Hide();
        }
        private void ImportC_MouseDown(object sender, MouseEventArgs e)
        {

        }
   
        private void btnSubirDispo_Click(object sender, EventArgs e)
        {
            //if (ImportarMusica.ShowDialog() == DialogResult.OK)
            //{

            //}
        }

        private void btnSubirDrive_Click(object sender, EventArgs e)
        {

        }

        private void ImportarC_Load(object sender, EventArgs e)
        {

        }
    }
}
