using System;

namespace Arrays
{
    class Program
    {
      
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
         static void Array04()
         {
             // 4-Leia dois arrays A e B com 10 elementos. Em seguida, compare os arrays e verifique se
            // os mesmos são iguais ou diferentes.
            var arraya = new double?[10];
            var arrayb = new double[10];
            var resultado = false;
            System.Console.WriteLine("primeira lista");
            for (int i = 0; i < arraya.Length; i++)
            {
                System.Console.WriteLine($"digite o {i + 1}º numero");
                while (true)
                {
                    try
                    {
                        arraya[i] = double.Parse(Console.ReadLine());
                        break;
                    }
                    catch (System.Exception)
                    {
                        System.Console.WriteLine($"numero invalido,por favor tente novamente");
                        
                    }
                    
                }
            }
            System.Console.WriteLine("segunda lista");
            for (int i = 0; i < arrayb.Length; i++)
            {
                System.Console.WriteLine($"Digite o {i + 1}º numero");
                while (true)
                {
                     
                    try
                    {
                        arrayb[i] = double.Parse(Console.ReadLine());
                        break;
                    }
                    catch (System.Exception)
                    {
                        System.Console.WriteLine($"numero invalido,por favor tente novamente");
                        
                    }
                }   
            for (int k = 0; k < arraya.Length; k++)
            {
                resultado = false;
                if(arraya[k] == arrayb[i])
                {
                  resultado = true;
                  arraya[k] = null;
                  break;
                }
            }    
            }
             var mensagem = (resultado) ? "Os numeros são iguais" : "Os numeros são diferentes";
             System.Console.WriteLine(mensagem);
        }  
      static void Array05()  
       {
        //  Leia um array A com 15 elementos, e calcule a média aritmética dos mesmos, 
        //  em seguida, diga quantos dos elementos lidos estão abaixo, acima e na média.
            var array = new double[3];
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
            var maior = 0;
            var igual = 0;
            var menor = 0;
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
        static void Array06()
        {
            //Leia um array A com 12 elementos. Após sua leitura, colocar os seus elementos em
            //ordem crescente. Depois ler um array B também com doze elementos, colocar os elementos 
            //de B em ordem decrescente. Construir um array C, onde cada elemento de C é a soma do 
            //elemento correspondente de A com b. Colocar em ordem crescente a matriz
            //C e apresentar os seus valores.
            const int arraytam = 12;
              double[] a = new double[arraytam];
              double[] b = new double[arraytam];
              double[] c = new double[arraytam]; 
             for (int i = 0; i < arraytam; i++)
             {
                 double numero = double.MinValue;
                 System.Console.WriteLine($"Informe o {i + 1}º numero da lista.");
                while (true)
                {
                    try
                    {
                        numero = double.Parse(Console.ReadLine());
                        break;
                    }
                    catch (System.Exception)
                    {
                        System.Console.WriteLine("Número inválido, digite outro valor: ");
                    }
                }

                 if (numero > a[11])
                 {
                     a[0] = a[1];
                     a[1] = a[2];
                     a[2] = a[3];
                     a[3] = a[4];
                     a[4] = a[5];
                     a[5] = a[6];
                     a[6] = a[7];
                     a[7] = a[8];
                     a[8] = a[9];
                     a[9] = a[10];
                     a[10] = a[11];
                     a[11] = numero;
                 }
                 else if(numero > a[10])
                 {
                     a[0] = a[1];
                     a[1] = a[2];
                     a[2] = a[3];
                     a[3] = a[4];
                     a[4] = a[5];
                     a[5] = a[6];
                     a[6] = a[7];
                     a[7] = a[8];
                     a[8] = a[9];
                     a[9] = a[10];
                     a[10] = numero;
                 }
                 else if(numero > a[9])
                 {
                     a[0] = a[1];
                     a[1] = a[2];
                     a[2] = a[3];
                     a[3] = a[4];
                     a[4] = a[5];
                     a[5] = a[6];
                     a[6] = a[7];
                     a[7] = a[8];
                     a[8] = a[9];
                     a[9] = numero;
                 }
                 else if(numero >a[8])
                 {
                     a[0] = a[1];
                     a[1] = a[2];
                     a[2] = a[3];
                     a[3] = a[4];
                     a[4] = a[5];
                     a[5] = a[6];
                     a[6] = a[7];
                     a[7] = a[8];
                     a[8] = numero;
                 }
                 else if(numero >a[7])
                 {
                     a[0] = a[1];
                     a[1] = a[2];
                     a[2] = a[3];
                     a[3] = a[4];
                     a[4] = a[5];
                     a[5] = a[6];
                     a[6] = a[7];
                     a[7] = numero;
                 }
                 else if(numero > a[6])
                 {
                     a[0] = a[1];
                     a[1] = a[2];
                     a[2] = a[3];
                     a[3] = a[4];
                     a[4] = a[5];
                     a[5] = a[6];
                     a[6] = numero;
                 }
                 else if(numero > a[5])
                 {
                     a[0] = a[1];
                     a[1] = a[2];
                     a[2] = a[3];
                     a[3] = a[4];
                     a[4] = a[5];
                     a[5] = numero;
                 }
                 else if(numero >a[4])
                 {
                     a[0] = a[1];
                     a[1] = a[2];
                     a[2] = a[3];
                     a[3] = a[4];
                     a[4] = numero;
                 }
                 else if(numero >a[3])
                 {
                     a[0] = a[1];
                     a[1] = a[2];
                     a[2] = a[3];
                     a[3] = numero;
                 }
                 else if(numero > a[2])
                 {
                     a[0] = a[1];
                     a[1] = a[2];
                     a[2] = numero;
                 }
                 else if(numero > a[1])
                 {
                     a[0] = a[1];
                     a[1] = numero;
                 }
                 else if(numero > a[0])
                 {
                     a[0] = numero;
                 }
             }
                 System.Console.WriteLine("Primeiro array");
                 for (int i = 0; i < arraytam; i++)
                 {
                     System.Console.WriteLine(a[i]);
                 }
                 System.Console.WriteLine("Segundo Array");
                 for (int i = 0; i < 12; i++)
                 {   
                     double numero = double.MinValue;
                     System.Console.WriteLine($"Digite o {i +1}º numero da segunda lista.");
                     while (true)
                {
                    try
                    {
                        numero = double.Parse(Console.ReadLine());
                        break;
                    }
                    catch (System.Exception)
                    {
                        System.Console.WriteLine("Número inválido, digite outro valor: ");
                    }
                }

                     if (numero < b[11])
                     {
                        b[0] = b[1];
                        b[1] = b[2];
                        b[2] = b[3];
                        b[3] = b[4];
                        b[4] = b[5];
                        b[5] = b[6];
                        b[6] = b[7];
                        b[7] = b[8];
                        b[8] = b[9];
                        b[9] = b[10];
                        b[10] = b[11];
                        b[11] = numero;
                     }
                     else if (numero < b[10])
                     {
                         b[0] = b[1];
                         b[1] = b[2];
                         b[2] = b[3];
                         b[3] = b[4];
                         b[4] = b[5];
                         b[5] = b[6];
                         b[6] = b[7];
                         b[7] = b[8];
                         b[8] = b[9];
                         b[9] = b[10];
                         b[10] = numero;
                     }
                     else if (numero < b[9])
                     {
                         b[0] = b[1];
                         b[1] = b[2];
                         b[2] = b[3];
                         b[3] = b[4];
                         b[4] = b[5];
                         b[5] = b[6];
                         b[6] = b[7];
                         b[7] = b[8];
                         b[8] = b[9];
                         b[9] = numero;
                     }
                     else if (numero < b[8])
                     {
                         b[0] = b[1];
                         b[1] = b[2];
                         b[2] = b[3];
                         b[3] = b[4];
                         b[4] = b[5];
                         b[5] = b[6];
                         b[6] = b[7];
                         b[7] = b[8];
                         b[8] = numero;
                     }
                     else if ( numero < b[7])
                     {
                         b[0] = b[1];
                         b[1] = b[2];
                         b[2] = b[3];
                         b[3] = b[4];
                         b[4] = b[5];
                         b[5] = b[6];
                         b[6] = b[7];
                         b[7] = numero;
                     }
                     else if ( numero < b[6])
                     {
                         b[0] = b[1];
                         b[1] = b[2];
                         b[2] = b[3];
                         b[3] = b[4];
                         b[4] = b[5];
                         b[5] = b[6];
                         b[6] = numero;
                     }
                     else if ( numero < b[5])
                     {
                         b[0] = b[1];
                         b[1] = b[2];
                         b[2] = b[3];
                         b[3] = b[4];
                         b[4] = b[5];
                         b[5] = numero;
                     }
                     else if ( numero < b[4])
                     {
                         b[0] = b[1];
                         b[1] = b[2];
                         b[2] = b[3];
                         b[3] = b[4];
                         b[4] = numero;
                     }
                     else if ( numero < b[3])
                     {
                         b[0] = b[1];
                         b[1] = b[2];
                         b[2] = b[3];
                         b[3] = numero;
                     }
                     else if ( numero < b[2])
                     {
                         b[0] = b[1];
                         b[1] = b[2];
                         b[2] = numero;
                     }
                     else if ( numero < b[1])
                     {
                         b[0] = b[1];
                         b[1] = numero;
                     }
                     else if ( numero < b[0])
                     {
                         b[0] = numero;
                     }
                 }
                     System.Console.WriteLine("Segundo Array");
                     for (int i = 0; i < arraytam; i++)
                     {
                         System.Console.WriteLine(b[i]);
                     }
                     for (int i = 0; i < arraytam; i++)
                     {
                         double numero = a[i] + b[i];

                         if ( numero > c[11])
                         {
                            c[0] = c[1];
                            c[1] = c[2];
                            c[2] = c[3];
                            c[3] = c[4];
                            c[4] = c[5];
                            c[5] = c[6];
                            c[6] = c[7];
                            c[7] = c[8];
                            c[8] = c[9];
                            c[9] = c[10];
                            c[10] = c[11];
                            c[11] = numero;
                         }
                         else if(numero > c[10])
                         {
                             c[0] = c[1];
                             c[1] = c[2];
                             c[2] = c[3];
                             c[3] = c[4];
                             c[4] = c[5];
                             c[5] = c[6];
                             c[6] = c[7];
                             c[7] = c[8];
                             c[8] = c[9];
                             c[9] = c[10];
                             c[10] = numero;
                         }
                         else if ( numero > c[9])
                         {
                            c[0] = c[1];
                            c[1] = c[2];
                            c[2] = c[3];
                            c[3] = c[4];
                            c[4] = c[5];
                            c[5] = c[6];
                            c[6] = c[7];
                            c[7] = c[8];
                            c[8] = c[9];
                            c[9] = numero;
                         }
                         else if( numero > c[8])
                         {
                             c[0] = c[1];
                             c[1] = c[2];
                             c[2] = c[3];
                             c[3] = c[4];
                             c[4] = c[5];
                             c[5] = c[6];
                             c[6] = c[7];
                             c[7] = c[8];
                             c[8] = numero;
                         }
                         else if ( numero > c[7])
                         {
                             c[0] = c[1];
                             c[1] = c[2];
                             c[2] = c[3];
                             c[3] = c[4];
                             c[4] = c[5];
                             c[5] = c[6];
                             c[6] = c[7];
                             c[7] = numero;
                         }
                         else if ( numero > c[6])
                         {
                             c[0] = c[1];
                             c[1] = c[2];
                             c[2] = c[3];
                             c[3] = c[4];
                             c[4] = c[5];
                             c[5] = c[6];
                             c[6] = numero;
                         }
                         else if ( numero > c[5])
                         {
                             c[0] = c[1];
                             c[1] = c[2];
                             c[2] = c[3];
                             c[3] = c[4];
                             c[4] = c[5];
                             c[5] = numero;
                         }
                         else if ( numero > c[4])
                         {
                             c[0] = c[1];
                             c[1] = c[2];
                             c[2] = c[3];
                             c[3] = c[4];
                             c[4] = numero;
                         }
                         else if ( numero > c[3])
                         {
                             c[0] = c[1];
                             c[1] = c[2];
                             c[2] = c[3];
                             c[3] = numero;
                         }
                         else if ( numero > c[2])
                         {
                             c[0] = c[1];
                             c[1] = c[2];
                             c[2] = numero;
                         }
                         else if ( numero > c[1])
                         {
                             c[0] = c[1];
                             c[1] = numero;
                         }
                         else if ( numero >c[0])
                         {
                             c[0] = numero;
                         }
                     }
                         System.Console.WriteLine("Lista de numeros do Array C");
                         for (int i = 0; i < arraytam; i++)
                         {
                             System.Console.WriteLine(c[i]);
                         }
                        
                         
                         
        }
    }
}
