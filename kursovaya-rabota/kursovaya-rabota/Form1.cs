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

            

            mapa.MinZoom = 5;
            mapa.MaxZoom = 100;
            mapa.Zoom = 10;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void mapa_Load(object sender, EventArgs e)
        {

        }
    }
}
