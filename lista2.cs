using System;

namespace Arrays
{ 
    class Program2
    {
        static void Main(string[] args)
        {
            ArrayLista2_09();
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
       static void ArrayLista2_02()
       {
            // 2)Dado um vetor qualquer com 10 números, faça um programa que informa se há ou não
            // números repetidos nesse vetor.
            var a = new double?[10];
             var repetido = false;
            for (int i = 0; i < 10; i++)
            {
                a[i] = null;
                System.Console.WriteLine($"Digite o {i+1}° numero da lista de arrays.");
                a[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
              for (int j = i; j < 10; j++)
              {
                if (i != j && a[i] == a[j])
                {
                    repetido = true;
                }  
              }
              if (repetido)
              {
                  break;
              }
                   
            }
            var mensagem = (repetido) ? "Existe um numero repetido no array":"Não ha numero repetido";
            Console.WriteLine(mensagem);
        }
        static void ArrayLista2_03()
        {
         //Um certa empresa fez uma pesquisa para saber se as pessoas gostaram ou não de um novo
         // produto lançado no mercado. Para isso, forneceu-se o sexo do entrevistado e a sua resposta
         // (sim ou não). Sabendo-se que foram entrevistadas 10 pessoas, fazer um algoritmo que calcule e
         // escreva:
         // • O número de pessoas que responderam sim;
         // • O número de pessoas que responderam não;
         // • A percentagem de pessoas do sexo feminino que responderam sim;
         // • A percentagem de pessoas do sexo masculino que responderam não;
         const int entrevistados = 5;
         (int mulheres,double sim ,double não) mulheres = (0,0,0);
         (int homens,double sim,double não) homens = (0,0,0);
         for (int i = 0; i < entrevistados; i++)
         {
             var sexo = 0;
             var gostou = 0;
             System.Console.WriteLine("Qual seu genero:Digite 1 para homem ou 2 para mulher");
             sexo = Int32.Parse(Console.ReadLine());
             System.Console.WriteLine("Você gosta do nosso produto? Digite 1 para sim ou 2 para não");
             gostou = Int32.Parse(Console.ReadLine());
         if (  sexo == 1)
         {
           homens.homens ++;
           if (gostou ==1)
           {
               homens.sim++;
           }
           else 
           {
               homens.não ++;
           }

         }
          else
          {
              mulheres.mulheres ++;
              if ( gostou == 1)
              {
                  mulheres.sim ++;
              }
              else{
                  mulheres.não ++;
              }
          }
         }
         System.Console.WriteLine($"{ mulheres.sim + homens.sim} pessoas disseram que gostam do produto ");
         System.Console.WriteLine($" {mulheres.não + homens.não} pessoas disseram que não gostam do produto" );
         System.Console.WriteLine();
         System.Console.WriteLine($"{(mulheres.sim / mulheres.mulheres) * 100} %  das mulheres disseram que gostam do produto ");
         System.Console.WriteLine($"{(mulheres.não / mulheres.mulheres) * 100}% das mulheres disseram que não gostam do produto.");
         System.Console.WriteLine();
         System.Console.WriteLine($"{(homens.sim / homens.homens) * 100}% dos homens disseram que gostam do produto");
         System.Console.WriteLine($"{(homens.não / homens.homens) * 100} % dos homens disseram que não gostam do produto");
        }
        static void ArrayLista2_04()
        {
            //Desenvolver um programa que efetue a leitura de cinco elementos de uma matriz 
            // A do tipo vetor. No final, apresente o total da soma de todos os elementos 
            // que sejam impares.
            var a  = new int [5];
            var sum = 0.0;
            for (int i = 0; i < 5; i++)
            {
                System.Console.WriteLine($"Digite o {i +1}º numero");
                a[i] = Int32.Parse(Console.ReadLine());
                if (a[i] % 2 == 1)
                {
                  sum += a[i];
                }
            }
             System.Console.WriteLine($"A soma de todos os elementos impares é de {sum}");

        }
        static void ArrayLista2_05()
        {
            //Contar quantos valores de um vetor de 10 posições são positivos.
            var a =new double[10];
            var positive = 0;
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine($"Digite o {i+1}º numero");
                a[i] = double.Parse(Console.ReadLine());
                if (a[i] > 0)
                {
                    positive ++;
                }
            }
            System.Console.WriteLine($"{positive} numeros dessa lista são positivos.");
        }
        static void ArrayLista2_06()
        {
            //Ler um vetor de 10 posições (aceitar somente números positivos). 
            //Escrever a seguir o valor do maior elemento de Q e a respectiva posição que ele ocupa no vetor.
            var a = new double[10];
            var positive = 0.0;
            (double value,int position,int flag) greatnumber = (0.0,0,0);
            for (int i = 0; i < 10; i++)
            {
            System.Console.WriteLine($"Digite o {i+1}º numero da lista");
            
            while (true)
            {
               try
               {
                 positive = double.Parse(Console.ReadLine());
                 if ( positive < 0)
                 {
                     System.Console.WriteLine("Numeros negativos não são aceitos,insira um numero positivo");
                     continue;
                 }
                 else
                 {
                     a[i] = positive;
                     break;
                 }
               }
               catch (System.Exception)
               {
                   System.Console.WriteLine("Comando invalido,insira apenas numeros");
               } 
            }
                  
            }
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[i] >a[j])
                    {
                        greatnumber.value = a[i];
                        greatnumber.position = i;
                        greatnumber.flag ++;
                    }
                }
                if (greatnumber.flag == a.Length -1)
                {
                    break;
                }
                greatnumber.flag = 0;
            }
            Console.WriteLine($"O maior numero da lista é {greatnumber.value} e esta na posição {greatnumber.position}.");
        }
        static void ArrayLista2_07()
        {
            //Crie e popule um vetor A e imprima na tela o número de vezes que existe 
           //um número residindo na mesma posição do vetor que seu valor numérico.
           var match = 0;
           var vontade = 0;
           System.Console.WriteLine("Quantos numeros você quer adicionar ao vetor?");
           vontade = Int32.Parse(Console.ReadLine());
           var a = new double[vontade];
           for (int i = 0; i < a.Length; i++)
           {
               System.Console.WriteLine($"Digite o {i+1}º numero da lista");
               a[i] = double.Parse(Console.ReadLine());
               if ( a[i] == i)
               {
                   match ++;
               }
           }
               System.Console.WriteLine($" há {match} vezes em que o numero esta na mesma posição do vetor.");
        }  
        static void ArrayLista2_08()
        {
            //Crie um vetor de strings de 10 posições onde cada posição
            //recebe uma letra do alfabeto. No final, imprima quantas destas são vogais.
            string[] a = new string[10];
            var count = 0;
            for (int i = 0; i < a.Length; i++)
            {
              System.Console.WriteLine($"Digite a {i+1}ª letra da matriz.");
              a[i] = Console.ReadLine().ToLower();
              if (a[i] == "a" || a[i] == "e" || a[i] == "i" || a[i] == "o" || a[i] == "u") 
              {
                  count ++;
              } 
            }
            System.Console.WriteLine($"{count} letras da matriz são vogais.");
        } 
         static void ArrayLista2_09() 
         {
             //Crie um vetor de strings de 10 posições onde cada posição recebe uma letra do alfabeto. 
             //No final, imprima a string resultante da soma das strings que residem em índices pares.
             string[] a = new string[10];
             var palavra = "";
             for (int i = 0; i < a.Length; i++)
             {
                 System.Console.WriteLine($"Digite a {i+1}ª letra.");
                 a[i] = Console.ReadLine();
                 if ( i %2 == 0)
                 {
                     palavra += a[i];
                 }
             }
                 System.Console.WriteLine($"A palavra formada é {palavra}.");
         } 
       


    }
}
    