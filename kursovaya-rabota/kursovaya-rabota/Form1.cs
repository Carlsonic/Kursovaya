using GMap.NET;
using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;

namespace kursovaya_rabota
{
    public partial class Form1 : Form
    {
        Client client = new Client();
        public Form1()
        {
            client.LoadEventData();

            InitializeComponent();

            mapa.MapProvider = GoogleMapProvider.Instance;

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

        private void button1_Click(object sender, EventArgs e)
        {
        PointLatLng point = new PointLatLng(11, 11);
        Bitmap bmpmarker = (Bitmap)Image.FromFile("D:\\Kursovaya\\kursovaya-rabota\\kursovaya-rabota\\imag\\metka.png");
        GMapMarker marker = new GMarkerGoogle(point, bmpmarker);
            
        }


    }
}
