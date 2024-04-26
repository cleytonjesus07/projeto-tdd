using ToDoList.Models;

namespace ToDoListTests;

public class Tests
{

    private Agenda _agenda = new();

    [SetUp]
    public void Setup()
    {
        DeveInserirUmaTarefaNaAgendaERetornarMensagem();
      
    }

    [Test]
    public void DeveListarAsTarefasERetornarMensagem()
    {
        var lista = _agenda.MostrarTarefas();
        Assert.That(_agenda.agenda,Is.EqualTo(lista));
    }
    [Test]
    public void DeveInserirUmaTarefaNaAgendaERetornarMensagem()
    {
        Tarefa tarefa = new(){
            id = 1,
            title = "Tarefa 1",
            descricao = "Tarefinha do rafinha"
        };

        var res = _agenda.AdicionarTarefa(tarefa);
        Assert.That(res,Is.EqualTo("Tarefa adicionada com sucesso"));
    }
    [Test]
    public void DeveAtualizarTarefaExistenteERrtornarMensagem()
    {
        Tarefa tarefa = new(){
            title = "Tarefada",
            descricao = "Tarefada da fada"
        };

        var res = _agenda.AtualizarTarefa(tarefa,1);
        Assert.That(res,Is.EqualTo("Tarefa atualizada com sucesso!"));
    }
    [Test]
    public void DeveExcluirTarefaExistenteERrtornarMensagem()
    {
    
        var res = _agenda.ExcluirTarefa(1);
        Assert.That(res,Is.EqualTo("Exclusão concluída com sucesso!"));
    }


}