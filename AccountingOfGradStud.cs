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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace scientific_work
{
    public partial class AccountingOfGradStud : Form
    {
        private NpgsqlConnection conn;
        NpgsqlDataAdapter adapter;
        DataSet ds;
        string sql = $"";
        string status = "";
        public AccountingOfGradStud(Scientific_work parent, NpgsqlConnection connection)
        {
            InitializeComponent();
            conn = connection;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            status = "cur";
            sql = $"SELECT * FROM Graduate_student_accounting('cur');";
            adapter = new NpgsqlDataAdapter(sql, conn);
            ds = new DataSet();
            adapter.Fill(ds);  
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            status = "arh";
            sql = $"SELECT * FROM Graduate_student_accounting('arh');";
            adapter = new NpgsqlDataAdapter(sql, conn);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int cnt = ds.Tables[0].Rows.Count;
            DataRow row = ds.Tables[0].Rows[cnt - 1];
            string p1 = row[1].ToString();
            string p2 = row[2].ToString();
            string p3 = row[3].ToString();
            string p4 = row[4].ToString();
            string p5 = row[5].ToString();
            string p6 = row[6].ToString();
            sql = $"INSERT INTO Student VALUES (default, '{p1}', '{p2}', {p3}, {p4}, '{p5}', {p6})";
            var cmd = new NpgsqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            adapter = new NpgsqlDataAdapter($"SELECT * FROM Graduate_student_accounting('{status}') ORDER BY Id_stud", conn);
            ds.Clear();
            adapter.Fill(ds);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                int ind = cell.RowIndex;
                string col_name = dataGridView1.Columns[cell.ColumnIndex].HeaderText.ToString();
                string val = cell.Value.ToString();
                string id_stud = dataGridView1[0, ind].Value.ToString();

                sql = $"UPDATE Student SET {col_name} = '{val}' WHERE Id_stud = {id_stud}";
                var cmd = new NpgsqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }

            ds.Clear();
            adapter = new NpgsqlDataAdapter($"SELECT * FROM Graduate_student_accounting('{status}') ORDER BY Id_stud", conn);
            adapter.Fill(ds);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string p1 = row.Cells[0].Value.ToString();
                sql = $"DELETE FROM Student WHERE Id_Stud = {p1};";
                var cmd = new NpgsqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                dataGridView1.Rows.Remove(row);
            }

            adapter = new NpgsqlDataAdapter($"SELECT * FROM Graduate_student_accounting('{status}') ORDER BY Id_stud", conn);
            ds.Clear();
            adapter.Fill(ds);
        }
    }
}
