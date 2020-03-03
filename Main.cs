using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba5
{
    public partial class Main : Form
    {
        SqlConnection connection;

        public Main()
        {
            InitializeComponent();
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=laba5;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            connection.Open();

            string sql = SELECT.All("Name");
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            Result.DataSource = ds.Tables[0];
        }

        private void ButtonGenre_Click(object sender, EventArgs e)
        {// Поиск по жанрам в БД
            string sql = SELECT.All("Genre");
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTable table = ds.Tables[0];

            int n = table.Rows.Count;
            List<string> Name = new List<string>(n);
            foreach (DataRow row in table.Rows)
            {
                string s = row[0].ToString();
                Name.Add(row[0].ToString());
            }
            Genre genre = new Genre(n, Name);

            EventHandler submit = (s, ev) =>
            {
                int vs = genre.GetChecked();
                sql = "SELECT n.Price AS Цена, n.Title AS Название, n.Date AS Дата FROM Name n, " +
                    "Genre g, Relation r WHERE n.ID_Name = r.ID_Name AND g.ID_Genre = r.ID_Genre AND " +
                    "g.ID_Genre = " + vs.ToString();
                adapter = new SqlDataAdapter(sql, connection);
                ds = new DataSet();
                adapter.Fill(ds);
                Result.DataSource = ds.Tables[0];
                genre.Close();
            };
            genre.AddSubmit(submit);

            genre.Show();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {// Поиск по названию в БД
            string sql = SELECT.WhereValue("NameField", TextBoxSearch.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            Result.DataSource = ds.Tables[0];
        }

        private void ButtonTake_Click(object sender, EventArgs e)
        {// Взятие записи
            Take take = new Take(connection);
            take.Title = Result.CurrentRow.Cells[1].Value.ToString();
            take.Show();
        }

        private void ButtonReturn_Click(object sender, EventArgs e)
        {// Возвращение записи
            Return r = new Return(connection);
            r.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) => connection.Close();

        private void ButtonDebt_Click(object sender, EventArgs e)
        {// Поиск должников в БД
            Debt debt = new Debt(connection);
            debt.Show();
        }

        private void NewFilm_Click(object sender, EventArgs e)
        {// Добавление фильма в БД
            NewFilm film = new NewFilm(connection);

            EventHandler submit = (s, ev) =>
            {
                string sql = SELECT.All("Name");
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                Result.DataSource = ds.Tables[0];
            };

            film.AddSubmit(submit);
            film.Show();
        }
    }
}
