using System;

namespace Arrays
{ 
    class Program2
    {
        static void Main(string[] args)
        {
            ArrayLista2_02();
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

        }
           
           
       


    }
}
    