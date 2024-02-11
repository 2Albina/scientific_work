using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scientific_work
{
    public partial class ListOfParticipant : Form
    {
        private NpgsqlConnection conn;
        NpgsqlDataAdapter adapter;
        DataSet ds;
        String tableName = "";
        string sql = $"";
        public ListOfParticipant(Scientific_work parent, NpgsqlConnection connection)
        {
            InitializeComponent();
            conn = connection;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tableName = comboBox1.SelectedItem.ToString();
            if (comboBox1.SelectedItem.ToString() == "по годам")
            {
                int yr = Convert.ToInt32(textBox1.Text);
                sql = $"SELECT * FROM List_of_participant_year({yr});";
            }
            else if (comboBox1.SelectedItem.ToString() == "по руководителям")
            {
                string name = textBox1.Text;
                sql = $"SELECT * FROM List_of_participant_mngr('%{name}%');";
            }
            else if (comboBox1.SelectedItem.ToString() == "по тематике")
            {
                string theme = textBox1.Text;
                sql = $"SELECT * FROM List_of_participant_theme('%{theme}%');";
            }
            adapter = new NpgsqlDataAdapter(sql, conn);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ds != null)
            {
                ds.Clear();
            }
            if (comboBox1.SelectedItem.ToString() == "по годам")
            {
                label1.Text = "Введите год";
            }
            else if (comboBox1.SelectedItem.ToString() == "по руководителям")
            {
                label1.Text = "Введите ФИО руководителя";
            }
            else if (comboBox1.SelectedItem.ToString() == "по тематике")
            {
                label1.Text = "Введите тематику";
            }
        }
    }
}
