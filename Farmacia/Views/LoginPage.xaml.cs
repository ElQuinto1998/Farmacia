using Farmacia.Domain;
using Farmacia.Services;
using Jose;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Farmacia.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {

        public LoginPage()
        {
            InitializeComponent();
        }

        private async void HomePage_Click(object sender, EventArgs e)
        {

            if (email.Text != " " && email.Text != " " && password.Text != null && password.Text != null)
            {
                DataLogin usuario = new DataLogin();
                usuario.email = email.Text;
                usuario.password = password.Text;

                UserResponse response = FarmaciaService.Login(usuario);

                if (response.error != null)
                {
                    await DisplayAlert("Ops!", response.error, "OK");
                }
                else
                {
                    await SecureStorage.SetAsync("userEmail", response.usuario.email);
                    await SecureStorage.SetAsync("userName", response.usuario.firstName);
                    await SecureStorage.SetAsync("avatar", response.usuario.avatar);

                    await Navigation.PushAsync(new PedidosPage());
                 
                }

            }
            else
            {
                await DisplayAlert("Ops!", "Campos requeridos", "OK");
            }
        }
    }
}