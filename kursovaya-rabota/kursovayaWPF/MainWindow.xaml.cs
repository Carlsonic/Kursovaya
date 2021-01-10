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
        Client client = new Client();

        List<string> spisokartistov = new List<string>() {
            "Avatar", "Usher", "Blue Water Highway", "Street Kult", "Hearty Har", "Milky Chance", "311", "Pinegrove",
            "The Revivalists", "Jimmy Eat World", "Leprous", "Disciple", "Steelheart", "Nightwish", "BTS", "O-Town",

            };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MapLoaded(object sender, RoutedEventArgs e)
        {
            GMaps.Instance.Mode = AccessMode.ServerAndCache;

            Map.MapProvider = YandexMapProvider.Instance;

            Map.MinZoom = 2;
            Map.MaxZoom = 17;
            Map.Zoom = 15;

            Map.Position = new PointLatLng(55.012823, 82.950359);

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

        public void ArtistAdd(Detail arr)
        {
            
                GMapMarker Marker = CreatMarker(arr.MarkerCoord,
                    arr.EventName + '\n' + arr.Description + '\n' + "В городе " + arr.City + ", " + arr.Country + '\n' + "Запланировано " + arr.Date);

                Map.Markers.Add(Marker);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Map.Markers.Clear();
            string artname = namebox.Text;
            new Thread(() => {
                info = client.LoadEventData(artname);
                Application.Current.Dispatcher.Invoke(() =>
                {
                    for (int i = 0; i < info.Count;i++)
                        ArtistAdd(info[i]);
                });

            }).Start();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Map.Markers.Clear();
            new Thread(() =>
            {
                foreach (string i in spisokartistov)
                {
                    info = client.LoadEventData(i);
                    if (info == null)
                        continue;
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        for (int j = 0; j < info.Count; j++)
                            if (option1.Text.ToString() == info[j].Country)
                                ArtistAdd(info[j]);
                    });
                }
            }).Start();
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Map.Markers.Clear();
            new Thread(() =>
            {
            foreach (string i in spisokartistov)
            {
                info = client.LoadEventData(i);
                if (info == null)
                    continue;
                    Application.Current.Dispatcher.Invoke(() =>
                    {

                        for (int j = 0; j < info.Count; j++)
                            if (_1.SelectedDate.Value < info[j].Date && _2.SelectedDate.Value > info[j].Date)
                                ArtistAdd(info[j]);
                    });
            }
            }).Start();
        }
    }
}
