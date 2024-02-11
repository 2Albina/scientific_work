using Microsoft.EntityFrameworkCore.Metadata.Conventions;
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
    public partial class AccountingForPubl : Form
    {
        private NpgsqlConnection conn;
        NpgsqlDataAdapter adapter;
        DataSet ds;
        string sql = $"";
        string sql_ = $"";
        string config = "";
        string tableName = "";
        string tableName2 = "";
        string idName = "";
        string name_person = "";
        public AccountingForPubl(Scientific_work parent, NpgsqlConnection connection)
        {
            InitializeComponent();
            conn = connection;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                config = "t";
                tableName = "Tchr_Pb";
                tableName2 = "Teacher";
                idName = "Id_Tchr";
                name_person = "name_tchr";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                config = "g";
                tableName = "Stud_Pb";
                tableName2 = "Student";
                idName = "Id_Stud";
                name_person = "name_stud";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                config = "m";
                tableName = "Stud_Pb";
                tableName2 = "Student";
                idName = "Id_Stud";
                name_person = "name_stud";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                config = "s";
                tableName = "Stud_Pb";
                tableName2 = "Student";
                idName = "Id_Stud";
                name_person = "name_stud";
            }
            sql = $"SELECT * FROM Accounting_for_publ('{config}')";
            adapter = new NpgsqlDataAdapter(sql, conn);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string p1 = row.Cells[0].Value.ToString();
                string p2 = row.Cells[2].Value.ToString();
                sql_ = $"DELETE FROM {tableName} WHERE {idName} = {p1} AND Id_Publ = {p2};";
                var cmd = new NpgsqlCommand(sql_, conn);
                cmd.ExecuteNonQuery();
                dataGridView1.Rows.Remove(row);
            }

            sql = $"SELECT * FROM Accounting_for_publ('{config}')";
            adapter = new NpgsqlDataAdapter(sql, conn);
            ds.Clear();
            adapter.Fill(ds);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string tableName_ = "";
            string idName_ = "";
            string col_name = "";
            int ind_id = 0;
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                int ind_col = cell.ColumnIndex;
                if (ind_col != 0 && ind_col != 2)
                {
                    if (ind_col == 1)
                    {
                        tableName_ = tableName2;
                        idName_ = idName;
                        ind_id = 0;
                        col_name = name_person;
                    }
                    else
                    {
                        tableName_ = "Publication";
                        idName_ = "id_pb";
                        ind_id = 2;
                        col_name = dataGridView1.Columns[ind_col].HeaderText.ToString();
                    }

                    int ind_row = cell.RowIndex;
                    string val = cell.Value.ToString();
                    string id = dataGridView1[ind_id, ind_row].Value.ToString();

                    sql = $"UPDATE {tableName_} SET {col_name} = '{val}' WHERE {idName_} = {id}";
                    var cmd = new NpgsqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }

            }

            ds.Clear(); 
            sql = $"SELECT * FROM Accounting_for_publ('{config}')";
            adapter = new NpgsqlDataAdapter(sql, conn);
            adapter.Fill(ds);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int cnt = ds.Tables[0].Rows.Count;
            DataRow row = ds.Tables[0].Rows[cnt - 1];
            string p1 = row[0].ToString();
            string p2 = row[2].ToString();

            sql_ = $"INSERT INTO {tableName} VALUES ({p1}, {p2})";
            var cmd = new NpgsqlCommand(sql_, conn);
            cmd.ExecuteNonQuery();

            sql = $"SELECT * FROM Accounting_for_publ('{config}')";
            adapter = new NpgsqlDataAdapter(sql, conn);
            ds.Clear();
            adapter.Fill(ds);
        }
    }
}
