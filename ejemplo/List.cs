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
using ejemplo;

namespace ejemplo
{
    public partial class List : KryptonForm
    {
        public List()
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
            
        }

        private void List_Load(object sender, EventArgs e)
        {

        }

        private void List_MouseDown(object sender, MouseEventArgs e)
        {

        }

    } 
}
