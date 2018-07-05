using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace test4
{
    public partial class MonthPage : ContentPage
    {
        MonthClass monthClass1;
        NoteClass noteClass1;

        public MonthPage(int k1, MonthClass monthClass, NoteClass noteClass)
        {
            //InitializeComponent();
            //string b = a.ToString();

            monthClass1 = monthClass;
            noteClass1 = noteClass;

            ListView listView = new ListView();
            int k = 0;
            if (k1 == 2)
                k = 28;
            else if (k1 == 4 || k1 == 6 || k1 == 9 || k1 == 11)
                k = 30;
            else
                k = 31;
            string b = "";
            switch(k1){
                case 0:
                    b = "December";
                    break;
                case 1:
                    b = "January";
                    break;
                case 2:
                    b = "February";
                    break;
                case 3:
                    b = "March";
                    break;
                case 4:
                    b = "April";
                    break;
                case 5:
                    b = "May";
                    break;
                case 6:
                    b = "June";
                    break;
                case 7:
                    b = "July";
                    break;
                case 8:
                    b = "August";
                    break;
                case 9:
                    b = "September";
                    break;
                case 10:
                    b = "October";
                    break;
                case 11:
                    b = "November";
                    break;
                    
            }
            string[] arr = new string[k];

            for (int i = 1; i <= k; i++){
                string str = "";
                switch(i){
                    case 1:
                    case 21:
                    case 31:    
                        str = "st ";
                        break;
                    case 2:
                    case 22:
                        str = "nd ";
                        break;
                    case 3:
                    case 23:
                        str = "rd ";
                        break;
                    default:
                        str = "th ";
                        break;
                }
                arr[i - 1] = i.ToString() + str + b;
            }
                

            listView.ItemsSource = arr;

            listView.ItemTapped += (object sender, ItemTappedEventArgs e) =>
            {
                int i = 0;
                string str = e.Item.ToString();
                int.TryParse(str.Substring(0, 2), out i);
                if(i == 0)
                    int.TryParse(str.Substring(0, 1), out i);
                if (monthClass[k1,i] == null)
                    monthClass[k1,i] = new DayPage(e.Item);

                Navigation.PushAsync(monthClass[k1,i]);

            };

            ToolbarItem toolbar = new ToolbarItem
            {
                Text = "Months",
                Order = ToolbarItemOrder.Primary
            };
            toolbar.Clicked += MonthClick;

            this.ToolbarItems.Add(toolbar);
            Content = listView;

        }

        async void MonthClick(object sender, System.EventArgs e)
        {
            var acr = await DisplayActionSheet("Months", "Cancel", null, "January", "February", "March", "April", "May", "June", "July", "August", "September",
                                               "October", "November", "December");
            int k1 = 0;
            switch (acr)
            {
                case "December":
                    k1 = 0;
                    break;
                case "January":
                    k1 = 1;
                    break;
                case "February":
                    k1 = 2;
                    break;
                case "March":
                    k1 = 3;
                    break;
                case "April":
                    k1 = 4;
                    break;
                case "May":
                    k1 = 5;
                    break;
                case "June":
                    k1 = 6;
                    break;
                case "July":
                    k1 = 7;
                    break;
                case "August":
                    k1 = 8;
                    break;
                case "September":
                    k1 = 9;
                    break;
                case "October":
                    k1 = 10;
                    break;
                case "November":
                    k1 = 11;
                    break;

            }
            if (acr != "Cancel")
                await Navigation.PushAsync(new MonthPage(k1, monthClass1, noteClass1));

        }


        //public void List_ItemTapped(object sender, ItemTappedEventArgs e)
        //{
        //    //if (daysClass[])
        //    Navigation.PushAsync(new DayPage(e.Item));
        //}


    }
}
