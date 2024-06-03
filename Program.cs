using System;
using System.Collections.Generic;


public class Robo
{
    private string Nome;
    private string Modelo;
    private int AnoFabricacao;

    public Robo(string nome, string modelo, int anoFabricacao)
    {
        this.Nome = nome;
        this.Modelo = modelo;
        this.AnoFabricacao = anoFabricacao;
    }

    public void ExibirInformacoes()
    {
        //TODO: Imprimir as informações de acordo com o enunciado deste desafio.
        Console.WriteLine($"O robô {Nome}, modelo {Modelo}, foi fabricado em {AnoFabricacao}.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        string nome, modelo;
        int ano;


        nome = Console.ReadLine();

        modelo = Console.ReadLine();

        ano = int.Parse(Console.ReadLine());

        //TODO: Instanciar um Robo passando os valores lidos em seu construtor.
        Robo robo = new Robo(nome, modelo, ano);
  
        //TODO: Invocar o método "exibirInformacoes".
        robo.ExibirInformacoes();
    }
}