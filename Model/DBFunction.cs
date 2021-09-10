using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Model
{
    public static class DBFunction
    {
        public static SqlConnection Connection { get; set; } = new SqlConnection("Data Source=BUE205D87;Initial Catalog=BDTurmaManha;User ID=guest01;Password=@Senac2021");

        /// <summary>
        /// This function returns all elements selected in the table, the table already include dbo.
        /// </summary>
        /// <param name="table"></param>
        /// <param name="element"></param>
        /// <returns>List(string) allSelectElements</string></returns>
        public static List<string> GenericUnitSelect(string element, string table)
        {
            List<string> returnElements = new List<string>();
            string select = $"SELECT {element} from dbo.{table}";

            SqlCommand cmd = new SqlCommand(select, Connection);
            Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                returnElements.Add(dr[0].ToString());
            }
            dr.Close();
            Connection.Close();

            return returnElements;

        }

        /// <summary>
        /// This function returns all elements selected in the table, the table already include dbo. and WHERE must be complete
        /// </summary>
        /// <param name="element"></param>
        /// <param name="table"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public static List<string> GenericUnitSelect(string element, string table, string where)
        {
            List<string> returnElements = new List<string>();
            string select = $"SELECT {element} from dbo.{table} WHERE {where}";

            SqlCommand cmd = new SqlCommand(select, Connection);
            Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                returnElements.Add(dr[0].ToString());
            }
            dr.Close();
            Connection.Close();

            return returnElements;

        }

        /// <summary>
        /// Execute a Non query function using the command as reference
        /// </summary>
        /// <param name="command"></param>
        public static void GenericExecute(string command)
        {
            SqlCommand cmd = new SqlCommand(command, Connection);
            Connection.Open();
            cmd.ExecuteNonQuery();
            Connection.Close();

        }

        /// <summary>
        /// Select all values from all elements from given Table, already have dbo. before table 
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>

        public static List<string[]> GenericSelectAll(string table)
        {
            List<string[]> lista = new List<string[]>();

            string select = $"SELECT * from dbo.{table}";
            SqlCommand cmd = new SqlCommand(select, Connection);
            Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string[] vetor = new string[dr.FieldCount];

                for (int i = 0; i < vetor.Length; i++)
                {
                    vetor[i] = dr[i].ToString();
                }
                lista.Add(vetor);
            }
            dr.Close();
            Connection.Close();
            return lista;


        }



    }
}
