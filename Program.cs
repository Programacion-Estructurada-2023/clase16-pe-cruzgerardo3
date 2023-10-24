using System;


namespace MyApp
{  

    
internal class program
{
  static void Main (string[] args )
  {
   int opciones; 
  do
  {
    Console.WriteLine("\n\nMenu:");
    Console.WriteLine("1. Programa que muestre los numeros de n al 1 de manera decendente");
    Console.WriteLine("2.Programa que muestre los numeros del 1 al 5 con while");
    Console.WriteLine("3.Programa que muestre los numeros minimo de una lista ");
    Console.WriteLine("4.Salir");
    Console.Write("Selecione una opcion (1-4):");
    
      if (int.TryParse(Console.ReadLine(), out opciones))
      {

        switch ( opciones)
        {
             case 1:
                numerosDecendentes();
                break;

            case 2:
                numerosWhile();
                break;

            case 3:
                minimoListar();
                break;

            case 4:
           
                break;

                default:
                Console.WriteLine("Opciones no valida. por favor, selecione una opcion valida (1-4)");
                break;
        }
        
     }
     else {
        Console.WriteLine("\nEntrada no valida, debe ingresar un numero (1-4)");
        }
  }while (opciones !=4);

  }

 static void numerosDecendentes()
      {
        Console.Write("\nIngrese un numero (n):");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n >= 1)
           {
            for (int i=n; i >= 1; i--)
               {
                Console.WriteLine($"Numero > a {i}");
               }
           }
           else
           {
            Console.WriteLine("Ingresar un numero mayor a 1");
           }
      }

      static void numerosWhile()
      {
        int contador = 1;
        while( contador <=5)
        {
            Console.WriteLine($"Numero >>{contador}");
            contador++;
        }
      }

      static void minimoListar(){
        List<int> numeros = new List<int> {24,15,45,35,14,10};
        int minimo = numeros[0];
        foreach (int  numero1 in numeros)
        {
            if (numero1 < minimo)
            {
                minimo = numero1;
            }
        }

        Console.WriteLine("El numero mas pequeno en la lista es >"+ minimo);
      }
   }


}
