namespace AVTOBUS
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddBuses = new System.Windows.Forms.Button();
            this.btnExitBus = new System.Windows.Forms.Button();
            this.btnEnterBus = new System.Windows.Forms.Button();
            this.btnShowByNumber = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBusesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnBusNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDriver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnRoute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnShowByRoute = new System.Windows.Forms.Button();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddBuses
            // 
            this.btnAddBuses.Location = new System.Drawing.Point(20, 435);
            this.btnAddBuses.Name = "btnAddBuses";
            this.btnAddBuses.Size = new System.Drawing.Size(120, 30);
            this.btnAddBuses.TabIndex = 0;
            this.btnAddBuses.Text = "Добавить автобусы";
            this.btnAddBuses.UseVisualStyleBackColor = true;
            this.btnAddBuses.Click += new System.EventHandler(this.addBusesToolStripMenuItem_Click);
            // 
            // btnExitBus
            // 
            this.btnExitBus.Location = new System.Drawing.Point(20, 471);
            this.btnExitBus.Name = "btnExitBus";
            this.btnExitBus.Size = new System.Drawing.Size(120, 30);
            this.btnExitBus.TabIndex = 1;
            this.btnExitBus.Text = "Выезд автобуса";
            this.btnExitBus.UseVisualStyleBackColor = true;
            this.btnExitBus.Click += new System.EventHandler(this.exitBusToolStripMenuItem_Click);
            // 
            // btnEnterBus
            // 
            this.btnEnterBus.Location = new System.Drawing.Point(20, 507);
            this.btnEnterBus.Name = "btnEnterBus";
            this.btnEnterBus.Size = new System.Drawing.Size(120, 30);
            this.btnEnterBus.TabIndex = 2;
            this.btnEnterBus.Text = "Въезд автобуса";
            this.btnEnterBus.UseVisualStyleBackColor = true;
            this.btnEnterBus.Click += new System.EventHandler(this.enterBusToolStripMenuItem_Click);
            // 
            // btnShowByNumber
            // 
            this.btnShowByNumber.Location = new System.Drawing.Point(174, 471);
            this.btnShowByNumber.Name = "btnShowByNumber";
            this.btnShowByNumber.Size = new System.Drawing.Size(176, 30);
            this.btnShowByNumber.TabIndex = 3;
            this.btnShowByNumber.Text = "Сортировать по номерам";
            this.btnShowByNumber.UseVisualStyleBackColor = true;
            this.btnShowByNumber.Click += new System.EventHandler(this.showByBusToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(714, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBusesToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // addBusesToolStripMenuItem
            // 
            this.addBusesToolStripMenuItem.Name = "addBusesToolStripMenuItem";
            this.addBusesToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.addBusesToolStripMenuItem.Text = "Начальное формирование";
            this.addBusesToolStripMenuItem.Click += new System.EventHandler(this.addBusesToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnBusNumber,
            this.columnDriver,
            this.columnRoute});
            this.dataGridView1.Location = new System.Drawing.Point(20, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(687, 337);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // columnBusNumber
            // 
            this.columnBusNumber.HeaderText = "Номер автобуса";
            this.columnBusNumber.Name = "columnBusNumber";
            // 
            // columnDriver
            // 
            this.columnDriver.HeaderText = "Водитель";
            this.columnDriver.Name = "columnDriver";
            // 
            // columnRoute
            // 
            this.columnRoute.HeaderText = "Маршрут";
            this.columnRoute.Name = "columnRoute";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(23, 396);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(200, 20);
            this.txtInput.TabIndex = 6;
            // 
            // btnShowByRoute
            // 
            this.btnShowByRoute.Location = new System.Drawing.Point(174, 435);
            this.btnShowByRoute.Name = "btnShowByRoute";
            this.btnShowByRoute.Size = new System.Drawing.Size(176, 30);
            this.btnShowByRoute.TabIndex = 7;
            this.btnShowByRoute.Text = "Сортировать по маршрутам";
            this.btnShowByRoute.UseVisualStyleBackColor = true;
            this.btnShowByRoute.Click += new System.EventHandler(this.showByRouteToolStripMenuItem_Click);
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Location = new System.Drawing.Point(20, 380);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(375, 13);
            this.lblInstruction.TabIndex = 8;
            this.lblInstruction.Text = "Введите номер, водителя и маршрут (через пробел) или номер автобуса";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(714, 542);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.btnShowByRoute);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnShowByNumber);
            this.Controls.Add(this.btnEnterBus);
            this.Controls.Add(this.btnExitBus);
            this.Controls.Add(this.btnAddBuses);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Автобусный парк";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddBuses;
        private System.Windows.Forms.Button btnExitBus;
        private System.Windows.Forms.Button btnEnterBus;
        private System.Windows.Forms.Button btnShowByNumber;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBusesToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnBusNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDriver;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnRoute;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnShowByRoute;
        private System.Windows.Forms.Label lblInstruction;
    }
}

