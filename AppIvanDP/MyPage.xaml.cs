using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppIvanDP
{
    public partial class MyPage : ContentPage
    {
        public MyPage()
        {
            InitializeComponent();

       
        }

        public void mioClick2(object sender, EventArgs args)
        {
            Navigation.PushAsync(new MyPage3());
        }
    }
}
