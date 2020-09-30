using System;

namespace Arrays
{ 
    class Program2
    {
        static void Main(string[] args)
        {
            ArrayLista2_03();
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
         (int mulheres,int sim ,int não) mulheres = (0,0,0);
         (int homens,int sim,int não) homens = (0,0,0);
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
         System.Console.WriteLine($"{(mulheres.sim / mulheres.mulheres) * 100} %  das mulheres disseram que gostam do produto ");
         System.Console.WriteLine($"{(homens.não / homens.homens) * 100} % dos homens disseram que não gostam do produto");
        }
           
           
       


    }
}
    