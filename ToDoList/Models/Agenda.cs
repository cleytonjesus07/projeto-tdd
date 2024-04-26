using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class Agenda
    {
     public List<Tarefa> agenda = [];


    public List<Tarefa> MostrarTarefas(){
        return agenda;
    }

    public string AdicionarTarefa(Tarefa tarefa){
        
        if(tarefa == null){
            throw new Exception("A tarefa está vazia");
        }
        agenda.Add(tarefa);
        return "Tarefa adicionada com sucesso";
    }
    public string AtualizarTarefa(Tarefa tarefaAtualizada,int id){
        int posicaoTarefa = agenda.FindIndex(tarefa=>tarefa.id == id);
        
        if(posicaoTarefa == -1){
            throw new Exception("Não foi encontrada nenhuma tarefa para que a atualização seja feita");
        }

        agenda[posicaoTarefa].title = tarefaAtualizada.title;
        agenda[posicaoTarefa].descricao = tarefaAtualizada.descricao;
        return "Tarefa atualizada com sucesso!";
    }

    public string ExcluirTarefa(int id){
       
       int indice = agenda.FindIndex(tarefa=>tarefa.id == id);
       agenda.RemoveAt(indice);

       return "Exclusão concluída com sucesso!";
    }
    }
}