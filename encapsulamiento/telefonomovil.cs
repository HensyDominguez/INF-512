using System;

namespace EncapsulacionTelefonoMovil
{
    class TelefonoMovil
    {
        // Hensy Milver Domimguez Diaz 100553845.
        // Atributos de clase privados
        private string marca;
        private string color;
        private string modelo;
        private int cantidadCamaras;
        private float size;
        private string estado;

        //Hensy Milver Dominguez Diaz 100553845.

        // Métodos de acceso público (getters y setters)
        public string GetMarca()
        {
            return marca;
        }

        public void SetMarca(string marca)
        {
            this.marca = marca;
        }

        public string GetColor()
        {
            return color;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

        public string GetModelo()
        {
            return modelo;
        }

        public void SetModelo(string modelo)
        {
            this.modelo = modelo;
        }

        public int GetCantidadCamaras()
        {
            return cantidadCamaras;
        }

        public void SetCantidadCamaras(int cantidadCamaras)
        {
            if (cantidadCamaras > 8)
            {
                Console.WriteLine("Error: la cantidad de cámaras no puede ser mayor a 8.");
            }
            else
            {
                this.cantidadCamaras = cantidadCamaras;
            }
        }

        public float GetSize()
        {
            return size;
        }

        public void SetSize(float size)
        {
            if (size > 7)
            {
                Console.WriteLine("Error: el tamaño no puede ser mayor a 7 pulgadas.");
            }
            else
            {
                this.size = size;
            }
        }

        public string GetEstado()
        {
            return estado;
        }

        public void SetEstado(string estado)
        {
            if (estado != "encendido" && estado != "suspendido" && estado != "apagado")
            {
                Console.WriteLine("Error: estado no válido.");
            }
            else
            {
                this.estado = estado;
            }
        }

        // Métodos de la clase
        public bool Marcar()
        {
            return true;
        }

        public bool Llamar(string numeroTelefonoDestino)
        {
            return true;
        }

        public void Vibrar()
        {
            // Implementación del método
        }

        public bool Encender()
        {
            return true;
        }

        public bool Apagar()
        {
            return true;
        }
    }

    class TelefonoMovilTest
    {
        static void Main(string[] args)
        {
            TelefonoMovil miCelular = new TelefonoMovil();
            miCelular.SetMarca("Samsung");
            miCelular.SetColor("Negro");
            miCelular.SetModelo("A50");
            miCelular.SetCantidadCamaras(4);
            miCelular.SetSize(6);
            miCelular.SetEstado("encendido");

            Console.WriteLine("\n*** Salida ***\n");
            Console.WriteLine("Marca: " + miCelular.GetMarca());
            Console.WriteLine("Color: " + miCelular.GetColor());
            Console.WriteLine("Modelo: " + miCelular.GetModelo());
            Console.WriteLine("Cantidad Camaras: " + miCelular.GetCantidadCamaras());
            Console.WriteLine("Tamaño: " + miCelular.GetSize());
            Console.WriteLine("Estado: " + miCelular.GetEstado());
        }
    }
}
