namespace scientific_work
{
    partial class Scientific_work
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FunctionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListOfGrStudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListOfConfParticipantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountingOfGradStudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountingForPubltoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountingForConfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TablesToolStripMenuItem,
            this.FunctionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(739, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TablesToolStripMenuItem
            // 
            this.TablesToolStripMenuItem.Name = "TablesToolStripMenuItem";
            this.TablesToolStripMenuItem.Size = new System.Drawing.Size(85, 26);
            this.TablesToolStripMenuItem.Text = "Таблицы";
            this.TablesToolStripMenuItem.Click += new System.EventHandler(this.TablesToolStripMenuItem_Click);
            // 
            // FunctionsToolStripMenuItem
            // 
            this.FunctionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListOfGrStudToolStripMenuItem,
            this.ListOfConfParticipantToolStripMenuItem,
            this.AccountingOfGradStudToolStripMenuItem,
            this.AccountingForPubltoolStripMenuItem1,
            this.AccountingForConfToolStripMenuItem});
            this.FunctionsToolStripMenuItem.Name = "FunctionsToolStripMenuItem";
            this.FunctionsToolStripMenuItem.Size = new System.Drawing.Size(84, 26);
            this.FunctionsToolStripMenuItem.Text = "Функции";
            // 
            // ListOfGrStudToolStripMenuItem
            // 
            this.ListOfGrStudToolStripMenuItem.Name = "ListOfGrStudToolStripMenuItem";
            this.ListOfGrStudToolStripMenuItem.Size = new System.Drawing.Size(324, 26);
            this.ListOfGrStudToolStripMenuItem.Text = "Список аспирантов";
            this.ListOfGrStudToolStripMenuItem.Click += new System.EventHandler(this.LIstOfGrStudToolStripMenuItem_Click);
            // 
            // ListOfConfParticipantToolStripMenuItem
            // 
            this.ListOfConfParticipantToolStripMenuItem.Name = "ListOfConfParticipantToolStripMenuItem";
            this.ListOfConfParticipantToolStripMenuItem.Size = new System.Drawing.Size(324, 26);
            this.ListOfConfParticipantToolStripMenuItem.Text = "Список участников конференции";
            this.ListOfConfParticipantToolStripMenuItem.Click += new System.EventHandler(this.ListOfConfParticipantToolStripMenuItem_Click);
            // 
            // AccountingOfGradStudToolStripMenuItem
            // 
            this.AccountingOfGradStudToolStripMenuItem.Name = "AccountingOfGradStudToolStripMenuItem";
            this.AccountingOfGradStudToolStripMenuItem.Size = new System.Drawing.Size(324, 26);
            this.AccountingOfGradStudToolStripMenuItem.Text = "Учет аспирантов";
            this.AccountingOfGradStudToolStripMenuItem.Click += new System.EventHandler(this.AccountingOfGradStudToolStripMenuItem_Click);
            // 
            // AccountingForPubltoolStripMenuItem1
            // 
            this.AccountingForPubltoolStripMenuItem1.Name = "AccountingForPubltoolStripMenuItem1";
            this.AccountingForPubltoolStripMenuItem1.Size = new System.Drawing.Size(324, 26);
            this.AccountingForPubltoolStripMenuItem1.Text = "Учет публикаций";
            this.AccountingForPubltoolStripMenuItem1.Click += new System.EventHandler(this.AccountingForPubltoolStripMenuItem1_Click);
            // 
            // AccountingForConfToolStripMenuItem
            // 
            this.AccountingForConfToolStripMenuItem.Name = "AccountingForConfToolStripMenuItem";
            this.AccountingForConfToolStripMenuItem.Size = new System.Drawing.Size(324, 26);
            this.AccountingForConfToolStripMenuItem.Text = "Учет конференций";
            this.AccountingForConfToolStripMenuItem.Click += new System.EventHandler(this.AccountingForConfToolStripMenuItem_Click);
            // 
            // Scientific_work
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 515);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Scientific_work";
            this.Text = "Scientific work";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Scientific_work_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FunctionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListOfGrStudToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListOfConfParticipantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AccountingOfGradStudToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AccountingForPubltoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem AccountingForConfToolStripMenuItem;
    }
}

