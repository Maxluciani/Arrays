using System;

namespace Arrays
{ 
    class Program2
    {
        static void Main(string[] args)
        {
            ArrayLista2_01();
        }
       static void ArrayLista2_01()
       {
           // Popule dois vetores com 10 valores cada. Após esta operação, troque o conteúdo dos
          // vetores.
          const int  tamanhoarray = 3;
          double[] a = new double[tamanhoarray];
          double [] b = new double[tamanhoarray];
          double[] invert = new double[tamanhoarray];
          for (int i = 0; i < tamanhoarray; i++)
          {
              System.Console.WriteLine($"Digite o {i+1}° numero da lista");
              a[i] = double.Parse(Console.ReadLine());
              invert[i] = a[i];
          }
              for (int i = 0; i < tamanhoarray; i++)
              {
                 System.Console.WriteLine($"Digite o {i+1}º numero da segunda lista"); 
                 b[i] = double.Parse(Console.ReadLine());
              a[i] = b[i];
              }

              for (int i = 0; i < tamanhoarray; i++)
              {
                  b[i] = invert[i];
              }
               System.Console.WriteLine(String.Join(",",a));
               System.Console.WriteLine(String.Join(",",b));
       }


    }
}
    