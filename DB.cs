using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5
{
    public class DB
    {
        public static string Fields(string name)
        {
            switch(name)
            {
                case "Name":
                    return " Name.Price AS Цена, Name.Title AS Название, Name.Date AS Дата ";
                case "Genre":
                    return " Genre.Name AS Жанры ";
            }
            return string.Empty;
        }
    }
}
