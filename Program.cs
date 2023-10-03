using System;

class Esempio
{
    //Attributi
    public string string1;
    public double numero;

    //Costruttore
    public Esempio(string string1, double numero)
    {
        this.string1 = string1;
        this.numero=numero;
    }

    //Metodo
    public string Unisci()
    { 
        return string1 + numero;
    }

    //Distruttore
    ~Esempio()
    {
        Console.WriteLine("Oggetto Esempio distrutto!");
    }

}

class Program
{
    static void Main()
    {
        Console.WriteLine("Inserisci la stringa: ");
        string a = Console.ReadLine();

        Console.WriteLine("Inserisci numero: ");
        double numero = Convert.ToDouble(Console.ReadLine());

        Esempio esempio1 = new Esempio(a,numero);

        string b = esempio1.Unisci();
        Console.WriteLine("Esempio = " + b);
    }
}