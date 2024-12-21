namespace TodoApp.Data;

public class Todo
{
    // Ідентифікатор задачі
    public Guid Id { get; set; }

    // Текст задачи
    public string Title { get; set; }

    // Виконана чи ні
    public bool IsCompleted { get; set; }
}