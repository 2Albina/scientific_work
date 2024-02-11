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
    public partial class ListOfGradStud : Form
    {
        private NpgsqlConnection conn;
        NpgsqlDataAdapter adapter;
        DataSet ds;
        string sql = $"";
        public ListOfGradStud(Scientific_work parent, NpgsqlConnection connection)
        {
            InitializeComponent();
            conn = connection;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ds != null)
            {
                ds.Clear();
            }
            if (comboBox1.SelectedItem.ToString() == "По году поступления")
            {
                label1.Text = "Введите год поступления";
            }
            else if (comboBox1.SelectedItem.ToString() == "По научному руководителю")
            {
                label1.Text = "Введите ФИО руководителя";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "По году поступления")
            {
                int yr = Convert.ToInt32(textBox1.Text);
                sql = $"SELECT * FROM List_GradStud_Year({yr});";
            }
            else if (comboBox1.SelectedItem.ToString() == "По научному руководителю")
            {
                string name = textBox1.Text;
                sql = $"SELECT * FROM List_GradStud_Tchr('%{name}%');";
            }
            adapter = new NpgsqlDataAdapter(sql, conn);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
