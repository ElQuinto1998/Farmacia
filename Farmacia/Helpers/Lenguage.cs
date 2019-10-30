using Farmacia.Interfaces;
using Farmacia.Resources;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Farmacia.Helpers
{
    public static class Language
    {
        static Language()
        {
            var ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
            AppResources.Culture = ci;
            DependencyService.Get<ILocalize>().SetLocale(ci);
        }
        public static string Aceptar
        {
            get { return AppResources.Aceptar; }
        }
        public static string BienvenidoARappiFarma
        {
            get { return AppResources.BienvenidoARappiFarma; }
        }
        public static string Cantidad
        {
            get { return AppResources.Cantidad; }
        }
         public static string Continuar
        {
            get { return AppResources.Continuar; }
        }
         public static string Contraseña
        {
            get { return AppResources.Contraseña; }
        }
         public static string CrearPedido
        {
            get { return AppResources.CrearPedido; }
        }
         public static string Estado
        {
            get { return AppResources.Estado; }
        }
         public static string Fecha
        {
            get { return AppResources.Fecha; }
        }
         public static string Genial
        {
            get { return AppResources.Genial; }
        }
         public static string IniciarSesion
        {
            get { return AppResources.IniciarSesion; }
        }
         public static string Inicio
        {
            get { return AppResources.Inicio; }
        }
         public static string Medicamento
        {
            get { return AppResources.Medicamento; }
        }
         public static string Nombre
        {
            get { return AppResources.Nombre; }
        }
         public static string OlvidasteLaContraseñaRecuperar
        {
            get { return AppResources.OlvidasteLaContraseñaRecuperar; }
        }
         public static string Precio
        {
            get { return AppResources.Precio; }
        }
         public static string RealizarPedido
        {
            get { return AppResources.RealizarPedido; }
        }
         public static string Salir
        {
            get { return AppResources.Salir; }
        }
         public static string Total
        {
            get { return AppResources.Total; }
        }
         public static string Usuario
        {
            get { return AppResources.Usuario; }
        }
        public static string MedicamentoAgregado
        {
            get { return AppResources.MedicamentoAgregado; }
        }
        public static string MisPedidos
        {
            get { return AppResources.MisPedidos; }
        }
        
    }
}
