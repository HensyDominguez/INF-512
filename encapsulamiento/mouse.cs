using System;

class Mouse {
    private string marca;
    private string modelo;
    private string tipo;
    private string color;
    private bool ergonómico;
    private float precio;

//Contructor Hensy Milver Dominguez Diaz 100553845.
    public Mouse(string marca, string modelo, string tipo, string color, bool ergonómico, float precio) {
        if (marca != "Dell" && marca != "Genius" && marca != "Logitec") {
            this.marca = "Generic Device";
        } else {
            this.marca = marca;
        }
        this.modelo = modelo;
        this.tipo = tipo;
        if (tipo == "Ergonómico") {
            this.ergonómico = true;
        } else {
            this.ergonómico = false;
        }
        setColor(color);
        setPrecio(precio);
    }
// Proceso Hensy Milver Dominguez Diaz 100553845.
    public bool seleccionar(string bloqueoTexto) {
        Console.WriteLine("Se ha seleccionado el botón " + bloqueoTexto);
        return true;
    }

    public bool clickderecho() {
        Console.WriteLine("Se ha hecho clic derecho");
        return true;
    }

    public bool clickiIzquierdo() {
        Console.WriteLine("Se ha hecho clic izquierdo");
        return true;
    }

    public string arrastrar(string bloqueTexto) {
        Console.WriteLine("Se ha arrastrado el objeto a " + bloqueTexto);
        return bloqueTexto;
    }

    public float getPrecio() {
        return precio;
    }

    public void setPrecio(float precio) {
        if (precio < 0) {
            this.precio = 0;
        } else {
            this.precio = precio;
        }
    }

    public string getColor() {
        return color;
    }

    public void setColor(string color) {
        if (color == "rojo" || color == "verde" || color == "azul") {
            this.color = color;
        } else {
            this.color = "no disponible";
        }
    }

    public void desplegarInformacion() {
        Console.WriteLine("Marca: " + marca);
        Console.WriteLine("Modelo: " + modelo);
        Console.WriteLine("Tipo: " + tipo);
        Console.WriteLine("Color: " + color);
        Console.WriteLine("Ergonómico: " + ergonómico);
        Console.WriteLine("Precio: " + precio);
    }
}
// Informacion Hensy Milver Dominguez 100553845.
class mouse {
    static void Main(string[] args) {
        Mouse mouse1 = new Mouse("Dell", "X5", "Normal", "rojo", false, 900.00f);
        Mouse mouse2 = new Mouse("Genius", "GX-10", "Ergonómico", "verde", true, 500.00f);
        Mouse mouse3 = new Mouse("Logitec", "M210", "Normal", "azul", false, 600.00f);
        Mouse mouse4 = new Mouse("HP", "H260", "Ergonómico", "negro", true, 800.00f);

        mouse1.desplegarInformacion();
        mouse2.desplegarInformacion();
        mouse3.desplegarInformacion();
        mouse4.desplegarInformacion();
    }
}