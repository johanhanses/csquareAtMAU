using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayTesterApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            MusicAlbum album = new MusicAlbum();

            album.SetTestValues();
            lstAlbums.Items.Clear();
            string[] infoStrings = album.GetInfo();
            if (infoStrings != null)
                lstAlbums.Items.AddRange(infoStrings);
        }
    }
}
