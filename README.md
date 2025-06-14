
# Автобусный парк

## Общее описание

Программа представляет собой систему учета автобусов в парке и на маршрутах. Реализована на C# с использованием Windows Forms. Основные функции:
- Учет автобусов в парке и на маршрутах
- Визуальное отображение информации
- Сортировка данных по разным критериям

## Архитектура программы

Программа использует:
- **MVC-подход** (неявно через Windows Forms)
- Два словаря для хранения данных:
  - `parkBuses` - автобусы в парке
  - `routeBuses` - автобусы на маршруте
- DataGridView для отображения данных

## Детали реализации

### Основные компоненты:
Ключевые классы и методы
1. Инициализация
csharp

public Form1()
{
    InitializeComponent();
    InitializeCustomComponents(); // Настройка интерфейса
}

2. Обработка данных из файла
csharp

private bool ProcessFileLines(string[] lines)
{
    // Анализирует каждую строку файла
    // Формат: "номер_автобуса Фамилия И.О. номер_маршрута"
    // Возвращает true, если все строки обработаны успешно
}

3. Управление автобусами
csharp

// Перемещение автобуса из парка на маршрут
private void exitBusToolStripMenuItem_Click(object sender, EventArgs e)
{
    ShowInputDialog("Выезд автобуса");
}

// Возврат автобуса с маршрута в парк
private void enterBusToolStripMenuItem_Click(object sender, EventArgs e)
{
    ShowInputDialog("Въезд автобуса");
}

4. Отображение данных
csharp

// Сортировка по номеру автобуса
private void ShowBusesByNumber()
{
    dataGridView1.Rows.Clear();
    foreach (var bus in parkBuses.OrderBy(b => b.Key))
        dataGridView1.Rows.Add(bus.Key, bus.Value.FullDriverName, bus.Value.Route);
}

// Сортировка по номеру маршрута
private void UpdateDisplayByRoute()
{
    dataGridView1.Rows.Clear();
    foreach (var bus in parkBuses.OrderBy(b => b.Value.Route).ThenBy(b => b.Key))
        dataGridView1.Rows.Add(bus.Key, bus.Value.FullDriverName, bus.Value.Route);
}

Примеры использования
1. Добавление автобусов
csharp

// Через интерфейс:
// 1. Меню "Добавить автобусы"
// 2. Ввод данных вручную или загрузка из файла

// Программно:
parkBuses["A123"] = new BusData {
    LastName = "Иванов",
    Initials = "И.И.",
    Route = 12
};

2. Перемещение автобуса
csharp

// Выезд из парка:
if (parkBuses.ContainsKey("A123")) 
{
    routeBuses["A123"] = parkBuses["A123"];
    parkBuses.Remove("A123");
}
