using System;
using System.Collections.Generic;

// It should be in another place and be called to work here
// using Desafio_de_Código_Coding_The_Future_Avanade_1.models;

public class ItemMagico
    {
        public string Nome;
        public string Descricao;
        public int Poder;
        public ItemMagico(string nome, string descricao, int poder)
        {
            Nome = nome;
            Descricao = descricao;
            Poder = poder;
        }
    }

class Program
{
    static void Main(string[] args)
    {
        // Recebe a entrada do usuário

        string nome = Console.ReadLine();


        string descricao = Console.ReadLine();


        int poder = int.Parse(Console.ReadLine());

        // Cria o item mágico
        ItemMagico item = new ItemMagico(nome, descricao, poder);

        // Imprime o item criado
        Console.WriteLine($"Item: {item.Nome}\nDescrição: {item.Descricao}\nPoder: {item.Poder}");
    }
}