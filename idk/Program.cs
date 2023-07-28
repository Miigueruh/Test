using System;
class idk
{
    static void Main(string[] args)
    {
        Aluno aluno1 = new Aluno();
        aluno1.Nome = "Miguelius";
        aluno1.Cpf = "123456789";
        aluno1.DataNascimento = DateOnly.Parse("28/02/2020");
        aluno1.Matricula = 1;

        Aluno aluno2 = new Aluno();
        aluno2.Nome = "Silicones";
        aluno2.Cpf = "987654321";
        aluno2.DataNascimento = DateOnly.Parse("14/07/2019");
        aluno2.Matricula = 2;

        List<Aluno> lista = new List<Aluno>();
        lista.Add(aluno1);
        lista.Add(aluno2);

        foreach(Aluno aluno in lista)
        {
            aluno.Nome = "Alcino";
            Console.WriteLine(aluno.Nome+" "+aluno.Cpf);
        }
        Console.WriteLine(aluno1.Nome);
        Console.WriteLine(aluno2.Nome);

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
        /*
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
        */
    }
}