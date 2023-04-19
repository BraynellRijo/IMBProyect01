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

using DevExpress.Utils.CommonDialogs;
using System.IO;

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
        }
        private void btnCerrarApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            if (!isPlaying)
            {

                axWindowsMediaPlayer.Ctlcontrols.pause();
                isPlaying = true;

            
                btnPlay.Size = new Size(47, 50);
                btnPlay.BackColor = Color.Transparent;
                btnPlay.SizeMode = PictureBoxSizeMode.CenterImage;


                Point posicionActual = btnPlay.Location;


                posicionActual.X += 0;
                posicionActual.Y += 0;
                btnPlay.Location = posicionActual;
                btnPlay.BackColor = Color.Transparent;


            }

            else
            {
                isPlaying = false;
                axWindowsMediaPlayer.Ctlcontrols.play();
                btnPlay.Image = Properties.Resources.play_button_arrowhead;
                btnPlay.Size = new Size(47, 50);
                btnPlay.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }



        private void btnSkip_Click(object sender, EventArgs e)
        {
            int selectedIndex = ListMs.SelectedIndex;


            if (ListMs.Items.Count > 0 && selectedIndex < ListMs.Items.Count - 1)
            {

                ListMs.SelectedIndex = selectedIndex + 1;
            }
        }

        private void btnRewind_Click(object sender, EventArgs e)
        {
            int selectedIndex = ListMs.SelectedIndex;


            if (ListMs.Items.Count > 0 && selectedIndex < ListMs.Items.Count - 1)
            {

                ListMs.SelectedIndex = selectedIndex - 1;

            }
        }

        private void ImgCancion_Click(object sender, EventArgs e)
        {

        }

        private void btnPistas_Click(object sender, EventArgs e)
        {
            Indicador.Top = btnPistas.Top + 10;
            PagContain.SetPage(1);
            //abrirForm(new List());
        }


        private void btnSentting_Click(object sender, EventArgs e)
        {

            Indicador.Top = btnSentting.Top + 10;
            PagContain.SetPage(4);


        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            PagContain.SetPage(0);
            Indicador.Top = btnInicio.Top + 10;
        }

        string[] archivo, ruta;
        private void btnSubir_MouseClick(object sender, MouseEventArgs e)
        {
            SubirMs.Multiselect = true;
            if (SubirMs.ShowDialog() == DialogResult.OK)
            {
                archivo = SubirMs.SafeFileNames;
                ruta = SubirMs.FileNames;

                foreach (string path in ruta)
                {
                    WindowsMediaPlayer player = new WindowsMediaPlayer();
                    IWMPMedia media = player.newMedia(path);
                    TimeSpan duration = TimeSpan.FromSeconds(media.duration);

                    ListMs.Items.Add(Path.GetFileName(path));
                }
            }
        }

        private readonly AxWindowsMediaPlayer mediaPlayer = new AxWindowsMediaPlayer();
        private bool isPlaying = false;

        private void ListMs_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = ListMs.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < ruta.Length)
            {

                string selectedFilePath = ruta[selectedIndex];
                axWindowsMediaPlayer.URL = selectedFilePath;

                isPlaying = false;
                axWindowsMediaPlayer.Ctlcontrols.play();

                btnPlay.Image = Properties.Resources.play_button_arrowhead;
                btnPlay.Size = new Size(47, 50);
                btnPlay.SizeMode = PictureBoxSizeMode.CenterImage;
                btnPlay.BackColor = Color.Transparent;
            }
            else
            {
                MessageBox.Show("El índice seleccionado está fuera de los límites de la matriz.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAlbum_Click(object sender, EventArgs e)
        {

            PagContain.SetPage(2);
            Indicador.Top = btnAlbum.Top + 10;

        }

        private void btmImport_Click(object sender, EventArgs e)
        {
            Indicador.Top = btnImport.Top + 10;
            PagContain.SetPage(3);

        }

        // public void abrirForm(object formHj)
        //{
        //    if (this.panelContenedor.Controls.Count > 0)
        //    {
        //        panelContenedor.Controls.RemoveAt(0);
        //        Form hijo = formHj as Form;


        //        //foreach (Control control in panelContenedor.Controls)
        //        //{
        //        //    if (control is Form)
        //        //    {
        //        //        control.Hide();
        //        //    }
        //        //}

        //        hijo.TopLevel = false;
        //        hijo.Dock = DockStyle.Fill;
        //        this.panelContenedor.Controls.Add(hijo);
        //        this.panelContenedor.Tag = hijo;
        //        hijo.Show();
        //    }

        //}


        private bool ImagenOriginal = true;
        private void btnAleatorio_Click(object sender, EventArgs e)
        {


            if (ImagenOriginal)
            {
                Aleatorio.Image = Properties.Resources.aleatorioVerde;
                ImagenOriginal = false;

            }
            else
            {
                Aleatorio.Image = Properties.Resources.aleatorio;
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

        private void BarraProgress_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            if (axWindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying) // asegúrate de que la canción se esté reproduciendo
            {
                axWindowsMediaPlayer.Ctlcontrols.pause(); // pausa la reproducción de la canción
                axWindowsMediaPlayer.Ctlcontrols.currentPosition = BarraProgress.Value; // establece la posición de la canción en función del valor de la TrackBar
                axWindowsMediaPlayer.Ctlcontrols.play(); // reinicia la reproducción de la canción
            }
        }
        private void axWindowsMediaPlayer1_StatusChange(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {

                BarraProgress.Maximum = (int)axWindowsMediaPlayer.Ctlcontrols.currentItem.duration;
                timer.Start();

            }
            else if (axWindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer.Stop();

            }

            else if (axWindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer.Stop();
                BarraProgress.Value = 0;
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            CountMs.Text = axWindowsMediaPlayer.Ctlcontrols.currentPositionString;
            DurationCanc.Text = axWindowsMediaPlayer.Ctlcontrols.currentItem.durationString.ToString();

            if (axWindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                BarraProgress.Value = (int)axWindowsMediaPlayer.Ctlcontrols.currentPosition;

            }
        }

        private void PagInicio_Click(object sender, EventArgs e)
        {

        }
     
        private void Aleatorio_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int index = random.Next(ListMs.Items.Count);
            ListMs.SelectedIndex = index;
        }

        private void btnAleatorioList_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int index = random.Next(ListMs.Items.Count);
            ListMs.SelectedIndex = index;
        }

        private void lblTituloCancion_Click(object sender, EventArgs e)
        {


        }

        private void CountMs_Click(object sender, EventArgs e)
        {

        }

        private void BarraReproduccion_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
