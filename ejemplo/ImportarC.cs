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
        private void btnInicio_Click(object sender, EventArgs e)
        {
            Inicio home = new Inicio();
            home.Show();
            this.Hide();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);
        private void ImportC_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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
