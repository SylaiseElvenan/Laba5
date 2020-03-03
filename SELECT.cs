using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5
{
    public class SELECT
    {
        public static string All(string name)
        {
            return "SELECT" + DB.Fields(name) + "FROM " + name;
        }

        public static string WhereValue(string name, string value)
        {
            switch (name)
            {
                case "Name":
                    return "SELECT ID_Name FROM Name WHERE Title = '" + value + "'";
                case "Contact":
                    return "SELECT ID_Contact FROM Contact WHERE FIO = '" + value + "'";
                case "NameField":
                    return "SELECT" + DB.Fields("Name") + "FROM Name WHERE Title = '" + value + "'";
            }
            return string.Empty;
        }
    }
}
