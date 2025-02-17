// <copyright file="LogSheetRepository.cs" company="ATEC">
// Copyright (c) ATEC. All rights reserved.
// </copyright>

namespace ATEC_API.Data.Repositories
{
    using ATEC_API.Data.DTO.LogSheetDTO;
    using ATEC_API.Data.IRepositories;
    using ATEC_API.Data.StoredProcedures;
    using Dapper;
    using Microsoft.Data.SqlClient;
    using System.Data;

    public class LogSheetRepository
        (IDapperConnection _dapperConnection)
    : ILogSheetRepository
    {
        public async Task<IEnumerable<LogSheetFieldsDTO>> GetLogSheetFields(LogSheetFieldsDTO input)
        {
            await using SqlConnection sqlConnection = _dapperConnection.LogSheet_CreateConnection();

            var fieldDetails = await sqlConnection.QueryAsync<LogSheetFieldsDTO>(
                                                                   LogSheetSP.SP_GetLogsheetFields,
                                                                   new
                                                                   {
                                                                       tableName = input.FieldColumn,
                                                                   },
                                                                   commandType: CommandType.StoredProcedure
                                                                   );

            return fieldDetails;
        }

        public async Task<IEnumerable<LogSheetFieldsDTO>> GetLogSheetName()
        {
            await using SqlConnection sqlConnection = _dapperConnection.LogSheet_CreateConnection();

            var fieldDetails = await sqlConnection.QueryAsync<LogSheetFieldsDTO>(
                                                                   LogSheetSP.SP_GetLogsheetsName,
                                                                   commandType: CommandType.StoredProcedure
                                                                   );

            return fieldDetails;
        }
    }
}
