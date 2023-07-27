using System;
class idk
{
    static void Main(string[] args)
    {
        /*
        int[] n1 = new int[5];
        //int[] n2 = new int[5] {0, 3, 6, 7, 6 };


        Console.Write("Informe o 1º número: ");
        n1[0] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Informe o 2º número: ");
        //n2[1] = Convert.ToInt32(Console.ReadLine());
        n1[1] = Convert.ToInt32(Console.ReadLine());
        n1[2] = (n1[0] + n1[1]) / 2;
        Console.WriteLine(n1[2]);
        */

        List<string> lista = new List<string>();
        lista.Add("Nome");
        lista.Add("Menguel");

        //lista.Sort();
        lista.Insert(0, "Nombre");
        lista.Remove("Nome");
        //lista.RemoveAt(0); //Remove uma unidade em uma posição
        //lista.Clear(); //Limpa a lista
        //lista.Reverse(); //Reverte a lista

        //Console.WriteLine(lista.Count); //Conta o tamanho da lista
        //Console.WriteLine(lista.Contains("Menguel")); //Verifica se possui ou não um dado específico, retornando True ou False

        //Console.WriteLine(lista.IndexOf("Menguel"));

        foreach (string s in lista)
        {
            Console.WriteLine(s);
        }

    }
}