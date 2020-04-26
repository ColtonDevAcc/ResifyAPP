using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resify.Views;
using Xamarin.Forms;

namespace Resify
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void SignUp_Button_Pressed(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new SignUpPage(), false);
        }
    }
}
