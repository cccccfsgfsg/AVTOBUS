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
            this.btnShowByRoute = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddBuses
            // 
            this.btnAddBuses.BackColor = System.Drawing.Color.LightCyan;
            this.btnAddBuses.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddBuses.ForeColor = System.Drawing.Color.Black;
            this.btnAddBuses.Location = new System.Drawing.Point(145, 406);
            this.btnAddBuses.Name = "btnAddBuses";
            this.btnAddBuses.Size = new System.Drawing.Size(196, 30);
            this.btnAddBuses.TabIndex = 0;
            this.btnAddBuses.Text = "Добавить автобусы";
            this.btnAddBuses.UseVisualStyleBackColor = false;
            this.btnAddBuses.Click += new System.EventHandler(this.addBusesToolStripMenuItem_Click);
            // 
            // btnExitBus
            // 
            this.btnExitBus.BackColor = System.Drawing.Color.LightCyan;
            this.btnExitBus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExitBus.ForeColor = System.Drawing.Color.Black;
            this.btnExitBus.Location = new System.Drawing.Point(145, 442);
            this.btnExitBus.Name = "btnExitBus";
            this.btnExitBus.Size = new System.Drawing.Size(196, 30);
            this.btnExitBus.TabIndex = 1;
            this.btnExitBus.Text = "Выезд автобуса";
            this.btnExitBus.UseVisualStyleBackColor = false;
            this.btnExitBus.Click += new System.EventHandler(this.exitBusToolStripMenuItem_Click);
            // 
            // btnEnterBus
            // 
            this.btnEnterBus.BackColor = System.Drawing.Color.LightCyan;
            this.btnEnterBus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEnterBus.ForeColor = System.Drawing.Color.Black;
            this.btnEnterBus.Location = new System.Drawing.Point(145, 478);
            this.btnEnterBus.Name = "btnEnterBus";
            this.btnEnterBus.Size = new System.Drawing.Size(196, 30);
            this.btnEnterBus.TabIndex = 2;
            this.btnEnterBus.Text = "Въезд автобуса";
            this.btnEnterBus.UseVisualStyleBackColor = false;
            this.btnEnterBus.Click += new System.EventHandler(this.enterBusToolStripMenuItem_Click);
            // 
            // btnShowByNumber
            // 
            this.btnShowByNumber.BackColor = System.Drawing.Color.LightCyan;
            this.btnShowByNumber.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowByNumber.ForeColor = System.Drawing.Color.Black;
            this.btnShowByNumber.Location = new System.Drawing.Point(531, 442);
            this.btnShowByNumber.Name = "btnShowByNumber";
            this.btnShowByNumber.Size = new System.Drawing.Size(272, 30);
            this.btnShowByNumber.TabIndex = 3;
            this.btnShowByNumber.Text = "Сортировать по номерам";
            this.btnShowByNumber.UseVisualStyleBackColor = false;
            this.btnShowByNumber.Click += new System.EventHandler(this.showByBusToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SkyBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 24);
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
            this.addBusesToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            this.addBusesToolStripMenuItem.Name = "addBusesToolStripMenuItem";
            this.addBusesToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.addBusesToolStripMenuItem.Text = "Начальное формирование";
            this.addBusesToolStripMenuItem.Click += new System.EventHandler(this.addBusesToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnBusNumber,
            this.columnDriver,
            this.columnRoute});
            this.dataGridView1.GridColor = System.Drawing.Color.SkyBlue;
            this.dataGridView1.Location = new System.Drawing.Point(117, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(275, 300);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // columnBusNumber
            // 
            this.columnBusNumber.HeaderText = "Номер автобуса";
            this.columnBusNumber.Name = "columnBusNumber";
            this.columnBusNumber.ReadOnly = true;
            // 
            // columnDriver
            // 
            this.columnDriver.HeaderText = "Водитель";
            this.columnDriver.Name = "columnDriver";
            this.columnDriver.ReadOnly = true;
            // 
            // columnRoute
            // 
            this.columnRoute.HeaderText = "Маршрут";
            this.columnRoute.Name = "columnRoute";
            this.columnRoute.ReadOnly = true;
            // 
            // btnShowByRoute
            // 
            this.btnShowByRoute.BackColor = System.Drawing.Color.LightCyan;
            this.btnShowByRoute.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowByRoute.ForeColor = System.Drawing.Color.Black;
            this.btnShowByRoute.Location = new System.Drawing.Point(531, 406);
            this.btnShowByRoute.Name = "btnShowByRoute";
            this.btnShowByRoute.Size = new System.Drawing.Size(272, 30);
            this.btnShowByRoute.TabIndex = 7;
            this.btnShowByRoute.Text = "Сортировать по маршрутам";
            this.btnShowByRoute.UseVisualStyleBackColor = false;
            this.btnShowByRoute.Click += new System.EventHandler(this.showByRouteToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 648);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(900, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView2.GridColor = System.Drawing.Color.SkyBlue;
            this.dataGridView2.Location = new System.Drawing.Point(531, 59);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(275, 300);
            this.dataGridView2.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер автобуса";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Водитель";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Маршрут";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(215, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Парк";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SkyBlue;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(635, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Линия";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Wheat;
            this.BackgroundImage = global::AVTOBUS.Properties.Resources._3e57f553_7b7b_4b11_bdcd_758c7782333f;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(900, 670);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnShowByRoute);
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
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.Button btnShowByRoute;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

