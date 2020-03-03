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
    public partial class Return : Form
    {
        SqlConnection connection;

        public Return(SqlConnection c)
        {
            InitializeComponent();
            connection = c;
        }

        private void Search_Click(object sender, EventArgs e)
        {// Поиск контакта в БД
            string sql = "SELECT n.Title AS Название, n.Price AS Цена, d.Date AS Дата FROM Contact c, DVD d, Name n WHERE c.FIO = '" +
                Title.Text + "' AND c.ID_Contact = d.ID_Contact AND n.ID_Name = d.ID_Name";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            Result.DataSource = ds.Tables[0];
        }

        private void Replace_Click(object sender, EventArgs e)
        {// Удаление записи о выдаче диска в БД
            string sql = "DELETE DVD WHERE ID_Name = (" + SELECT.WhereValue("Name", Result.CurrentRow.Cells[0].Value.ToString()) +
                ") AND ID_Contact = (" + SELECT.WhereValue("Contact", Title.Text) + ")";
            SqlCommand command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
        }
    }
}
