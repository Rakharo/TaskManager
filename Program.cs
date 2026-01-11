using TaskManager.Services;

var taskService = new TaskService();

//Para criar tarefas
taskService.CreateTask("Aprender POO", "Estudo de conceito de programação orientada a objetos");
taskService.CreateTask("Funções", "Qual a finalidade de Models, Services e Controllers");

//Para listar todas as tarefas
var tasks = taskService.GetAllTasks();
foreach (var task in tasks)
{
    Console.WriteLine($"ID: {task.Id}, Título: {task.Title}, Descrição: {task.Description}, Status: {(task.Status ? "Concluído" : "Pendente")}");
}


//Atualizar uma tarefa
var updateTask = taskService.UpdateTask(1, "Aprender POO", "Estudo aprofundado de programação orientada a objetos", true);
Console.WriteLine(updateTask ? "Tarefa atualizada com sucesso." : "Tarefa não encontrada.");

//Deletar uma tarefa
var deleteTask = taskService.DeleteTask(2);
Console.WriteLine(deleteTask ? "Tarefa deletada com sucesso." : "Tarefa não encontrada.");

//Listar todas as tarefas após atualização e deleção
tasks = taskService.GetAllTasks();
foreach (var task in tasks)
{
    Console.WriteLine($"ID: {task.Id}, Título: {task.Title}, Descrição: {task.Description}, Status: {(task.Status ? "Concluído" : "Pendente")}");
}