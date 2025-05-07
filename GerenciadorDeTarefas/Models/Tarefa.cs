using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDeTarefas.models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public DateTime DataDeCriacao { get; set; }

        public DateTime? Prazo { get; set; }

        public string Categoria { get; set; }

        public bool Concluida { get; set; }

        //Criando relacionamento entre Tarefas e ususários

        public int UsuarioId { get; set; }

        public Usuario Usuario { get; set; }
    }
}