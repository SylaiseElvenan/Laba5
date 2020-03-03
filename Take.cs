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
    public partial class Take : Form
    {
        SqlConnection connection;

        public string Title { set => NameFilm.Text = value; }

        public Take(SqlConnection c)
        {
            InitializeComponent();
            connection = c;
        }

        private void Add_Click(object sender, EventArgs e)
        {// Добавление контакта в БД
            AddContact contact = new AddContact();

            EventHandler submit = (s, ev) =>
            {
                string sql = "INSERT Contact VALUES ('" + contact.TextFIO + "', '" + contact.TextPhone + "')";
                SqlCommand command = new SqlCommand(sql, connection);
                int number = command.ExecuteNonQuery();
                if (number > 0)
                    Contact.Text = contact.TextFIO;
                else
                    Contact.Text = "Не добавлен";
                contact.Close();
            };

            contact.AddSubmit(submit);
            contact.Show();
        }

        private void Search_Click(object sender, EventArgs e)
        {// Поиск контакта в БД
            string sql = SELECT.WhereValue("Contact", SearchContact.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTable dt = ds.Tables[0];
            if (dt.Rows.Count > 0)
                Contact.Text = "Найден";
            else
                Contact.Text = "Не найден";
        }

        private void Give_Click(object sender, EventArgs e)
        {// Вставка записи о выдаче диска в БД
            string sql = "INSERT DVD VALUES ((" + SELECT.WhereValue("Name", NameFilm.Text) + "), '" +
                DateTime.Now.ToString() + "', (" + SELECT.WhereValue("Contact", SearchContact.Text) + "))";
            SqlCommand command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
        }
    }
}
