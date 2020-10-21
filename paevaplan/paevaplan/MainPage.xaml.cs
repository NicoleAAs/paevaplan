using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace paevaplan
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Button Tbl_btn = new Button { Text = "DataPicker" };
            StackLayout st = new StackLayout();
            st.Children.Add(Tbl_btn);
            Content = st;
            Tbl_btn.Clicked += Tbl_btn_Clicked;
        }

        private async void Tbl_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DataPicker());
        }

        
    }
    }

