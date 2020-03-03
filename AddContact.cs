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
    public partial class AddContact : Form
    {
        public string TextFIO => TextBoxFIO.Text;
        public string TextPhone => TextBoxPhone.Text;
        public AddContact() => InitializeComponent();
        public void AddSubmit(EventHandler ev) => Create.Click += ev;
    }
}
