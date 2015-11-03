using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Colores
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        string[] colorN = {"Negro", "Rojo","","Azul","Violeta","Amarillo","Naranja","","Verde","Blanco" };
        Color[] colors = { Color.FromArgb(0xff,0,0,0) //Negro
                ,Color.FromArgb(0xff,0xff,0,0) //Rojo
                ,Color.FromArgb(0xff,0,0,0x00) //Vacio
                ,Color.FromArgb(0xff,0,0,0xff) //Azul
                ,Color.FromArgb(0xff,0xff,0,0xff) //Violeta
                ,Color.FromArgb(0xff,0xff,0xff,0)//Amarillo
                ,Color.FromArgb(0xff,0xff,0x66,0)//Naranja
                ,Color.FromArgb(0xff,0xff,0,0)//Vacio
                ,Color.FromArgb(0xff,0,0xff,0)//Verde
                ,Color.FromArgb(0xff,0xff,0xff,0xff)//Blanco
        };

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void setColor(object sender, RoutedEventArgs e)
        {


            int r = ((bool)red.IsChecked) ? 1 : 0;
            int b = ((bool)blue.IsChecked) ? 3 : 0;
            int y = ((bool)yellow.IsChecked) ? 5 : 0;

            int c = r + b + y;

            txt.Text = colorN[c];
            bg.Fill = new SolidColorBrush(colors[c]);

        }
    }
}
