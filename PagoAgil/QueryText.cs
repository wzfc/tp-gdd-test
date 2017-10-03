using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil
{
    class QueryText
    {
        public String Text { get; set; }

        public QueryText() : this("") { }

        public QueryText(String text)
        {
            Text = text;
        }

        public QueryText Select(params String[] columns)
        {
            var selectText = " SELECT ";
            for (int i = 0; ; ++i)
            {
                selectText += columns[i];
                if (i == columns.Length - 1)
                    break;
                selectText += ", ";
            }

            return Append(selectText);
        }

        public QueryText From(String tableName)
        {
            var fromText = " FROM "
                + SQLManager.SchemaName()
                + "." + tableName;

            return Append(fromText);
        }

        public QueryText Where(String conditions)
        {
            var whereText = " WHERE " + conditions;
            return Append(whereText);
        }

        public QueryText Update(String tableName)
        {
            var updateText = " UPDATE "
                + SQLManager.SchemaName()
                + "." + tableName;

            return Append(updateText);
        }

        public QueryText Append(String appendText)
        {
            Text += appendText;
            return this;
        }
    }
}
