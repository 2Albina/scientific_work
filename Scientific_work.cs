using Npgsql;
using System;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace scientific_work
{
    public partial class Scientific_work : Form
    {
        private NpgsqlConnection conn;

        private Tables TablesWindow;
        private ListOfGradStud ListOfGradStudWindow;
        private ListOfParticipant ListOfParticipantWindow;
        private AccountingOfGradStud AccountingOfGradStudWindow;
        private AccountingForPubl AccountingForPublWindow;
        private AccountingForConf AccountingForConfWindow;

        public Scientific_work()
        {
            InitializeComponent();
            string connString = "Host=localhost;Port=5432;Database=scientific work;Username=postgres;Password=belka02";
            //string connString = System.Configuration.ConfigurationManager.ConnectionStrings["scientific work"].ConnectionString;
            conn = new NpgsqlConnection(connString);
            conn.Open();
            if (conn == null)
            {
                MessageBox.Show("Ошибка подключения к БД. Завершение приложения...");
                Application.Exit();
            }

        }
        private void Scientific_work_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }

        private void TablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TablesWindow == null || TablesWindow.IsDisposed)
            {
                TablesWindow = new Tables(this, conn);
                TablesWindow.MdiParent = this;
            }
            TablesWindow.Show();
            TablesWindow.Activate();
        }

        private void LIstOfGrStudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ListOfGradStudWindow == null || ListOfGradStudWindow.IsDisposed)
            {
                ListOfGradStudWindow = new ListOfGradStud(this, conn);
                ListOfGradStudWindow.MdiParent = this;
            }
            ListOfGradStudWindow.Show();
            ListOfGradStudWindow.Activate();
        }

        private void ListOfConfParticipantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ListOfParticipantWindow == null || ListOfParticipantWindow.IsDisposed)
            {
                ListOfParticipantWindow = new ListOfParticipant(this, conn);
                ListOfParticipantWindow.MdiParent = this;
            }
            ListOfParticipantWindow.Show();
            ListOfParticipantWindow.Activate();
        }

        private void AccountingOfGradStudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AccountingOfGradStudWindow == null || AccountingOfGradStudWindow.IsDisposed)
            {
                AccountingOfGradStudWindow = new AccountingOfGradStud(this, conn);
                AccountingOfGradStudWindow.MdiParent = this;
            }
            AccountingOfGradStudWindow.Show();
            AccountingOfGradStudWindow.Activate();
        }

        private void AccountingForPubltoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (AccountingForPublWindow == null || AccountingForPublWindow.IsDisposed)
            {
                AccountingForPublWindow = new AccountingForPubl(this, conn);
                AccountingForPublWindow.MdiParent = this;
            }
            AccountingForPublWindow.Show();
            AccountingForPublWindow.Activate();
        }

        private void AccountingForConfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (AccountingForConfWindow == null || AccountingForConfWindow.IsDisposed)
            {
                AccountingForConfWindow = new AccountingForConf(this, conn);
                AccountingForConfWindow.MdiParent = this;
            }
            AccountingForConfWindow.Show();
            AccountingForConfWindow.Activate();
        }
    }
}
