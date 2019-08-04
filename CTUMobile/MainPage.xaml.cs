using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CTUMobile
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        CampusList campusList = new CampusList();
        private static string br = "\n";

        private string DescriptionHeading = $"ABOUT US {br}";
        private string ActivitiesHeading = $"OUR ACTIVITIES {br}";
        private string CourseHeading = $"OUR POPULAR COURSES {br}";
        private string VideoHeading = $"{br} {br} STUDENT LIFE";

        private void onBoot_Event(object sender, RoutedEventArgs e)
        {
            foreach (var item in campusList.campuses)
            {
                CampusStack.Items.Add(item.CampusName);
            }
        }

        private void CleanView()
        {
            CampusDescription.Text = "";
            CampusDesc1.Text = "";
            CampusActivities.Text = "";
            CampusCourses.Text = "";
            CampusVid1.Source = null;
            //CampusMapImage.Source = null;
            CampusImage1.Source = null;
        }

        private void CampusStack_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CleanView();
            var clickedCampus = from cm in campusList.campuses where cm.Id == CampusStack.SelectedIndex select cm;

            foreach (var item in clickedCampus)
            {
                CampusDesc1.Text = item.CampusContact;
                CampusDescription.Text = DescriptionHeading + item.CampusDescription;
                CampusActivities.Text = ActivitiesHeading + item.CampusActivities;
                CampusActivities.Text += VideoHeading;
                CampusCourses.Text = CourseHeading;
                foreach (var itemCourse in item.CampusCourses)
                {
                    CampusCourses.Text += itemCourse.Key + itemCourse.Value;
                }
                CampusVid1.Source = item.CampusVideos;
                CampusImage1.Source = item.CampusImage;

                var InteractMap = new MapControl();

                InteractMap.ZoomInteractionMode = MapInteractionMode.Auto;
                InteractMap.TiltInteractionMode = MapInteractionMode.GestureAndControl;
                InteractMap.PanInteractionMode = MapPanInteractionMode.Auto;
                InteractMap.MapServiceToken = "xVw4m3LWqMqNhkkV6iTs~8xCzHMDnuTdugl7qS-7lQA~AgsDbT7TRxvrwzPA2TyPwbZnYKpauH3Ke4kgOl2W5M4VOsIPXIF4Ir6ofAGjrNye";
                InteractMap.Margin = new Thickness(15);
                Grid.SetColumn(InteractMap, 1);
                Grid.SetRow(InteractMap, 15);
                InteractMap.Height = 400;

                GridView.Children.Add(InteractMap);

                var myLandMarks = new List<MapElement>();

                BasicGeoposition snPosition = new BasicGeoposition { Latitude = item.MapLat, Longitude = item.MapLong };
                Geopoint snPoint = new Geopoint(snPosition);

                var spaceNeedleIcon = new MapIcon
                {
                    Location = snPoint,
                    NormalizedAnchorPoint = new Point(0.5, 1.0),
                    ZIndex = 0,
                    Title = item.CampusName,
                    Image = RandomAccessStreamReference.CreateFromUri(item.CampusLocation)
                };

                myLandMarks.Add(spaceNeedleIcon);

                var LandmarksLayer = new MapElementsLayer
                {
                    ZIndex = 1,
                    MapElements = myLandMarks
                };

                InteractMap.Layers.Add(LandmarksLayer);

                InteractMap.Center = snPoint;
                InteractMap.ZoomLevel = 15;
            }
        }
    }
}
