using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App150
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MyModel obj { get; set; }
        public MainPage()
        {
            obj = new MyModel();
            obj.id = "idTest";
            obj.first_name = "alex";
            obj.last_name = "allen";
            obj.email = "abc.com";
            obj.avatar = "http://image10.bizrate-images.com/resize?sq=60&uid=2216744464";

            InitializeComponent();

        }
    }

    public class MyModel {

        public string id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string avatar { get; set; }
    }
}
