﻿public class Aluno
{
    public int Matricula { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public DateOnly DataNascimento { get; set; }

    public Aluno()
    {
    
    }

        
    public Aluno(string nome, string cpf, DateOnly dataNascimento, int matricula)
    {
        this.Matricula = matricula;
        this.Nome = nome;
        this.Cpf = cpf;
        this.DataNascimento = dataNascimento;
    }


}
