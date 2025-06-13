using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AVTOBUS
{
    public partial class Form1 : Form
    {
        private Dictionary<string, BusData> parkBuses = new Dictionary<string, BusData>();
        private Dictionary<string, BusData> routeBuses = new Dictionary<string, BusData>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Инициализация формы при загрузке (если нужно)
        }

        private class BusData
        {
            public string Driver { get; set; }
            public int Route { get; set; }
        }

        private void AddInitialBuses()
        {
            string input = txtInput.Text.Trim();
            if (!string.IsNullOrEmpty(input))
            {
                string[] parts = input.Split(' ');
                if (parts.Length == 3)
                {
                    string busNumber = parts[0];
                    string driver = parts[1];
                    if (int.TryParse(parts[2], out int route))
                    {
                        parkBuses[busNumber] = new BusData { Driver = driver, Route = route };
                        UpdateDisplay();
                    }
                    else
                    {
                        MessageBox.Show("Неверный формат маршрута. Введите число.");
                    }
                }
                else
                {
                    MessageBox.Show("Введите номер, водителя и маршрут через пробел (например, 'A1 Иванов 5').");
                }
            }
            txtInput.Text = "";
        }

        private void ExitBus()
        {
            string busNumber = txtInput.Text.Trim();
            if (!string.IsNullOrEmpty(busNumber) && parkBuses.ContainsKey(busNumber))
            {
                routeBuses[busNumber] = parkBuses[busNumber];
                parkBuses.Remove(busNumber);
                UpdateDisplay();
            }
            else
            {
                MessageBox.Show("Автобус с таким номером не найден в парке.");
            }
            txtInput.Text = "";
        }

        private void EnterBus()
        {
            string busNumber = txtInput.Text.Trim();
            if (!string.IsNullOrEmpty(busNumber) && routeBuses.ContainsKey(busNumber))
            {
                parkBuses[busNumber] = routeBuses[busNumber];
                routeBuses.Remove(busNumber);
                UpdateDisplay();
            }
            else
            {
                MessageBox.Show("Автобус с таким номером не найден на маршруте.");
            }
            txtInput.Text = "";
        }

        private void ShowBusesByNumber()
        {
            dataGridView1.Rows.Clear();
            foreach (var bus in parkBuses.OrderBy(b => b.Key))
                dataGridView1.Rows.Add(bus.Key, bus.Value.Driver, bus.Value.Route);
            foreach (var bus in routeBuses.OrderBy(b => b.Key))
                dataGridView1.Rows.Add(bus.Key, bus.Value.Driver, bus.Value.Route);
        }

        private void ShowBusesByRoute()
        {
            dataGridView1.Rows.Clear();
            foreach (var bus in parkBuses.OrderBy(b => b.Value.Route))
                dataGridView1.Rows.Add(bus.Key, bus.Value.Driver, bus.Value.Route);
            foreach (var bus in routeBuses.OrderBy(b => b.Value.Route))
                dataGridView1.Rows.Add(bus.Key, bus.Value.Driver, bus.Value.Route);
        }

        private void UpdateDisplay()
        {
            ShowBusesByNumber(); // По умолчанию сортировка по номерам
        }

        private void addBusesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddInitialBuses();
        }

        private void exitBusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitBus();
        }

        private void enterBusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnterBus();
        }

        private void showByBusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowBusesByNumber();
        }

        private void showByRouteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowBusesByRoute();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Пустой обработчик, так как клик по ячейкам не используется
            // Можно удалить привязку в Form1.Designer.cs, если не требуется
        }
    }
}