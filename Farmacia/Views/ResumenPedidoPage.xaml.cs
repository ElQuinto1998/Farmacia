using Farmacia.Domain;
using Farmacia.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Farmacia.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResumenPedidoPage : ContentPage
    {
        Pedido pedido1 = new Pedido();
        public ResumenPedidoPage(Pedido pedido)
        {
            InitializeComponent();

            pedido1 = pedido;

            lvt_pedidos.ItemsSource = pedido.items;

            total.Text += pedido.total.ToString();

        }

        private async void hacer_pedido(object sender, EventArgs e)
        {
            PedidoResponse response = FarmaciaService.crearPedido(pedido1);

            if(response.error != null)
            {
                await DisplayAlert("Ops!", response.error, "Ok");
            }
            else
            {
                await DisplayAlert("Genail!", response.message, "Ok");
                await Navigation.PushAsync(new PedidosPage());
            }

        }

    }
}