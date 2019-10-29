using Ext.Net;
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
    public partial class DomiciliosPage : ContentPage
    {

        public Pedido pedido = new Pedido();
        public List<Medicamento> medicamentos = new List<Medicamento>();
        public List<ItemPedido> itemPedidos = new List<ItemPedido>();
        public DomiciliosPage()
        {
            InitializeComponent();
            ListaMedicamentos.ItemsSource = FarmaciaService.GetMedicamentos();

    }

        private async void ListaMedicamentos_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            //string result = await DisplayPromptAsyn("Cantidad", maxLength: 10, keyboard: Keyboard.Numeric);

            //if (result.Text != null && result.Text != " "){
            var item = (Medicamento)e.SelectedItem;
            //int cant = int.Parse(result.Text);
            bool existe = false;
            if(itemPedidos.Count > 0)
            {
                for (int i = 0; i < itemPedidos.Count; i++)
                {
                    if (itemPedidos[i].codeMedicamento.Equals(item.code))
                    {
                        existe = true;
                    };
                }

                if (existe == false)
                {
                    ItemPedido itemPedido = new ItemPedido();
                    itemPedido.codeMedicamento = item.code;
                    itemPedido.name = item.name;
                    itemPedido.price = item.salePrice;
                    itemPedido.quantity = 1;
                    itemPedidos.Add(itemPedido);
                    pedido.total += (itemPedido.price * itemPedido.quantity);

                    await DisplayAlert("Genail!", "Medicamento agregado", "Aceptar");

                }
                else
                {
                    await DisplayAlert("Ops!", "Ya agregaste el medicamento", "Aceptar");
                }
            }
            else
            {
                ItemPedido itemPedido = new ItemPedido();
                itemPedido.codeMedicamento = item.code;
                itemPedido.name = item.name;
                itemPedido.price = item.salePrice;
                itemPedido.quantity = 1;
                itemPedidos.Add(itemPedido);
                pedido.total += (itemPedido.price * itemPedido.quantity);

                await DisplayAlert("Genail!", "Medicamento agregado", "Aceptar");

            }


        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            pedido.userEmail = await SecureStorage.GetAsync("userEmail");
            pedido.items = itemPedidos;

            if(pedido.items.Count == 0)
            {
                await DisplayAlert("Ops!", "No has seleccionado ningun medicamento", "Aceptar");
            }
            else
            {
                await Navigation.PushAsync(new ResumenPedidoPage(pedido));
            }

        }
    }
}