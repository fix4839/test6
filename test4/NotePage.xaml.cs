using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace test4
{
    public partial class NotePage : ContentPage
    {
        public NotePage()
        {
            InitializeComponent();

        }

        void pop(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
