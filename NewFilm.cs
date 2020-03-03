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
    public partial class NewFilm : Form
    {
        SqlConnection connection;

        public NewFilm(SqlConnection c)
        {
            InitializeComponent();
            connection = c;
        }

        private void Add_Click(object sender, EventArgs e)
        {// Добавление фильма в БД
            string sql = "INSERT Name VALUES (" + TextBoxPrice.Text + ", '" + TextBoxTitle.Text + "', '" + TextBoxDate.Text + "')";
            SqlCommand command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
            Close();
        }

        public void AddSubmit(EventHandler ev) => Add.Click += ev;
    }
}
