// <copyright file="IDownloadRepository.cs" company="ATEC">
// Copyright (c) ATEC. All rights reserved.
// </copyright>

using ATEC_API.Data.DTO.DownloadCompressDTO;
using Microsoft.AspNetCore.Mvc;

namespace ATEC_API.Data.IRepositories
{
    public interface IDownloadRepository
    {
        Task<MemoryStream> DownloadToExcelAndCompress<T>(DownloadCompressDTO downloadCompressDTO);
    }
}
