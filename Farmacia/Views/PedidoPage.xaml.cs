using Farmacia.Domain;
using Farmacia.Services;
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
    public partial class PedidoPage : ContentPage
    {
        public PedidoPage()
        {
            InitializeComponent();
            GetPedidos();

        }

        public async void GetPedidos()
        {
            string email = await SecureStorage.GetAsync("userEmail");

            List<Pedido> pedids = FarmaciaService.GetPedidos(email);

            pedidos.ItemsSource = pedids;

            if (pedids.Count == 0)
            {
                await DisplayAlert("Hola!", "No has realizado pedidos", "Aceptar");
            }

        }
    }
}