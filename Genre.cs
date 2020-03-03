using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba5
{
    public partial class Genre : Form
    {
        Button Submit;
        int Num;
        List<RadioButton> Genres;

        public Genre(int N, List<string> name)
        {
            InitializeComponent();
            Num = N;
            Size = new Size(250, (Num + 1) * 27);

            Submit = new Button
            {
                Location = new Point(12, Size.Height - 80),
                Text = "Применить"
            };

            Genres = new List<RadioButton>(Num);
            for (int i = 0; i < Num; i++)
            {
                Genres.Add(new RadioButton
                {
                    AutoSize = true,
                    Text = name[i],
                    Location = new Point(12, 12 + 23 * i),
                    Size = new Size(150, 20)
                });
                Controls.Add(Genres[i]);
            }
            Controls.Add(Submit);
        }

        public void AddSubmit(EventHandler handler) => Submit.Click += handler;

        public int GetChecked()
        {
            for (int i = 0; i < Num; i++)
                if (Genres[i].Checked)
                    return i + 1;
            return 0;
        }
    }
}
