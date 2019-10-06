using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Data.Layer.Base
{
    public class SQLHelper<T> where T : class
    {
        private string _connString;

        public SQLHelper(string ConnectionString)
        {
            _connString = ConnectionString;
        }

        public DataTable getSPResult(string cmdQuery, List<SqlParameter> Params)
        {
            var connection = new SqlConnection(_connString);

            try
            {
                var sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.SelectCommand = new SqlCommand(cmdQuery, connection);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                foreach (SqlParameter sqlParameter in Params)
                {
                    sqlDataAdapter.SelectCommand.Parameters.Add(sqlParameter);
                }

                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet, "Result");
                return dataSet.Tables["Result"];
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection?.Close();
            }
        }

        public List<T> ExecuteQuery(string spName, DynamicParameters parameters)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(_connString))
                {
                    return cnn.Query<T>(spName, parameters, commandType: CommandType.StoredProcedure).ToList<T>();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExecuteNonQuery(string spName, DynamicParameters parameters)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(_connString))
                {
                    cnn.Execute(spName, parameters, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object ExecuteScalar(string spName, DynamicParameters parameters)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(_connString))
                {
                    return cnn.ExecuteScalar(spName, parameters, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
