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
    public partial class PedidosPage : MasterDetailPage
    {
        public PedidosPage()
        {
            InitializeComponent();
        }

        private async void cerrar_sesion(object sender, EventArgs e)
        {
            SecureStorage.RemoveAll();

            await Navigation.PushAsync(new LoginPage());
        }

        private async void crear_pedido(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DomiciliosPage());
        }

        private async void pedidos(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PedidoPage());
        }

        private async void main_page(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}