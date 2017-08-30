using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            sum.Clicked += delegate
            {
                int val1 = int.Parse(value1.Text);
                int val2 = int.Parse(value2.Text);

                int resultado = Matematica.Soma(val1, val2);

                result.Text = "O resultado é " + resultado;

            };

            multiple.Clicked += delegate
            {
                int val1 = int.Parse(value1.Text);
                int val2 = int.Parse(value2.Text);

                int resultado = Matematica.Multiplicar(val1, val2);

                result.Text = "O resultado da multiplicação é " + resultado;
            };

            sub.Clicked += delegate
            {
                int val1 = int.Parse(value1.Text);
                int val2 = int.Parse(value2.Text);

                int resultado = Matematica.Subtracao(val1, val2);

                result.Text = "O resultado da subtração é " + resultado;
            };

            div.Clicked += delegate
            {
                int val1 = int.Parse(value1.Text);
                int val2 = int.Parse(value2.Text);

                float resultado = Matematica.Divisao(val1, val2);

                result.Text = "O resultado da divisão é " + resultado;
            };

        }

        private class Matematica
        {
            public static int Soma(int a, int b)
            {
                return a + b;
            }

            public static int Multiplicar(int a, int b)
            {
                return a * b;
            }

            public static int Subtracao(int a, int b)
            {
                return a - b;
            }

            public static float Divisao(float a, float b)
            {
                return a / b;
            }
        }
    }
}
