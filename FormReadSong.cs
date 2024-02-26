using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppSpotifyClone
{
    public partial class FormReadSong : Form
    {
        public FormReadSong()
        {
            InitializeComponent();
        }

        private void FormReadSong_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDD_SpotifyMusicDataSet.TBL_SONG' Puede moverla o quitarla según sea necesario.
            this.tBL_SONGTableAdapter.Fill(this.bDD_SpotifyMusicDataSet.TBL_SONG);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
