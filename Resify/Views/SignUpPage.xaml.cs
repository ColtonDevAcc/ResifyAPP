using System;
using System.Collections.Generic;
using Resify.Models;
using Xamarin.Forms;

namespace Resify.Views
{
    public partial class SignUpPage : CarouselPage
    {
        public UserDetails _user = new UserDetails();

        public SignUpPage()
        {
            InitializeComponent();
            BindingContext = _user;
        }

        public async void Finish_Button_Pressed(System.Object sender, System.EventArgs e)
        {
            try
            {
                _user.LastName = LastName_Entry.Text;
                await Navigation.PopModalAsync();
            }
            catch
            {
                await DisplayAlert("d","d","a");
            }
        }
    }
}
