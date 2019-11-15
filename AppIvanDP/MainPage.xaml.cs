using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppIvanDP
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        int i = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        public void mioClick (object sender, EventArgs args)
        {
            switch (i)
            {
                case 0:
                    this.miaLabel.Text = "BBB";
                    i = 1;
                    break;
                case 1:
                    this.miaLabel.Text = "CCC";
                    i = 2;
                    break;
                case 2:
                    this.miaLabel.Text = "AAA";
                    i = 0;
                    break;
            }
            Navigation.PushAsync(new MyPage());
        }
    }
}
