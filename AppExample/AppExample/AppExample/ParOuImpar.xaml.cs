using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ParOuImpar : ContentPage
    {
        public ParOuImpar()
        {
            InitializeComponent();
            bt_calcular.Clicked += Bt_calcular_Clicked;
        }

        private void Bt_calcular_Clicked(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(et_valor.Text);
            string resultado;
            if(valor % 2 == 0)
            {
                resultado = $"{valor} é par";
            }
            else
            {
                resultado = $"{valor} é ímpar";
            }

            lb_resultado.Text = resultado;
        }
    }
}