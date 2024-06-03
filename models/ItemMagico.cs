using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_de_Código_Coding_The_Future_Avanade_1.models
{
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
}