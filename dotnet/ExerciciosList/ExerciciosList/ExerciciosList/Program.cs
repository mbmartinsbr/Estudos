using System;
using System.Collections.Generic;

namespace ExerciciosList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            // Add insere um item ao final da List
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            //Insert você escolhe aonde quer inserir na List
            list.Insert(2, "Marco");


            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine("Mosta a quantidade de itens na List: " + list.Count);

            // expressão Lambda ou usando a função Test
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("Primeiro 'A' encontrado pela função Find: " + s1);

            // expressão Lambda ou usando a função Test
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Ultimo 'A' encontrado pela função FindLast: " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Indica a posição do primeiro item com a letra 'A' : " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Indica a posição do ultimo item com a letra 'A' : " + pos2);

            Console.WriteLine("----------------------------------------------------");

            // A nova lista sera criada somente com itens que tenham 5 caracteres 
            List<string> list2 = list.FindAll( x => x.Length ==5 );
            foreach (string obj2 in list2)
            {
                Console.WriteLine(obj2);
            }
            Console.WriteLine("----------------------------------------------------");

            //Remove da lista o Alex
            list.Remove("Alex");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("----------------------------------------------------");
            //Remove da lista Todos que atendam ao retorno da expressão lambda (que iniciem com a letra M)
            list.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //Remove da lista a informação que está na posição 3
            list.RemoveAt(3);//Bob lista inicial

            //Remove da lista contando de uma posição inicial , quantidade de itens a serem removidos
            list.RemoveRange(2,2);

        }
        static bool Test(string s)
        {
            // retorna true quando a primeira posição da String é Igual 'A'
            return s[0] == 'A';
        }
    }
}
