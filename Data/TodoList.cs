namespace TodoApp.Data;

public static class TodoList
{
    // Список усіх задач
    private static List<Todo> todos = [];


    // Створити нову задачу, вказуючи її текст
    public static Todo Add(string title)
    {
        // нова задача
        var newTodo = new Todo
        {
            Title = title,
            IsCompleted = false,
            Id = Guid.NewGuid()
        };

        // додаємо нову задачу в список усіх задач
        todos.Add(newTodo);

        // повертаємо нову сформовану задачу
        return newTodo;
    }

    public static void Clear()
    {
        todos.Clear();
    }


    // Видалити задачу з вказаним id
    public static void Delete(Guid id)
    {
        // видалити всі задачі у котрих співпадає id
        todos.RemoveAll(t => t.Id == id);
    }


    // Встановити задачі статус ВИКОНАНО
    public static void Complete(Guid id)
    {
        // Шукаємо задачу зі вказаним id
        Todo todo = todos.First(t => t.Id == id);
        // Ставимо флаг виконання
        todo.IsCompleted = true;
    }
}

