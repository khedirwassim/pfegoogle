using DocumentFormat.OpenXml.Drawing.Charts;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using MailChimp.Net.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pfegoogle
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            map.MapProvider = GMapProviders.GoogleMap;
            map.DragButton = MouseButtons.Left;
            map.MinZoom = 5;
            map.MaxZoom = 100;
            map.Zoom = 10;
            map.OnMarkerClick += new MarkerClick(gOnMarkerClick);
        }

        private void Map_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
 
        private void Button1_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }
        private void gOnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            Console.WriteLine(String.Format("Marker {0} was clicked.", item.Tag));
            Console.WriteLine("marker clicked");


        }

      



    private void button1_Click(object sender, EventArgs e)
        {
           

            double lat =Convert.ToDouble(txtlat.Text);
            double longt = Convert.ToDouble(txtlong.Text);
            
            map.Position = new PointLatLng(lat, longt);
           PointLatLng po = new PointLatLng(lat, longt);
            GMapMarker marker = new GMarkerGoogle(po,GMarkerGoogleType.green);
            GMapOverlay markers = new GMapOverlay("markers");

            markers.Markers.Add(marker);
            map.Overlays.Add(markers);
            marker.ToolTipText = "hello\nout there";
            
           








        }

       
    }
}
