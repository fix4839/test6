using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace test4
{
    public partial class DayPage : ContentPage
    {
        //int i = 0, k1,k2;
        //string[] str = new string[15];
        //ListView listView1;

        public DayPage(object a)
        {
            InitializeComponent();

            //int.TryParse(str.Substring(0, 2), out k2);
            //if (k2 == 0)
                //int.TryParse(str.Substring(0, 1), out k2);

            //string sb = a.ToString().Substring(4);
            //if (sb[0] == " ")
            //    sb = sb.substring(1);
            //switch (sb)
            //{
            //    case "December":
            //        k1 = 0;
            //        break;
            //    case "January":
            //        k1 = 1;
            //        break;
            //    case "February":
            //        k1 = 2;
            //        break;
            //    case "March":
            //        k1 = 3;
            //        break;
            //    case "April":
            //        k1 = 4;
            //        break;
            //    case "May":
            //        k1 = 5;
            //        break;
            //    case "June":
            //        k1 = 6;
            //        break;
            //    case "July":
            //        k1 = 7;
            //        break;
            //    case "August":
            //        k1 = 8;
            //        break;
            //    case "September":
            //        k1 = 9;
            //        break;
            //    case "October":
            //        k1 = 10;
            //        break;
            //    case "November":
            //        k1 = 11;
            //        break;

            //}
            ListView listView = new ListView();
            Label label = new Label
            {
                Text = a.ToString(),
                HorizontalOptions = LayoutOptions.Center
            };
   

            ToolbarItem toolbar = new ToolbarItem
            {
                Text = "+",
                Order = ToolbarItemOrder.Primary
            };
            toolbar.Clicked += dClick;


            this.ToolbarItems.Add(toolbar);

            //listView1 = listView;

            StackLayout stackLayout = new StackLayout
            {
                Children = {  label, listView}
            };
            Content = stackLayout;
        }

        async void dClick(object sender, System.EventArgs e)
        {
            var acr = await DisplayActionSheet("add", "Cancel", null, "Note", "Photo");
            if (acr ==  "Note"){
                //if (noteClass[k1, k2] == null)
                    //noteClass[k1, k2] = new NotePage();

                Navigation.PushAsync(new NotePage());

                //str[i] = "Note" + (i + 1).ToString();

                //listView1.ItemsSource = str;

                //Content = 
            }
        }

    }
}
