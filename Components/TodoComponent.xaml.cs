using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using TodoApp.Data;

namespace TodoApp.Components;

public partial class TodoComponent : UserControl
{
    // Дані про задачу всередині компонента
    private Todo todo;

    public TodoComponent(Todo todo)
    {
        InitializeComponent();
        this.todo = todo;
    }

    // Функція що реагує на кнопку виконання задачі
    public void OnCompleteClick(object sender, RoutedEventArgs e)
    {
        // Масиву з задачами кажемо, що задача виконана
        TodoList.Complete(todo.Id);
        // Фарбуємо текст задачі в зелений колір
        TitleLabel.Foreground = Brushes.Green;
        // Вимикаємо кнопку
        CompleteButton.IsEnabled = false;
    }

    // Функція, що реагує на кнопку видалення задачі
    public void OnDeleteClick(object sender, RoutedEventArgs e)
    {
        // 0. TodoList delete
        TodoList.Delete(todo.Id);

        // 1. Отримати доступ до StackPanel, в котрій знаходиться компонент
        StackPanel parent = Parent as StackPanel;

        // 2. Сказати панелі щоб вона видалила цей туду компонент
        parent.Children.Remove(this);
    }

    // Функція що спрацьовує коли прогрузился лейбл і готов до роботи
    private void TitleLabel_Loaded(object sender, RoutedEventArgs e)
    {
        TitleLabel.Content = todo.Title;
    }
}
