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
    public partial class Debt : Form
    {
        public Debt(SqlConnection c)
        {
            InitializeComponent();
            SqlConnection connection = c;

            string sql = "SELECT c.FIO AS ФИО, c.Phone AS Телефон, n.Title AS Название FROM Name n, " +
                "Contact c, DVD d WHERE n.ID_Name = d.ID_Name AND c.ID_Contact = d.ID_Contact AND " +
                "DATEADD(d,21,d.Date) < '" + DateTime.Now.ToString() + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DebtResult.DataSource = ds.Tables[0];
        }
    }
}
