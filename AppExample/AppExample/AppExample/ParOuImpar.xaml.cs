using AppExample.Util;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ParOuImpar : ContentPage
    {
        private string Login = "admin";
        private string Senha = "123";

        public ParOuImpar()
        {
            InitializeComponent();
            bt_login.Clicked += Bt_calcular_Clicked;
        }

        private void Bt_calcular_Clicked(object sender, EventArgs e)
        {
            string user = et_user.Text;
            string password = et_password.Text;

            string user_error = Validators.ValidarCampoVazio(user + "");
            string password_error = Validators.ValidarCampoVazio(password + "");

            lb_user_error.Text = user_error;
            lb_password_error.Text = password_error;

            lb_user_error.IsVisible = !user_error.Equals("");
            lb_password_error.IsVisible = !password_error.Equals("");

            if (!user_error.Equals("") || !password_error.Equals(""))
            {
                if (user == "admin" && password == "123")
                {
                    lb_msg.Text = "Logado";
                }
                else
                {
                    lb_msg.Text = "Usuário ou senha inválidos";
                }
            }
        }
    }
}