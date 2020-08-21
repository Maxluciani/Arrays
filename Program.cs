using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
      {
           Array05();
      }
      static void Array01()
        {
         //  Leia dois arrays A e B com 15 elementos. Construir um array C, onde cada 
         //  elemento de C é a subtração do elemento correspondente de A com B   

            const int arraystam = 3;

            var a = new double[arraystam];
            var b = new double[arraystam];
            var c = new double[arraystam];
            System.Console.WriteLine($"digite os {arraystam} primeiros valores");
            for (int i = 0; i < arraystam; i++)
            {
              System.Console.WriteLine("digite um numero");
              while (true)
              {
                  try
                  {
                      a [i] = double.Parse(Console.ReadLine());
                      break;
                  }
                  catch (System.Exception)
                  {
                      System.Console.WriteLine("Numero invalido,tente novamente.");
                      
                  }
              }  
            }
            System.Console.WriteLine($"digite os {arraystam} proximos numeros.");
            for (int i = 0; i < arraystam; i++)
            {
                System.Console.WriteLine("digite um numero");
                var resultado = Double.Parse(Console.ReadLine());
                b[i] = resultado;
                c[i] = a[i] - resultado;
            }
            System.Console.WriteLine("os resultados são.");
            foreach (var item in c)
            {
                System.Console.WriteLine(item);
            }
        }
      static void Array02()
       {
             // Ler um array com 10 inteiros e mostrar os números na ordem direta e 
             //inversa a que foram lidos.
             const int array01 = 10;
             var a = new int[array01];
             for (int i = 0; i < array01 ; i++)
             {
             System.Console.WriteLine("Digite um numero.");
             a[i] = Int32.Parse(Console.ReadLine()); 
             }
             System.Console.WriteLine("Numeros digitados");
             foreach (var item in a)
             {
             System.Console.WriteLine(item);   
             }
             System.Console.WriteLine("Numeros em ordem inversa de digitação.");
             for (int i = 9; i > -1; i--)
             {
             System.Console.WriteLine(a[i]);   
             }
        }
      static void Array03()
       {
         //Leia 10 elementos e armazene em um array A. Em seguida, solicite pelo 
         //teclado um número qualquer e pesquise no array se o número existe. Caso, 
         //seja verdade imprima a mensagem: “O número existe no array” , caso 
         //contrário “Número inexistente”.
         var array = new double[3];
         for (int i = 0; i < array.Length ; i++)
         {
         System.Console.WriteLine("Digite um numero para adicionar na lista.");
         array[i] = Double.Parse(Console.ReadLine());
         }
         System.Console.WriteLine("Digite um numero para procurar na lista.");
         var numero = Double.Parse(Console.ReadLine());
         var encontrado = false;
         foreach (var item in array)
         {
         if ( item == numero)
         {
            encontrado = true;
            break;
         }   
         }
         if (encontrado)
         {
         System.Console.WriteLine("O numero existe no array.");
         }
         else
         {
         System.Console.WriteLine("O numero não existe no array");
         }
        }
      static void Array05()  
       {
        //  Leia um array A com 15 elementos, e calcule a média aritmética dos mesmos, 
        //  em seguida, diga quantos dos elementos lidos estão abaixo, acima e na média.
            var array = new double[15];
            var soma = 0.0;
            for (int i = 0; i < array.Length; i++)
            {
            System.Console.WriteLine("Digite um numero");
            var numero =Double.Parse(Console.ReadLine());
            array [i] = numero;
            soma += numero;
            } 
            var media = soma/array.Length;
            System.Console.WriteLine($"A média dos numeros é de {media}");
            System.Console.WriteLine();
            var maior = 0.0;
            var igual = 0.0;
            var menor = 0.0;
            foreach (var item in array)
            {
             if (item > media)
             {
                 maior ++;
             } 
             else if (item == media)
             {
                 igual ++;
             }
             else
             {
                 menor ++;
             }
            }
            System.Console.WriteLine($"{maior} numeros estão acima da média.");
            System.Console.WriteLine($"{igual} numeros estão na média.");
            System.Console.WriteLine($"{menor} numeros estão abaixo da media.");
        }  
    }
}
