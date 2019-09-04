using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace NestedScrollView
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public List<string> Buttons { get; set; }

        public MainPage()
        {
            Buttons = new List<string>()
            {
                "Ipsum Lorem 1",
                "Ipsum Lorem 2",
                "Ipsum Lorem 3",
                "Ipsum Lorem 4",
                "Ipsum Lorem 5",
                "Ipsum Lorem 6",
                "Ipsum Lorem 7",
                "Ipsum Lorem 8",
                "Ipsum Lorem 9",
                "Ipsum Lorem 10",
                "Ipsum Lorem 11",
                "Ipsum Lorem 12",
                "Ipsum Lorem 13",
                "Ipsum Lorem 14",
                "Ipsum Lorem 15",
                "Ipsum Lorem 16",
                "Ipsum Lorem 17",
                "Ipsum Lorem 18",
                "Ipsum Lorem 19",
                "Ipsum Lorem 20",
                "Ipsum Lorem 21",
                "Ipsum Lorem 22",
                "Ipsum Lorem 23",
                "Ipsum Lorem 24",
                "Ipsum Lorem 25",
                "Ipsum Lorem 26",
                "Ipsum Lorem 27",
                "Ipsum Lorem 28",
                "Ipsum Lorem 29",
                "Ipsum Lorem 30"
            };

            InitializeComponent();
            BindingContext = this;
        }
    }
}
