using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio_2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn_suma(object sender, EventArgs e)
        {
            var Dato1 = double.Parse(dato1.Text);
            var Dato2 = double.Parse(dato2.Text);
            var Resul = Dato1 + Dato2;


           

        }
    }
}
