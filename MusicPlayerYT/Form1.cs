using DevExpress.Utils.CommonDialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagLib;


namespace MusicPlayerYT
{
    public partial class MediaPlayer : Form
    {
        public MediaPlayer()
        {
            InitializeComponent();

        }

        public class Cancion
        {
            public int NO_canciones { get; set; } 
            public string NombreCanc { get; set; } 
            public string ArtistCanc { get; set; } 
            public TimeSpan DuracionCanc { get; set; }
    }

        private void btnPlaying_Click(object sender, EventArgs e)
        {
            Inicador.Top = btnPlaying.Top;
            PagContain.SetPage(0);
        }

        private void btnExplorer_Click(object sender, EventArgs e)
        {
            Inicador.Top = btnExplorer.Top+5;
            PagContain.SetPage(1);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Environment.Exit();
        }

        private void kryptonListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAlbum_Click(object sender, EventArgs e)
        {
            Inicador.Top = btnAlbum.Top + 5;
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            Inicador.Top = btnPlaylist.Top + 5;

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void SubirCanc_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos MP3 (*.mp3)|*.mp3";
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                List<Cancion> canciones = new List<Cancion>();
                int id = 1;
                foreach (string archivo in openFileDialog.FileNames)
                {
                    Cancion cancion = new Cancion();
                    cancion.NO_canciones = id++;
                    cancion.NombreCanc = Path.GetFileName(archivo);
                    string ruta = archivo;
                    if (System.IO.File.Exists(ruta))
                    {
                        TagLib.File file = TagLib.File.Create(ruta);
                        TimeSpan duracion = file.Properties.Duration;
                    }
                    else
                    {
                        // El archivo no existe o no se puede acceder.
                    }
                }
                ListMs.DataSource = canciones;
            }

        }

        private void MediaPlayer_Shown(object sender, EventArgs e)
        {
            //Fake data
        }
    }
}