using System.Data;
using System.Data.SqlClient;

namespace Middleware
{
    public partial class CurdMiddleware
    {
        public async Task<T> ExecuteDataReaderSingle<T>(string connectionString, string storedProcedureName, Func<SqlDataReader, T> mapFunction, SqlParameter[]? parameters = null)
        {
            try
            {
                T? result = default;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                result = mapFunction(reader);

                            }
                            else
                            {
                                result = object.Equals(result, DBNull.Value) ? default : result;

                            }
                        }
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




        public async Task<List<T>> ExecuteDataReaderList<T>(string connectionString, string storedProcedureName, Func<SqlDataReader, T> mapFunction, SqlParameter[]? parameters = null)
        {
            try
            {
                List<T> results = new List<T>();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                results.Add(mapFunction(reader));
                            }
                        }
                    }
                }

                if (results.Count > 0)
                {
                    return results;
                }
                else
                {
                    return default;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public async Task<int> ExecuteNonQuery(string connectionString, string storedProcedureName, SqlParameter[]? parameters = null)
        {
            try
            {
                int result = 0;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        result = await command.ExecuteNonQueryAsync();
                    }
                }

                if (result > 0)
                {
                    return result;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<T> ExecuteNonQueryGeneric<T>(string connectionString, string storedProcedureName, T? outputValue, string? outputParameterName, SqlParameter[]? parameters = null)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        if (!string.IsNullOrEmpty(outputParameterName))
                        {
                            SqlParameter outputParameter = new SqlParameter(outputParameterName, SqlDbType.NVarChar);
                            outputParameter.Direction = ParameterDirection.Output;
                            outputParameter.Size = 255;
                            command.Parameters.Add(outputParameter);
                        }

                        await command.ExecuteNonQueryAsync();

                        if (!string.IsNullOrEmpty(outputParameterName) && command.Parameters[outputParameterName].Value != DBNull.Value)
                        {
                            outputValue = (T)Convert.ChangeType(command.Parameters[outputParameterName].Value, typeof(T));
                        }
                    }
                }

                if (outputValue != null)
                {
                    return outputValue;
                }
                else
                {
                    return default;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public async Task<T> ExecuteScalar<T>(string connectionString, string storedProcedureName, SqlParameter[]? parameters = null)
        {
            try
            {
                T result;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        var scalarResult = await command.ExecuteScalarAsync();

                        // Use Convert.ChangeType to handle nullable value types
                        result = (T)Convert.ChangeType(scalarResult, typeof(T))!;
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}