using Farmacia.Domain;
using Farmacia.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmacia.Services
{
    class FarmaciaService
    {
        public static UserResponse Login(DataLogin dataLogin)
        {
            var respuesta = ApiHelper.Post<UserResponse>("/login", dataLogin);
            return respuesta;
        }
        public static List<Medicamento> GetMedicamentos()
        {
            var medicamentos = ApiHelper.Get<List<Medicamento>>("/inventario/medicamentos");
            return medicamentos;

        }

        public static List<Pedido> GetPedidos(string userEmail)
        {
            var pedidos = ApiHelper.Get<List<Pedido>>("/inventario/pedidos/" + userEmail);
            return pedidos;

        }

        public static PedidoResponse crearPedido(Pedido pedido)
        {
            var respuesta = ApiHelper.Post<PedidoResponse>("/inventario/pedidos", pedido);
            return respuesta;

        }
    }
}
