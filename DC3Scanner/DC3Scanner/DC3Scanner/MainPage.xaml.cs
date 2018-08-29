using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DC3Scanner
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            btnlogin.Clicked += btnlogin_Clicked;

        }
        String userRefer = "cristian";
        String passRefer = "ryzen";
        private void btnlogin_Clicked(object sender, EventArgs e)
        {

            String user =usuariotxt.Text;
            String password = passwordtxt.Text;


            if (String.IsNullOrEmpty(user) || String.IsNullOrEmpty(password))
            {

                DisplayAlert("Log In fallido", "campo vacio", "Aceptar");
                return;
            }

            if (user.Equals(userRefer) & password.Equals(passRefer))
            {
                this.Navigation.PushModalAsync(new Inicio());

            }
            else
            {

                DisplayAlert("Log In fallido", "Usuario o password incorrecto", "Aceptar");
            }


        }
    }
}
