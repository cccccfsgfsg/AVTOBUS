using System;
using System.Collections.Generic;
using System.IO;
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
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            UpdateStatusBar();
        }

        private class BusData
        {
            public string LastName { get; set; }
            public string Initials { get; set; }
            public int Route { get; set; }

            public string FullDriverName => $"{LastName} {Initials}";
        }

        // Добавляем новый метод для обработки загрузки файла
        private bool ProcessFileLines(string[] lines)
        {
            try
            {
                foreach (var line in lines)
                {
                    var parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length >= 3)
                    {
                        string busNumber = parts[0].Trim();
                        string driver = parts[1].Trim();
                        if (int.TryParse(parts[2].Trim(), out int route))
                        {
                            string[] nameParts = driver.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            string lastName = nameParts.Length > 0 ? nameParts[0] : "";
                            string initials = "";
                            if (nameParts.Length > 1)
                            {
                                initials = $"{nameParts[1][0]}.";
                                if (nameParts.Length > 2)
                                {
                                    initials += $"{nameParts[2][0]}.";
                                }
                            }
                            parkBuses[busNumber] = new BusData
                            {
                                LastName = lastName,
                                Initials = initials,
                                Route = route
                            };
                        }
                        else
                        {
                            MessageBox.Show($"Ошибка в строке: {line}. Неверный номер маршрута.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Ошибка в строке: {line}. Недостаточно данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обработке файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Остальные методы остаются без изменений
        private void addBusesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowInputDialog("Добавить автобусы");
        }

        private void exitBusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowInputDialog("Выезд автобуса");
        }

        private void enterBusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowInputDialog("Въезд автобуса");
        }

        private void showByBusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void showByRouteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDisplayByRoute();
        }

        private void loadFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFromFile();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Обработка кликов по ячейкам DataGridView
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Инициализация при загрузке формы
        }

        private void ShowInputDialog(string operation)
        {
            Form inputForm = new Form
            {
                Text = operation,
                Size = new System.Drawing.Size(400, 250),
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterParent,
                MinimizeBox = false,
                MaximizeBox = false
            };

            Label lblBusNumber = new Label { Text = "Номер автобуса:", Location = new System.Drawing.Point(20, 20) };
            TextBox txtBusNumber = new TextBox { Location = new System.Drawing.Point(180, 20), Width = 180 };

            Label lblDriver = new Label { Text = "Водитель (Фамилия И.О.):", Location = new System.Drawing.Point(20, 50) };
            TextBox txtDriver = new TextBox { Location = new System.Drawing.Point(180, 50), Width = 180 };

            Label lblRoute = new Label { Text = "Номер маршрута:", Location = new System.Drawing.Point(20, 80) };
            TextBox txtRoute = new TextBox { Location = new System.Drawing.Point(180, 80), Width = 180 };
            txtRoute.Enabled = operation == "Добавить автобусы";

            Button btnOk = new Button { Text = "OK", Location = new System.Drawing.Point(180, 190) };
            Button btnCancel = new Button { Text = "Отмена", Location = new System.Drawing.Point(280, 190) };

            Button btnLoadFromFile = null;
            if (operation == "Добавить автобусы")
            {
                btnLoadFromFile = new Button
                {
                    Text = "Загрузить из файла",
                    Location = new System.Drawing.Point(20, 120),
                    Size = new System.Drawing.Size(340, 30)
                };
                btnLoadFromFile.Click += (s, e) =>
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog
                    {
                        Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*",
                        Title = "Выберите файл с данными"
                    };

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            var lines = File.ReadAllLines(openFileDialog.FileName);
                            if (ProcessFileLines(lines))
                            {
                                UpdateDisplay();
                                UpdateStatusBar();
                                MessageBox.Show($"Загружено {lines.Length} записей из файла.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ошибка при загрузке файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                };
            }

            btnOk.Click += (s, e) =>
            {
                string[] nameParts = txtDriver.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string lastName = nameParts.Length > 0 ? nameParts[0] : "";
                string initials = "";
                if (nameParts.Length > 1)
                {
                    initials = $"{nameParts[1][0]}.";
                    if (nameParts.Length > 2)
                    {
                        initials += $"{nameParts[2][0]}.";
                    }
                }

                if (operation == "Добавить автобусы")
                {
                    if (int.TryParse(txtRoute.Text, out int route))
                    {
                        parkBuses[txtBusNumber.Text] = new BusData
                        {
                            LastName = lastName,
                            Initials = initials,
                            Route = route
                        };
                    }
                    else
                    {
                        parkBuses[txtBusNumber.Text] = new BusData
                        {
                            LastName = lastName,
                            Initials = initials,
                            Route = 0
                        };
                    }
                }
                else if (operation == "Выезд автобуса")
                {
                    if (parkBuses.ContainsKey(txtBusNumber.Text))
                    {
                        routeBuses[txtBusNumber.Text] = parkBuses[txtBusNumber.Text];
                        parkBuses.Remove(txtBusNumber.Text);
                    }
                }
                else if (operation == "Въезд автобуса")
                {
                    if (routeBuses.ContainsKey(txtBusNumber.Text))
                    {
                        parkBuses[txtBusNumber.Text] = routeBuses[txtBusNumber.Text];
                        routeBuses.Remove(txtBusNumber.Text);
                    }
                }

                UpdateDisplay();
                UpdateStatusBar();
                inputForm.Close();
            };

            btnCancel.Click += (s, e) => inputForm.Close();

            inputForm.Controls.AddRange(new Control[] { lblBusNumber, txtBusNumber, lblDriver, txtDriver, lblRoute, txtRoute, btnOk, btnCancel });
            if (btnLoadFromFile != null) inputForm.Controls.Add(btnLoadFromFile);
            inputForm.Show(this);
        }

        private void LoadFromFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*",
                Title = "Выберите файл с данными"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var lines = File.ReadAllLines(openFileDialog.FileName);
                    if (ProcessFileLines(lines))
                    {
                        UpdateDisplay();
                        UpdateStatusBar();
                        MessageBox.Show($"Загружено {lines.Length} записей из файла.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ShowBusesByNumber()
        {
            dataGridView1.Rows.Clear();
            foreach (var bus in parkBuses.OrderBy(b => b.Key))
                dataGridView1.Rows.Add(bus.Key, bus.Value.FullDriverName, bus.Value.Route);

            dataGridView2.Rows.Clear();
            foreach (var bus in routeBuses.OrderBy(b => b.Key))
                dataGridView2.Rows.Add(bus.Key, bus.Value.FullDriverName, bus.Value.Route);
        }

        private void UpdateDisplayByRoute()
        {
            dataGridView1.Rows.Clear();
            foreach (var bus in parkBuses.OrderBy(b => b.Value.Route).ThenBy(b => b.Key))
                dataGridView1.Rows.Add(bus.Key, bus.Value.FullDriverName, bus.Value.Route);

            dataGridView2.Rows.Clear();
            foreach (var bus in routeBuses.OrderBy(b => b.Value.Route).ThenBy(b => b.Key))
                dataGridView2.Rows.Add(bus.Key, bus.Value.FullDriverName, bus.Value.Route);
        }

        private void UpdateDisplay()
        {
            ShowBusesByNumber();
        }

        private void UpdateStatusBar()
        {
            toolStripStatusLabel1.Text = $"Автобусов в парке: {parkBuses.Count} | На маршруте: {routeBuses.Count}";
        }
    }
}