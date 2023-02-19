using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVIDAD_SEMANA_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.cliente();

            
            
            


        }
    }
}
public abstract class Saludo
{
    public abstract void saludo();
}



public class Cliente : Saludo
    
{
    Bebidas bebid = new Bebidas();

    public string NombreCliente;
    public int Edad;
    public override void saludo()
    {
        Console.WriteLine("Hola, " + NombreCliente + " Bienvenido a mi tienda!. ");
    }

    public void cliente()
    {
        Console.WriteLine("Escriba su nombre: ");
        NombreCliente = Console.ReadLine();
        if (NombreCliente != null )
        {
            saludo();
        }
        Console.WriteLine("Digite  su edad: ");
        Edad=Convert.ToInt32(Console.ReadLine());
        if (Edad <= 17)
        {
            Console.WriteLine("Solo se te mostrara bebidas sin alcohol. ");
            Console.WriteLine("MENU.");
            bebid.Menu2();
        }
        else
        {
            Console.WriteLine("Menu: ");
            bebid.Menu();
        }
    }

    
}

public class Bebidas: Saludo
{
    int numero;
    string beb1 = "Delvalle";
    string beb2 = "Chaparro";
    string beb3 = "Coca-Cola";
    string beb4 = "Agua";
    string beb5 = "Bodka";
    string Vende = "Niky Lauda";
    string Cate1 = "Bebida Refrescante";
    string Cate2 = "Bebidas Alcoholicas";
    public void Menu()
    {
        Console.WriteLine("Escoja el numero que corresponde a la bebida deceada. "+ "\n");
        Console.WriteLine("1- Delvalle."+ "\n");
        Console.WriteLine("2- Chaparro."+ "\n");
        Console.WriteLine("3- Coca-Cola." + "\n");
        Console.WriteLine("4- Agua." + "\n");
        Console.WriteLine("5- Bodka." + "\n");
        int numero =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\n");
        if (numero == 1)
        {
            Console.WriteLine("Tu orden es: " + beb1 + "\n"+ "Esta bebida pertenece a la categoria: " + Cate1 + "\n" + "Preparacion: Después de que se recolecta la fruta,"  +"\n" + 
                " se extrae el jugo y se concentra, llega a nuestras plantas de producción para reconstituirlo" + "\n"  + 
                " donde le añadimos agua para llegar al nivel deseado de dulzor del jugo de fruta y así tener siempre un delicioso sabor.//");
              
        }
 
        if (numero == 2)
        {
            Console.WriteLine("Tu orden es: " + beb2 + "\n" + "Esta bebida pertenece a la categoria: " + Cate2 + "\n" + "Preparacion: La elaboración del chaparro es una forma de destilación, se prepara como hacer la famosa chicha pero en este caso no es fermentación, " + "\n" +
                "aquí se pone a hervir en un cántaro de de barro el arroz, maíz y dulce de panela, a fuego lento");
        }
        if (numero == 3)
        {
            Console.WriteLine("Tu orden es: " + beb3 + "\n" + "Esta bebida pertenece a la categoria: " + Cate1 + "\n" + "Elavoracion: En su fórmula original incluía vainilla, azúcar, zumo de limón y extracto de nuez de cola.");
        }
        if (numero == 4)
        {
            Console.WriteLine("Tu orden es: " + beb4 + "\n" + "Esta bebida pertenece a la categoria: " + Cate1 + "\n" + "Elavoracion: El proceso de purificación de agua consiste en un tratamiento físico y químico " + "\n" +
                " que tiene como objeto eliminar contaminantes que podrían representar un riesgo. ");
        }
        if (numero == 5)
        {
            Console.WriteLine("Tu orden es: " + beb5 + "\n" + "Esta bebida pertenece a la categoria: " + Cate2 + "\n" + "Elavoracion: Para elaborar el vodka primero se muelen los granos convirtiéndolos en harina, se añade agua" + "\n" +
                " y se hace la mezcla bajo presión. En este paso el almidón contenido en los granos se transforma en un gel y luego en azúcar, que bajo el efecto de" + "\n" +
                " la levadura se transforma en alcohol al fermentarse.");
        }
        Bartender();
        saludo();
    }

    public void Menu2()
    {

        Console.WriteLine("Escoja el numero que corresponde a la bebida deceada. " + "\n");
        Console.WriteLine("1- Delvalle." + "\n");        
        Console.WriteLine("3- Coca-Cola." + "\n");
        Console.WriteLine("4- Agua." + "\n");
        numero =Convert.ToInt32(Console.ReadLine());
        
        
        if (numero == 1)
        {
            Console.WriteLine("Tu orden es: " + beb1 + "\n" + "Esta bebida pertenece a la categoria: " + Cate1 + "\n" + "Preparacion: Después de que se recolecta la fruta," + "\n" +
                " se extrae el jugo y se concentra, llega a nuestras plantas de producción para reconstituirlo" + "\n" +
                " donde le añadimos agua para llegar al nivel deseado de dulzor del jugo de fruta y así tener siempre un delicioso sabor.//");
        }
        if (numero == 3)
        {
            Console.WriteLine("Tu orden es: " + beb3 + "\n" + "Esta bebida pertenece a la categoria: " + Cate1 + "\n" + "Elavoracion: En su fórmula original incluía vainilla, azúcar, zumo de limón y extracto de nuez de cola.");
        }
        if (numero == 4)
        {
            Console.WriteLine("Tu orden es: " + beb4 + "\n" + "Esta bebida pertenece a la categoria: " + Cate1 + "\n" + "Elavoracion: El proceso de purificación de agua consiste en un tratamiento físico y químico " + "\n" +
                " que tiene como objeto eliminar contaminantes que podrían representar un riesgo. ");
        }
        Bartender();
        saludo();
        
    }
    public void Bartender()
    {
        Console.WriteLine("Ha sido atendido por: " + Vende);
    }

    public override void saludo()
    {
        Console.WriteLine("Gracias por visitarnos! regresa pronto!! ");
        Console.ReadKey();
    }
    
}

