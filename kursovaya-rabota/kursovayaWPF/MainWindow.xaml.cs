using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsPresentation;
using System.Device.Location;
using System.Threading;

namespace kursovayaWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Detail> info = new List<Detail>();
        List<GMapMarker> spisokmarkerov = new List<GMapMarker>();
        Client client = new Client();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MapLoaded(object sender, RoutedEventArgs e)
        {
            // настройка доступа к данным
            GMaps.Instance.Mode = AccessMode.ServerAndCache;

            // установка провайдера карт
            Map.MapProvider = YandexMapProvider.Instance;

            // установка зума карты
            Map.MinZoom = 2;
            Map.MaxZoom = 17;
            Map.Zoom = 15;
            // установка фокуса карты
            Map.Position = new PointLatLng(55.012823, 82.950359);

            // настройка взаимодействия с картой
            Map.MouseWheelZoomType = MouseWheelZoomType.MousePositionAndCenter;
            Map.CanDragMap = true;
            Map.DragButton = MouseButton.Left;
        }

        GMapMarker CreatMarker(PointLatLng markercoord, string info)
        {
            
            return new GMapMarker(markercoord)
            {
                Shape = new Image
                {
                    Width = 40,
                    Height = 40,
                    ToolTip = info,
                    Source = new BitmapImage(new Uri("pack://application:,,,/imag/metka.png"))
                }
            };
        }
        public void doit()
        {
            foreach (GMapMarker removablemarker in spisokmarkerov)
            {
                Map.Markers.Remove(removablemarker);
            }

                info = client.LoadEventData(namebox.Text);//вставить имя артиста
            // по count
            

            for (int i = 0; i < info.Count; i++)
            {
                GMapMarker Marker = CreatMarker(info[i].MarkerCoord, info[i].EventName);

                Map.Markers.Add(Marker);

                spisokmarkerov.Add(Marker);
            }

            
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            doit();
        }

        private void namebox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
