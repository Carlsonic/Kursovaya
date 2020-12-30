using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovaya_rabota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            mapa.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;

            doit();

            mapa.MinZoom = 5;
            mapa.MaxZoom = 100;
            mapa.Zoom = 10;
        }

        public void doit()
        {
            double lat = Convert.ToDouble(txtlat.Text);
            double lon = Convert.ToDouble(txtlon.Text);
            mapa.Position = new GMap.NET.PointLatLng(lat, lon);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void mapa_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            doit();
        }

        private void filteroption1_Click(object sender, EventArgs e)
        {

        }

        private void filteroption2_Click(object sender, EventArgs e)
        {

        }
    }
}
