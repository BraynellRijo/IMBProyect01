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
using WMPLib;
using AxWMPLib;
using ejemplo.Resources;
using MusicPlayerYT;

namespace ejemplo
{
    public partial class Inicio : KryptonForm
    {
        public Inicio()
        {
            InitializeComponent();
        }
        private void Inicio_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);
        private void btnCerrarApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnStateNormal.Visible = true;
        }        private void btnStateNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnStateNormal.Visible = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }


        private void btnInicio_Enter(object sender, EventArgs e)
        {
            btnInicio.ForeColor = Color.FromArgb(239, 239, 239);
        }

        private void btnInicio_Leave(object sender, EventArgs e)
        {
            btnInicio.ForeColor = Color.LightGray;

        }

        private void MenuV_Paint(object sender, PaintEventArgs e)
        {
            this.MouseMove += btnInicio_Enter;
            this.MouseMove += btnInicio_Leave;
        }

        private void MenuV_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //if (!isPlaying)
            //{

            //    axWindowsMediaPlayer1.Ctlcontrols.pause();
            //    isPlaying = true;



            //    Point posicionActual = btnPlay.Location;


            //    posicionActual.X += 0;
            //    posicionActual.Y += 0;
            //    btnPlay.Location = posicionActual;


            //}

            //else
            //{
            //    isPlaying = false;
            //    axWindowsMediaPlayer1.Ctlcontrols.play();

            //} 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            //int selectedIndex = Listado.SelectedIndex;


            //if (Listado.Items.Count > 0 && selectedIndex < Listado.Items.Count - 1)
            //{

            //    Listado.SelectedIndex = selectedIndex + 1;
            //}
        }

        private void btnRetoceder_Click(object sender, EventArgs e)
        {
            //int selectedIndex = Listado.SelectedIndex;


            //if (Listado.Items.Count > 0 && selectedIndex < Listado.Items.Count - 1)
            //{

            //    Listado.SelectedIndex = selectedIndex - 1;
            //}
        }

        private void ImgCancion_Click(object sender, EventArgs e)
        {

        }

        private void btnPistas_Click(object sender, EventArgs e)
        {
            abrirForm(new List());
        }
        private void BusquedaBar_Enter(object sender, EventArgs e)
        {
            if (BusquedaBar.Text == "Buscar...")
            {
                BusquedaBar.Text = "";
                BusquedaBar.ForeColor = Color.DimGray;
            }
        }

        private void BusquedaBar_Leave(object sender, EventArgs e)
        {

            if (BusquedaBar.Text == "")
            {
                BusquedaBar.Text = "Buscar...";
                BusquedaBar.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void btnSentting_Click(object sender, EventArgs e)
        {
            abrirForm(new Configuracion());
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
                Inicio inicio = new Inicio();
                inicio.Show();
                this.Hide();
        }

        //string[] archivo, ruta;
        //private void Listado_MouseClick(object sender, MouseEventArgs e)
        //{
        //    openFileDialog.Multiselect = true;

        //    if (openFileDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        archivo = openFileDialog.SafeFileNames;
        //        ruta = openFileDialog.FileNames;

        //        for (int i = 0; i < archivo.Length; i++)
        //        {

        //            Listado.Items.Add(archivo[i]);
        //        }
        //    }
        //}
        //private readonly AxWindowsMediaPlayer mediaPlayer = new AxWindowsMediaPlayer();
        //private bool isPlaying = false;

        //private void Listado_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    int selectedIndex = Listado.SelectedIndex;
        //    if (selectedIndex >= 0 && selectedIndex < ruta.Length)
        //    {

        //        string selectedFilePath = ruta[selectedIndex];
        //        axWindowsMediaPlayer1.URL = selectedFilePath;

        //        isPlaying = false;
        //        axWindowsMediaPlayer1.Ctlcontrols.play();

        //    }
        //    else
        //    {
        //        MessageBox.Show("El índice seleccionado está fuera de los límites de la matriz.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void Listado_SelectedIndexChanged_1(object sender, EventArgs e)
        //{
        //    int selectedIndex = Listado.SelectedIndex;
        //    if (selectedIndex >= 0 && selectedIndex < ruta.Length)
        //    {

        //        string selectedFilePath = ruta[selectedIndex];
        //        axWindowsMediaPlayer1.URL = selectedFilePath;

        //        isPlaying = false;
        //        axWindowsMediaPlayer1.Ctlcontrols.play();

        //    }
        //    else
        //    {
        //        MessageBox.Show("El índice seleccionado está fuera de los límites de la matriz.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void btnAlbum_Click(object sender, EventArgs e)
        {
            abrirForm(new Albumes());

        }

        private void btmImport_Click(object sender, EventArgs e)
        {
            abrirForm(new ImportarC());
        }

         public void abrirForm(object formHj)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                panelContenedor.Controls.RemoveAt(0);
                Form hijo = formHj as Form;


                //foreach (Control control in panelContenedor.Controls)
                //{
                //    if (control is Form)
                //    {
                //        control.Hide();
                //    }
                //}

                hijo.TopLevel = false;
                hijo.Dock = DockStyle.Fill;
                this.panelContenedor.Controls.Add(hijo);
                this.panelContenedor.Tag = hijo;
                hijo.Show();
            }

        }

        private bool ImagenOriginal = true;
        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            if (ImagenOriginal)
            {
                btnAleatorio.Image = Properties.Resources.aleatorioVerde;
                ImagenOriginal = false;
            }
            else
            {
                btnAleatorio.Image = Properties.Resources.aleatorio;
                ImagenOriginal = true;
            }
        }

        private bool ImagenOriginalLoop = true;
        private void btnLoop_Click(object sender, EventArgs e)
        {
            if (ImagenOriginalLoop)
            {
                btnLoop.Image = Properties.Resources.loopVerde;
                ImagenOriginalLoop = false;
            }
            else
            {
                btnLoop.Image = Properties.Resources.loop;
                ImagenOriginalLoop = true;
            }
        }

        private void btnInicio_MouseHover(object sender, EventArgs e)
        {
            btnInicio.ForeColor = Color.FromArgb(255,130,0);
        }

        private void btnInicio_MouseMove(object sender, MouseEventArgs e)
        {
            // Obtener las coordenadas X e Y del ratón en relación con el control pictureBox1
            int x = e.X;
            int y = e.Y;

            // Realizar acciones en función de la posición del ratón en el control
            // Por ejemplo, cambiar el color de fondo del control
            if (x > 50 && x < 100 && y > 20 && y < 70)
            {
                btnInicio.ForeColor = Color.Red;
            }
            else
            {
                btnInicio.ForeColor = Color.Transparent;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MusicPlayerYT.MediaPlayer form = new MusicPlayerYT.MediaPlayer();
            form.Show();
            this.Hide();

        }
    }
}
