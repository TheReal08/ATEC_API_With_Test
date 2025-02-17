// <copyright file="ILogSheetRepository.cs" company="ATEC">
// Copyright (c) ATEC. All rights reserved.
// </copyright>

using ATEC_API.Data.DTO.LogSheetDTO;

namespace ATEC_API.Data.IRepositories
{
    public interface ILogSheetRepository
    {
        Task<IEnumerable<LogSheetFieldsDTO>> GetLogSheetFields(LogSheetFieldsDTO input);

        Task<IEnumerable<LogSheetFieldsDTO>> GetLogSheetName();
    }
}
