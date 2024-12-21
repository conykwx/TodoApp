using System.Windows;
using TodoApp.Components;
using TodoApp.Data;

namespace TodoApp;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    // Функція, що спрацьовує при натисканні кнопки додавання нової задачі
    public void OnAddClick(object sender, RoutedEventArgs e)
    {
        // 1. Витягуємо текст нової задачі з текстбокса
        string title = TitleTextBox.Text;

        // 2. Через TodoList отримати новострорену задачу
        Todo newTodo = TodoList.Add(title);

        // 3. На основі створеної тудушки створити TodoComponent
        TodoComponent component = new TodoComponent(newTodo);

        // 4. Додати TodoComponent в панель щоб вона відобразилася
        TodoListPanel.Children.Add(component);
    }

    private void OnClearClick(object sender, RoutedEventArgs e)
    {
        // очищуємо задачі у моделі
        TodoList.Clear();

        // очищуємо графічні елементи у вікні
        TodoListPanel.Children.Clear();
    }

}