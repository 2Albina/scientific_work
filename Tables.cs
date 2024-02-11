using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace scientific_work
{
    public partial class Tables : Form
    {
        private NpgsqlConnection conn;
        NpgsqlDataAdapter adapter;
        DataSet ds;

        public Tables(Scientific_work parent, NpgsqlConnection connection)
        {
            InitializeComponent();
            conn = connection;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String tableName = comboBox1.SelectedItem.ToString();
            string cmd_view = $"SELECT * FROM {tableName}";
            adapter = new NpgsqlDataAdapter(cmd_view, conn);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }

            NpgsqlCommandBuilder cmdBldr = new NpgsqlCommandBuilder(adapter);
            adapter.Update(ds);
            ds.Clear();
            adapter.Fill(ds);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            NpgsqlCommandBuilder cmdBldr = new NpgsqlCommandBuilder(adapter);
            adapter.Update(ds);
            ds.Clear();
            adapter.Fill(ds);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            NpgsqlCommandBuilder cmdBldr = new NpgsqlCommandBuilder(adapter);
            adapter.Update(ds);
            ds.Clear();
            adapter.Fill(ds);
        }
    }
}
