using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int saldoDisponivel;

        int saldoTotal = int.Parse(Console.ReadLine());
        

        int valorSaque = int.Parse(Console.ReadLine());
        
        saldoDisponivel = saldoTotal;
        if (saldoDisponivel >= valorSaque)
        {
            saldoDisponivel = saldoDisponivel - valorSaque;
            Console.WriteLine($"Saque realizado com sucesso. Novo saldo: {saldoDisponivel}");
        } 
        else
        {
            Console.WriteLine("Saldo insuficiente. Saque nao realizado!");
        }

    }
}