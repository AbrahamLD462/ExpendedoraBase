using System;
using System.Threading;

namespace ExpendedoraBase
{
    internal class Expendedora
    {
        string Marca;
        byte Temperatura;
        string Codigo; //Atributo
        float Precio;

        public Expendedora()
        {
            Saludar();
            Marca = "AMS";
            Temperatura = 14;
            Console.WriteLine("Marca: " + Marca);
            ControlarTiempoDisplay();
            Console.WriteLine("La temperatura es: " + Temperatura+"°C.");
            ControlarTiempoDisplay();
            Codigo = MostrarCodigoDeProductos();
            ControlarTiempoDisplay();
            MostrarPecio(Codigo);
        }
        void ControlarTiempoDisplay()
        {
            Thread.Sleep(1500);
            Console.Clear();
        }
        void Saludar()
        {
            Console.WriteLine("Bienvenido");
        }
        string MostrarCodigoDeProductos()//Metodos
        {
            Console.WriteLine("MENU");
            Console.WriteLine("A1: Kinder Delice \tB2: Takis \tC3: Gomitas");
            Console.WriteLine("Ingrese el codigo del producto: ");
            string Codigo = Console.ReadLine(); //codigo es una "Variable de tipo local"
            return Codigo;
        }
        void MostrarPecio(string Codigo)
        {
            switch (Codigo)
            {
                case "A1":
                    Console.WriteLine("Su precio es de: {0}", Precio);
                    break;
                case "B2":
                    Console.WriteLine("Su precio es de: {0}", Precio);
                    break;
                case "C3":
                    Console.WriteLine("Su precio es de: {0}", Precio);
                    break;
                default: 
                    Console.WriteLine("Producto no reconocido");
                    break;
            }
        }
    }
}
