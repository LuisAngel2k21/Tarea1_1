using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace app1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnsegunda_Clicked(object sender, EventArgs e)
        {
            var dato1 = double.Parse(nombre.Text);
            var dato2 = double.Parse(Telefono.Text);
            var suma = dato1 + dato2;

            var Estudiantes = new models.operaciones
            {
                resultado = suma,
               
            };

            var pagina = new views.Page2();
            pagina.BindingContext = Estudiantes;
            await Navigation.PushAsync(pagina);
        }


        private async void btnsegunda_Clicked2(object sender, EventArgs e)
        {
            var dato1 = double.Parse(nombre.Text);
            var dato2 = double.Parse(Telefono.Text);
            var resta = dato1 - dato2;

            var Estudiantes = new models.operaciones
            {
                resultado = resta,

            };
            var pagina = new views.Page2();
            pagina.BindingContext = Estudiantes;
            await Navigation.PushAsync(pagina);
        }


        private async void btnsegunda_Clicked3(object sender, EventArgs e)
        {
            var dato1 = double.Parse(nombre.Text);
            var dato2 = double.Parse(Telefono.Text);
            var multiplicacion = dato1 * dato2;

            var Estudiantes = new models.operaciones
            {
                resultado = multiplicacion,

            };

            var pagina = new views.Page2();
            pagina.BindingContext = Estudiantes;
            await Navigation.PushAsync(pagina);
        }

        private async void btnsegunda_Clicked4(object sender, EventArgs e)
        {
            var dato1 = double.Parse(nombre.Text);
            var dato2 = double.Parse(Telefono.Text);
            var division = dato1 / dato2;

            var Estudiantes = new models.operaciones
            {
                resultado = division,

            };

            var pagina = new views.Page2();
            pagina.BindingContext = Estudiantes;
            await Navigation.PushAsync(pagina);
        }
    }
}
