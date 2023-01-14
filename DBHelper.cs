using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach_1
{
    public static class DBHelper
    {
        public static string UserName { get; set; }
        public static bool IsCurrentUserAdmin { get; set; }
        public static string SPGetBookIdByName { get; private set; }

        public static string SPGetAuthorIdByLastName { get; private set; }

        public static string SPInsertLogNote { get; private set; }

        public static Dictionary<int, string> ColumnsNameAuthorsDictionary = new Dictionary<int, string>();
        public static Dictionary<int, string> ColumnsNameBooksDictionary = new Dictionary<int, string>();
        public static Dictionary<int, string> ColumnsNameDesignersDictionary = new Dictionary<int, string>();
        public static Dictionary<int, string> ColumnsNameEditorsDictionary = new Dictionary<int, string>();
        public static Dictionary<int, string> ColumnsNameShopsBooksDictionary = new Dictionary<int, string>();
        public static Dictionary<int, string> ColumnsNameViewDictionary = new Dictionary<int, string>();

        public static object ExecuteSpForAuthor_booksTable(string param, int columnName)
        {
            object outputId;
            string commandText;
            string paramName = "";
            int nvarcharSize = 0;
            switch (columnName)
            {
                case 0:
                    commandText = SPGetBookIdByName;
                    nvarcharSize = 40;
                    paramName = "@name";
                    break;
                case 1:
                    commandText = SPGetAuthorIdByLastName;
                    nvarcharSize = 25;
                    paramName = "@lastName";
                    break;
                default:
                    commandText = "";
                    break;
            }

            using (SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.publishing_houseConnectionString))
            {
                try
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.CommandText = commandText;
                        sqlCommand.Parameters.Add(new SqlParameter
                        {
                            ParameterName = "@id",
                            SqlDbType = SqlDbType.Int,
                            Direction = ParameterDirection.Output
                        });
                        sqlCommand.Parameters.Add(new SqlParameter
                        {
                            ParameterName = paramName,
                            SqlDbType = SqlDbType.NVarChar,
                            Size = nvarcharSize,
                            Value = param
                        });

                        sqlCommand.ExecuteNonQuery();
                        outputId = sqlCommand.Parameters["@id"].Value;

                    }
                }

                finally
                {
                    if (sqlConnection != null && sqlConnection.State == ConnectionState.Open) sqlConnection.Close();
                }
                return outputId;
            }

        }

        public static void InsertErrorInLogTable(DateTime dateTime, string message)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.publishing_houseConnectionString))
            {
                try
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.CommandText = SPInsertLogNote;
                        sqlCommand.Parameters.Add(new SqlParameter
                        {
                            ParameterName = "@LogDate",
                            SqlDbType = SqlDbType.DateTime,
                            Value = dateTime
                        });
                        sqlCommand.Parameters.Add(new SqlParameter
                        {
                            ParameterName = "@Logmsg",
                            SqlDbType = SqlDbType.NVarChar,
                            Size = 100,
                            Value = message
                        });

                        sqlCommand.ExecuteNonQuery();
                    }
                }

                finally
                {
                    if (sqlConnection != null && sqlConnection.State == ConnectionState.Open) sqlConnection.Close();
                }
            }
        }

       

        public static void CheckPermissions()
        {
            using (SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.publishing_houseConnectionString))
            {
                try
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.CommandText = "CheckPermessionsForUser";

                        sqlCommand.Parameters.Add(new SqlParameter
                        {
                            ParameterName = "@username",
                            SqlDbType = SqlDbType.NVarChar,
                            Size = 128,
                            Value = UserName
                        });

                        try
                        {

                            var reader = sqlCommand.ExecuteReader();
                            if (!reader.HasRows)
                                IsCurrentUserAdmin = true;
                            else
                                IsCurrentUserAdmin = false;

                        }
                        catch (Exception)
                        {
                            IsCurrentUserAdmin = false;
                        }
                    }
                }

                finally
                {
                    if (sqlConnection != null && sqlConnection.State == ConnectionState.Open) sqlConnection.Close();
                }
            }
        }
        static DBHelper()
        {
            SPGetBookIdByName = "GetBookIdByName";
            SPGetAuthorIdByLastName = "SPGetAuthorIdByLastName";
            SPInsertLogNote = "InsertLogNote";
        }
    }
}
